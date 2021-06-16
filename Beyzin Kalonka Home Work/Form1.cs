using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beyzin_Kalonka_Home_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(250,188,60);
            comboBox1.BackColor = Color.FromArgb(255,178,56);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Name";
            List<Petrol> petrols = new List<Petrol>
            {
                new Petrol
                {
                    Name="AI-92",
                    Price=1.00
                },
                new Petrol
                {
                    Name = "AI-93",
                    Price = 1.05
                },
                new Petrol
                {
                    Name = "AI-95(Premium)",
                    Price = 1.20
                },
                new Petrol
                {
                    Name = "AI-98(Super)",
                    Price = 1.50
                }
            };
            comboBox1.DataSource = petrols;

            Cafe Hot_dog = new Cafe
            {
                Name = "Hot Dog",
                Price = 1.89
            };

            Cafe Ramen = new Cafe
            {
                Name = "Ramen",
                Price = 3.69
            };

            Cafe Sushi = new Cafe
            {
                Name = "Sushi",
                Price = 5.20
            };

            Cafe Burger = new Cafe
            {
                Name = "Burger",
                Price = 2.00
            };

            Cafe Fried_potato = new Cafe
            {
                Name = "Fried Potato",
                Price = 2.90
            };

            Cafe Pizza = new Cafe
            {
                Name = "Pizza",
                Price = 12.49
            };

            Cafe Pasta = new Cafe
            {
                Name = "Pasta",
                Price = 6.25
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var petrol = comboBox1.SelectedItem as Petrol;
            Amount.Text = petrol.Price.ToString();
        }

        private void Numeric_Hot_Dog_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Liter_txt_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var petrol = comboBox1.SelectedItem as Petrol;
                var litertext = double.Parse(Liter_txt_box.Text) * petrol.Price;
                Cash_txt_box.Text = litertext.ToString();

            }
            catch (Exception)
            {

                
            }

        }

        private void Cash_txt_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var petrol = comboBox1.SelectedItem as Petrol;
                var cashtext = double.Parse(Cash_txt_box.Text) / petrol.Price;
                Liter_txt_box.Text = cashtext.ToString();
            }
            catch (Exception)
            {
            }
            Total_Petrol_Price.Text = Cash_txt_box.Text;
        }

        private void Liter_radio_Click_1(object sender, EventArgs e)
        {
            if (Liter_radio.Checked)
            {
                Liter_txt_box.ReadOnly = false;
                Cash_txt_box.ReadOnly = true;
            }
        }

        private void Cash_radio_Click(object sender, EventArgs e)
        {
            if (Cash_radio.Checked)
            {
                Liter_txt_box.ReadOnly = true;
                Cash_txt_box.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var TotalResult = (double.Parse(Hot_Dog_price.Text)* double.Parse(Hotdog_txt_box.Text)) + (double.Parse(Ramen_price.Text) * double.Parse(Ramen_txt_box.Text)) + (double.Parse(Pizza_price.Text) * double.Parse(Pizza_txt_box.Text)) + (double.Parse(Pasta_price.Text) * double.Parse(Pasta_txt_box.Text)) + (double.Parse(Sushi_price.Text) * double.Parse(Sushi_txt_box.Text)) + (double.Parse(Fried_Potato_price.Text) * double.Parse(Fried_txt_box.Text)) + (double.Parse(Burger_price.Text) * double.Parse(Burger_txt_box.Text));
            Meals_price.Text = TotalResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = double.Parse(Meals_price.Text) + double.Parse(Total_Petrol_Price.Text);
            Total.Text = result.ToString();
        }
    }
}
