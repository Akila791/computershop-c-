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

namespace Techfix_App
{
    public partial class Report : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<Order> orders;
        public Report()
        {
            InitializeComponent();
            LoadOrders();
        }

        private async Task LoadOrders()
        {
            var response = await _client.GetAsync("https://localhost:7070/TechFix_API/Reports/GetAllOrders");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                orders = JsonConvert.DeserializeObject<List<Order>>(result); 
                OrderdataGridView1.DataSource = orders; 
            }
            else
            {
                MessageBox.Show("Error loading orders.");
            }
        }

        private void OrderidtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void CompletOrderbutton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(OrderidtextBox1.Text.Trim(), out int orderId))
            {
                var response = await _client.PostAsJsonAsync("https://localhost:7070/TechFix_API/Reports/CompleteOrder", new { OrderId = orderId });
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order status updated to 'Completed'.");
                    await LoadOrders(); 
                }
                else
                {
                    MessageBox.Show("Error completing the order.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Order ID.");
            }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public int QuoteId { get; set; }
            public string ProductName { get; set; }
            public string SupplierName { get; set; }
            public int OrderedQuantity { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime OrderDate { get; set; }
            public string Status { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();

            mForm.Show();

            this.Hide();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
