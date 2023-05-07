namespace WinUI
{
	partial class SearchUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SearchUCLabel = new System.Windows.Forms.Label();
			this.DisplayTextBox = new System.Windows.Forms.TextBox();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.SearchBoxLabel = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SearchUCLabel
			// 
			this.SearchUCLabel.AutoSize = true;
			this.SearchUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.SearchUCLabel.Location = new System.Drawing.Point(372, 0);
			this.SearchUCLabel.Name = "SearchUCLabel";
			this.SearchUCLabel.Size = new System.Drawing.Size(154, 65);
			this.SearchUCLabel.TabIndex = 3;
			this.SearchUCLabel.Text = "Search";
			// 
			// DisplayTextBox
			// 
			this.DisplayTextBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DisplayTextBox.Location = new System.Drawing.Point(14, 337);
			this.DisplayTextBox.Multiline = true;
			this.DisplayTextBox.Name = "DisplayTextBox";
			this.DisplayTextBox.Size = new System.Drawing.Size(976, 386);
			this.DisplayTextBox.TabIndex = 4;
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(240, 174);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(152, 22);
			this.SearchTextBox.TabIndex = 5;
			// 
			// SearchBoxLabel
			// 
			this.SearchBoxLabel.AutoSize = true;
			this.SearchBoxLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchBoxLabel.Location = new System.Drawing.Point(64, 168);
			this.SearchBoxLabel.Name = "SearchBoxLabel";
			this.SearchBoxLabel.Size = new System.Drawing.Size(170, 38);
			this.SearchBoxLabel.TabIndex = 6;
			this.SearchBoxLabel.Text = "Enter a word:";
			// 
			// SearchButton
			// 
			this.SearchButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchButton.Location = new System.Drawing.Point(420, 167);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(83, 39);
			this.SearchButton.TabIndex = 7;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchBoxLabel);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.DisplayTextBox);
			this.Controls.Add(this.SearchUCLabel);
			this.Name = "SearchUC";
			this.Size = new System.Drawing.Size(1004, 741);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SearchUCLabel;
		private System.Windows.Forms.TextBox DisplayTextBox;
		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.Label SearchBoxLabel;
		private System.Windows.Forms.Button SearchButton;
	}
}
