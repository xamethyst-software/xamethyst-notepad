using FurrypadCore;
using FurrypadCore.Functionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furrypad
{
	public partial class FormReplace : Form
	{
		FindNextSearch query = new FindNextSearch();
		public RichTextBox Editor;
		public EditOperation editOperation;

		public FindNextSearch Query { get => query; set => query = value; }

		public FormReplace()
		{
			InitializeComponent();
		}
		private void FormReplace_Load(object sender, EventArgs e)
		{
			DisableButtons();
			Down.Checked = true;
		}

		private void DisableButtons()
		{
			if (textFind.Text.Length == 0)
			{
				buttonFindNext.Enabled = buttonReplace.Enabled = buttonReplaceAll.Enabled = false;
			}
			else
			{
				buttonFindNext.Enabled = buttonReplace.Enabled = buttonReplaceAll.Enabled = true;
			}
		}

		private void textFind_TextChanged(object sender, EventArgs e)
		{
			DisableButtons();
		}

		public void UpdateSearchQuery()
		{
			query.SearchString = textFind.Text;
			query.Direction = Up.Checked ? "Up" : "Down";
			query.MatchCase = MatchCase.Checked;
			query.Content = Editor.Text;
			query.Position = Editor.SelectionStart;
		}

		private void buttonFindNext_Click(object sender, EventArgs e)
		{
			UpdateSearchQuery();
			FindNextResult result = editOperation.FindNext(this.query);
			if (result.SearchStatus)
				this.Editor.Select(result.SelectionStart, textFind.Text.Length);
		}
		
		private void buttonReplace_Click(object sender, EventArgs e)
		{
			if (Editor.SelectionLength == 0)
				buttonFindNext.PerformClick();
			else
			Editor.SelectedText = textReplace.Text;
		}

		private void buttonReplaceAll_Click(object sender, EventArgs e)
		{
			Editor.Text = Editor.Text.Replace(textFind.Text, textReplace.Text);
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
