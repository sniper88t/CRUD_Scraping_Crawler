namespace WindowsFormsApp1
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
            this.btnFetchData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAllData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(581, 374);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(182, 40);
            this.btnFetchData.TabIndex = 0;
            this.btnFetchData.Text = "Show Current Data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAllData
            // 
            this.btnAllData.Location = new System.Drawing.Point(582, 449);
            this.btnAllData.Name = "btnAllData";
            this.btnAllData.Size = new System.Drawing.Size(182, 39);
            this.btnAllData.TabIndex = 2;
            this.btnAllData.Text = "Show Scraped Data";
            this.btnAllData.UseVisualStyleBackColor = true;
            this.btnAllData.Click += new System.EventHandler(this.btnAllData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblCostPrice);
            this.groupBox1.Controls.Add(this.lblItemID);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Controls.Add(this.txtCostPrice);
            this.groupBox1.Controls.Add(this.txtItemID);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(95, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD OPERATION";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(274, 156);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 32);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(274, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(273, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Insert Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(28, 168);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(55, 13);
            this.lblCostPrice.TabIndex = 9;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(28, 137);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 8;
            this.lblItemID.Text = "Item ID";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(20, 99);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Item Name";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(98, 168);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(149, 20);
            this.txtCostPrice.TabIndex = 6;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(98, 130);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(149, 20);
            this.txtItemID.TabIndex = 5;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(98, 97);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(149, 20);
            this.txtItemName.TabIndex = 4;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(98, 59);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(149, 20);
            this.txtBrandName.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(17, 62);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(66, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ProductID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAllData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFetchData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAllData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}

