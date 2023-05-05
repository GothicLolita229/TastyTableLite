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
			this.SuspendLayout();
			// 
			// QuantityComboBox
			// 
			this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.QuantityComboBox.Font = new System.Drawing.Font("Segoe Print", 8F);
			this.QuantityComboBox.FormattingEnabled = true;
			this.QuantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
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
			// AddIngredientUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.UnitComboBox);
			this.Controls.Add(this.QuantityComboBox);
			this.Name = "AddIngredientUC";
			this.Size = new System.Drawing.Size(597, 60);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox QuantityComboBox;
		private System.Windows.Forms.ComboBox UnitComboBox;
		private System.Windows.Forms.TextBox textBox1;
	}
}
