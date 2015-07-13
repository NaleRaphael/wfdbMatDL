using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;

namespace wfdbMatDL
{
    //haven't been improved:
    //1. method of getting record list.
    //   (there is a record list in database, so it's no need to get list from source code)
    //annotations file link:
    //format:
    //http://physionet.org/atm/ + "database"/"fileNum"/"annotationType"/"startTime"/"endTime"/rdann/ann
    //ex: http://physionet.org/atm/afdb/04048/atr/0/e/rdann/annotations.txt
    //annotator:
    //list of annotation type
    public partial class MainFrm : Form
    {
        #region Field
        private string _url;    //shared parameter
        private HtmlSource _htmlDatabase;
        private HtmlSource _htmlRecord;
        private HtmlSource _htmlRecord_Sub;
        private HtmlSource _htmlAnnotations;
        private Thread _workerThread;
        private MatchCollection matches;
        private int[] prevCmbSelectedIndex;
        private delegate void GetSourceCodeDelegate();
        private delegate void DownloadDelegate();
        private delegate void AsyncDelegate(object obj);
        private AsyncDelegate asyncDelegate;
        private event GetSourceCodeDelegate _getSourceCodeCompleted;
        private IAsyncResult asyncResult;
        private List<string> fileURL;
        #endregion

        public MainFrm()
        {
            InitializeComponent();
            prevCmbSelectedIndex = new int[2]{-1,-1};
        }

