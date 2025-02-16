using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.ComponentModel.DataAnnotations;
using static Techfix_App.Models;


namespace Techfix_App
{
    public partial class Order : Form
    {
        private readonly HttpClient _client = new HttpClient();

        public Order()
        {
            InitializeComponent();
            LoadQuotes();
        }


        private async Task LoadQuotes()
        {
            var response = await _client.GetAsync("https://localhost:7070/TechFix_API/Quotes/GetAllQuotes");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var Quotes = JsonConvert.DeserializeObject<List<Quote>>(result);
                dataGridViewOrder.DataSource = Quotes; 
            }
        }

        public class Quote
        {
            public int QuoteId { get; set; }
            public string SupplierName { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal PricePerUnit { get; set; }
            public decimal TotalPrice { get; set; }
            public string Status { get; set; }
        }

        private async void buttonPlaceOrder_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxQuoteId.Text, out int quoteId)) 
            {
                var response = await _client.PostAsJsonAsync("https://localhost:7070/TechFix_API/Orders/PlaceOrder", new { QuoteId = quoteId });
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Order placed successfully.");
                    await LoadQuotes(); 
                }
                else
                {
                    MessageBox.Show("Error placing the order. Please check the Quote ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Quote ID.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();

            
            mForm.Show();

            
            this.Hide();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
    
