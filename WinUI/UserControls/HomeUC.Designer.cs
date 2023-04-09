namespace WinUI
{
	partial class HomeUC
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
			this.HomeUCLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// HomeUCLabel
			// 
			this.HomeUCLabel.AutoSize = true;
			this.HomeUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.HomeUCLabel.Location = new System.Drawing.Point(382, 328);
			this.HomeUCLabel.Name = "HomeUCLabel";
			this.HomeUCLabel.Size = new System.Drawing.Size(169, 81);
			this.HomeUCLabel.TabIndex = 0;
			this.HomeUCLabel.Text = "Home";
			// 
			// HomeUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.HomeUCLabel);
			this.Name = "HomeUC";
			this.Size = new System.Drawing.Size(955, 741);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HomeUCLabel;
	}
}
