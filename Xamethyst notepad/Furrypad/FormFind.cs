using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FurrypadCore;
using System.Windows.Forms;
using FurrypadCore.Functionality;

namespace Furrypad
{
	public partial class FormFind : Form
	{
		Form1 mainForm;
		EditOperation editOperation;
		FindNextSearch query = new FindNextSearch();
		
		public RichTextBox Editor { get; internal set; }
		public FindNextSearch Query { get => query; set => query = value; }

		public FormFind(Form1 mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			Down.Checked = true;
			buttonFindNext.Enabled = false;
			editOperation = mainForm.EditOperation;
			query.Success = false;
		}

		private void textFind_TextChanged(object sender, EventArgs e)
		{
			buttonFindNext.Enabled = (textFind.Text.Length > 0) ? true : false;
			UpdateSearchQuery();
		}

		public void UpdateSearchQuery()
		{
			query.SearchString = textFind.Text;
			query.Direction = Up.Checked ? "Up" : "Down";
			query.MatchCase = MatchCase.Checked;
			query.Content = Editor.Text;
			query.Position = Editor.SelectionStart;
		}

		private void MatchCase_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void Up_CheckedChanged(object sender, EventArgs e)
		{
			UpdateSearchQuery();
		}

		private void FormFind_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}

		private void buttonFindNext_Click(object sender, EventArgs e)
		{
			UpdateSearchQuery();
			FindNextResult result = editOperation.FindNext(query);
			if (result.SearchStatus)
				Editor.Select(result.SelectionStart, textFind.Text.Length);
		}
	}
}
