namespace Artificial_intelligence
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbCase = new System.Windows.Forms.ComboBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBuyPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSpeak = new System.Windows.Forms.Button();
            this.BtnListen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnProductAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CmbCase);
            this.panel1.Controls.Add(this.MskDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtSellPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtBuyPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtStock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtMark);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 496);
            this.panel1.TabIndex = 0;
            // 
            // CmbCase
            // 
            this.CmbCase.FormattingEnabled = true;
            this.CmbCase.Items.AddRange(new object[] {
            "Active",
            "Pasive"});
            this.CmbCase.Location = new System.Drawing.Point(90, 275);
            this.CmbCase.Name = "CmbCase";
            this.CmbCase.Size = new System.Drawing.Size(154, 26);
            this.CmbCase.TabIndex = 18;
            this.CmbCase.BackColorChanged += new System.EventHandler(this.CmbCase_BackColorChanged);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(90, 245);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(154, 24);
            this.MskDate.TabIndex = 17;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            this.MskDate.BackColorChanged += new System.EventHandler(this.MskDate_BackColorChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "case:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "date:";
            // 
            // TxtCategory
            // 
            this.TxtCategory.Location = new System.Drawing.Point(90, 215);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(154, 24);
            this.TxtCategory.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "category:";
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(90, 185);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(154, 24);
            this.TxtSellPrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "sell price:";
            // 
            // TxtBuyPrice
            // 
            this.TxtBuyPrice.Location = new System.Drawing.Point(90, 155);
            this.TxtBuyPrice.Name = "TxtBuyPrice";
            this.TxtBuyPrice.Size = new System.Drawing.Size(154, 24);
            this.TxtBuyPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "buy price:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(90, 125);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(154, 24);
            this.TxtStock.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "stock:";
            // 
            // TxtMark
            // 
            this.TxtMark.Location = new System.Drawing.Point(90, 95);
            this.TxtMark.Name = "TxtMark";
            this.TxtMark.Size = new System.Drawing.Size(154, 24);
            this.TxtMark.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "brand:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(90, 65);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(154, 24);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSpeak);
            this.panel2.Controls.Add(this.BtnListen);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BtnProductAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 100);
            this.panel2.TabIndex = 1;
            // 
            // BtnSpeak
            // 
            this.BtnSpeak.BackColor = System.Drawing.Color.Bisque;
            this.BtnSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSpeak.Location = new System.Drawing.Point(552, 22);
            this.BtnSpeak.Name = "BtnSpeak";
            this.BtnSpeak.Size = new System.Drawing.Size(119, 54);
            this.BtnSpeak.TabIndex = 4;
            this.BtnSpeak.Text = "speak";
            this.BtnSpeak.UseVisualStyleBackColor = false;
            this.BtnSpeak.Click += new System.EventHandler(this.BtnSpeak_Click);
            // 
            // BtnListen
            // 
            this.BtnListen.BackColor = System.Drawing.Color.Bisque;
            this.BtnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListen.Location = new System.Drawing.Point(677, 22);
            this.BtnListen.Name = "BtnListen";
            this.BtnListen.Size = new System.Drawing.Size(135, 54);
            this.BtnListen.TabIndex = 3;
            this.BtnListen.Text = "listen";
            this.BtnListen.UseVisualStyleBackColor = false;
            this.BtnListen.Click += new System.EventHandler(this.BtnListen_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Bisque;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(411, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "object detection";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(280, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "image";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(155, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "camera feel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnProductAdd
            // 
            this.BtnProductAdd.BackColor = System.Drawing.Color.Bisque;
            this.BtnProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnProductAdd.Location = new System.Drawing.Point(14, 22);
            this.BtnProductAdd.Name = "BtnProductAdd";
            this.BtnProductAdd.Size = new System.Drawing.Size(135, 54);
            this.BtnProductAdd.TabIndex = 0;
            this.BtnProductAdd.Text = "product add";
            this.BtnProductAdd.UseVisualStyleBackColor = false;
            this.BtnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(258, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(839, 151);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(258, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 100);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(258, 251);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 148);
            this.panel4.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Please Wait...";
            this.label10.TextChanged += new System.EventHandler(this.label10_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 148);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 496);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbCase;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBuyPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnListen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnProductAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnSpeak;
        private System.Windows.Forms.Timer timer1;
    }
}

