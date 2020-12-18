using FurrypadCore;
using FurrypadCore.Functionality;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Speech.Synthesis;

namespace Furrypad
{
	public partial class Form1 : Form
	{
		FileOperation fileOperation;
		EditOperation editOperation;
		Timer timer;
		FormFind formFind;
		FormReplace formReplace;

		public EditOperation EditOperation { get => editOperation; set => editOperation = value; }

		public Form1()
		{
			InitializeComponent();
			fileOperation = new FileOperation();
			editOperation = new EditOperation();
			formFind = new FormFind(this);
			formFind.Editor = TextArea;
			fileOperation.InitializedNewFile();
			this.Text = fileOperation.Filename;
			timer = new Timer();
			timer.Tick += Mytimer_Tick;
			timer.Interval = 500;
			TextArea.HideSelection = false;
		}

		private void Mytimer_Tick(object sender, EventArgs e)
		{
			timer.Stop();
			editOperation.Add_UndoRedo(TextArea.Text);
			UpdateView();
		}

		private void NewFileMenu_Click(object sender, System.EventArgs e)
		{
			if (fileOperation.IsFileSaved)
			{
				TextArea.Text = "";
				fileOperation.InitializedNewFile();
				UpdateView();
			}
			else
			{
				DialogResult result = MessageBox.Show("shave de changesh to " + fileOperation.Filename, "uwu?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					if (fileOperation.Filename.Contains("Untitwed"))
					{
						SaveFileDialog newFileSave = new SaveFileDialog();
						newFileSave.Filter = "Text(*.txt)|*.txt";
						if (newFileSave.ShowDialog() == DialogResult.OK)
						{
							fileOperation.SaveFile(newFileSave.FileName, TextArea.Lines);
							UpdateView();
						}
						else 
						{
							fileOperation.SaveFile(fileOperation.FileLocation, TextArea.Lines);
							UpdateView();
						}
					}
					else if (result == DialogResult.No)
					{
						TextArea.Text = "";
						fileOperation.InitializedNewFile();
						UpdateView();
					}
				}
				else if( result == DialogResult.No)
				{ 
				}
				else 
				{ 
				}
			}
		}

		private void UpdateView()
		{
			this.Text = !fileOperation.IsFileSaved ? fileOperation.Filename + "*":fileOperation.Filename;
			UndoEditMenu.Enabled = editOperation.CanUndo() ? true : false;
			RedoEditMenu.Enabled = editOperation.CanRedo() ? true : false;
			FindNextEditMenu.Enabled = FindEditMenu.Enabled;
		}

		private void TextArea_TextChanged(object sender, EventArgs e)
		{
			fileOperation.IsFileSaved = false;
			if (editOperation.TextAreaTextChangeRequired)
			{
				timer.Start();
			}
			else
			{
				editOperation.TextAreaTextChangeRequired = false;
			}
			UpdateView();
		}

