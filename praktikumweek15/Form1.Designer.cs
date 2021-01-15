namespace praktikumweek15
{
    partial class Form1
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioBtnMakanan = new System.Windows.Forms.RadioButton();
            this.radioBtnMinuman = new System.Windows.Forms.RadioButton();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNominal = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.radioBtnJumbo = new System.Windows.Forms.RadioButton();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.panelMknmnm = new System.Windows.Forms.Panel();
            this.panelSize = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(236, 34);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(120, 29);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "BU DEWI";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(94, 75);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(33, 13);
            this.labelItem.TabIndex = 1;
            this.labelItem.Text = "ITEM";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(25, 108);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(141, 212);
            this.listBoxMenu.TabIndex = 2;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.Location = new System.Drawing.Point(172, 108);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(118, 212);
            this.listBoxHarga.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(214, 337);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // radioBtnMakanan
            // 
            this.radioBtnMakanan.AutoSize = true;
            this.radioBtnMakanan.Location = new System.Drawing.Point(337, 108);
            this.radioBtnMakanan.Name = "radioBtnMakanan";
            this.radioBtnMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioBtnMakanan.TabIndex = 5;
            this.radioBtnMakanan.TabStop = true;
            this.radioBtnMakanan.Text = "Makanan";
            this.radioBtnMakanan.UseVisualStyleBackColor = true;
            this.radioBtnMakanan.CheckedChanged += new System.EventHandler(this.radioBtnMakanan_CheckedChanged);
            // 
            // radioBtnMinuman
            // 
            this.radioBtnMinuman.AutoSize = true;
            this.radioBtnMinuman.Location = new System.Drawing.Point(452, 108);
            this.radioBtnMinuman.Name = "radioBtnMinuman";
            this.radioBtnMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioBtnMinuman.TabIndex = 6;
            this.radioBtnMinuman.TabStop = true;
            this.radioBtnMinuman.Text = "Minuman";
            this.radioBtnMinuman.UseVisualStyleBackColor = true;
            this.radioBtnMinuman.CheckedChanged += new System.EventHandler(this.radioBtnMinuman_CheckedChanged);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Items.AddRange(new object[] {
            "Es teh ",
            "Teh Hangat",
            "Nutrisari",
            "Aqua",
            "Nais Goreng",
            "Nasi Goreng Spesial",
            "Nasi Goreng Pete",
            "Ayam Bakar "});
            this.comboBoxMenu.Location = new System.Drawing.Point(371, 141);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMenu.TabIndex = 7;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(329, 144);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(39, 13);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "MENU";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(526, 149);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(36, 13);
            this.labelHarga.TabIndex = 9;
            this.labelHarga.Text = "Harga";
            // 
            // labelNominal
            // 
            this.labelNominal.AutoSize = true;
            this.labelNominal.Location = new System.Drawing.Point(592, 148);
            this.labelNominal.Name = "labelNominal";
            this.labelNominal.Size = new System.Drawing.Size(13, 13);
            this.labelNominal.TabIndex = 10;
            this.labelNominal.Text = "  ";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(333, 193);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "Size";
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.Location = new System.Drawing.Point(337, 223);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(58, 17);
            this.radioBtnNormal.TabIndex = 12;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "Normal";
            this.radioBtnNormal.UseVisualStyleBackColor = true;
            // 
            // radioBtnJumbo
            // 
            this.radioBtnJumbo.AutoSize = true;
            this.radioBtnJumbo.Location = new System.Drawing.Point(452, 223);
            this.radioBtnJumbo.Name = "radioBtnJumbo";
            this.radioBtnJumbo.Size = new System.Drawing.Size(56, 17);
            this.radioBtnJumbo.TabIndex = 13;
            this.radioBtnJumbo.TabStop = true;
            this.radioBtnJumbo.Text = "Jumbo";
            this.radioBtnJumbo.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(435, 268);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(102, 43);
            this.buttonBuy.TabIndex = 14;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(529, 369);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(110, 57);
            this.buttonCheckOut.TabIndex = 15;
            this.buttonCheckOut.Text = "CHECKOUT";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // panelMknmnm
            // 
            this.panelMknmnm.Location = new System.Drawing.Point(325, 96);
            this.panelMknmnm.Name = "panelMknmnm";
            this.panelMknmnm.Size = new System.Drawing.Size(205, 40);
            this.panelMknmnm.TabIndex = 16;
            // 
            // panelSize
            // 
            this.panelSize.Location = new System.Drawing.Point(325, 213);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(200, 39);
            this.panelSize.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 449);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.radioBtnJumbo);
            this.Controls.Add(this.radioBtnNormal);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelNominal);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.radioBtnMinuman);
            this.Controls.Add(this.radioBtnMakanan);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.panelMknmnm);
            this.Controls.Add(this.panelSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioBtnMakanan;
        private System.Windows.Forms.RadioButton radioBtnMinuman;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNominal;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RadioButton radioBtnNormal;
        private System.Windows.Forms.RadioButton radioBtnJumbo;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Panel panelMknmnm;
        private System.Windows.Forms.Panel panelSize;
    }
}

