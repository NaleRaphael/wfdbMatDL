using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace wfdbMatDL
{
    class HtmlSource
    {
        
        #region Fields
        private string _url = null;
        private string _source = null;
        private List<string> _dbList = null;            //saving name of database
        private List<string> _dbFullNameList = null;    //saving full name of each disease
        private List<string> _recordList = null;
        private List<string> _recordSubList = null;
        private List<string> _annotationsList = null;
        private MatchCollection _dbMatches;
        private HttpWebRequest _chkRequest;
        private WebResponse _chkResponse;
        private WebClient _client;
        private delegate void SourceCodeDownloadEventHandler();
        private SourceCodeDownloadEventHandler _sourceCodeDownloadComplete;
        #endregion

        #region Properties
        public string Source
        {
            set { _source = value; }
            get { return _source; }
        }
        public string URL
        {
            set { _url = value; }
            get { return _url; }
        }
        public List<string> DBList
        {
            get { return _dbList; }
        }
        public List<string> DBFullNameList
        {
            get { return _dbFullNameList; }
        }
        public List<string> RecordList
        {
            get { return _recordList; }
        }
        public List<string> RecordSubList
        {
            get { return _recordSubList; }
        }
        public List<string> AnnotationsList
        {
            get { return _annotationsList; }
        }
        public WebClient Client
        {
            get { return _client; }
            set { _client = value; }
        }
        #endregion

        #region Constructor and Destructor
        public HtmlSource(string targetURL)
        {
            if ((_url = targetURL) == "")
            {
                throw new ArgumentNullException("URL");
            }

            //check whether the website is online.
            if (CheckURL())
            {
                try
                {
                    //download the source code of a website
                    _client = new WebClient();
                    _source = _client.DownloadString(targetURL);
                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                if (_url.Contains("/ANNOTATORS"))
                {
                    throw new NoAnnotationsException(_url);
                }
                else
                {
                    throw new URLNoResponseException(_url);
                }
            }
        }
        ~HtmlSource()
        {
            //_chkResponse.Close();
            _dbList = null;
            _dbFullNameList = null;
            GC.Collect();
        }
        #endregion

        #region Method
        private bool CheckURL()
        {
            _chkRequest = (HttpWebRequest)WebRequest.Create(_url);
            try
            {
                _chkResponse = (HttpWebResponse)_chkRequest.GetResponse();
                _chkResponse.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void SetDesireSourceRange(string startSyntax, string endSyntax)
        {
            int dbSegStart = _source.IndexOf(startSyntax);    //start index of database segment
            int dbSegEnd = _source.IndexOf(endSyntax);        //end index of database segment
            if (dbSegStart == -1 || dbSegEnd == -1)
            {
                throw new Exception("Failed to set search range.");
            }
            _source = _source.Substring(dbSegStart, dbSegEnd - dbSegStart - 1);
        }
        private void GetDatabaseList()   //can be improved
        {
            #region note
            //link: http://physionet.org/cgi-bin/atm/ATM
            //source format: database
            //<td align="RIGHT">Database:</td><td align="LEFT"> <select name="database"  onchange="submit()">

            //link (.mat): http://physionet.org/atm/afdb/04908/atr/0/10/export/matlab/04908m.mat
            //link (.info): http://physionet.org/atm/afdb/04908/atr/0/10/export/matlab/04908m.info
            //link (.hea): http://physionet.org/atm/afdb/04908/atr/0/10/export/matlab/04908m.hea
            //format: http://physionet.org/atm/ + /"DB Name" + /"File Num" + /"annotation format" + /0 + /"data length" + /export/matlab/ + "FileNum"m.ext
            //"annotation format": atr,qrs,qrsc...
            //"data length": senconds; 10 secs, 1 min, 1 hr, 12 hrs, to end (10,60,3600,43200,e)
            #endregion
            try
            {
                _dbList = null;     //reset
                _dbList = new List<string>();
                _dbMatches = Regex.Matches(_source, RegexPattern.Database, RegexOptions.None);
                foreach (Match match in _dbMatches)
                {
                    _dbList.Add(match.ToString().Substring(15));
                }
                _dbMatches = null;  //clear space
                GC.Collect();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void GetFullNameList()
        {
            string temp;
            int i = 0;
            _dbFullNameList = null;     //reset
            _dbFullNameList = new List<string>();
            try
            {
                _dbMatches = Regex.Matches(_source, RegexPattern.DatabaseFullName);
                foreach (Match match in _dbMatches)
                {
                    temp = match.ToString().Substring(17 + _dbList[i].Length);
                    _dbFullNameList.Add(temp);
                    i++;
                }
                GC.Collect();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void GetRecordList()   //Files in database are named by number.
        {
            //link: http://physionet.org/physiobank/database/adfecgdb/
            //format: http://physionet.org/physiobank/database/ + "Database Name" (ex:adfecgdb,aftdb...)
            _recordList = null;     //reset
            _recordList = new List<string>();
            //_recordSubList = new List<string>();
            string[] fileAry;
            string[] dataAry;
            try
            {
                fileAry = _source.Split('\n', '\r');
                foreach (string data in fileAry)
                {
                    dataAry = data.Split('/');
                    if (dataAry.Length == 2)
                    {
                        //means "data" is directory, not a file
                        //take the left side string (directory), and the right side string is dataName
                        if (!_recordList.Contains(dataAry[0] + "/"))
                        {
                            _recordList.Add(dataAry[0] + "/");
                        }
                    }
                    else
                    {
                        if (data != "")
                        {
                            _recordList.Add(data);
                        }
                    }
                }
                /*
                //release memory if there is no sub-list
                if (_recordSubList.Count == 0)
                {
                    _recordSubList = null;
                }*/
#if false
                _dbMatches = Regex.Matches(_source, RegexPattern.Record);
                foreach (Match match in _dbMatches)
                {
                    fileName = match.ToString().Substring(9);
                    ext = Path.GetExtension(fileName);
                    if (ext == "")
                    {
                        //no extension, it's probably not a file.
                        if (fileName[fileName.Length - 1] == '/' && !fileName.Contains("/physiobank/database/"))
                        {
                            //Notice that if there is a slash at the end of the fileName,
                            //it means this file actually is a folder.
                            _recordList.Add(fileName);
                        }
                        continue;
                    }
                    else if (ext == ".edf")
                    {
                        //special case: if extension is ".edf", keep it
                        //otherwise, delete ext from fileName(temp)
                        _recordList.Add(fileName);
                    }
                    else
                    {
                        fileNameNoExt = Path.GetFileNameWithoutExtension(fileName);
                        if (!_recordList.Contains(fileNameNoExt))
                        {
                            _recordList.Add(fileNameNoExt);
                        }
                    }
                }
#endif
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void GetRecordSubList()
        {
            _recordSubList = null;  //reset
            _recordSubList = new List<string>();
            string fileName;
            string fileNameNoExt;   //fileName without extension
            string ext;     //file extension
            try
            {
#if true
                _dbMatches = Regex.Matches(_source, RegexPattern.Record);
                foreach (Match match in _dbMatches)
                {
                    fileName = match.ToString().Substring(9);
                    ext = Path.GetExtension(fileName);
                    if (ext == "")
                    {
                        continue;
                    }
                    else
                    {
                        fileNameNoExt = Path.GetFileNameWithoutExtension(fileName);
                        if (!_recordSubList.Contains(fileNameNoExt))
                        {
                            _recordSubList.Add(fileNameNoExt);
                        }
                    }
                }
#endif
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void GetAnnotationsList()
        {
            _annotationsList = null;
            _annotationsList = new List<string>();
            string[] annoAry;
            string[] temp;
            try
            {
                annoAry = _source.Split('\n', '\r');
                foreach (string anno in annoAry)
                {
                    if (anno != "")
                    {
                        temp = anno.Split('\t');
                        _annotationsList.Add(temp[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GetInfo(SourceCode type)
        {
            try
            {
                switch (type)
                {
                    case SourceCode.Database:
                        SetDesireSourceRange(SyntaxHeader.DatabaseStart, SyntaxHeader.DatabaseEnd);
                        GetDatabaseList();
                        GetFullNameList();
                        break;
                    case SourceCode.Record:
                        //SetDesireSourceRange(SyntaxHeader.RecordStart, SyntaxHeader.RecordEnd);
                        GetRecordList();
                        break;
                    case SourceCode.Record_Sub:
                        SetDesireSourceRange(SyntaxHeader.RecordStart, SyntaxHeader.RecordEnd);
                        GetRecordSubList();
                        break;
                    case SourceCode.Annotations:
                        GetAnnotationsList();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }

    public class URLNoResponseException : Exception
    {
        private string _errorMessage;
        public URLNoResponseException(string url)
        {
            _errorMessage = "Can't not get response from this URL:\n" + url;
        }
    }

    public class NoAnnotationsException : Exception
    {
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public NoAnnotationsException(string url)
        {
            //Message = "There are no annotations in this databse:\n" + url;
            _errorMessage = "NOTICE: There is no annotation in this databse:\n" + url;
            
        }
    }
}
