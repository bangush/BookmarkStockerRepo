using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GoogleChromeBookmark
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			UpdateTree(treeView1.Nodes, BookmarkParser.ParseHistory());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveFileDialog ofd = new SaveFileDialog();
			ofd.Filter = "HTML|*.html";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (BookmarkParser.GenerateHtml(BookmarkParser.ParseHistory(), ofd.FileName))
					MessageBox.Show("Bookmarks were saved at " + ofd.FileName + "\nNow you can import it to IE or FireFox.");
			}
		}
		private void UpdateTree(TreeNodeCollection currentNode,List<BookmarkRecord> bookmarks)
		{
			foreach (BookmarkRecord br in bookmarks)
			{
				TreeNode newNode = new TreeNode(br.Title);
				newNode.ToolTipText = br.Url;
				currentNode.Add(newNode);
				if (!br.isBookmark)
					UpdateTree(newNode.Nodes, br.children);				
			}
		}


		private void Form1_Resize(object sender, EventArgs e)
		{
			splitContainer1.SplitterDistance = splitContainer1.Height - 30;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog();
		}
	}
}
