namespace AdoNetDemo
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
			LoadProducts();
		}

		private void LoadProducts()
		{
			dgwProducts.DataSource = _productDal.GetAll();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_productDal.Add(new Product
			{
				Name = tbxName.Text,
				UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
				StockAmount = Convert.ToInt32(tbxStockAmount.Text)
			});

			MessageBox.Show("Product Added!");
			LoadProducts();
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Product product = new Product
			{
				Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
				Name = tbNameUpdate.Text,
				UnitPrice = Convert.ToDecimal(tbUnitPriceUpdate.Text),
				StockAmount = Convert.ToInt32(tbStockAmountUpdate.Text),
			};
			_productDal.Update(product);
			MessageBox.Show("Updated!");
			LoadProducts();

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
			_productDal.Delete(id);
			LoadProducts();
			MessageBox.Show("Removed!");
			
		}
	}
}