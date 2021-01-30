using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Recognition;
using Artificial_intelligence.Forms;

namespace Artificial_intelligence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ProductList()
        {
            var products = db.TBLPRODUCTs.ToList();
            dataGridView1.DataSource = products;
        }

        public void enabled()
        {
            TxtBuyPrice.Enabled = false;
            TxtName.Enabled = false;
            TxtMark.Enabled = false;
            TxtCategory.Enabled = false;
            TxtSellPrice.Enabled = false;
            TxtStock.Enabled = false;
            CmbCase.Enabled = false;
            MskDate.Enabled = false;

        }

        public void colorMethod()
        {
            TxtBuyPrice.BackColor = Color.White;
            TxtName.BackColor = Color.White;
            TxtMark.BackColor = Color.White;
            TxtCategory.BackColor = Color.White;
            TxtSellPrice.BackColor = Color.White;
            TxtStock.BackColor = Color.White;
            CmbCase.BackColor = Color.White;
            MskDate.BackColor = Color.White;
        }

        DbProductArtEntities db = new DbProductArtEntities();

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                BtnSpeak.Text = "Please Speak";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                richTextBox1.Text = res.Text;
                
            }
            catch (Exception)
            {

                BtnSpeak.Text = "try again";
            }

        }

        private void BtnListen_Click(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(richTextBox1.Text);

        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (TxtName.BackColor == Color.Yellow || TxtName.Enabled == true)
            {
                TxtName.Text = richTextBox1.Text;
                enabled();
                colorMethod();
            }

            if (TxtMark.BackColor == Color.Yellow && TxtMark.Enabled == true)
            {
                TxtMark.Text = richTextBox1.Text;
                enabled();
                colorMethod();
            }

            if (TxtStock.BackColor == Color.Yellow && TxtStock.Enabled == true)
            {
                TxtStock.Text = richTextBox1.Text;
                enabled();
                colorMethod();
            }

            if (TxtBuyPrice.BackColor == Color.Yellow && TxtBuyPrice.Enabled == true)
            {
                TxtBuyPrice.Text = richTextBox1.Text;
                enabled();
                colorMethod();
            }

            if (TxtSellPrice.BackColor == Color.Yellow && TxtSellPrice.Enabled == true)
            {
                TxtSellPrice.Text = richTextBox1.Text;
                enabled();
                colorMethod();
            }

            if (TxtCategory.BackColor == Color.Yellow && TxtCategory.Enabled == true)
            {
                TxtCategory.Text = richTextBox1.Text;
                enabled();
                colorMethod();
            }

            if (MskDate.BackColor == Color.Yellow && MskDate.Enabled == true)
            {

                enabled();
                colorMethod();
            }

            if (CmbCase.BackColor == Color.Yellow && CmbCase.Enabled == true)
            {
                CmbCase.Text = "Active";
                enabled();
                colorMethod();
            }





            if (richTextBox1.Text == "Products list" || richTextBox1.Text == "Least")
            {
                ProductList();
            }

            if(richTextBox1.Text == "Add" || richTextBox1.Text == "Add to" || richTextBox1.Text == "Add the")
            {
                TBLPRODUCT t = new TBLPRODUCT();
                t.NAME = TxtName.Text;
                t.BRAND = TxtMark.Text;
                t.SELLPRICE = decimal.Parse(TxtSellPrice.Text);
                t.BUYPRICE = decimal.Parse(TxtBuyPrice.Text);
                t.STOCK = short.Parse(TxtStock.Text);
                t.PRODUCTCASE = true;
                t.DATEADDPRO = DateTime.Parse(MskDate.Text);
                t.CATEGORY = TxtCategory.Text;

                db.TBLPRODUCTs.Add(t);
                db.SaveChanges();
                label10.Text = "Products saved in database";
            }


            if(richTextBox1.Text == "Paint")
            {
                System.Diagnostics.Process.Start("MsPaint");
            }

            if (richTextBox1.Text == "Name" || richTextBox1.Text == "The name" || richTextBox1.Text == "Main")
            {
                TxtName.Focus();
                TxtName.BackColor = Color.Yellow;
                TxtName.Enabled = true;
            }

            if (richTextBox1.Text == "Mark" || richTextBox1.Text == "Brand")
            {
                TxtMark.Focus();
                TxtMark.BackColor = Color.Yellow;
                TxtMark.Enabled = true;
            }

            if (richTextBox1.Text == "Stock" || richTextBox1.Text == "Stocks" || richTextBox1.Text == "Stack")
            {
                TxtStock.Focus();
                TxtStock.BackColor = Color.Yellow;
                TxtStock.Enabled = true;
            }

            if (richTextBox1.Text == "By price" || richTextBox1.Text == "Buying price" || richTextBox1.Text == "By a prize" || richTextBox1.Text == "By")
            {
                TxtBuyPrice.Focus();
                TxtBuyPrice.BackColor = Color.Yellow;
                TxtBuyPrice.Enabled = true;
            }



            if (richTextBox1.Text == "Sell price" || richTextBox1.Text == "Sales")
            {
                TxtSellPrice.Focus();
                TxtSellPrice.BackColor = Color.Yellow;
                TxtSellPrice.Enabled = true;
            }



            if (richTextBox1.Text == "Category" || richTextBox1.Text == "Cut the glory")
            {
                TxtCategory.Focus();
                TxtCategory.BackColor = Color.Yellow;
                TxtCategory.Enabled = true;
            }

            if (richTextBox1.Text == "Date" || richTextBox1.Text == "State" || richTextBox1.Text == "Dates" || richTextBox1.Text == "Eight")
            {
                MskDate.Focus();
                MskDate.BackColor = Color.Yellow;
                MskDate.Enabled = true;
            }

            if (richTextBox1.Text == "State" || richTextBox1.Text == "Chase" || richTextBox1.Text == "Case" || richTextBox1.Text == "States")
            {
                CmbCase.Focus();
                CmbCase.BackColor = Color.Yellow;
                CmbCase.Enabled = true;
            }

            if (richTextBox1.Text == "Exit")
            {
                timer1.Stop();
                Application.Exit();
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enabled();
            colorMethod();
            //timer1.Start();
        }

        private void MskDate_BackColorChanged(object sender, EventArgs e)
        {
            if(MskDate.BackColor == Color.Yellow)
            {
                MskDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        private void CmbCase_BackColorChanged(object sender, EventArgs e)
        {
            if (CmbCase.BackColor == Color.Yellow)
            {
                CmbCase.Text = "Active";
            }

        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(label10.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);
            try
            {
                BtnSpeak.Text = "Please Speak";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                richTextBox1.Text = res.Text;

            }
            catch (Exception)
            {

                BtnSpeak.Text = "try again";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.FrmObjDet fr = new Forms.FrmObjDet();
            fr.Show();

        }
    }
}