        #region Method
        private void GetURLSource(object htmlDataType)
        {
            tssl_Status.UpdateStatus("Conneting...");
            try
            {
                //htmlDataType = new HtmlSource(_url);
                switch((SourceCode)htmlDataType)
                {
                    case SourceCode.Database:
                        _htmlDatabase = new HtmlSource(_url);
                        _htmlDatabase.GetInfo(SourceCode.Database);
                        break;
                    case SourceCode.Record:
                        _htmlRecord = new HtmlSource(_url);
                        _htmlRecord.GetInfo(SourceCode.Record);
                        break;
                    case SourceCode.Record_Sub:
                        _htmlRecord_Sub = new HtmlSource(_url);
                        _htmlRecord_Sub.GetInfo(SourceCode.Record_Sub);
                        break;
                    case SourceCode.Annotations:
                        _htmlAnnotations = new HtmlSource(_url);
                        _htmlAnnotations.GetInfo(SourceCode.Annotations);
                        break;
                    default:
                        MessageBox.Show("Wrong input type.");
                        return;
                }
                //_getSourceCodeCompleted();   //trig event
            }
            catch (NoAnnotationsException ex)
            {
                tssl_Status.UpdateStatus("Done.");
                //throw ex;     //failed
                //throw new Exception(ex.ErrorMessage);

                //temporary solution
                _htmlAnnotations = null;    
                MessageBox.Show(ex.ErrorMessage);
                return;
            }
            catch (URLNoResponseException ex)
            {
                tssl_Status.UpdateStatus("Failed.");
                MessageBox.Show(ex.Message);
                return;
            }
            tssl_Status.UpdateStatus("Done.");
        }
        private void btn_Test_Click(object sender, EventArgs e)
        {
            /*
            string fileName = "abc.02";
            txt_Test.Text += fileName + "\r\n";
            fileName = fileName.Replace('.', '_');
            txt_Test.Text += fileName + "\r\n";
            txt_Test.Text += SourceCode.Record_Sub + "\r\n";
            int i = (int)SourceCode.Record_Sub;
            txt_Test.Text += i + "\r\n";*/
            /*
            WebClient wc = new WebClient();
            string url = @"http://physionet.org/atm/adfecgdb/r01.edf/qrs/0/e/export/matlab/r01_edfm.info";
            //wc.DownloadFile(url, @"E:\Users\SPLab\Documents\PhysiobankDatabase\r01_edfm.info");
            wc.DownloadFileAsync(new Uri(url), @"E:\Users\SPLab\Documents\PhysiobankDatabase\r01_edfm.info");
            */
            
            string url;
            url = GetForepartURL();
            txt_Message.Text = url;
            string dataName = GetDataName();
            txt_Message.Text += "\n" + dataName;
            //txt_Test.Text = url;
            /*
            foreach (string data in _htmlDatabase.DBFullNameList)
            {
                txt_Test.Text += data + "\r\n";

            }
            */
            /*
            foreach (string data in _htmlDatabase.DBList)
            {
                txt_Test.Text += data + "\r\n";
            }
            */
            /*
            string str = "<a href=\"?C=D;O=A\">Description</a><hr><img src=\"/icons/back.gif\" alt=\"[DIR]\" width=\"20\" height=\"22\">";
            //string pattern = "(<option value=\")[a-zA-z0-9/-]*(\">)[a-zA-z0-9/,/-/ /(/)]*";
            //string pattern = "(<option value=\")[a-zA-Z0-9/-]*(\">)" + "[\\/\\(\\)\\[\\]\\,\\-\\w\\s]*";
            string pattern = "Description";
            matches = Regex.Matches(str, pattern);
            foreach (Match match in matches)
            {
                txt_Test.Text += match + "\r\n";
            }
            */
            //txt_Test.Text = _htmlRecord.Source;
            
            //Record
            /*
            string str = "<a href=\"r10-1_a.edf\">r10.edf</a>  <img src=\"/icons/binary.gif\" alt=\"[   ]\" width=\"20\" height=\"22\"> <a href=\"r10.edf.qrs\">r10.edf.qrs</a";
            //string pattern = "(<option value=\")[a-zA-z0-9/-]*(\">)[a-zA-z0-9/,/-/ /(/)]*";
            string pattern = "(<a href=\")[\\w\\.\\-/_]*";
            matches = Regex.Matches(str, pattern);
            foreach (Match match in matches)
            {
                txt_Test.Text += match + "\r\n";
            }
            */
            /*
            foreach (string str in _htmlRecord.RecordList)
            {
                txt_Test.Text += str + "\r\n";
                txt_Test.Text += "ext:" + Path.GetExtension(str);
            }
            */
            /*
            string str = "abc(option value=\"03665\")03665</option>abc<option value=\"04015\">04015</option>abc";
            //string pattern = "<[^(option value)]+>";
            //string pattern = @"<?[option value][\d\D]*>[\d\D]*?</option>";
            string pattern = "(<option value=\")[a-zA-z0-9]*(\")";
            //string pattern = "((option value)=\"+)^[a-zA-Z0-9]";
            matches = Regex.Matches(str, pattern);
            foreach (Match match in matches)
            {
                txt_Test.Text += match + "\n";
            }
            */
        }
        private void cmb_Database_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check: prevent to refresh while selectedIndex doesn't change
            if (cmb_Database.SelectedIndex == prevCmbSelectedIndex[(int)SourceCode.Database])
            {
                return;
            }
            prevCmbSelectedIndex[(int)SourceCode.Database] = cmb_Database.SelectedIndex;

            cmb_Record.Items.Clear();
            cmb_Record_SubDir.Items.Clear();
            cmb_Annotations.Items.Clear();
            prevCmbSelectedIndex[1] = -1;   //reset

            string dbName = _htmlDatabase.DBList[cmb_Database.SelectedIndex];
            
