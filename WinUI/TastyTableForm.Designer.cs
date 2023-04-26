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
            this.footerLabel = new System.Windows.Forms.Label();
            this.panelHeaderContainer = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.TastyTableLabel = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.panelButtonContainer = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.RecipeBookButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.searchUCF = new WinUI.SearchUC();
            this.aboutUCF = new WinUI.AboutUC();
            this.addRecipeUCF = new WinUI.AddRecipeUC();
            this.recipeBookUCF = new WinUI.RecipeBookUC();
            this.homeUCF = new WinUI.HomeUC();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panelFooterContainer.SuspendLayout();
            this.panelHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.panelButtonContainer.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooterContainer
            // 
            this.panelFooterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
            this.panelFooterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooterContainer.Controls.Add(this.footerLabel);
            this.panelFooterContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterContainer.Location = new System.Drawing.Point(0, 597);
            this.panelFooterContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooterContainer.Name = "panelFooterContainer";
            this.panelFooterContainer.Size = new System.Drawing.Size(1035, 43);
            this.panelFooterContainer.TabIndex = 1;
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLabel.Location = new System.Drawing.Point(603, 4);
            this.footerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(167, 33);
            this.footerLabel.TabIndex = 3;
            this.footerLabel.Text = "Tasty Table Inc.";
            // 
            // panelHeaderContainer
            // 
            this.panelHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.panelHeaderContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeaderContainer.Controls.Add(this.loginButton);
            this.panelHeaderContainer.Controls.Add(this.registerButton);
            this.panelHeaderContainer.Controls.Add(this.WelcomeLabel);
            this.panelHeaderContainer.Controls.Add(this.TastyTableLabel);
            this.panelHeaderContainer.Controls.Add(this.LogoPicture);
            this.panelHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeaderContainer.Name = "panelHeaderContainer";
            this.panelHeaderContainer.Size = new System.Drawing.Size(1035, 88);
            this.panelHeaderContainer.TabIndex = 2;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(1120, 27);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(105, 33);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome!";
            // 
            // TastyTableLabel
            // 
            this.TastyTableLabel.AutoSize = true;
            this.TastyTableLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TastyTableLabel.Location = new System.Drawing.Point(81, 15);
            this.TastyTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TastyTableLabel.Name = "TastyTableLabel";
            this.TastyTableLabel.Size = new System.Drawing.Size(198, 54);
            this.TastyTableLabel.TabIndex = 1;
            this.TastyTableLabel.Text = "Tasty Table";
            // 
            // LogoPicture
            // 
            this.LogoPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(7, 6);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(72, 76);
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
            this.panelButtonContainer.Location = new System.Drawing.Point(0, 88);
            this.panelButtonContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtonContainer.Name = "panelButtonContainer";
            this.panelButtonContainer.Size = new System.Drawing.Size(1035, 51);
            this.panelButtonContainer.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.SearchButton.Location = new System.Drawing.Point(622, -2);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(157, 50);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AboutButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.AboutButton.Location = new System.Drawing.Point(466, 0);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(157, 50);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "About Us";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
            this.AddRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRecipeButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.AddRecipeButton.Location = new System.Drawing.Point(310, 0);
            this.AddRecipeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(157, 50);
            this.AddRecipeButton.TabIndex = 2;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = false;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // RecipeBookButton
            // 
            this.RecipeBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
            this.RecipeBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecipeBookButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.RecipeBookButton.Location = new System.Drawing.Point(155, 0);
            this.RecipeBookButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecipeBookButton.Name = "RecipeBookButton";
            this.RecipeBookButton.Size = new System.Drawing.Size(157, 50);
            this.RecipeBookButton.TabIndex = 1;
            this.RecipeBookButton.Text = "Recipe Book";
            this.RecipeBookButton.UseVisualStyleBackColor = false;
            this.RecipeBookButton.Click += new System.EventHandler(this.RecipeBookButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(133)))), ((int)(((byte)(45)))));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(157, 50);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.userInfoLabel);
            this.userInfoPanel.Controls.Add(this.userNameLabel);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userInfoPanel.Location = new System.Drawing.Point(856, 139);
            this.userInfoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(179, 458);
            this.userInfoPanel.TabIndex = 4;
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoLabel.Location = new System.Drawing.Point(16, 70);
            this.userInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(157, 28);
            this.userInfoLabel.TabIndex = 4;
            this.userInfoLabel.Text = "Number of recipes";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(34, 15);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(121, 33);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "User Name";
            // 
            // searchUCF
            // 
            this.searchUCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.searchUCF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchUCF.Location = new System.Drawing.Point(157, 138);
            this.searchUCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchUCF.Name = "searchUCF";
            this.searchUCF.Size = new System.Drawing.Size(962, 577);
            this.searchUCF.TabIndex = 9;
            // 
            // aboutUCF
            // 
            this.aboutUCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.aboutUCF.Location = new System.Drawing.Point(157, 138);
            this.aboutUCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aboutUCF.Name = "aboutUCF";
            this.aboutUCF.Size = new System.Drawing.Size(962, 574);
            this.aboutUCF.TabIndex = 8;
            // 
            // addRecipeUCF
            // 
            this.addRecipeUCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.addRecipeUCF.Location = new System.Drawing.Point(157, 138);
            this.addRecipeUCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecipeUCF.Name = "addRecipeUCF";
            this.addRecipeUCF.Size = new System.Drawing.Size(962, 577);
            this.addRecipeUCF.TabIndex = 7;
            // 
            // recipeBookUCF
            // 
            this.recipeBookUCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.recipeBookUCF.Location = new System.Drawing.Point(157, 138);
            this.recipeBookUCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recipeBookUCF.Name = "recipeBookUCF";
            this.recipeBookUCF.Size = new System.Drawing.Size(962, 577);
            this.recipeBookUCF.TabIndex = 6;
            // 
            // homeUCF
            // 
            this.homeUCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.homeUCF.Location = new System.Drawing.Point(163, 138);
            this.homeUCF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeUCF.Name = "homeUCF";
            this.homeUCF.Size = new System.Drawing.Size(956, 577);
            this.homeUCF.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(311, 29);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(104, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(422, 28);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(96, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // TastyTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.searchUCF);
            this.Controls.Add(this.aboutUCF);
            this.Controls.Add(this.addRecipeUCF);
            this.Controls.Add(this.recipeBookUCF);
            this.Controls.Add(this.homeUCF);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.panelButtonContainer);
            this.Controls.Add(this.panelHeaderContainer);
            this.Controls.Add(this.panelFooterContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TastyTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasty Table Lite";
            this.Load += new System.EventHandler(this.TastyTableForm_Load);
            this.panelFooterContainer.ResumeLayout(false);
            this.panelFooterContainer.PerformLayout();
            this.panelHeaderContainer.ResumeLayout(false);
            this.panelHeaderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.panelButtonContainer.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelFooterContainer;
		private System.Windows.Forms.Panel panelHeaderContainer;
		private System.Windows.Forms.Label TastyTableLabel;
		private System.Windows.Forms.PictureBox LogoPicture;
		private System.Windows.Forms.Panel panelButtonContainer;
		private System.Windows.Forms.Button AboutButton;
		private System.Windows.Forms.Button AddRecipeButton;
		private System.Windows.Forms.Button RecipeBookButton;
		private System.Windows.Forms.Button HomeButton;
		private System.Windows.Forms.Label WelcomeLabel;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Panel userInfoPanel;
		private HomeUC homeUCF;
		private RecipeBookUC recipeBookUCF;
		private AddRecipeUC addRecipeUCF;
		private AboutUC aboutUCF;
		private SearchUC searchUCF;
		private System.Windows.Forms.Label footerLabel;
		private System.Windows.Forms.Label userInfoLabel;
		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button registerButton;
	}
}

