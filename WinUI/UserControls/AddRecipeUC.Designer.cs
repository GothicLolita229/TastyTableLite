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
			this.AddIngButton = new System.Windows.Forms.Button();
			this.QuantityLabel = new System.Windows.Forms.Label();
			this.IngNameLabel = new System.Windows.Forms.Label();
			this.UnitLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddRecipeUCLabel
			// 
			this.AddRecipeUCLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AddRecipeUCLabel.AutoSize = true;
			this.AddRecipeUCLabel.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold);
			this.AddRecipeUCLabel.Location = new System.Drawing.Point(3, 0);
			this.AddRecipeUCLabel.Name = "AddRecipeUCLabel";
			this.AddRecipeUCLabel.Size = new System.Drawing.Size(239, 65);
			this.AddRecipeUCLabel.TabIndex = 2;
			this.AddRecipeUCLabel.Text = "Add Recipe";
			// 
			// AddIngButton
			// 
			this.AddIngButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.AddIngButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddIngButton.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
			this.AddIngButton.Location = new System.Drawing.Point(465, 33);
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
			this.QuantityLabel.Location = new System.Drawing.Point(25, 41);
			this.QuantityLabel.Name = "QuantityLabel";
			this.QuantityLabel.Size = new System.Drawing.Size(73, 24);
			this.QuantityLabel.TabIndex = 4;
			this.QuantityLabel.Text = "Quantity";
			// 
			// IngNameLabel
			// 
			this.IngNameLabel.AutoSize = true;
			this.IngNameLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.IngNameLabel.Location = new System.Drawing.Point(311, 41);
			this.IngNameLabel.Name = "IngNameLabel";
			this.IngNameLabel.Size = new System.Drawing.Size(81, 24);
			this.IngNameLabel.TabIndex = 5;
			this.IngNameLabel.Text = "Ingredient";
			// 
			// UnitLabel
			// 
			this.UnitLabel.AutoSize = true;
			this.UnitLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.UnitLabel.Location = new System.Drawing.Point(134, 41);
			this.UnitLabel.Name = "UnitLabel";
			this.UnitLabel.Size = new System.Drawing.Size(160, 24);
			this.UnitLabel.TabIndex = 6;
			this.UnitLabel.Text = "Unit of Measurement";
			// 
			// AddRecipeUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.UnitLabel);
			this.Controls.Add(this.IngNameLabel);
			this.Controls.Add(this.QuantityLabel);
			this.Controls.Add(this.AddIngButton);
			this.Controls.Add(this.AddRecipeUCLabel);
			this.Name = "AddRecipeUC";
			this.Size = new System.Drawing.Size(953, 735);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AddRecipeUCLabel;
		private System.Windows.Forms.Button AddIngButton;
		private System.Windows.Forms.Label QuantityLabel;
		private System.Windows.Forms.Label IngNameLabel;
		private System.Windows.Forms.Label UnitLabel;
	}
}
