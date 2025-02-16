using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Techfix_App.Models;

namespace Techfix_App
{
    public partial class Quote : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<Supplier> suppliers; // To hold the suppliers
        private List<Product> products; // To hold products for the selected supplier
        public Quote()
        {
            InitializeComponent();
            LoadSuppliers(); // Load suppliers when form initializes
            LoadQuotes(); // Load existing quotes
        }

        private async Task LoadSuppliers()
        {
            var response = await _client.GetAsync("https://localhost:7070/TechFix_API/Supplier");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(result);

                suppliercomboBox1.DataSource = new BindingSource(suppliers, null);
                suppliercomboBox1.DisplayMember = "SupplierName"; // Display SupplierName
                suppliercomboBox1.ValueMember = "Id"; // Supplier ID is the value
            }
        }

        private async Task LoadProductsForSupplier(int supplierId)
        {
            var response = await _client.GetAsync($"https://localhost:7070/TechFix_API/SupplierProducts/GetProductsBySupplier/{supplierId}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(result);

                productcomboBox2.DataSource = new BindingSource(products, null);
                productcomboBox2.DisplayMember = "ProductName"; // Display ProductName
                productcomboBox2.ValueMember = "ProductId"; // Product ID is the value
            }
        }

        private async Task LoadQuotes()
        {
            var response = await _client.GetAsync("https://localhost:7070/TechFix_API/Quotes/GetAllQuotes");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var quotes = JsonConvert.DeserializeObject<List<Quotes>>(result);
                quotedataGridView1.DataSource = quotes; // Bind quotes to the DataGridView
            }
            else
            {
                MessageBox.Show("Error loading quotes.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void suppliercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppliercomboBox1.SelectedValue is int selectedSupplierId)
            {
                await LoadProductsForSupplier(selectedSupplierId); // Load products for the selected supplier
            }
        }

        private async void quoteBtn_Click(object sender, EventArgs e)
        {
            if (suppliercomboBox1.SelectedValue is int supplierId &&
                productcomboBox2.SelectedValue is int productId &&
                int.TryParse(QuntitytextBox1.Text.Trim(), out int quantity))
            {
                // Create the quote object
                var quoteRequest = new
                {
                    SupplierId = supplierId,
                    ProductId = productId,
                    Quantity = quantity
                };

                var response = await _client.PostAsJsonAsync("https://localhost:7070/TechFix_API/Quotes/RequestQuote", quoteRequest);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Quote request submitted successfully.");
                    await LoadQuotes(); // Refresh the quotes after creating a new quote
                }
                else
                {
                    MessageBox.Show("Error submitting the quote request.");
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier, product, and enter a valid quantity.");
            }
        }
        public class Quotes
        {
            public int QuoteId { get; set; }
            public string SupplierName { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal PricePerUnit { get; set; }
            public decimal TotalPrice { get; set; }
            public string Status { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();

            // Show the Order form
            mForm.Show();

            // Optionally, hide the current form (MainForm)
            this.Hide();
        }
    }
}
