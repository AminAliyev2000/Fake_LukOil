using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_LukOil
{
    public partial class Form1 : Form
    {
        class Oil
        {
            public string Octane { get; set; }
            public double Price { get; set; }
        }

        decimal oilcount = 0;
        decimal cafecount = 0;
        decimal hamburgercount = 0;
        decimal colacount = 0;
        decimal friescount = 0;
        decimal kindercount = 0;
        public Form1()
        {
            InitializeComponent();
            OilComboBox1.DisplayMember = "Octane";
            OilComboBox1.Items.Add(new Oil
            {
                Octane = "Diesel",
                Price = 0.80
            });
            OilComboBox1.Items.Add(new Oil
            {
                Octane = "AI-92",
                Price = 1
            });
            OilComboBox1.Items.Add(new Oil
            {
                Octane = "AI-95",
                Price = 1.50
            });

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void OilComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            OilpriceHtmlLabel1.Text = ((OilComboBox1.SelectedItem as Oil)?.Price).ToString();
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton1.Checked)
            {
                LitresNumericUpDown1.Enabled = true;
                YourAmountNumericUpDown2.Enabled = false;
            }
            else
            {
                LitresNumericUpDown1.Enabled = false;
            }
        }

        private void LitresNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            oilcount = LitresNumericUpDown1.Value * Decimal.Parse(OilpriceHtmlLabel1.Text);
            TotalOilHtmlLabel1.Text = oilcount.ToString();
            TotalCheckHtmlLabel1.Text = (oilcount + cafecount).ToString();

        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton3.Checked)
            {
                LitresNumericUpDown1.Enabled = false;
                YourAmountNumericUpDown2.Enabled = true;
            }
            else
            {
                YourAmountNumericUpDown2.Enabled = false;
            }
        }

        private void YourAmountNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            oilcount = YourAmountNumericUpDown2.Value;
            TotalOilHtmlLabel1.Text = oilcount.ToString();
            TotalCheckHtmlLabel1.Text = (oilcount + cafecount).ToString();

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                hamburgernudown.Enabled = true;
            }
            else
            {
                hamburgernudown.Enabled = false;
                hamburgercount = hamburgernudown.Value * Decimal.Parse(hamburgerTextBox1.Text);
                cafecount += hamburgercount;
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                hamburgernudown.Value = 0;
            }
        }

        private void hamburgernudown_ValueChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                cafecount += Decimal.Parse(hamburgerTextBox1.Text);
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                TotalCheckHtmlLabel1.Text = (oilcount + cafecount).ToString();
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                ColaNumericUpDown4.Enabled = true;
            }
            else
            {
                ColaNumericUpDown4.Enabled = false;
                colacount = ColaNumericUpDown4.Value * Decimal.Parse(ColaTextBox2.Text);
                cafecount -= colacount;
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                ColaNumericUpDown4.Value = 0;
            }
        }

        private void ColaNumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                cafecount += Decimal.Parse(ColaTextBox2.Text);
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                TotalCheckHtmlLabel1.Text = (oilcount + cafecount).ToString();
            }
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox3.Checked)
            {
                FriesNumericUpDown5.Enabled = true;
            }
            else
            {
                FriesNumericUpDown5.Enabled = false;
                friescount = FriesNumericUpDown5.Value * Decimal.Parse(friesTextBox3.Text);
                cafecount -= colacount;
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                FriesNumericUpDown5.Value = 0;
            }
        }

        private void FriesNumericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox3.Checked)
            {
                cafecount += Decimal.Parse(friesTextBox3.Text);
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                TotalCheckHtmlLabel1.Text = (oilcount + cafecount).ToString();
            }
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox4.Checked)
            {
                kinderNumericUpDown6.Enabled = true;
            }
            else
            {
                kinderNumericUpDown6.Enabled = false;
                kindercount = kinderNumericUpDown6.Value * Decimal.Parse(kinderNumericUpDown6.Text);
                cafecount -= colacount;
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                kinderNumericUpDown6.Value = 0;
            }
        }

        private void kinderNumericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox4.Checked)
            {
                cafecount += Decimal.Parse(KinderTextBox4.Text);
                TotalCafeHtmlLabel1.Text = cafecount.ToString();
                TotalCheckHtmlLabel1.Text = (oilcount + cafecount).ToString();
            }
        }
    }
}
