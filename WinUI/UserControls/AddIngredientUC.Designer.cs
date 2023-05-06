namespace WinUI.UserControls
{
	partial class AddIngredientUC
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
			this.QuantityComboBox = new System.Windows.Forms.ComboBox();
			this.UnitComboBox = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// QuantityComboBox
			// 
			this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.QuantityComboBox.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.QuantityComboBox.FormattingEnabled = true;
			this.QuantityComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30",
            "30.5",
            "31",
            "31.5",
            "32",
            "32.5",
            "33",
            "33.5",
            "34",
            "34.5",
            "35",
            "35.5",
            "36",
            "36.5",
            "37",
            "37.5",
            "38",
            "38.5",
            "39",
            "39.5",
            "40",
            "40.5",
            "41",
            "41.5",
            "42",
            "42.5",
            "43",
            "43.5",
            "44",
            "44.5",
            "45",
            "45.5",
            "46",
            "46.5",
            "47",
            "47.5",
            "48",
            "48.5",
            "49",
            "49.5",
            "50",
            "50.5"});
			this.QuantityComboBox.Location = new System.Drawing.Point(11, 14);
			this.QuantityComboBox.Name = "QuantityComboBox";
			this.QuantityComboBox.Size = new System.Drawing.Size(99, 31);
			this.QuantityComboBox.TabIndex = 0;
			// 
			// UnitComboBox
			// 
			this.UnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UnitComboBox.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.UnitComboBox.FormattingEnabled = true;
			this.UnitComboBox.Items.AddRange(new object[] {
            "Teaspoon",
            "Tablespoon",
            "Cup",
            "Fluid Ounce",
            "Ounce",
            "Can",
            "Gram",
            "Pound",
            "Pint",
            "Quart",
            "Gallon",
            "Milliliter",
            "Liter"});
			this.UnitComboBox.Location = new System.Drawing.Point(116, 14);
			this.UnitComboBox.Name = "UnitComboBox";
			this.UnitComboBox.Size = new System.Drawing.Size(174, 31);
			this.UnitComboBox.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(296, 14);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(283, 31);
			this.textBox1.TabIndex = 2;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(617, 18);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddIngredientUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.UnitComboBox);
			this.Controls.Add(this.QuantityComboBox);
			this.Name = "AddIngredientUC";
			this.Size = new System.Drawing.Size(726, 60);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox QuantityComboBox;
		private System.Windows.Forms.ComboBox UnitComboBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button SaveButton;
	}
}
