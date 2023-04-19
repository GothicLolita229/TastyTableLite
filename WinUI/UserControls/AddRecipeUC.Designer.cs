namespace WinUI
{
	partial class AddRecipeUC
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
			this.AddRecipeUCLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddRecipeUCLabel
			// 
			this.AddRecipeUCLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AddRecipeUCLabel.AutoSize = true;
			this.AddRecipeUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.AddRecipeUCLabel.Location = new System.Drawing.Point(339, 0);
			this.AddRecipeUCLabel.Name = "AddRecipeUCLabel";
			this.AddRecipeUCLabel.Size = new System.Drawing.Size(239, 65);
			this.AddRecipeUCLabel.TabIndex = 2;
			this.AddRecipeUCLabel.Text = "Add Recipe";
			// 
			// AddRecipeUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.AddRecipeUCLabel);
			this.Name = "AddRecipeUC";
			this.Size = new System.Drawing.Size(953, 735);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AddRecipeUCLabel;
	}
}
