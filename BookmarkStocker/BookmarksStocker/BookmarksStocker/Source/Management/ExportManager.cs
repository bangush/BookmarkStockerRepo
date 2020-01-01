using BookmarksStocker.Source.BO;
using BookmarksStocker.Source.Variables;
using Net.Light.Framework.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;

namespace BookmarksStocker.Source.Management
{
    internal class ExportManager
    {

        #region [ Export2Excel method ]

        /// <summary>
        /// Exports List to Excel.
        /// </summary>
        /// <param name="dt2Export">Bookmark List for Export</param>
        /// <param name="tableName">TableName</param>
        /// <param name="fileName">File Save Name</param>
        public void Export2Excel(List<Bookmark> dt2Export, string tableName, string fileName)
        {
            try
            {
                Type typeOfBookmark = typeof(Bookmark);
                using (StreamWriter excelWriter = new System.IO.StreamWriter(fileName))
                {
                    excelWriter.Write(AppVariables.ExcelStartXml);
                    excelWriter.Write("<Worksheet ss:Name=\"" + typeOfBookmark.Name + "\">");
                    excelWriter.Write("<Table>");

                    PropertyInfo[] propertiesOfBookmark = typeOfBookmark.GetProperties();
                    if (propertiesOfBookmark != null)
                    {
                        excelWriter.Write("<Row>");

                        for (int colCounter = 0; colCounter < propertiesOfBookmark.Length; colCounter++)
                        {
                            if (propertiesOfBookmark[colCounter].GetType().Name.Equals("String"))
                            {
                                excelWriter.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                                excelWriter.Write(propertiesOfBookmark[colCounter].Name);
                                excelWriter.Write("</Data></Cell>");
                            }
                        }

                        excelWriter.Write("</Row>");
                    }

                    foreach (Bookmark row2Export in dt2Export)
                    {
                        excelWriter.Write("<Row>");
                        for (int colCounter = 0; colCounter < propertiesOfBookmark.Length; colCounter++)
                        {
                            System.Type rowType;
                            rowType = row2Export.GetType();
                            switch (rowType.Name)
                            {
                                default:
                                case "String":
                                case "string":
                                case "System.String":
                                    string XMLstring = propertiesOfBookmark[colCounter].GetValue(row2Export, null).ToStr();
                                    XMLstring = XMLstring.Trim();
                                    XMLstring = XMLstring.Replace("&", "&");
                                    XMLstring = XMLstring.Replace(">", ">");
                                    XMLstring = XMLstring.Replace("<", "<");
                                    excelWriter.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                                   "<Data ss:Type=\"String\">");
                                    excelWriter.Write(XMLstring);
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "DateTime":
                                case "datetime":
                                case "System.DateTime":
                                    //Excel has a specific Date Format of YYYY-MM-DD followed by
                                    //the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
                                    //The Following Code puts the date stored in XMLDate
                                    //to the format above
                                    DateTime XMLDate = propertiesOfBookmark[colCounter].GetValue(row2Export, null).ToDateTime();
                                    string XMLDatetoString = ""; //Excel Converted Date
                                    XMLDatetoString = XMLDate.Year.ToString() +
                                         "-" +
                                         (XMLDate.Month < 10 ? "0" +
                                         XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
                                         "-" +
                                         (XMLDate.Day < 10 ? "0" +
                                         XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
                                         "T" +
                                         (XMLDate.Hour < 10 ? "0" +
                                         XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
                                         ":" +
                                         (XMLDate.Minute < 10 ? "0" +
                                         XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
                                         ":" +
                                         (XMLDate.Second < 10 ? "0" +
                                         XMLDate.Second.ToString() : XMLDate.Second.ToString()) +
                                         ".000";
                                    excelWriter.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                                 "<Data ss:Type=\"DateTime\">");
                                    excelWriter.Write(XMLDatetoString);
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "Boolean":
                                case "boolean":
                                case "Bool":
                                case "bool":
                                case "System.Boolean":
                                    excelWriter.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                                "<Data ss:Type=\"String\">");
                                    excelWriter.Write(propertiesOfBookmark[colCounter].GetValue(row2Export, null).ToBool());
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "Int16":
                                case "Int32":
                                case "Int64":
                                case "Byte":
                                case "System.Int16":
                                case "System.Int32":
                                case "System.Int64":
                                case "System.Byte":
                                    excelWriter.Write("<Cell ss:StyleID=\"Integer\">" +
                                            "<Data ss:Type=\"Number\">");
                                    excelWriter.Write(propertiesOfBookmark[colCounter].GetValue(row2Export, null).ToLong());
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "Decimal":
                                case "Double":
                                case "System.Decimal":
                                case "System.Double":
                                    excelWriter.Write("<Cell ss:StyleID=\"Decimal\">" +
                                          "<Data ss:Type=\"Number\">");
                                    excelWriter.Write(propertiesOfBookmark[colCounter].GetValue(row2Export, null).ToDouble());
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "DBNull":
                                case "System.DBNull":
                                    excelWriter.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                          "<Data ss:Type=\"String\">");
                                    excelWriter.Write("");
                                    excelWriter.Write("</Data></Cell>");
                                    break;
                                /*
                            default:
                                throw (new Exception(rowType.ToString() + " not handled."));
                                */
                            }
                        }
                        excelWriter.Write("</Row>");
                    }
                    excelWriter.Write("</Table>");
                    excelWriter.Write(" </Worksheet>");
                    excelWriter.Write(AppVariables.ExcelEndXml);
                    excelWriter.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ Export2Excel method ]


        #region [ Export2Excel method ]

        /// <summary>
        /// Exports DataTable to Excel.
        /// </summary>
        /// <param name="dt2Export">DataTable for Export</param>
        /// <param name="tableName">Table Name</param>
        /// <param name="fileName">Save File Name</param>
        public void Export2Excel(DataTable dt2Export, string tableName, string fileName)
        {
            try
            {
                using (StreamWriter excelWriter = new System.IO.StreamWriter(fileName))
                {
                    excelWriter.Write(AppVariables.ExcelStartXml);
                    excelWriter.Write("<Worksheet ss:Name=\"" + tableName + "\">");
                    excelWriter.Write("<Table>");
                    excelWriter.Write("<Row>");

                    for (int colCounter = 0; colCounter < dt2Export.Columns.Count; colCounter++)
                    {
                        excelWriter.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                        excelWriter.Write(dt2Export.Columns[colCounter].ColumnName);
                        excelWriter.Write("</Data></Cell>");
                    }
                    excelWriter.Write("</Row>");

                    foreach (DataRow row2Export in dt2Export.Rows)
                    {
                        excelWriter.Write("<Row>");
                        for (int colCounter = 0; colCounter < dt2Export.Columns.Count; colCounter++)
                        {
                            System.Type rowType;
                            rowType = row2Export[colCounter].GetType();
                            switch (rowType.Name)
                            {
                                default:
                                case "String":
                                case "string":
                                case "System.String":
                                    string XMLstring = row2Export[colCounter].ToString();
                                    XMLstring = XMLstring.Trim();
                                    XMLstring = XMLstring.Replace("&", "&");
                                    XMLstring = XMLstring.Replace(">", ">");
                                    XMLstring = XMLstring.Replace("<", "<");
                                    excelWriter.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                                   "<Data ss:Type=\"String\">");
                                    excelWriter.Write(XMLstring);
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "DateTime":
                                case "datetime":
                                case "System.DateTime":
                                    //Excel has a specific Date Format of YYYY-MM-DD followed by
                                    //the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
                                    //The Following Code puts the date stored in XMLDate
                                    //to the format above
                                    DateTime XMLDate = (DateTime)row2Export[colCounter];
                                    string XMLDatetoString = ""; //Excel Converted Date
                                    XMLDatetoString = XMLDate.Year.ToString() +
                                         "-" +
                                         (XMLDate.Month < 10 ? "0" +
                                         XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
                                         "-" +
                                         (XMLDate.Day < 10 ? "0" +
                                         XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
                                         "T" +
                                         (XMLDate.Hour < 10 ? "0" +
                                         XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
                                         ":" +
                                         (XMLDate.Minute < 10 ? "0" +
                                         XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
                                         ":" +
                                         (XMLDate.Second < 10 ? "0" +
                                         XMLDate.Second.ToString() : XMLDate.Second.ToString()) +
                                         ".000";
                                    excelWriter.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                                 "<Data ss:Type=\"DateTime\">");
                                    excelWriter.Write(XMLDatetoString);
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "Boolean":
                                case "boolean":
                                case "Bool":
                                case "bool":
                                case "System.Boolean":
                                    excelWriter.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                                "<Data ss:Type=\"String\">");
                                    excelWriter.Write(row2Export[colCounter].ToString());
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "Int16":
                                case "Int32":
                                case "Int64":
                                case "Byte":
                                case "System.Int16":
                                case "System.Int32":
                                case "System.Int64":
                                case "System.Byte":
                                    excelWriter.Write("<Cell ss:StyleID=\"Integer\">" +
                                            "<Data ss:Type=\"Number\">");
                                    excelWriter.Write(row2Export[colCounter].ToString());
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "Decimal":
                                case "Double":
                                case "System.Decimal":
                                case "System.Double":
                                    excelWriter.Write("<Cell ss:StyleID=\"Decimal\">" +
                                          "<Data ss:Type=\"Number\">");
                                    excelWriter.Write(row2Export[colCounter].ToString());
                                    excelWriter.Write("</Data></Cell>");
                                    break;

                                case "DBNull":
                                case "System.DBNull":
                                    excelWriter.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                          "<Data ss:Type=\"String\">");
                                    excelWriter.Write("");
                                    excelWriter.Write("</Data></Cell>");
                                    break;
                                /*
                            default:
                                throw (new Exception(rowType.ToString() + " not handled."));
                                */
                            }
                        }
                        excelWriter.Write("</Row>");
                    }
                    excelWriter.Write("</Table>");
                    excelWriter.Write(" </Worksheet>");
                    excelWriter.Write(AppVariables.ExcelEndXml);
                    excelWriter.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}