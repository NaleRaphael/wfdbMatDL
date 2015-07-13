using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfdbMatDL
{

    public static class Link
    {
        public static string PhysionetATM = @"http://physionet.org/atm";
    }
    public static class ExportType
    {
        public static string Matlab = @"export/matlab";
        public static string Annotations = @"rdann/annotations.txt";
    }
    public static class SyntaxHeader
    {
        //<select name="database"  onchange="submit()">
        public static string DatabaseStart = "<select name=\"database\"  onchange=\"submit()\">";
        //</select><noscript><input type="submit" name="action" value="Refresh" />
        public static string DatabaseEnd = "</select><noscript><input type=\"submit\" name=\"action\" value=\"Refresh\" />";
        //<a href="/physiobank/database/">Parent Directory</a>
        //public static string RecordStart = "<a href=\"/physiobank/database/\">Parent Directory</a>";
        //<a href="?C=D;O=A">Description
        public static string RecordStart = "Description";
        //</div> <table width="100%" style="margin: 0;"><tr>
        public static string RecordEnd = "<table width=\"100%\" style=\"margin: 0;\"><tr>";
    }
    public static class RegexPattern
    {
        public static string Database = "(<option value=\")[a-zA-Z0-9/-]*";
        public static string DatabaseFullName = "(<option value=\")[a-zA-Z0-9/-]*(\">)" + "[\\.\\/\\(\\)\\[\\]\\,\\-\\w\\s]*";
        public static string Record = "(<a href=\")[\\/\\w\\.\\-/_]*";
    }

    public enum SourceCode
    {
        Database = 0, Record, Record_Sub, Annotations
    }
    public enum FileExtension
    {
        mat = 0, info, hea
    }
    public enum WFDBFileType
    {
        ECGSignal = 0, Annotations
    }
}