            //get record list
            //_url = @"http://physionet.org/physiobank/database/" + dbName;
            _url = @"http://physionet.org/physiobank/database/" + dbName + "/RECORDS";
            try
            {
                _workerThread = new Thread(new ParameterizedThreadStart(GetURLSource));
                _workerThread.Start(SourceCode.Record);
                _workerThread.Join();
                /*
                _workerThread = new Thread(new ParameterizedThreadStart(GetURLSource));
                _url = @"http://physionet.org/physiobank/database/" + dbName + "/ANNOTATORS";
                _workerThread.Start(SourceCode.Annotations);
                _workerThread.Join();
                */
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //get annotation list
            _url = @"http://physionet.org/physiobank/database/" + dbName + "/ANNOTATORS";
            try
            {
                _workerThread = new Thread(new ParameterizedThreadStart(GetURLSource));
                _workerThread.Start(SourceCode.Annotations);
                _workerThread.Join();
            }
            catch (Exception ex)
            {
                _htmlAnnotations = null;
                MessageBox.Show(ex.Message);
            }

            cmb_Record.UpdateItems(_htmlRecord.RecordList);
            if (_htmlAnnotations != null)
            {
                cmb_Annotations.UpdateItems(_htmlAnnotations.AnnotationsList);
            }
            else
            {
                cmb_Annotations.Items.Clear();
            }
        }
        private void cmb_Record_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check: prevent to refresh while selectedIndex doesn't change
            if (cmb_Record.SelectedIndex == prevCmbSelectedIndex[(int)SourceCode.Record])
            {
                return;
            }
            prevCmbSelectedIndex[(int)SourceCode.Record] = cmb_Record.SelectedIndex;
            
            cmb_Record_SubDir.Items.Clear();

