namespace WinUI
{
	partial class RecipeBookUC
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
			this.RecipeBookUCLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// RecipeBookUCLabel
			// 
			this.RecipeBookUCLabel.AutoSize = true;
			this.RecipeBookUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.RecipeBookUCLabel.Location = new System.Drawing.Point(338, 315);
			this.RecipeBookUCLabel.Name = "RecipeBookUCLabel";
			this.RecipeBookUCLabel.Size = new System.Drawing.Size(316, 81);
			this.RecipeBookUCLabel.TabIndex = 1;
			this.RecipeBookUCLabel.Text = "Recipe Book";
			// 
			// RecipeBookUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RecipeBookUCLabel);
			this.Name = "RecipeBookUC";
			this.Size = new System.Drawing.Size(956, 742);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label RecipeBookUCLabel;
	}
}
