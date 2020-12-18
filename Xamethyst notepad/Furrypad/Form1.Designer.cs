using System;

namespace Furrypad
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.MenuBar = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.NewFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.UndoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.CutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.PasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.FindEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectAllEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.DateTimeEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.RedoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.GoToEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.FindNextEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ReplaceEditMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.FormatMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.WordWrapFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.FontFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewHelpHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusBarViewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.furryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TranslateFurry = new System.Windows.Forms.ToolStripMenuItem();
			this.uwuFurry = new System.Windows.Forms.ToolStripMenuItem();
			this.owoFurry = new System.Windows.Forms.ToolStripMenuItem();
			this.uwUCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.owOCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.voiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TTS = new System.Windows.Forms.ToolStripMenuItem();
			this.TextArea = new System.Windows.Forms.RichTextBox();
			this.StatusContent = new System.Windows.Forms.StatusStrip();
			this.Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.neutralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MaleChild = new System.Windows.Forms.ToolStripMenuItem();
			this.MaleTeen = new System.Windows.Forms.ToolStripMenuItem();
			this.MaleAdult = new System.Windows.Forms.ToolStripMenuItem();
			this.MaleSenior = new System.Windows.Forms.ToolStripMenuItem();
			this.FemaleChild = new System.Windows.Forms.ToolStripMenuItem();
			this.FemaleTeen = new System.Windows.Forms.ToolStripMenuItem();
			this.FemaleAdult = new System.Windows.Forms.ToolStripMenuItem();
			this.FemaleSenior = new System.Windows.Forms.ToolStripMenuItem();
			this.NeutralChild = new System.Windows.Forms.ToolStripMenuItem();
			this.NeutralTeen = new System.Windows.Forms.ToolStripMenuItem();
			this.NeutralAdult = new System.Windows.Forms.ToolStripMenuItem();
			this.NeutralSenior = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuBar.SuspendLayout();
			this.StatusContent.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuBar
			// 
			this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.FormatMenu,
            this.HelpMenu,
            this.viewToolStripMenuItem,
            this.furryToolStripMenuItem,
            this.voiceToolStripMenuItem});
			this.MenuBar.Location = new System.Drawing.Point(0, 0);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.MenuBar.Size = new System.Drawing.Size(1151, 28);
			this.MenuBar.TabIndex = 0;
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileMenu,
            this.OpenFileMenu,
            this.SaveFileMenu,
            this.SaveAsFileMenu,
            this.ExitFileMenu});
			this.FileMenu.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(49, 24);
			this.FileMenu.Text = "File";
			// 
			// NewFileMenu
			// 
			this.NewFileMenu.Name = "NewFileMenu";
			this.NewFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.NewFileMenu.Size = new System.Drawing.Size(249, 26);
			this.NewFileMenu.Text = "New";
			this.NewFileMenu.Click += new System.EventHandler(this.NewFileMenu_Click);
			// 
			// OpenFileMenu
			// 
			this.OpenFileMenu.Name = "OpenFileMenu";
			this.OpenFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OpenFileMenu.Size = new System.Drawing.Size(249, 26);
			this.OpenFileMenu.Text = "Open";
			this.OpenFileMenu.Click += new System.EventHandler(this.OpenFileMenu_Click);
			// 
			// SaveFileMenu
			// 
			this.SaveFileMenu.Name = "SaveFileMenu";
			this.SaveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveFileMenu.Size = new System.Drawing.Size(249, 26);
			this.SaveFileMenu.Text = "Save";
			this.SaveFileMenu.Click += new System.EventHandler(this.SaveFileMenu_Click);
			// 
			// SaveAsFileMenu
			// 
			this.SaveAsFileMenu.Name = "SaveAsFileMenu";
			this.SaveAsFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.SaveAsFileMenu.Size = new System.Drawing.Size(249, 26);
			this.SaveAsFileMenu.Text = "Save As";
			this.SaveAsFileMenu.Click += new System.EventHandler(this.SaveAsFileMenu_Click);
			// 
			// ExitFileMenu
			// 
			this.ExitFileMenu.Name = "ExitFileMenu";
			this.ExitFileMenu.Size = new System.Drawing.Size(249, 26);
			this.ExitFileMenu.Text = "Exit";
			this.ExitFileMenu.Click += new System.EventHandler(this.ExitFileMenu_Click);
			// 
			// EditMenu
			// 
			this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoEditMenu,
            this.CutEditMenu,
            this.CopyEditMenu,
            this.PasteEditMenu,
            this.DeleteEditMenu,
            this.FindEditMenu,
            this.SelectAllEditMenu,
            this.DateTimeEditMenu,
            this.RedoEditMenu,
            this.GoToEditMenu,
            this.FindNextEditMenu,
            this.ReplaceEditMenu});
			this.EditMenu.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.EditMenu.Name = "EditMenu";
			this.EditMenu.Size = new System.Drawing.Size(52, 24);
			this.EditMenu.Text = "Edit";
			this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
			this.EditMenu.MouseEnter += new System.EventHandler(this.EditMenu_MouseEnter);
			// 
			// UndoEditMenu
			// 
			this.UndoEditMenu.Enabled = false;
			this.UndoEditMenu.Name = "UndoEditMenu";
			this.UndoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.UndoEditMenu.Size = new System.Drawing.Size(228, 26);
			this.UndoEditMenu.Text = "Undo";
			this.UndoEditMenu.Click += new System.EventHandler(this.UndoEditMenu_Click);
			// 
			// CutEditMenu
			// 
			this.CutEditMenu.Enabled = false;
			this.CutEditMenu.Name = "CutEditMenu";
			this.CutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.CutEditMenu.Size = new System.Drawing.Size(228, 26);
			this.CutEditMenu.Text = "Cut";
			this.CutEditMenu.Click += new System.EventHandler(this.CutEditMenu_Click);
			// 
			// CopyEditMenu
			// 
			this.CopyEditMenu.Enabled = false;
			this.CopyEditMenu.Name = "CopyEditMenu";
			this.CopyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.CopyEditMenu.Size = new System.Drawing.Size(228, 26);
			this.CopyEditMenu.Text = "Copy";
			this.CopyEditMenu.Click += new System.EventHandler(this.CopyEditMenu_Click);
			// 
			// PasteEditMenu
			// 
			this.PasteEditMenu.Enabled = false;
			this.PasteEditMenu.Name = "PasteEditMenu";
			this.PasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.PasteEditMenu.Size = new System.Drawing.Size(228, 26);
			this.PasteEditMenu.Text = "Paste";
			this.PasteEditMenu.Click += new System.EventHandler(this.PasteEditMenu_Click);
			// 
			// DeleteEditMenu
			// 
			this.DeleteEditMenu.Name = "DeleteEditMenu";
			this.DeleteEditMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.DeleteEditMenu.Size = new System.Drawing.Size(228, 26);
			this.DeleteEditMenu.Text = "Delete";
			this.DeleteEditMenu.Click += new System.EventHandler(this.DeleteEditMenu_Click);
			// 
			// FindEditMenu
			// 
			this.FindEditMenu.Name = "FindEditMenu";
			this.FindEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.FindEditMenu.Size = new System.Drawing.Size(228, 26);
			this.FindEditMenu.Text = "Find";
			this.FindEditMenu.Click += new System.EventHandler(this.FindEditMenu_Click);
			// 
			// SelectAllEditMenu
			// 
			this.SelectAllEditMenu.Name = "SelectAllEditMenu";
			this.SelectAllEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.SelectAllEditMenu.Size = new System.Drawing.Size(228, 26);
			this.SelectAllEditMenu.Text = "Select All";
			this.SelectAllEditMenu.Click += new System.EventHandler(this.SelectAllEditMenu_Click);
			// 
			// DateTimeEditMenu
			// 
			this.DateTimeEditMenu.Name = "DateTimeEditMenu";
			this.DateTimeEditMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.DateTimeEditMenu.Size = new System.Drawing.Size(228, 26);
			this.DateTimeEditMenu.Text = "Date/Time";
			this.DateTimeEditMenu.Click += new System.EventHandler(this.DateTimeEditMenu_Click);
			// 
			// RedoEditMenu
			// 
			this.RedoEditMenu.Enabled = false;
			this.RedoEditMenu.Name = "RedoEditMenu";
			this.RedoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.RedoEditMenu.Size = new System.Drawing.Size(228, 26);
			this.RedoEditMenu.Text = "Redo";
			this.RedoEditMenu.Click += new System.EventHandler(this.RedoEditMenu_Click);
			// 
			// GoToEditMenu
			// 
			this.GoToEditMenu.Name = "GoToEditMenu";
			this.GoToEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.GoToEditMenu.Size = new System.Drawing.Size(228, 26);
			this.GoToEditMenu.Text = "Go To";
			this.GoToEditMenu.Click += new System.EventHandler(this.GoToEditMenu_Click);
			// 
			// FindNextEditMenu
			// 
			this.FindNextEditMenu.Name = "FindNextEditMenu";
			this.FindNextEditMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.FindNextEditMenu.Size = new System.Drawing.Size(228, 26);
			this.FindNextEditMenu.Text = "Find Next";
			this.FindNextEditMenu.Click += new System.EventHandler(this.FindNextEditMenu_Click);
			// 
			// ReplaceEditMenu
			// 
			this.ReplaceEditMenu.Name = "ReplaceEditMenu";
			this.ReplaceEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.ReplaceEditMenu.Size = new System.Drawing.Size(228, 26);
			this.ReplaceEditMenu.Text = "Replace";
			this.ReplaceEditMenu.Click += new System.EventHandler(this.ReplaceEditMenu_Click);
			// 
			// FormatMenu
			// 
			this.FormatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapFormatMenu,
            this.FontFormatMenu});
			this.FormatMenu.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.FormatMenu.Name = "FormatMenu";
			this.FormatMenu.Size = new System.Drawing.Size(75, 24);
			this.FormatMenu.Text = "Format";
			// 
			// WordWrapFormatMenu
			// 
			this.WordWrapFormatMenu.CheckOnClick = true;
			this.WordWrapFormatMenu.Name = "WordWrapFormatMenu";
			this.WordWrapFormatMenu.Size = new System.Drawing.Size(178, 26);
			this.WordWrapFormatMenu.Text = "Word Wrap";
			this.WordWrapFormatMenu.CheckedChanged += new System.EventHandler(this.WordWrapFormatMenu_CheckedChanged);
			// 
			// FontFormatMenu
			// 
			this.FontFormatMenu.Name = "FontFormatMenu";
			this.FontFormatMenu.Size = new System.Drawing.Size(178, 26);
			this.FontFormatMenu.Text = "Font";
			this.FontFormatMenu.Click += new System.EventHandler(this.FontFormatMenu_Click);
			// 
			// HelpMenu
			// 
			this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelpHelpMenu,
            this.AboutHelpMenu});
			this.HelpMenu.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.HelpMenu.Name = "HelpMenu";
			this.HelpMenu.Size = new System.Drawing.Size(55, 24);
			this.HelpMenu.Text = "Help";
			// 
			// ViewHelpHelpMenu
			// 
			this.ViewHelpHelpMenu.Name = "ViewHelpHelpMenu";
			this.ViewHelpHelpMenu.Size = new System.Drawing.Size(210, 26);
			this.ViewHelpHelpMenu.Text = "View Help";
			this.ViewHelpHelpMenu.Click += new System.EventHandler(this.ViewHelpHelpMenu_Click);
			// 
			// AboutHelpMenu
			// 
			this.AboutHelpMenu.Name = "AboutHelpMenu";
			this.AboutHelpMenu.Size = new System.Drawing.Size(210, 26);
			this.AboutHelpMenu.Text = "About Furrypad";
			this.AboutHelpMenu.Click += new System.EventHandler(this.AboutHelpMenu_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarViewMenu});
			this.viewToolStripMenuItem.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// StatusBarViewMenu
			// 
			this.StatusBarViewMenu.Name = "StatusBarViewMenu";
			this.StatusBarViewMenu.Size = new System.Drawing.Size(171, 26);
			this.StatusBarViewMenu.Text = "Status Bar";
			// 
			// furryToolStripMenuItem
			// 
			this.furryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TranslateFurry,
            this.uwuFurry,
            this.owoFurry,
            this.uwUCheckerToolStripMenuItem,
            this.owOCheckerToolStripMenuItem});
			this.furryToolStripMenuItem.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.furryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.furryToolStripMenuItem.Name = "furryToolStripMenuItem";
			this.furryToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.furryToolStripMenuItem.Text = "Furry";
			// 
			// TranslateFurry
			// 
			this.TranslateFurry.Name = "TranslateFurry";
			this.TranslateFurry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.TranslateFurry.Size = new System.Drawing.Size(306, 26);
			this.TranslateFurry.Text = "Translate";
			this.TranslateFurry.Click += new System.EventHandler(this.TranslateFurry_Click);
			// 
			// uwuFurry
			// 
			this.uwuFurry.Name = "uwuFurry";
			this.uwuFurry.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
			this.uwuFurry.Size = new System.Drawing.Size(306, 26);
			this.uwuFurry.Text = "UwU Counter";
			this.uwuFurry.Click += new System.EventHandler(this.uwuFurry_Click);
			// 
			// owoFurry
			// 
			this.owoFurry.Name = "owoFurry";
			this.owoFurry.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
			this.owoFurry.Size = new System.Drawing.Size(306, 26);
			this.owoFurry.Text = "OwO Counter";
			this.owoFurry.Click += new System.EventHandler(this.owoFurry_Click);
			// 
			// uwUCheckerToolStripMenuItem
			// 
			this.uwUCheckerToolStripMenuItem.Name = "uwUCheckerToolStripMenuItem";
			this.uwUCheckerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
			this.uwUCheckerToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
			this.uwUCheckerToolStripMenuItem.Text = "UwU Checker";
			this.uwUCheckerToolStripMenuItem.Click += new System.EventHandler(this.uwUCheckerToolStripMenuItem_Click);
			// 
			// owOCheckerToolStripMenuItem
			// 
			this.owOCheckerToolStripMenuItem.Name = "owOCheckerToolStripMenuItem";
			this.owOCheckerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
			this.owOCheckerToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
			this.owOCheckerToolStripMenuItem.Text = "OwO Checker";
			this.owOCheckerToolStripMenuItem.Click += new System.EventHandler(this.owOCheckerToolStripMenuItem_Click);
			// 
			// voiceToolStripMenuItem
			// 
			this.voiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTS,
            this.femaleToolStripMenuItem,
            this.neutralToolStripMenuItem});
			this.voiceToolStripMenuItem.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.voiceToolStripMenuItem.Name = "voiceToolStripMenuItem";
			this.voiceToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.voiceToolStripMenuItem.Text = "Voice";
			// 
			// TTS
			// 
			this.TTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaleChild,
            this.MaleTeen,
            this.MaleAdult,
            this.MaleSenior});
			this.TTS.Name = "TTS";
			this.TTS.Size = new System.Drawing.Size(224, 26);
			this.TTS.Text = "Male";
			// 
			// TextArea
			// 
			this.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextArea.Font = new System.Drawing.Font("Gauge Heavy", 12F);
			this.TextArea.Location = new System.Drawing.Point(0, 28);
			this.TextArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.TextArea.Name = "TextArea";
			this.TextArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TextArea.Size = new System.Drawing.Size(1151, 616);
			this.TextArea.TabIndex = 1;
			this.TextArea.Text = "";
			this.TextArea.SelectionChanged += new System.EventHandler(this.TextArea_SelectionChanged);
			this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
			// 
			// StatusContent
			// 
			this.StatusContent.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
			this.StatusContent.Location = new System.Drawing.Point(0, 620);
			this.StatusContent.Name = "StatusContent";
			this.StatusContent.Size = new System.Drawing.Size(1151, 24);
			this.StatusContent.TabIndex = 2;
			// 
			// Status
			// 
			this.Status.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(137, 18);
			this.Status.Text = "Line 1, Column 1";
			// 
			// femaleToolStripMenuItem
			// 
			this.femaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FemaleChild,
            this.FemaleTeen,
            this.FemaleAdult,
            this.FemaleSenior});
			this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
			this.femaleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.femaleToolStripMenuItem.Text = "Female";
			// 
			// neutralToolStripMenuItem
			// 
			this.neutralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NeutralChild,
            this.NeutralTeen,
            this.NeutralAdult,
            this.NeutralSenior});
			this.neutralToolStripMenuItem.Name = "neutralToolStripMenuItem";
			this.neutralToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.neutralToolStripMenuItem.Text = "Neutral";
			// 
			// MaleChild
			// 
			this.MaleChild.Name = "MaleChild";
			this.MaleChild.Size = new System.Drawing.Size(224, 26);
			this.MaleChild.Text = "Child";
			this.MaleChild.Click += new System.EventHandler(this.MaleChild_Click);
			// 
			// MaleTeen
			// 
			this.MaleTeen.Name = "MaleTeen";
			this.MaleTeen.Size = new System.Drawing.Size(224, 26);
			this.MaleTeen.Text = "Teen";
			this.MaleTeen.Click += new System.EventHandler(this.MaleTeen_Click);
			// 
			// MaleAdult
			// 
			this.MaleAdult.Name = "MaleAdult";
			this.MaleAdult.Size = new System.Drawing.Size(224, 26);
			this.MaleAdult.Text = "Adult";
			this.MaleAdult.Click += new System.EventHandler(this.MaleAdult_Click);
			// 
			// MaleSenior
			// 
			this.MaleSenior.Name = "MaleSenior";
			this.MaleSenior.Size = new System.Drawing.Size(224, 26);
			this.MaleSenior.Text = "Senior";
			this.MaleSenior.Click += new System.EventHandler(this.MaleSenior_Click);
			// 
			// FemaleChild
			// 
			this.FemaleChild.Name = "FemaleChild";
			this.FemaleChild.Size = new System.Drawing.Size(224, 26);
			this.FemaleChild.Text = "Child";
			this.FemaleChild.Click += new System.EventHandler(this.FemaleChild_Click);
			// 
			// FemaleTeen
			// 
			this.FemaleTeen.Name = "FemaleTeen";
			this.FemaleTeen.Size = new System.Drawing.Size(224, 26);
			this.FemaleTeen.Text = "Teen";
			this.FemaleTeen.Click += new System.EventHandler(this.FemaleTeen_Click);
			// 
			// FemaleAdult
			// 
			this.FemaleAdult.Name = "FemaleAdult";
			this.FemaleAdult.Size = new System.Drawing.Size(224, 26);
			this.FemaleAdult.Text = "Adult";
			this.FemaleAdult.Click += new System.EventHandler(this.FemaleAdult_Click);
			// 
			// FemaleSenior
			// 
			this.FemaleSenior.Name = "FemaleSenior";
			this.FemaleSenior.Size = new System.Drawing.Size(224, 26);
			this.FemaleSenior.Text = "Senior";
			this.FemaleSenior.Click += new System.EventHandler(this.FemaleSenior_Click);
			// 
			// NeutralChild
			// 
			this.NeutralChild.Name = "NeutralChild";
			this.NeutralChild.Size = new System.Drawing.Size(224, 26);
			this.NeutralChild.Text = "Child";
			this.NeutralChild.Click += new System.EventHandler(this.NeutralChild_Click);
			// 
			// NeutralTeen
			// 
			this.NeutralTeen.Name = "NeutralTeen";
			this.NeutralTeen.Size = new System.Drawing.Size(224, 26);
			this.NeutralTeen.Text = "Teen";
			this.NeutralTeen.Click += new System.EventHandler(this.NeutralTeen_Click);
			// 
			// NeutralAdult
			// 
			this.NeutralAdult.Name = "NeutralAdult";
			this.NeutralAdult.Size = new System.Drawing.Size(224, 26);
			this.NeutralAdult.Text = "Adult";
			this.NeutralAdult.Click += new System.EventHandler(this.NeutralAdult_Click);
			// 
			// NeutralSenior
			// 
			this.NeutralSenior.Name = "NeutralSenior";
			this.NeutralSenior.Size = new System.Drawing.Size(224, 26);
			this.NeutralSenior.Text = "Senior";
			this.NeutralSenior.Click += new System.EventHandler(this.NeutralSenior_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 644);
			this.Controls.Add(this.StatusContent);
			this.Controls.Add(this.TextArea);
			this.Controls.Add(this.MenuBar);
			this.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuBar;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "Furrypad";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MenuBar.ResumeLayout(false);
			this.MenuBar.PerformLayout();
			this.StatusContent.ResumeLayout(false);
			this.StatusContent.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.MenuStrip MenuBar;
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ToolStripMenuItem NewFileMenu;
		private System.Windows.Forms.ToolStripMenuItem OpenFileMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveFileMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveAsFileMenu;
		private System.Windows.Forms.ToolStripMenuItem ExitFileMenu;
		private System.Windows.Forms.ToolStripMenuItem EditMenu;
		private System.Windows.Forms.ToolStripMenuItem UndoEditMenu;
		private System.Windows.Forms.ToolStripMenuItem CutEditMenu;
		private System.Windows.Forms.ToolStripMenuItem CopyEditMenu;
		private System.Windows.Forms.ToolStripMenuItem PasteEditMenu;
		private System.Windows.Forms.ToolStripMenuItem DeleteEditMenu;
		private System.Windows.Forms.ToolStripMenuItem FindEditMenu;
		private System.Windows.Forms.ToolStripMenuItem FormatMenu;
		private System.Windows.Forms.ToolStripMenuItem HelpMenu;
		private System.Windows.Forms.ToolStripMenuItem ViewHelpHelpMenu;
		private System.Windows.Forms.ToolStripMenuItem AboutHelpMenu;
		private System.Windows.Forms.RichTextBox TextArea;
		private System.Windows.Forms.ToolStripMenuItem SelectAllEditMenu;
		private System.Windows.Forms.ToolStripMenuItem DateTimeEditMenu;
		private System.Windows.Forms.ToolStripMenuItem RedoEditMenu;
		private System.Windows.Forms.ToolStripMenuItem GoToEditMenu;
		private System.Windows.Forms.ToolStripMenuItem FindNextEditMenu;
		private System.Windows.Forms.ToolStripMenuItem ReplaceEditMenu;
		private System.Windows.Forms.ToolStripMenuItem WordWrapFormatMenu;
		private System.Windows.Forms.ToolStripMenuItem FontFormatMenu;
		private System.Windows.Forms.StatusStrip StatusContent;
		private System.Windows.Forms.ToolStripStatusLabel Status;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem StatusBarViewMenu;
		private System.Windows.Forms.ToolStripMenuItem furryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TranslateFurry;
		private System.Windows.Forms.ToolStripMenuItem uwuFurry;
		private System.Windows.Forms.ToolStripMenuItem owoFurry;
		private System.Windows.Forms.ToolStripMenuItem uwUCheckerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem owOCheckerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem voiceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TTS;
		private System.Windows.Forms.ToolStripMenuItem MaleChild;
		private System.Windows.Forms.ToolStripMenuItem MaleTeen;
		private System.Windows.Forms.ToolStripMenuItem MaleAdult;
		private System.Windows.Forms.ToolStripMenuItem MaleSenior;
		private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FemaleChild;
		private System.Windows.Forms.ToolStripMenuItem FemaleTeen;
		private System.Windows.Forms.ToolStripMenuItem FemaleAdult;
		private System.Windows.Forms.ToolStripMenuItem FemaleSenior;
		private System.Windows.Forms.ToolStripMenuItem neutralToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NeutralChild;
		private System.Windows.Forms.ToolStripMenuItem NeutralTeen;
		private System.Windows.Forms.ToolStripMenuItem NeutralAdult;
		private System.Windows.Forms.ToolStripMenuItem NeutralSenior;
	}
}

