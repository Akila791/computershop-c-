using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Techfix_App.Models;

namespace Techfix_App
{
    public partial class Inventory : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<Supplier> suppliers;
        public Inventory()
        {
            InitializeComponent();
            LoadSuppliers(); 
        }

        private async Task LoadSuppliers()
        {
            var response = await _client.GetAsync("https://localhost:7070/TechFix_API/Supplier");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(result);

             
                suppliercomboBox1.DataSource = new BindingSource(suppliers, null);
                suppliercomboBox1.DisplayMember = "SupplierName"; 
                suppliercomboBox1.ValueMember = "Id"; 

                suppliercomboBox2.DataSource = new BindingSource(suppliers, null);
                suppliercomboBox2.DisplayMember = "SupplierName";
                suppliercomboBox2.ValueMember = "Id"; 

               
                if (suppliers.Count > 0)
                {
                    suppliercomboBox1.SelectedIndex = 0;
                    await LoadProductsForSupplier((int)suppliercomboBox1.SelectedValue, dataGridView1);
                }

                if (suppliers.Count > 1)
                {
                    suppliercomboBox2.SelectedIndex = 1;
                    await LoadProductsForSupplier((int)suppliercomboBox2.SelectedValue, dataGridView2);
                }
            }
            else
            {
                MessageBox.Show("Error loading suppliers.");
            }
        }

     
        private async Task LoadProductsForSupplier(int supplierId, DataGridView dataGridView)
        {
            var response = await _client.GetAsync($"https://localhost:7070/TechFix_API/SupplierProducts/GetProductsBySupplier/{supplierId}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<List<Product>>(result);
                dataGridView.DataSource = products; 
            }
            else
            {
                MessageBox.Show("Error loading products.");
            }
        }

        private async void suppliercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppliercomboBox1.SelectedValue is int selectedSupplierId)
            {
                await LoadProductsForSupplier(selectedSupplierId, dataGridView1); 
            }
        }

        private async void suppliercomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppliercomboBox2.SelectedValue is int selectedSupplierId)
            {
                await LoadProductsForSupplier(selectedSupplierId, dataGridView2); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();

            mForm.Show();

            this.Hide();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
