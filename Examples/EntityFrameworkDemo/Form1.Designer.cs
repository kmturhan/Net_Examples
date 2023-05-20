namespace EntityFrameworkDemo
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRemove = new System.Windows.Forms.Button();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbStockAmountUpdate = new System.Windows.Forms.TextBox();
			this.tbUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.tbNameUpdate = new System.Windows.Forms.TextBox();
			this.gbxAdd = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxStockAmount = new System.Windows.Forms.TextBox();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.dgwProducts = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.btnGetId = new System.Windows.Forms.Button();
			this.gbxUpdate.SuspendLayout();
			this.gbxAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(612, 341);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(126, 23);
			this.btnRemove.TabIndex = 7;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.label4);
			this.gbxUpdate.Controls.Add(this.label5);
			this.gbxUpdate.Controls.Add(this.label6);
			this.gbxUpdate.Controls.Add(this.tbStockAmountUpdate);
			this.gbxUpdate.Controls.Add(this.tbUnitPriceUpdate);
			this.gbxUpdate.Controls.Add(this.tbNameUpdate);
			this.gbxUpdate.Location = new System.Drawing.Point(318, 341);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(278, 181);
			this.gbxUpdate.TabIndex = 6;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Update a product";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(144, 133);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Stock Amount";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Unit Price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 15);
			this.label6.TabIndex = 3;
			this.label6.Text = "Name";
			// 
			// tbStockAmountUpdate
			// 
			this.tbStockAmountUpdate.Location = new System.Drawing.Point(107, 93);
			this.tbStockAmountUpdate.Name = "tbStockAmountUpdate";
			this.tbStockAmountUpdate.Size = new System.Drawing.Size(147, 23);
			this.tbStockAmountUpdate.TabIndex = 2;
			// 
			// tbUnitPriceUpdate
			// 
			this.tbUnitPriceUpdate.Location = new System.Drawing.Point(107, 64);
			this.tbUnitPriceUpdate.Name = "tbUnitPriceUpdate";
			this.tbUnitPriceUpdate.Size = new System.Drawing.Size(147, 23);
			this.tbUnitPriceUpdate.TabIndex = 1;
			// 
			// tbNameUpdate
			// 
			this.tbNameUpdate.Location = new System.Drawing.Point(107, 35);
			this.tbNameUpdate.Name = "tbNameUpdate";
			this.tbNameUpdate.Size = new System.Drawing.Size(147, 23);
			this.tbNameUpdate.TabIndex = 0;
			// 
			// gbxAdd
			// 
			this.gbxAdd.Controls.Add(this.btnAdd);
			this.gbxAdd.Controls.Add(this.label3);
			this.gbxAdd.Controls.Add(this.label2);
			this.gbxAdd.Controls.Add(this.label1);
			this.gbxAdd.Controls.Add(this.tbxStockAmount);
			this.gbxAdd.Controls.Add(this.tbxUnitPrice);
			this.gbxAdd.Controls.Add(this.tbxName);
			this.gbxAdd.Location = new System.Drawing.Point(12, 341);
			this.gbxAdd.Name = "gbxAdd";
			this.gbxAdd.Size = new System.Drawing.Size(278, 181);
			this.gbxAdd.TabIndex = 5;
			this.gbxAdd.TabStop = false;
			this.gbxAdd.Text = "Add a product";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(144, 133);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Stock Amount";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Unit Price";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			// 
			// tbxStockAmount
			// 
			this.tbxStockAmount.Location = new System.Drawing.Point(107, 93);
			this.tbxStockAmount.Name = "tbxStockAmount";
			this.tbxStockAmount.Size = new System.Drawing.Size(147, 23);
			this.tbxStockAmount.TabIndex = 2;
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(107, 64);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(147, 23);
			this.tbxUnitPrice.TabIndex = 1;
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(107, 35);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(147, 23);
			this.tbxName.TabIndex = 0;
			// 
			// dgwProducts
			// 
			this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProducts.Location = new System.Drawing.Point(12, 42);
			this.dgwProducts.Name = "dgwProducts";
			this.dgwProducts.RowTemplate.Height = 25;
			this.dgwProducts.Size = new System.Drawing.Size(726, 281);
			this.dgwProducts.TabIndex = 4;
			this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
			this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(482, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "Arama";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Location = new System.Drawing.Point(530, 9);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(208, 23);
			this.tbxSearch.TabIndex = 9;
			this.tbxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnGetId
			// 
			this.btnGetId.Location = new System.Drawing.Point(224, 10);
			this.btnGetId.Name = "btnGetId";
			this.btnGetId.Size = new System.Drawing.Size(117, 23);
			this.btnGetId.TabIndex = 10;
			this.btnGetId.Text = "First Or Default";
			this.btnGetId.UseVisualStyleBackColor = true;
			this.btnGetId.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 577);
			this.Controls.Add(this.btnGetId);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.gbxAdd);
			this.Controls.Add(this.dgwProducts);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
			this.gbxAdd.ResumeLayout(false);
			this.gbxAdd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnRemove;
		private GroupBox gbxUpdate;
		private Button btnUpdate;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox tbStockAmountUpdate;
		private TextBox tbUnitPriceUpdate;
		private TextBox tbNameUpdate;
		private GroupBox gbxAdd;
		private Button btnAdd;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox tbxStockAmount;
		private TextBox tbxUnitPrice;
		private TextBox tbxName;
		private DataGridView dgwProducts;
		private Label label7;
		private TextBox tbxSearch;
		private Button btnGetId;
	}
}