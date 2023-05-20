namespace EntityFrameworkDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		ProductDal _productDal = new ProductDal();
		private void Form1_Load(object sender, EventArgs e)
		{
			using (ETradeContext context = new ETradeContext())
			{
				LoadProducts();
			}
		}

		private void LoadProducts()
		{
			dgwProducts.DataSource = _productDal.GetAll();
		}
		private void SearchProducts(string key)
		{
			//dgwProducts.DataSource = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
			var result = _productDal.GetByName(key);
			dgwProducts.DataSource = result;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_productDal.Add(new Product
			{
				Name = tbxName.Text,
				UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
				StockAmount = Convert.ToInt32(tbxStockAmount.Text)
			});
			LoadProducts();
			MessageBox.Show("Added!");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			_productDal.Update(new Product
			{
				Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
				Name = tbNameUpdate.Text,
				UnitPrice = Convert.ToDecimal(tbUnitPriceUpdate.Text),
				StockAmount = Convert.ToInt32(tbStockAmountUpdate.Text),
			});
			LoadProducts();
			MessageBox.Show("Updated!");
			
		}

		private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tbNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
			tbUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
			tbStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			_productDal.Delete(new Product
			{
				Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
			});
			LoadProducts();
			MessageBox.Show("Removed!");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			SearchProducts(tbxSearch.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var result = _productDal.GetById(2);
			dgwProducts.DataSource = result;
		}
	}
}