		private void OpenFileMenu_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Text(*.txt)|*.txt";
			openFile.InitialDirectory = "C:";
			openFile.Title = "Open file";
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				TextArea.TextChanged -= TextArea_TextChanged;
				TextArea.Text = fileOperation.OpenFile(openFile.FileName);
				TextArea.TextChanged += TextArea_TextChanged;
				UpdateView();
			}
		}

		private void SaveFileMenu_Click(object sender, EventArgs e)
		{
			if (!fileOperation.IsFileSaved)
			{
				if (!this.Text.Contains("Untitwed.txt"))
				{
					fileOperation.SaveFile(fileOperation.FileLocation, TextArea.Lines);
					UpdateView();
				}
				else
				{
					SaveFile();
				}
			}
		}

		private void SaveFile()
		{
			SaveFileDialog fileSave = new SaveFileDialog();
			fileSave.Filter = "Text(*.txt)|*.txt";
			if (fileSave.ShowDialog() == DialogResult.OK)
			{
				fileOperation.SaveFile(fileSave.FileName, TextArea.Lines);
				UpdateView();
			}
		}

		private void SaveAsFileMenu_Click(object sender, EventArgs e)
		{
			SaveFile();
		}

		private void ExitFileMenu_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void EditMenu_Click(object sender, EventArgs e)
		{
			CutEditMenu.Enabled = TextArea.SelectedText.Length > 0 ? true : false;
			CopyEditMenu.Enabled = TextArea.SelectedText.Length > 0 ? true : false;
			PasteEditMenu.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
		}

		private void EditMenu_MouseEnter(object sender, EventArgs e)
		{
			EditMenu_Click(sender, e);
		}

		private void CutEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.Cut();
			PasteEditMenu.Enabled = true;
		}

		private void CopyEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.Copy();
			PasteEditMenu.Enabled = true;
		}

		private void PasteEditMenu_Click(object sender, EventArgs e)
		{
			if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
			TextArea.Paste();

		}

		private void SelectAllEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.SelectAll();
		}

		private void DeleteEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.Text = TextArea.Text.Remove(TextArea.SelectionStart, TextArea.SelectionLength);
		}

		private void DateTimeEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.Text = TextArea.Text.Insert(TextArea.SelectionStart, editOperation.DateTime_Now());
		}

		private void UndoEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.Text = editOperation.UndoClicked();
			UpdateView();
		}

		private void RedoEditMenu_Click(object sender, EventArgs e)
		{
			TextArea.Text = editOperation.RedoClicked();
			UpdateView();
		}

		private void GoToEditMenu_Click(object sender, EventArgs e)
		{
			string input = Interaction.InputBox("Line Number", "Go to", "1");
			try
			{
				int line = Convert.ToInt32(input);
				if (line > TextArea.Lines.Length)
				{
					MessageBox.Show("Theres " + TextArea.Lines.Length + " in this file.", "Can't reach", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					string[] lines = TextArea.Lines;
					int len = 0;
					for (int i = 0; i < line - 1; i++)
					{
						len = len + lines[i].Length+1;
					}
					TextArea.Focus();
					TextArea.Select(len,0);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Enter valid number", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FindEditMenu_Click(object sender, EventArgs e)
		{
			if (formFind == null)
			{
				formFind = new FormFind(this);
				formFind.Editor = TextArea;
			}
			formFind.Show();
		}

		private void FindNextEditMenu_Click(object sender, EventArgs e)
		{
			formFind.UpdateSearchQuery();
			if (formFind.Query.SearchString.Length == 0)
			{
				formFind.Show();
			}
			else
			{
				FindNextResult result = editOperation.FindNext(formFind.Query);
				if (result.SearchStatus)
					TextArea.Select(result.SelectionStart, formFind.Query.SearchString.Length);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			TextArea.WordWrap = WordWrapFormatMenu.Checked;
			StatusBarViewMenu.Enabled = !WordWrapFormatMenu.Checked;
			if (StatusBarViewMenu.Enabled)
				StatusBarViewMenu.Checked = true;
			StatusContent.Visible = StatusBarViewMenu.Checked;
		}

		private void WordWrapFormatMenu_CheckedChanged(object sender, EventArgs e)
		{
			TextArea.WordWrap = WordWrapFormatMenu.Checked;
			StatusBarViewMenu.Enabled = !WordWrapFormatMenu.Checked;
			StatusBarViewMenu.Checked = true;
			StatusContent.Visible = StatusBarViewMenu.Enabled;
		}

		private void StatusBarViewMenu_CheckedChanged(object sender, EventArgs e)
		{
			StatusContent.Visible = StatusBarViewMenu.Checked;
		}

		private void TextArea_SelectionChanged(object sender, EventArgs e)
		{
			UpdateStatus();
		}

		private void UpdateStatus()
		{
			int position = TextArea.SelectionStart;
			int line = TextArea.GetLineFromCharIndex(position) + 1;
			int col = position - TextArea.GetFirstCharIndexOfCurrentLine() + 1;

			Status.Text = "Line " + line + ", Column " + col;
		}

		private void ReplaceEditMenu_Click(object sender, EventArgs e)
		{
			if (formReplace == null)
			{
				formReplace = new FormReplace();
				formReplace.Editor = TextArea;
				formReplace.editOperation = editOperation;
			}
			formReplace.Show();
		}

		private void FontFormatMenu_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowColor = true;
			fontDialog.Font = TextArea.Font;
			fontDialog.Color = TextArea.ForeColor;
			if (fontDialog.ShowDialog() != DialogResult.Cancel)
			{
				TextArea.Font = fontDialog.Font;
				TextArea.ForeColor = fontDialog.Color;
			}
		}

		private void ViewHelpHelpMenu_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
		}

		private void AboutHelpMenu_Click(object sender, EventArgs e)
		{
			FormAbout aboutForm = new FormAbout();
			aboutForm.ShowDialog();
		}

		private void uwuFurry_Click(object sender, EventArgs e)
		{
			string text = TextArea.Text;
			string searchTerm = "uwu";
			string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

			var matchQuery = from word in source
							 where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
							 select word;
			int wordCount = matchQuery.Count();

			DialogResult result = MessageBox.Show("Thewe awe "+wordCount+" uwus in thish text!!!", "UwU Counter", MessageBoxButtons.OK);
		}

		private void owoFurry_Click(object sender, EventArgs e)
		{
			string text = TextArea.Text;
			string searchTerm = "owo";
			string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

			var matchQuery = from word in source
							 where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
							 select word;
			int wordCount = matchQuery.Count();

			DialogResult result = MessageBox.Show("Thewe awe " + wordCount + " owos in thish text!!!", "OwO Counter", MessageBoxButtons.OK);
		}

		private void TranslateFurry_Click(object sender, EventArgs e)
		{
			string s = TextArea.Text;
			var replacement = s.Replace("r", "w")
				.Replace("R", "W")
				.Replace("S", "Sh")
				.Replace("s", "sh")
				.Replace("l", "w")
				.Replace("L", "W")
				.Replace("th", "d")
				.Replace("Th", "D")
				.Replace("You", "U")
				.Replace("you", "u")
				;

			TextArea.Text = "uwu " + replacement + " owo!";
		}

		private void uwUCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string s = TextArea.Text;
			/*
			string[] array = new string[] { "uwu", "Uwu", "UWu", "UWU", "uWu", "uWU", "uwU", "UwU" };
			if (s.Any(array.Equals))
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text", "!!!", MessageBoxButtons.OK);
			}
			*/
			if (s.Contains("uwu") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("Uwu") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("UWu") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("UWU") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("uWu") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("uWU") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("uwU") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("UwU") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text!!!", "UwU Checker", MessageBoxButtons.OK);
			}
			else
			{
				DialogResult result = MessageBox.Show("No uwus hewe :(", "UwU Checker", MessageBoxButtons.OK);
			}
		}

		private void owOCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string s = TextArea.Text;
			/*
			string[] array = new string[] { "uwu", "Uwu", "UWu", "UWU", "uWu", "uWU", "uwU", "UwU" };
			if (s.Any(array.Equals))
			{
				DialogResult result = MessageBox.Show("Thewe ish uwu in thish text", "!!!", MessageBoxButtons.OK);
			}
			*/
			if (s.Contains("owo") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("Owo") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("OWo") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("OWO") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("oWo") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("oWO") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("owO") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else if (s.Contains("OwO") == true)
			{
				DialogResult result = MessageBox.Show("Thewe ish owo in thish text!!!", "OwO Checker", MessageBoxButtons.OK);
			}
			else
			{
				DialogResult result = MessageBox.Show("No owos hewe :(", "OwO Checker", MessageBoxButtons.OK);
			}
		}

		private void MaleChild_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void MaleTeen_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void MaleAdult_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void MaleSenior_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void FemaleChild_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void FemaleTeen_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void FemaleAdult_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void FemaleSenior_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void NeutralChild_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Child);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void NeutralTeen_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Teen);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void NeutralAdult_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Adult);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}

		private void NeutralSenior_Click(object sender, EventArgs e)
		{
			var synthesizer = new SpeechSynthesizer();
			synthesizer.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Senior);
			synthesizer.SetOutputToDefaultAudioDevice();
			synthesizer.Speak(TextArea.Text);
		}
	}
}
