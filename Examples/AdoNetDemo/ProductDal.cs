using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
	//Data Access Layer
	//CRUD Operations
	public class ProductDal
	{
		SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=True");
		public List<Product> GetAll()
		{

			ConnectionControl();


			SqlCommand command = new SqlCommand("select * from Products", _connection);
			SqlDataReader reader = command.ExecuteReader();
			List<Product> products = new List<Product>();

			while (reader.Read())
			{
				Product product = new Product
				{
					Id = Convert.ToInt32(reader["Id"]),
					Name = reader["Name"].ToString(),
					StockAmount = Convert.ToInt32(reader["StockAmount"]),
					UnitPrice = Convert.ToInt32(reader["UnitPrice"])
				};
				products.Add(product);
			}

			reader.Close();
			_connection.Close();
			return products;
		}

		public void Add(Product product)
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
			command.Parameters.AddWithValue("@name",product.Name);
			command.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
			command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
			command.ExecuteNonQuery();
			_connection.Close();
		}
		public void Update(Product product)
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("Update Products SET Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount WHERE Id=@id", _connection);
			command.Parameters.AddWithValue("@id", product.Id);
			command.Parameters.AddWithValue("@name", product.Name);
			command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
			command.ExecuteNonQuery();
			_connection.Close();
		}
		public void Delete(int id)
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id=@id", _connection);
			command.Parameters.AddWithValue("@id", id);
			command.ExecuteNonQuery();
			_connection.Close();
		}
		private void ConnectionControl()
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}
		}
		public DataTable GetAllDataTable()
		{
			SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=True");
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
			SqlCommand command = new SqlCommand("select * from Products", connection);
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			reader.Close();
			connection.Close();
			return dataTable;
		}
	}
}
