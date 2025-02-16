namespace Techfix_App
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            suppliercomboBox1 = new ComboBox();
            suppliercomboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // suppliercomboBox1
            // 
            suppliercomboBox1.FormattingEnabled = true;
            suppliercomboBox1.Location = new Point(93, 130);
            suppliercomboBox1.Name = "suppliercomboBox1";
            suppliercomboBox1.Size = new Size(343, 23);
            suppliercomboBox1.TabIndex = 0;
            suppliercomboBox1.SelectedIndexChanged += suppliercomboBox1_SelectedIndexChanged;
            // 
            // suppliercomboBox2
            // 
            suppliercomboBox2.FormattingEnabled = true;
            suppliercomboBox2.Location = new Point(628, 130);
            suppliercomboBox2.Name = "suppliercomboBox2";
            suppliercomboBox2.Size = new Size(329, 23);
            suppliercomboBox2.TabIndex = 1;
            suppliercomboBox2.SelectedIndexChanged += suppliercomboBox2_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 246);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(582, 169);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(538, 246);
            dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 31);
            label1.Name = "label1";
            label1.Size = new Size(220, 41);
            label1.TabIndex = 6;
            label1.Text = "Inventory";
            // 
            // button1
            // 
            button1.Location = new Point(1076, 12);
            button1.Name = "button1";
            button1.Size = new Size(44, 34);
            button1.TabIndex = 7;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1132, 467);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(suppliercomboBox2);
            Controls.Add(suppliercomboBox1);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox suppliercomboBox1;
        private ComboBox suppliercomboBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}