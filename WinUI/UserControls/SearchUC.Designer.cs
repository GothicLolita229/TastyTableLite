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
			this.SuspendLayout();
			// 
			// SearchUCLabel
			// 
			this.SearchUCLabel.AutoSize = true;
			this.SearchUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.SearchUCLabel.Location = new System.Drawing.Point(396, 315);
			this.SearchUCLabel.Name = "SearchUCLabel";
			this.SearchUCLabel.Size = new System.Drawing.Size(154, 65);
			this.SearchUCLabel.TabIndex = 3;
			this.SearchUCLabel.Text = "Search";
			// 
			// SearchUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.SearchUCLabel);
			this.Name = "SearchUC";
			this.Size = new System.Drawing.Size(1004, 741);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SearchUCLabel;
	}
}
