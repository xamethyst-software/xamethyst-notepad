namespace Furrypad
{
	partial class FormReplace
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReplace));
			this.MatchCase = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Down = new System.Windows.Forms.RadioButton();
			this.Up = new System.Windows.Forms.RadioButton();
			this.textFind = new System.Windows.Forms.TextBox();
			this.FindLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textReplace = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonFindNext = new System.Windows.Forms.Button();
			this.buttonReplace = new System.Windows.Forms.Button();
			this.buttonReplaceAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MatchCase
			// 
			this.MatchCase.AutoSize = true;
			this.MatchCase.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.MatchCase.Location = new System.Drawing.Point(13, 297);
			this.MatchCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MatchCase.Name = "MatchCase";
			this.MatchCase.Size = new System.Drawing.Size(115, 22);
			this.MatchCase.TabIndex = 12;
			this.MatchCase.Text = "Match Case";
			this.MatchCase.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.label1.Location = new System.Drawing.Point(245, 183);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 11;
			this.label1.Text = "Direction";
			// 
			// Down
			// 
			this.Down.AutoSize = true;
			this.Down.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Down.Location = new System.Drawing.Point(329, 208);
			this.Down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Down.Name = "Down";
			this.Down.Size = new System.Drawing.Size(71, 22);
			this.Down.TabIndex = 10;
			this.Down.TabStop = true;
			this.Down.Text = "Down";
			this.Down.UseVisualStyleBackColor = true;
			// 
			// Up
			// 
			this.Up.AutoSize = true;
			this.Up.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.Up.Location = new System.Drawing.Point(167, 208);
			this.Up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Up.Name = "Up";
			this.Up.Size = new System.Drawing.Size(48, 22);
			this.Up.TabIndex = 9;
			this.Up.TabStop = true;
			this.Up.Text = "Up";
			this.Up.UseVisualStyleBackColor = true;
			// 
			// textFind
			// 
			this.textFind.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.textFind.Location = new System.Drawing.Point(168, 40);
			this.textFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textFind.Name = "textFind";
			this.textFind.Size = new System.Drawing.Size(233, 28);
			this.textFind.TabIndex = 8;
			this.textFind.TextChanged += new System.EventHandler(this.textFind_TextChanged);
			// 
			// FindLabel
			// 
			this.FindLabel.AutoSize = true;
			this.FindLabel.Font = new System.Drawing.Font("Gauge Heavy", 12F);
			this.FindLabel.Location = new System.Drawing.Point(100, 44);
			this.FindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FindLabel.Name = "FindLabel";
			this.FindLabel.Size = new System.Drawing.Size(60, 24);
			this.FindLabel.TabIndex = 13;
			this.FindLabel.Text = "Find:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Gauge Heavy", 12F);
			this.label2.Location = new System.Drawing.Point(74, 118);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "Replace";
			// 
			// textReplace
			// 
			this.textReplace.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.textReplace.Location = new System.Drawing.Point(167, 114);
			this.textReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textReplace.Name = "textReplace";
			this.textReplace.Size = new System.Drawing.Size(233, 28);
			this.textReplace.TabIndex = 14;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.buttonCancel.Location = new System.Drawing.Point(453, 222);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(160, 50);
			this.buttonCancel.TabIndex = 17;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonFindNext
			// 
			this.buttonFindNext.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.buttonFindNext.Location = new System.Drawing.Point(453, 54);
			this.buttonFindNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonFindNext.Name = "buttonFindNext";
			this.buttonFindNext.Size = new System.Drawing.Size(160, 50);
			this.buttonFindNext.TabIndex = 16;
			this.buttonFindNext.Text = "Find Next";
			this.buttonFindNext.UseVisualStyleBackColor = true;
			this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
			// 
			// buttonReplace
			// 
			this.buttonReplace.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.buttonReplace.Location = new System.Drawing.Point(453, 110);
			this.buttonReplace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Size = new System.Drawing.Size(160, 50);
			this.buttonReplace.TabIndex = 18;
			this.buttonReplace.Text = "Replace";
			this.buttonReplace.UseVisualStyleBackColor = true;
			this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
			// 
			// buttonReplaceAll
			// 
			this.buttonReplaceAll.Font = new System.Drawing.Font("Gauge Heavy", 9F);
			this.buttonReplaceAll.Location = new System.Drawing.Point(453, 166);
			this.buttonReplaceAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonReplaceAll.Name = "buttonReplaceAll";
			this.buttonReplaceAll.Size = new System.Drawing.Size(160, 50);
			this.buttonReplaceAll.TabIndex = 19;
			this.buttonReplaceAll.Text = "Replace All";
			this.buttonReplaceAll.UseVisualStyleBackColor = true;
			this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
			// 
			// FormReplace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 331);
			this.Controls.Add(this.buttonReplaceAll);
			this.Controls.Add(this.buttonReplace);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonFindNext);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textReplace);
			this.Controls.Add(this.FindLabel);
			this.Controls.Add(this.MatchCase);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Down);
			this.Controls.Add(this.Up);
			this.Controls.Add(this.textFind);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReplace";
			this.Text = "Furrypad";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox MatchCase;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton Down;
		private System.Windows.Forms.RadioButton Up;
		private System.Windows.Forms.TextBox textFind;
		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textReplace;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonFindNext;
		private System.Windows.Forms.Button buttonReplace;
		private System.Windows.Forms.Button buttonReplaceAll;
	}
}