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
			this.components = new System.ComponentModel.Container();
			this.AddIngButton = new System.Windows.Forms.Button();
			this.QuantityLabel = new System.Windows.Forms.Label();
			this.IngNameLabel = new System.Windows.Forms.Label();
			this.UnitLabel = new System.Windows.Forms.Label();
			this.AddNewRecipeButton = new System.Windows.Forms.Button();
			this.RecipeNameLabel = new System.Windows.Forms.Label();
			this.TempNumLabel = new System.Windows.Forms.Label();
			this.TempCharLabel = new System.Windows.Forms.Label();
			this.RecipeNameTextBox = new System.Windows.Forms.TextBox();
			this.TempNumTextBox = new System.Windows.Forms.TextBox();
			this.TempCharComboBox = new System.Windows.Forms.ComboBox();
			this.DisplayRecipeTextBox = new System.Windows.Forms.TextBox();
			this.ReadyButton = new System.Windows.Forms.Button();
			this.DonWIngButton = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// AddIngButton
			// 
			this.AddIngButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.AddIngButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddIngButton.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
			this.AddIngButton.Location = new System.Drawing.Point(528, 217);
			this.AddIngButton.Name = "AddIngButton";
			this.AddIngButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.AddIngButton.Size = new System.Drawing.Size(36, 32);
			this.AddIngButton.TabIndex = 3;
			this.AddIngButton.Text = "+";
			this.AddIngButton.UseVisualStyleBackColor = false;
			this.AddIngButton.Click += new System.EventHandler(this.AddIngButton_Click);
			// 
			// QuantityLabel
			// 
			this.QuantityLabel.AutoSize = true;
			this.QuantityLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.QuantityLabel.Location = new System.Drawing.Point(27, 222);
			this.QuantityLabel.Name = "QuantityLabel";
			this.QuantityLabel.Size = new System.Drawing.Size(73, 24);
			this.QuantityLabel.TabIndex = 4;
			this.QuantityLabel.Text = "Quantity";
			// 
			// IngNameLabel
			// 
			this.IngNameLabel.AutoSize = true;
			this.IngNameLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.IngNameLabel.Location = new System.Drawing.Point(298, 222);
			this.IngNameLabel.Name = "IngNameLabel";
			this.IngNameLabel.Size = new System.Drawing.Size(81, 24);
			this.IngNameLabel.TabIndex = 5;
			this.IngNameLabel.Text = "Ingredient";
			// 
			// UnitLabel
			// 
			this.UnitLabel.AutoSize = true;
			this.UnitLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.UnitLabel.Location = new System.Drawing.Point(120, 222);
			this.UnitLabel.Name = "UnitLabel";
			this.UnitLabel.Size = new System.Drawing.Size(160, 24);
			this.UnitLabel.TabIndex = 6;
			this.UnitLabel.Text = "Unit of Measurement";
			// 
			// AddNewRecipeButton
			// 
			this.AddNewRecipeButton.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.AddNewRecipeButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AddNewRecipeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.AddNewRecipeButton.Location = new System.Drawing.Point(494, 0);
			this.AddNewRecipeButton.Name = "AddNewRecipeButton";
			this.AddNewRecipeButton.Size = new System.Drawing.Size(286, 67);
			this.AddNewRecipeButton.TabIndex = 7;
			this.AddNewRecipeButton.Text = "Add Recipe";
			this.AddNewRecipeButton.UseVisualStyleBackColor = true;
			this.AddNewRecipeButton.Click += new System.EventHandler(this.AddNewRecipeButton_Click);
			// 
			// RecipeNameLabel
			// 
			this.RecipeNameLabel.AutoSize = true;
			this.RecipeNameLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.RecipeNameLabel.Location = new System.Drawing.Point(18, 46);
			this.RecipeNameLabel.Name = "RecipeNameLabel";
			this.RecipeNameLabel.Size = new System.Drawing.Size(100, 24);
			this.RecipeNameLabel.TabIndex = 8;
			this.RecipeNameLabel.Text = "Recipe Name";
			// 
			// TempNumLabel
			// 
			this.TempNumLabel.AutoSize = true;
			this.TempNumLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.TempNumLabel.Location = new System.Drawing.Point(18, 87);
			this.TempNumLabel.Name = "TempNumLabel";
			this.TempNumLabel.Size = new System.Drawing.Size(101, 24);
			this.TempNumLabel.TabIndex = 9;
			this.TempNumLabel.Text = "Temperature";
			// 
			// TempCharLabel
			// 
			this.TempCharLabel.AutoSize = true;
			this.TempCharLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.TempCharLabel.Location = new System.Drawing.Point(82, 124);
			this.TempCharLabel.Name = "TempCharLabel";
			this.TempCharLabel.Size = new System.Drawing.Size(36, 24);
			this.TempCharLabel.TabIndex = 10;
			this.TempCharLabel.Text = "F/C";
			// 
			// RecipeNameTextBox
			// 
			this.RecipeNameTextBox.Location = new System.Drawing.Point(124, 46);
			this.RecipeNameTextBox.Name = "RecipeNameTextBox";
			this.RecipeNameTextBox.Size = new System.Drawing.Size(255, 22);
			this.RecipeNameTextBox.TabIndex = 11;
			// 
			// TempNumTextBox
			// 
			this.TempNumTextBox.Location = new System.Drawing.Point(125, 87);
			this.TempNumTextBox.Name = "TempNumTextBox";
			this.TempNumTextBox.Size = new System.Drawing.Size(136, 22);
			this.TempNumTextBox.TabIndex = 12;
			// 
			// TempCharComboBox
			// 
			this.TempCharComboBox.FormattingEnabled = true;
			this.TempCharComboBox.Items.AddRange(new object[] {
            "F",
            "C"});
			this.TempCharComboBox.Location = new System.Drawing.Point(125, 125);
			this.TempCharComboBox.Name = "TempCharComboBox";
			this.TempCharComboBox.Size = new System.Drawing.Size(136, 24);
			this.TempCharComboBox.TabIndex = 13;
			// 
			// DisplayRecipeTextBox
			// 
			this.DisplayRecipeTextBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.DisplayRecipeTextBox.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.DisplayRecipeTextBox.Location = new System.Drawing.Point(780, 0);
			this.DisplayRecipeTextBox.Multiline = true;
			this.DisplayRecipeTextBox.Name = "DisplayRecipeTextBox";
			this.DisplayRecipeTextBox.Size = new System.Drawing.Size(291, 672);
			this.DisplayRecipeTextBox.TabIndex = 14;
			// 
			// ReadyButton
			// 
			this.ReadyButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
			this.ReadyButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ReadyButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ReadyButton.Location = new System.Drawing.Point(22, 168);
			this.ReadyButton.Name = "ReadyButton";
			this.ReadyButton.Size = new System.Drawing.Size(280, 33);
			this.ReadyButton.TabIndex = 15;
			this.ReadyButton.Text = "Ready to add ingredients?";
			this.ReadyButton.UseVisualStyleBackColor = true;
			this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
			// 
			// DonWIngButton
			// 
			this.DonWIngButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.DonWIngButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DonWIngButton.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
			this.DonWIngButton.Location = new System.Drawing.Point(599, 214);
			this.DonWIngButton.Name = "DonWIngButton";
			this.DonWIngButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DonWIngButton.Size = new System.Drawing.Size(175, 32);
			this.DonWIngButton.TabIndex = 16;
			this.DonWIngButton.Text = "Done w/ Ingredients";
			this.DonWIngButton.UseVisualStyleBackColor = false;
			this.DonWIngButton.Click += new System.EventHandler(this.DonWIngButton_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// AddRecipeUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.DonWIngButton);
			this.Controls.Add(this.ReadyButton);
			this.Controls.Add(this.DisplayRecipeTextBox);
			this.Controls.Add(this.TempCharComboBox);
			this.Controls.Add(this.TempNumTextBox);
			this.Controls.Add(this.RecipeNameTextBox);
			this.Controls.Add(this.TempCharLabel);
			this.Controls.Add(this.TempNumLabel);
			this.Controls.Add(this.RecipeNameLabel);
			this.Controls.Add(this.AddNewRecipeButton);
			this.Controls.Add(this.UnitLabel);
			this.Controls.Add(this.IngNameLabel);
			this.Controls.Add(this.QuantityLabel);
			this.Controls.Add(this.AddIngButton);
			this.Name = "AddRecipeUC";
			this.Size = new System.Drawing.Size(953, 672);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button AddIngButton;
		private System.Windows.Forms.Label QuantityLabel;
		private System.Windows.Forms.Label IngNameLabel;
		private System.Windows.Forms.Label UnitLabel;
		private System.Windows.Forms.Button AddNewRecipeButton;
		private System.Windows.Forms.Label RecipeNameLabel;
		private System.Windows.Forms.Label TempNumLabel;
		private System.Windows.Forms.Label TempCharLabel;
		private System.Windows.Forms.TextBox RecipeNameTextBox;
		private System.Windows.Forms.TextBox TempNumTextBox;
		private System.Windows.Forms.ComboBox TempCharComboBox;
		private System.Windows.Forms.TextBox DisplayRecipeTextBox;
		private System.Windows.Forms.Button ReadyButton;
		private System.Windows.Forms.Button DonWIngButton;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}
