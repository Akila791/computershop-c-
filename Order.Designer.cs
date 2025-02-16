namespace Techfix_App
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            buttonPlaceOrder = new Button();
            label3 = new Label();
            dataGridViewOrder = new DataGridView();
            textBoxQuoteId = new TextBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlaceOrder.Location = new Point(124, 306);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(120, 35);
            buttonPlaceOrder.TabIndex = 5;
            buttonPlaceOrder.Text = "Place Order";
            buttonPlaceOrder.UseVisualStyleBackColor = true;
            buttonPlaceOrder.Click += buttonPlaceOrder_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 238);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 6;
            label3.Text = "Quote ID:";
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(404, 119);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.Size = new Size(373, 302);
            dataGridViewOrder.TabIndex = 7;
            // 
            // textBoxQuoteId
            // 
            textBoxQuoteId.Location = new Point(151, 237);
            textBoxQuoteId.Name = "textBoxQuoteId";
            textBoxQuoteId.Size = new Size(200, 23);
            textBoxQuoteId.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(746, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 35);
            button1.TabIndex = 9;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 31);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 10;
            label1.Text = "Order";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxQuoteId);
            Controls.Add(dataGridViewOrder);
            Controls.Add(label3);
            Controls.Add(buttonPlaceOrder);
            Name = "Order";
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxSupplier;
        private ComboBox comboBoxProduct;
        private TextBox textBoxQuantity;
        private Button buttonPlaceOrder;
        private Label label3;
        private DataGridView dataGridViewOrder;
        private TextBox textBoxQuoteId;
        private Button button1;
        private PictureBox pictureBox1;
    }
}