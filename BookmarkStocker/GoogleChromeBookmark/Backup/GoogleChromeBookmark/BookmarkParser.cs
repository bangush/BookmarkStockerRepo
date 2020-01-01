using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace GoogleChromeBookmark
{

	struct BookmarkRecord
	{
		public string Title;
		public string Url;
		public bool isBookmark; //else folder
		public List<BookmarkRecord> children;
		public BookmarkRecord(string title,string url,bool isbm)
		{
			Title = title;
			Url = url;
			isBookmark = isbm;
			if (isbm)
				children = null;
			else
				children = new List<BookmarkRecord>();
		}
		public BookmarkRecord(string title, bool isbm, List<BookmarkRecord> subfolder)
		{
			Title = title;
			Url = "";
			isBookmark = isbm;
			if (!isbm)
				children = subfolder;
			else
				children = null;
		}
	}

	class GChromeBookmarkParseException : System.ApplicationException
	{
		public GChromeBookmarkParseException()
		{

		}
	}

	class BookmarkParser
	{
		private static string ChromeDataPath()
		{
			return System.Environment.GetEnvironmentVariable("USERPROFILE")+@"\Local Settings\Application Data\Google\Chrome\User Data\Default\History" ;
		}
		public static List<BookmarkRecord> ParseHistory()
		{
			List<BookmarkRecord> queryResultList = new List<BookmarkRecord>();
		//step1: find the "history" file
			string HistoryPath = ChromeDataPath();
			string ConnectString = "Data Source="+HistoryPath;

		//step2: parse the "history" sqlite database
			SQLiteConnection conn = new SQLiteConnection(ConnectString);
			try
			{
				conn.Open();

				queryResultList = SearchChildren(0, conn);

				if (conn.State == System.Data.ConnectionState.Open)
					conn.Close();
				return queryResultList;
			}
			catch (Exception)
			{
				if (conn.State == System.Data.ConnectionState.Open)
					conn.Close();
				throw new GChromeBookmarkParseException();
			}

		}

		private static List<BookmarkRecord> SearchChildren(long currentId,SQLiteConnection conn)
		{
			SQLiteCommand cmd;
			SQLiteDataReader dr;
			List<BookmarkRecord> queryResult = new List<BookmarkRecord>();
			//step 1. handle bookmarks
			cmd = new SQLiteCommand("select title,url_id from [Main].starred where type=0 and parent_id="+currentId.ToString(), conn);
			dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				SQLiteCommand getUrlCmd=new SQLiteCommand("select url from [Main].urls where id="+dr["url_id"], conn);
				SQLiteDataReader urlDr=getUrlCmd.ExecuteReader();
				if(!urlDr.Read()) 	continue;
				queryResult.Add(new BookmarkRecord(dr["title"].ToString(), urlDr["url"].ToString(), true));
			}			
			//step 2. get subfolders
			cmd = new SQLiteCommand("select title,group_id from [Main].starred where type<>0 and parent_id=" + currentId.ToString(), conn);
			dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				queryResult.Add(new BookmarkRecord(dr["title"].ToString(), false,SearchChildren(Convert.ToInt64(dr["group_id"]), conn)));
				//step 3. handle subfolders
			}

			return queryResult;
		}

		public static bool GenerateHtml(List<BookmarkRecord> currentFolder, string filename)
		{
			//generate NETSCAPE-Bookmark-file format
			try
			{
				StreamWriter htmlFile = new StreamWriter(filename,false,System.Text.Encoding.GetEncoding(0));
				htmlFile.WriteLine(
@"<!DOCTYPE NETSCAPE-Bookmark-file-1>
    <!--This is an automatically generated file.
    It will be read and overwritten.
    Do Not Edit! -->
    <Title>Bookmarks</Title>
    <H1>Bookmarks</H1>"
				);
				long timeTick=Convert.ToInt64((DateTime.Now.ToFileTime()-(new DateTime(1970,1,1,0,0,0)).ToFileTime())/1e7);
				GenerateDL(currentFolder,htmlFile,timeTick);
				htmlFile.Close();
				return true;
			}
			catch (Exception)
			{
				MessageBox.Show("Can't generate the html bookmark at " + filename);
				return false;
			}

		}
		private static void GenerateDL(List<BookmarkRecord> currentFolder, StreamWriter htmlFile,long timeTick)
		{

			htmlFile.WriteLine("<DL><p>");
			foreach (BookmarkRecord br in currentFolder)
			{
				if (br.isBookmark)
					htmlFile.WriteLine("<DT><A HREF=\"" + br.Url + "\" ADD_DATE=\""+timeTick.ToString()+"\">" + br.Title + "</A>");
				else
				{
					htmlFile.WriteLine("<DT><H3 FOLDED ADD_DATE=\"" +timeTick.ToString()+ "\">" + br.Title + "</H3>");
					GenerateDL(br.children, htmlFile,timeTick);
				}
			}
			htmlFile.WriteLine("</DL><p>");
		}


	}
}