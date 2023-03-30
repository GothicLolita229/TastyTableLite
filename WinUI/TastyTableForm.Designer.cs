namespace WinUI
{
	partial class TastyTableForm
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
			this.EnterRecipeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// EnterRecipeLabel
			// 
			this.EnterRecipeLabel.AutoSize = true;
			this.EnterRecipeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EnterRecipeLabel.Location = new System.Drawing.Point(41, 40);
			this.EnterRecipeLabel.Name = "EnterRecipeLabel";
			this.EnterRecipeLabel.Size = new System.Drawing.Size(165, 28);
			this.EnterRecipeLabel.TabIndex = 0;
			this.EnterRecipeLabel.Text = "Enter Recipe:";
			// 
			// TastyTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.EnterRecipeLabel);
			this.Name = "TastyTableForm";
			this.Text = "Tasty Table Lite";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label EnterRecipeLabel;
	}
}

