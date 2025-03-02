namespace PresentationLayera
{
    partial class FrmProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetbyId = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblProdcutName = new System.Windows.Forms.Label();
            this.txtPrdocutStock = new System.Windows.Forms.TextBox();
            this.lblProdcutStock = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProdcutPrice = new System.Windows.Forms.Label();
            this.lblProdcutCategory = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblProdcutDescrip = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.btnListele2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(533, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 598);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnGetbyId
            // 
            this.btnGetbyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetbyId.Location = new System.Drawing.Point(151, 530);
            this.btnGetbyId.Name = "btnGetbyId";
            this.btnGetbyId.Size = new System.Drawing.Size(294, 35);
            this.btnGetbyId.TabIndex = 25;
            this.btnGetbyId.Text = "Id\'ye Göre Getir";
            this.btnGetbyId.UseVisualStyleBackColor = true;
            this.btnGetbyId.Click += new System.EventHandler(this.btnGetbyId_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(151, 491);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(294, 35);
            this.btnGüncelle.TabIndex = 24;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(151, 452);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(294, 35);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(151, 413);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(294, 35);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryId.Location = new System.Drawing.Point(232, 37);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(238, 29);
            this.txtCategoryId.TabIndex = 19;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductId.Location = new System.Drawing.Point(115, 37);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(111, 24);
            this.lblProductId.TabIndex = 18;
            this.lblProductId.Text = "Product Id:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(232, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(238, 29);
            this.txtProductName.TabIndex = 16;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(151, 374);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 35);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblProdcutName
            // 
            this.lblProdcutName.AutoSize = true;
            this.lblProdcutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdcutName.Location = new System.Drawing.Point(77, 73);
            this.lblProdcutName.Name = "lblProdcutName";
            this.lblProdcutName.Size = new System.Drawing.Size(149, 24);
            this.lblProdcutName.TabIndex = 14;
            this.lblProdcutName.Text = "Product Name:";
            // 
            // txtPrdocutStock
            // 
            this.txtPrdocutStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrdocutStock.Location = new System.Drawing.Point(232, 110);
            this.txtPrdocutStock.Name = "txtPrdocutStock";
            this.txtPrdocutStock.Size = new System.Drawing.Size(238, 29);
            this.txtPrdocutStock.TabIndex = 28;
            this.txtPrdocutStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblProdcutStock
            // 
            this.lblProdcutStock.AutoSize = true;
            this.lblProdcutStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdcutStock.Location = new System.Drawing.Point(81, 111);
            this.lblProdcutStock.Name = "lblProdcutStock";
            this.lblProdcutStock.Size = new System.Drawing.Size(145, 24);
            this.lblProdcutStock.TabIndex = 27;
            this.lblProdcutStock.Text = "Product Stock:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductPrice.Location = new System.Drawing.Point(232, 145);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(238, 29);
            this.txtProductPrice.TabIndex = 30;
            // 
            // lblProdcutPrice
            // 
            this.lblProdcutPrice.AutoSize = true;
            this.lblProdcutPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdcutPrice.Location = new System.Drawing.Point(84, 145);
            this.lblProdcutPrice.Name = "lblProdcutPrice";
            this.lblProdcutPrice.Size = new System.Drawing.Size(142, 24);
            this.lblProdcutPrice.TabIndex = 29;
            this.lblProdcutPrice.Text = "Product Price:";
            // 
            // lblProdcutCategory
            // 
            this.lblProdcutCategory.AutoSize = true;
            this.lblProdcutCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdcutCategory.Location = new System.Drawing.Point(127, 185);
            this.lblProdcutCategory.Name = "lblProdcutCategory";
            this.lblProdcutCategory.Size = new System.Drawing.Size(99, 24);
            this.lblProdcutCategory.TabIndex = 31;
            this.lblProdcutCategory.Text = "Category:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductDescription.Location = new System.Drawing.Point(232, 215);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(238, 115);
            this.txtProductDescription.TabIndex = 34;
            // 
            // lblProdcutDescrip
            // 
            this.lblProdcutDescrip.AutoSize = true;
            this.lblProdcutDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdcutDescrip.Location = new System.Drawing.Point(27, 219);
            this.lblProdcutDescrip.Name = "lblProdcutDescrip";
            this.lblProdcutDescrip.Size = new System.Drawing.Size(199, 24);
            this.lblProdcutDescrip.TabIndex = 33;
            this.lblProdcutDescrip.Text = "Product Description:";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(232, 181);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(238, 28);
            this.cmbProductCategory.TabIndex = 35;
            // 
            // btnListele2
            // 
            this.btnListele2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele2.Location = new System.Drawing.Point(318, 372);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(127, 35);
            this.btnListele2.TabIndex = 36;
            this.btnListele2.Text = "Listele";
            this.btnListele2.UseVisualStyleBackColor = true;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 624);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.lblProdcutDescrip);
            this.Controls.Add(this.lblProdcutCategory);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProdcutPrice);
            this.Controls.Add(this.txtPrdocutStock);
            this.Controls.Add(this.lblProdcutStock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetbyId);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblProdcutName);
            this.Name = "FrmProduct";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetbyId;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblProdcutName;
        private System.Windows.Forms.TextBox txtPrdocutStock;
        private System.Windows.Forms.Label lblProdcutStock;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProdcutPrice;
        private System.Windows.Forms.Label lblProdcutCategory;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblProdcutDescrip;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Button btnListele2;
    }
}