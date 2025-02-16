namespace Techfix_App
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            OrderdataGridView1 = new DataGridView();
            OrderidtextBox1 = new TextBox();
            CompletOrderbutton1 = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OrderdataGridView1
            // 
            OrderdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderdataGridView1.Location = new Point(373, 118);
            OrderdataGridView1.Name = "OrderdataGridView1";
            OrderdataGridView1.Size = new Size(415, 320);
            OrderdataGridView1.TabIndex = 0;
            // 
            // OrderidtextBox1
            // 
            OrderidtextBox1.Location = new Point(142, 236);
            OrderidtextBox1.Name = "OrderidtextBox1";
            OrderidtextBox1.Size = new Size(190, 23);
            OrderidtextBox1.TabIndex = 1;
            OrderidtextBox1.TextChanged += OrderidtextBox1_TextChanged;
            // 
            // CompletOrderbutton1
            // 
            CompletOrderbutton1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompletOrderbutton1.Location = new Point(165, 286);
            CompletOrderbutton1.Name = "CompletOrderbutton1";
            CompletOrderbutton1.Size = new Size(127, 57);
            CompletOrderbutton1.TabIndex = 2;
            CompletOrderbutton1.Text = "Order Complet";
            CompletOrderbutton1.UseVisualStyleBackColor = true;
            CompletOrderbutton1.Click += CompletOrderbutton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 236);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 3;
            label1.Text = "Order id:";
            // 
            // button1
            // 
            button1.Location = new Point(747, 12);
            button1.Name = "button1";
            button1.Size = new Size(41, 27);
            button1.TabIndex = 4;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 12);
            label2.Name = "label2";
            label2.Size = new Size(161, 41);
            label2.TabIndex = 11;
            label2.Text = "REPORT";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CompletOrderbutton1);
            Controls.Add(OrderidtextBox1);
            Controls.Add(OrderdataGridView1);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)OrderdataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderdataGridView1;
        private TextBox OrderidtextBox1;
        private Button CompletOrderbutton1;
        private Label label1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}