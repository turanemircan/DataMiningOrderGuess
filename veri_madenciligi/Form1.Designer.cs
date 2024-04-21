namespace veri_madenciligi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            radioButtonU1 = new RadioButton();
            radioButtonU2 = new RadioButton();
            radioButtonU3 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBoxSprsName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSiparisVer = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            buttonGecikme = new Button();
            buttonSprsTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(720, 370);
            dataGridView1.TabIndex = 0;
            // 
            // radioButtonU1
            // 
            radioButtonU1.AutoSize = true;
            radioButtonU1.Location = new Point(753, 27);
            radioButtonU1.Name = "radioButtonU1";
            radioButtonU1.Size = new Size(60, 19);
            radioButtonU1.TabIndex = 1;
            radioButtonU1.TabStop = true;
            radioButtonU1.Text = "Ürün 1";
            radioButtonU1.UseVisualStyleBackColor = true;
            // 
            // radioButtonU2
            // 
            radioButtonU2.AutoSize = true;
            radioButtonU2.Location = new Point(753, 52);
            radioButtonU2.Name = "radioButtonU2";
            radioButtonU2.Size = new Size(60, 19);
            radioButtonU2.TabIndex = 2;
            radioButtonU2.TabStop = true;
            radioButtonU2.Text = "Ürün 2";
            radioButtonU2.UseVisualStyleBackColor = true;
            // 
            // radioButtonU3
            // 
            radioButtonU3.AutoSize = true;
            radioButtonU3.Location = new Point(753, 77);
            radioButtonU3.Name = "radioButtonU3";
            radioButtonU3.Size = new Size(60, 19);
            radioButtonU3.TabIndex = 3;
            radioButtonU3.TabStop = true;
            radioButtonU3.Text = "Ürün 3";
            radioButtonU3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(753, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBoxSprsName
            // 
            textBoxSprsName.Location = new Point(753, 195);
            textBoxSprsName.Name = "textBoxSprsName";
            textBoxSprsName.Size = new Size(200, 23);
            textBoxSprsName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(753, 177);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Sipariş Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(753, 118);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Sipariş Teslim Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(753, 9);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "Ürünler";
            // 
            // buttonSiparisVer
            // 
            buttonSiparisVer.Location = new Point(753, 237);
            buttonSiparisVer.Name = "buttonSiparisVer";
            buttonSiparisVer.Size = new Size(88, 45);
            buttonSiparisVer.TabIndex = 9;
            buttonSiparisVer.Text = "Sipariş Ver";
            buttonSiparisVer.UseVisualStyleBackColor = true;
            buttonSiparisVer.Click += buttonSiparisVer_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(750, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(753, 293);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 11;
            label4.Text = "Siparis Durumu";
            // 
            // buttonGecikme
            // 
            buttonGecikme.Location = new Point(862, 237);
            buttonGecikme.Name = "buttonGecikme";
            buttonGecikme.Size = new Size(88, 45);
            buttonGecikme.TabIndex = 12;
            buttonGecikme.Text = "Gecikme Kontrol";
            buttonGecikme.UseVisualStyleBackColor = true;
            buttonGecikme.Click += buttonGecikme_Click;
            // 
            // buttonSprsTamamla
            // 
            buttonSprsTamamla.Location = new Point(750, 337);
            buttonSprsTamamla.Name = "buttonSprsTamamla";
            buttonSprsTamamla.Size = new Size(200, 45);
            buttonSprsTamamla.TabIndex = 13;
            buttonSprsTamamla.Text = "Sipariş Tamamlandı";
            buttonSprsTamamla.UseVisualStyleBackColor = true;
            buttonSprsTamamla.Click += buttonSprsTamamla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 388);
            Controls.Add(buttonSprsTamamla);
            Controls.Add(buttonGecikme);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(buttonSiparisVer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSprsName);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButtonU3);
            Controls.Add(radioButtonU2);
            Controls.Add(radioButtonU1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton radioButtonU1;
        private RadioButton radioButtonU2;
        private RadioButton radioButtonU3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxSprsName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSiparisVer;
        private TextBox textBox1;
        private Label label4;
        private Button buttonGecikme;
        private Button buttonSprsTamamla;
    }
}
