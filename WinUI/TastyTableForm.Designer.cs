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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TastyTableForm));
			this.panelFooterContainer = new System.Windows.Forms.Panel();
			this.panelHeaderContainer = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.LogoPicture = new System.Windows.Forms.PictureBox();
			this.panelButtonContainer = new System.Windows.Forms.Panel();
			this.HomeButton = new System.Windows.Forms.Button();
			this.RecipeBookButton = new System.Windows.Forms.Button();
			this.AddRecipeButton = new System.Windows.Forms.Button();
			this.AboutButton = new System.Windows.Forms.Button();
			this.WelcomeLabel = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.panelHeaderContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
			this.panelButtonContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelFooterContainer
			// 
			this.panelFooterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
			this.panelFooterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFooterContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooterContainer.Location = new System.Drawing.Point(0, 880);
			this.panelFooterContainer.Name = "panelFooterContainer";
			this.panelFooterContainer.Size = new System.Drawing.Size(1736, 53);
			this.panelFooterContainer.TabIndex = 1;
			// 
			// panelHeaderContainer
			// 
			this.panelHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.panelHeaderContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelHeaderContainer.Controls.Add(this.WelcomeLabel);
			this.panelHeaderContainer.Controls.Add(this.label1);
			this.panelHeaderContainer.Controls.Add(this.LogoPicture);
			this.panelHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeaderContainer.Location = new System.Drawing.Point(0, 0);
			this.panelHeaderContainer.Name = "panelHeaderContainer";
			this.panelHeaderContainer.Size = new System.Drawing.Size(1736, 108);
			this.panelHeaderContainer.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(108, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 65);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tasty Table";
			// 
			// LogoPicture
			// 
			this.LogoPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
			this.LogoPicture.Location = new System.Drawing.Point(9, 8);
			this.LogoPicture.Name = "LogoPicture";
			this.LogoPicture.Size = new System.Drawing.Size(95, 93);
			this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.LogoPicture.TabIndex = 0;
			this.LogoPicture.TabStop = false;
			// 
			// panelButtonContainer
			// 
			this.panelButtonContainer.BackColor = System.Drawing.Color.SeaShell;
			this.panelButtonContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelButtonContainer.Controls.Add(this.SearchButton);
			this.panelButtonContainer.Controls.Add(this.AboutButton);
			this.panelButtonContainer.Controls.Add(this.AddRecipeButton);
			this.panelButtonContainer.Controls.Add(this.RecipeBookButton);
			this.panelButtonContainer.Controls.Add(this.HomeButton);
			this.panelButtonContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelButtonContainer.Location = new System.Drawing.Point(0, 108);
			this.panelButtonContainer.Name = "panelButtonContainer";
			this.panelButtonContainer.Size = new System.Drawing.Size(1736, 62);
			this.panelButtonContainer.TabIndex = 3;
			// 
			// HomeButton
			// 
			this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
			this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.HomeButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HomeButton.Location = new System.Drawing.Point(0, 0);
			this.HomeButton.Name = "HomeButton";
			this.HomeButton.Size = new System.Drawing.Size(209, 62);
			this.HomeButton.TabIndex = 0;
			this.HomeButton.Text = "Home";
			this.HomeButton.UseVisualStyleBackColor = false;
			// 
			// RecipeBookButton
			// 
			this.RecipeBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
			this.RecipeBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RecipeBookButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
			this.RecipeBookButton.Location = new System.Drawing.Point(207, 0);
			this.RecipeBookButton.Name = "RecipeBookButton";
			this.RecipeBookButton.Size = new System.Drawing.Size(209, 62);
			this.RecipeBookButton.TabIndex = 1;
			this.RecipeBookButton.Text = "Recipe Book";
			this.RecipeBookButton.UseVisualStyleBackColor = false;
			// 
			// AddRecipeButton
			// 
			this.AddRecipeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
			this.AddRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddRecipeButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
			this.AddRecipeButton.Location = new System.Drawing.Point(414, 0);
			this.AddRecipeButton.Name = "AddRecipeButton";
			this.AddRecipeButton.Size = new System.Drawing.Size(209, 62);
			this.AddRecipeButton.TabIndex = 2;
			this.AddRecipeButton.Text = "Add Recipe";
			this.AddRecipeButton.UseVisualStyleBackColor = false;
			// 
			// AboutButton
			// 
			this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
			this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AboutButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
			this.AboutButton.Location = new System.Drawing.Point(621, 0);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(209, 62);
			this.AboutButton.TabIndex = 3;
			this.AboutButton.Text = "About Us";
			this.AboutButton.UseVisualStyleBackColor = false;
			// 
			// WelcomeLabel
			// 
			this.WelcomeLabel.AutoSize = true;
			this.WelcomeLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeLabel.Location = new System.Drawing.Point(1493, 33);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.Size = new System.Drawing.Size(126, 40);
			this.WelcomeLabel.TabIndex = 2;
			this.WelcomeLabel.Text = "Welcome!";
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
			this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SearchButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
			this.SearchButton.Location = new System.Drawing.Point(830, -2);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(209, 62);
			this.SearchButton.TabIndex = 4;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = false;
			// 
			// TastyTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(1736, 933);
			this.Controls.Add(this.panelButtonContainer);
			this.Controls.Add(this.panelHeaderContainer);
			this.Controls.Add(this.panelFooterContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TastyTableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tasty Table Lite";
			this.panelHeaderContainer.ResumeLayout(false);
			this.panelHeaderContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
			this.panelButtonContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelFooterContainer;
		private System.Windows.Forms.Panel panelHeaderContainer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox LogoPicture;
		private System.Windows.Forms.Panel panelButtonContainer;
		private System.Windows.Forms.Button AboutButton;
		private System.Windows.Forms.Button AddRecipeButton;
		private System.Windows.Forms.Button RecipeBookButton;
		private System.Windows.Forms.Button HomeButton;
		private System.Windows.Forms.Label WelcomeLabel;
		private System.Windows.Forms.Button SearchButton;
	}
}

