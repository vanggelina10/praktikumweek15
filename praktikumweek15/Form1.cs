using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumweek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelSize.Visible = false;
            radioBtnNormal.Visible = false;
            radioBtnJumbo.Visible = false;
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (listBoxHarga.Text == "" && listBoxMenu.Text == "")
            {
                MessageBox.Show("Choose Menu!");
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (radioBtnMakanan.Checked == true)
            {
                switch (comboBoxMenu.SelectedIndex)
                {
                    case 0:
                        listBoxMenu.Items.Add("Nasi Goreng");
                        break;
                    case 1:
                        listBoxMenu.Items.Add("Nasi Goreng Spesial");
                        break;
                    case 2:
                        listBoxMenu.Items.Add("Nasi Goreng Pete");
                        break;
                    case 3:
                        listBoxMenu.Items.Add("Ayam Bakar");
                        break;
                }
            }
            else if (radioBtnMinuman.Checked == true)
            {
                switch (comboBoxMenu.SelectedIndex)
                {
                    case 0:
                        listBoxMenu.Items.Add("Es Teh");
                        break;
                    case 1:
                        listBoxMenu.Items.Add("Teh Hangat");
                        break;
                    case 2:
                        listBoxMenu.Items.Add("Nutrisari");
                        break;
                    case 3:
                        listBoxMenu.Items.Add("Aqua");
                        break;
                }

            }
            listBoxHarga.Items.Add(labelHarga.Text);
        }

        private void radioBtnMinuman_CheckedChanged(object sender, EventArgs e)
        {
            labelSize.Visible = true;
            radioBtnNormal.Visible = true;
            radioBtnJumbo.Visible = true;
            if (radioBtnMinuman.Checked == true)
            {
                comboBoxMenu.Items.Clear();
                comboBoxMenu.Items.Add("Es Teh");
                comboBoxMenu.Items.Add("Teh Hangat");
                comboBoxMenu.Items.Add("Nutrisari");
                comboBoxMenu.Items.Add("Aqua");
            }
        }

        private void radioBtnMakanan_CheckedChanged(object sender, EventArgs e)
        {
            labelSize.Visible = false;
            radioBtnNormal.Visible = false;
            radioBtnJumbo.Visible = false;
            if (radioBtnMakanan.Checked == true)
            {
                comboBoxMenu.Items.Clear();
                comboBoxMenu.Items.Add("Nasi Goreng");
                comboBoxMenu.Items.Add("Nasi Goreng Spesial");
                comboBoxMenu.Items.Add("Nasi Goreng Pete");
                comboBoxMenu.Items.Add("Ayam Bakar");
            }

        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelHarga.Text = "10000";
            }
            else if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng Spesial")
            {
                labelHarga.Text = "12000";

            }
            else if (comboBoxMenu.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                labelHarga.Text = "15000";

            }
            else if (comboBoxMenu.SelectedItem.ToString() == "Es Teh")
            {
                if (radioBtnNormal.Checked == true)
                {
                    labelHarga.Text = "3000";
                }
                else if (radioBtnJumbo.Checked == true)
                {
                    labelHarga.Text = "5000";
                }
            }
            else if (comboBoxMenu.SelectedItem.ToString() == "Teh Hangat")
            {
                if (radioBtnNormal.Checked == true)
                {
                    labelHarga.Text = "3000";
                }
                else if (radioBtnJumbo.Checked == true)
                {
                    labelHarga.Text = "5000";
                }
            }
            else if (comboBoxMenu.SelectedItem.ToString() == "Nutrisari")
            {
                if (radioBtnNormal.Checked == true)
                {
                    labelHarga.Text = "6000";
                }
                else if (radioBtnJumbo.Checked == true)
                {
                    labelHarga.Text = "10000";
                }
            }
            else if (comboBoxMenu.SelectedItem.ToString() == "Aqua")
            {
                if (radioBtnNormal.Checked == true)
                {
                    labelHarga.Text = "2000";
                }
                else if (radioBtnJumbo.Checked == true)
                {
                    labelHarga.Text = "5000";
                }
            }
        }
    }
}
