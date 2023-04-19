namespace WinUI
{
	partial class AboutUC
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
			this.AboutUsUCLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AboutUsUCLabel
			// 
			this.AboutUsUCLabel.AutoSize = true;
			this.AboutUsUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.AboutUsUCLabel.Location = new System.Drawing.Point(436, 373);
			this.AboutUsUCLabel.Name = "AboutUsUCLabel";
			this.AboutUsUCLabel.Size = new System.Drawing.Size(199, 65);
			this.AboutUsUCLabel.TabIndex = 3;
			this.AboutUsUCLabel.Text = "About Us";
			// 
			// AboutUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.AboutUsUCLabel);
			this.Name = "AboutUC";
			this.Size = new System.Drawing.Size(956, 742);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AboutUsUCLabel;
	}
}
