namespace BookmarksStocker.Source.Variables
{
    internal class AppVariables
    {
        public static string ExcelStartXml
        {
            get
            {
                string startExcelXML = "<xml version>\r\n<Workbook " +
                     "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                     " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                     "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                     "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                     "office:spreadsheet\">\r\n <Styles>\r\n " +
                     "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                     "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                     "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                     "\r\n <Protection/>\r\n </Style>\r\n " +
                     "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                     "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                     "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                     " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                     "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                     "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                     "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                     "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                     "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                     "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                     "</Styles>\r\n ";

                return startExcelXML;
            }
        }

        public static string ExcelEndXml
        {
            get
            {
                string endExcelXML = "</Workbook>";
                return endExcelXML;
            }
        }
    }
}