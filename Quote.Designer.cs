namespace Techfix_App
{
    partial class Quote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quote));
            suppliercomboBox1 = new ComboBox();
            productcomboBox2 = new ComboBox();
            QuntitytextBox1 = new TextBox();
            quoteBtn = new Button();
            quotedataGridView1 = new DataGridView();
            supplier = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)quotedataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // suppliercomboBox1
            // 
            suppliercomboBox1.FormattingEnabled = true;
            suppliercomboBox1.Location = new Point(135, 181);
            suppliercomboBox1.Name = "suppliercomboBox1";
            suppliercomboBox1.Size = new Size(228, 23);
            suppliercomboBox1.TabIndex = 0;
            suppliercomboBox1.SelectedIndexChanged += suppliercomboBox1_SelectedIndexChanged;
            // 
            // productcomboBox2
            // 
            productcomboBox2.FormattingEnabled = true;
            productcomboBox2.Location = new Point(135, 224);
            productcomboBox2.Name = "productcomboBox2";
            productcomboBox2.Size = new Size(228, 23);
            productcomboBox2.TabIndex = 1;
            // 
            // QuntitytextBox1
            // 
            QuntitytextBox1.Location = new Point(135, 268);
            QuntitytextBox1.Name = "QuntitytextBox1";
            QuntitytextBox1.Size = new Size(228, 23);
            QuntitytextBox1.TabIndex = 2;
            // 
            // quoteBtn
            // 
            quoteBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quoteBtn.Location = new Point(177, 331);
            quoteBtn.Name = "quoteBtn";
            quoteBtn.Size = new Size(116, 39);
            quoteBtn.TabIndex = 3;
            quoteBtn.Text = "Get Quote";
            quoteBtn.UseVisualStyleBackColor = true;
            quoteBtn.Click += quoteBtn_Click;
            // 
            // quotedataGridView1
            // 
            quotedataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quotedataGridView1.Location = new Point(453, 103);
            quotedataGridView1.Name = "quotedataGridView1";
            quotedataGridView1.Size = new Size(441, 316);
            quotedataGridView1.TabIndex = 4;
            quotedataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // supplier
            // 
            supplier.AutoSize = true;
            supplier.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplier.Location = new Point(25, 179);
            supplier.Name = "supplier";
            supplier.Size = new Size(80, 22);
            supplier.TabIndex = 5;
            supplier.Text = "supplier:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 224);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 6;
            label2.Text = "product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 269);
            label3.Name = "label3";
            label3.Size = new Size(86, 22);
            label3.TabIndex = 7;
            label3.Text = "Quantity:";
            // 
            // button1
            // 
            button1.Location = new Point(860, 26);
            button1.Name = "button1";
            button1.Size = new Size(43, 32);
            button1.TabIndex = 8;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 11;
            label1.Text = "Quote";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Quote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(936, 539);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(supplier);
            Controls.Add(quotedataGridView1);
            Controls.Add(quoteBtn);
            Controls.Add(QuntitytextBox1);
            Controls.Add(productcomboBox2);
            Controls.Add(suppliercomboBox1);
            Name = "Quote";
            Text = "Quote";
            ((System.ComponentModel.ISupportInitialize)quotedataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox suppliercomboBox1;
        private ComboBox productcomboBox2;
        private TextBox QuntitytextBox1;
        private Button quoteBtn;
        private DataGridView quotedataGridView1;
        private Label supplier;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}