            string strItem = cmb_Record.Items[cmb_Record.SelectedIndex].ToString();
            if (strItem[strItem.Length-1] == '/')
            { 
                //it means this file actually is a folder.
                string parentDir = _htmlDatabase.DBList[cmb_Database.SelectedIndex];
                _url = @"http://physionet.org/physiobank/database/" + parentDir + "/" + strItem;

                try
                {
                    _workerThread = new Thread(new ParameterizedThreadStart(GetURLSource));
                    _workerThread.Start(SourceCode.Record_Sub);
                    _workerThread.Join();
                    cmb_Record_SubDir.UpdateItems(_htmlRecord_Sub.RecordSubList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion Method

        #region Button
        private void btn_GetURLSource_Click(object sender, EventArgs e)
        {
            //Find and select database first (from: http://physionet.org/cgi-bin/atm/ATM )
            //then find the annotations (from: http://physionet.org/physiobank/database/ + "DB Name" )

            _url = txt_WebsiteURL.Text;    //assign url to shared parameter
            try
            {
                _workerThread = new Thread(new ParameterizedThreadStart(GetURLSource));
                _workerThread.Start(SourceCode.Database);
                _workerThread.Join();
                cmb_Database.UpdateItems(_htmlDatabase.DBFullNameList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_SavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_SavePath.Text = fbd.SelectedPath;
                fbd.Dispose();
                return;
            }
            
        }
        private void btn_Download_Click(object sender, EventArgs e)
        {
            //check
            if (cmb_Database.SelectedIndex == -1 || cmb_Record.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a record.");
                return;
            }
            DownloadDelegate downloadMission = new DownloadDelegate(DownloadMethod);
            this.Invoke(downloadMission);

        }
        #endregion

        private void DownloadMethod()
        {
            WebClient webClient = new WebClient();
            //format: "http://physionet.org/atm" + /DBName + /parentPath + /annType + /startTime + /endTime + "/export/matlab/" + /dataName.ext
            string remoteURI = "";
            string dataName = "";
            string[] fileName = new string[4];
            string[] savePath = new string[4];
            Uri[] ObjUri = new Uri[4];
            
            /*
             * 
             * 未處理: 當沒有選擇annotations type的時候
             * 
            */


            try
            {
                remoteURI = GetForepartURL();
                dataName = GetDataName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //setting for ECG files (.mat, .hea, .info)
            for (int i = 0; i < 3; i++)
            {
                fileName[i] = dataName + "." + (FileExtension)i;
                ObjUri[i] = new Uri(remoteURI + "/" + ExportType.Matlab + "/" + fileName[i]);
                savePath[i] = txt_SavePath.Text + "\\" + fileName[i];
            }
            //setting for annotation file
            //fileName[3] = remoteURI + ExportType.Annotations;
            if (cmb_Annotations.Items.Count != 0)
            {
                savePath[3] = txt_SavePath.Text + "\\" + dataName + "_anno.txt";
                ObjUri[3] = new Uri(remoteURI + "/" + ExportType.Annotations);
            }

            try
            {
                tssl_Status.UpdateStatus("Downloading files...");
                for (int i = 0; i < 3; i++)
                {
                    txt_Message.Text += "Downloading from: " + ObjUri[i].AbsoluteUri + "\r\n";
                    webClient.DownloadFile(ObjUri[i], savePath[i]);
                }
                
                if (cmb_Annotations.Items.Count != 0)
                {
                    txt_Message.Text += "Downloading from: " + ObjUri[3].AbsoluteUri + "\r\n";
                    webClient.DownloadFile(ObjUri[3], savePath[3]);
                }
                tssl_Status.UpdateStatus("Download finished.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tssl_Status.UpdateStatus("Error occurs while downloading files");
                txt_Message.Text += "^^^^^ Failed to download this file. ^^^^^\r\n";
                txt_Message.Text += "It seens like this URL has not been created by Physionet server.\r\n";
                txt_Message.Text += "You can try to access the link below to get this file.\r\n";
                txt_Message.Text += "http://physionet.org/cgi-bin/atm/ATM" + "\r\n";
                return;
            }
        }

        private void ckb_EnableBatchDL_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_EnableBatchDL.Checked)
            {
                clb_BatchDLList.Enabled = true;
            }
            else
            {
                clb_BatchDLList.Enabled = false;
            }
        }

        private string GetForepartURL()
        {
            //format: "http://physionet.org/atm" + /dbName + /parentPath + /annType + /startTime + /endTime + "/export/matlab/" + /dataName.ext
            string remoteURI = Link.PhysionetATM;
            string dbName = "";
            string parentPath = "";
            string annoType = "";
            string startTime = "0";
            string endTime = "e";

            //check cmb_Database
            if (cmb_Database.SelectedIndex == -1)
            {
                throw new Exception("Please select a database.");
            }
            else
            {
                dbName = _htmlDatabase.DBList[cmb_Database.SelectedIndex];
            }
            //check cmb_Record
            if (cmb_Record.SelectedIndex == -1)
            {
                throw new Exception("Please select a record.");
            }
            else
            {
                parentPath = _htmlRecord.RecordList[cmb_Record.SelectedIndex];
            }

            if (cmb_Record_SubDir.SelectedIndex != -1)
            {
                //file is in subDirectory
                parentPath += _htmlRecord_Sub.RecordSubList[cmb_Record_SubDir.SelectedIndex];
            }

            if (cmb_Annotations.Items.Count != 0)
            {
                if (cmb_Annotations.SelectedIndex == -1)
                {
                    throw new Exception("Please select an annotation type.");
                }
                annoType = _htmlAnnotations.AnnotationsList[cmb_Annotations.SelectedIndex] + "/";
            }
            else
            {
                annoType = "";
            }

            remoteURI += "/" + dbName + "/" + parentPath + "/" + annoType + startTime + "/" + endTime;
            return remoteURI;
        }

        private string GetDataName()
        {
            string dataName = "";
            string parentPath = "";

            //check cmb_Record
            if (cmb_Record.SelectedIndex == -1)
            {
                throw new Exception("Please select a record.");
            }
            else
            {
                parentPath = _htmlRecord.RecordList[cmb_Record.SelectedIndex];
            }

            if (cmb_Record_SubDir.SelectedIndex != -1)
            {
                //file is in subDirectory
                parentPath += _htmlRecord_Sub.RecordSubList[cmb_Record_SubDir.SelectedIndex];
            }

            if (cmb_Record_SubDir.Items.Count != 0)
            {
                if (cmb_Record_SubDir.SelectedIndex == -1)
                {
                    MessageBox.Show("No file in subDirectory is selected.");
                    return dataName;
                }
                else
                {
                    dataName = _htmlRecord_Sub.RecordSubList[cmb_Record_SubDir.SelectedIndex];
                }
            }
            else
            {
                dataName = parentPath;
            }
            dataName = dataName.Replace('.', '_') + "m";
            return dataName;
        }
        
    }
}