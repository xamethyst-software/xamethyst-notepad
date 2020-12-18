namespace Furrypad
{
	partial class FormFind
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFind));
			this.textFind = new System.Windows.Forms.TextBox();
			this.FindLabel = new System.Windows.Forms.Label();
			this.buttonFindNext = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.Up = new System.Windows.Forms.RadioButton();
			this.Down = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.MatchCase = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// textFind
			// 
			this.textFind.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.textFind.Location = new System.Drawing.Point(168, 40);
			this.textFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textFind.Name = "textFind";
			this.textFind.Size = new System.Drawing.Size(233, 28);
			this.textFind.TabIndex = 0;
			this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
			// 
			// FindLabel
			// 
			this.FindLabel.AutoSize = true;
			this.FindLabel.Font = new System.Drawing.Font("Gauge Heavy", 12F);
			this.FindLabel.Location = new System.Drawing.Point(100, 40);
			this.FindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FindLabel.Name = "FindLabel";
			this.FindLabel.Size = new System.Drawing.Size(60, 24);
			this.FindLabel.TabIndex = 1;
			this.FindLabel.Text = "Find:";
			// 
			// buttonFindNext
			// 
			this.buttonFindNext.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.buttonFindNext.Location = new System.Drawing.Point(451, 40);
			this.buttonFindNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonFindNext.Name = "buttonFindNext";
			this.buttonFindNext.Size = new System.Drawing.Size(160, 50);
			this.buttonFindNext.TabIndex = 2;
			this.buttonFindNext.Text = "Find Next";
			this.buttonFindNext.UseVisualStyleBackColor = true;
			this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.buttonCancel.Location = new System.Drawing.Point(451, 108);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(160, 50);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// Up
			// 
			this.Up.AutoSize = true;
			this.Up.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Up.Location = new System.Drawing.Point(168, 108);
			this.Up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Up.Name = "Up";
			this.Up.Size = new System.Drawing.Size(48, 22);
			this.Up.TabIndex = 4;
			this.Up.TabStop = true;
			this.Up.Text = "Up";
			this.Up.UseVisualStyleBackColor = true;
			this.Up.CheckedChanged += new System.EventHandler(this.Up_CheckedChanged);
			// 
			// Down
			// 
			this.Down.AutoSize = true;
			this.Down.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Down.Location = new System.Drawing.Point(330, 108);
			this.Down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Down.Name = "Down";
			this.Down.Size = new System.Drawing.Size(71, 22);
			this.Down.TabIndex = 5;
			this.Down.TabStop = true;
			this.Down.Text = "Down";
			this.Down.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.label1.Location = new System.Drawing.Point(246, 83);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Direction";
			// 
			// MatchCase
			// 
			this.MatchCase.AutoSize = true;
			this.MatchCase.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.MatchCase.Location = new System.Drawing.Point(15, 191);
			this.MatchCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MatchCase.Name = "MatchCase";
			this.MatchCase.Size = new System.Drawing.Size(115, 22);
			this.MatchCase.TabIndex = 7;
			this.MatchCase.Text = "Match Case";
			this.MatchCase.UseVisualStyleBackColor = true;
			this.MatchCase.CheckedChanged += new System.EventHandler(this.MatchCase_CheckedChanged);
			// 
			// FormFind
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 228);
			this.Controls.Add(this.MatchCase);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Down);
			this.Controls.Add(this.Up);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonFindNext);
			this.Controls.Add(this.FindLabel);
			this.Controls.Add(this.textFind);
			this.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FormFind";
			this.Text = "Furrypad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFind_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textFind;
		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.Button buttonFindNext;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.RadioButton Up;
		private System.Windows.Forms.RadioButton Down;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox MatchCase;
	}
}