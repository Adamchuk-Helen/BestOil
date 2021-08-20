using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();


            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSumOil_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Oil> oil = new List<Oil>();

            oil.Add(new Oil() { type = "A 95", price = 33.5 });
            oil.Add(new Oil() { type = "A 92", price = 30.5 });
            oil.Add(new Oil() { type = "Disel", price = 18 });
            oil.Add(new Oil() { type = "Gaz", price = 25 });
            var cb = comboBoxOil.SelectedItem;
            
            foreach (Oil o in oil)
            {

                if (cb == o.type)
                {
                    tbPrice.Text = Convert.ToString(o.price);
                }
            }

            double sum;

            if (tbQuantityOil.Text != "")
            {
                string stQuant = tbQuantityOil.Text;
                string stPrice = tbPrice.Text;
                sum = Convert.ToDouble(stQuant) * Convert.ToDouble(stPrice);
                lbSumOil.Text = Convert.ToString(sum);
            }
            else
            {
                lbSumOil.Text = "00.00";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double sum;
            
            if (tbQuantityOil.Text != "")
            {
                string stQuant = tbQuantityOil.Text;
                string stPrice = tbPrice.Text;
                sum = Convert.ToDouble(stQuant) * Convert.ToDouble(stPrice);
                lbSumOil.Text = Convert.ToString(sum);
            }
            else 
            {
                lbSumOil.Text = "00.00";
            }
        }

        private void lbHamburg_Click(object sender, EventArgs e)
        {

        }

        private void tbQuantHamb_TextChanged(object sender, EventArgs e)
        {
            List<Shop> shop = new List<Shop>();
            shop.Add(new Shop() { type = lbHamburg.Text, price = tbPriceHamb.Text, quantity = tbQuantHamb.Text });
            shop.Add(new Shop() { type = lbHotdog.Text, price = tbPriceHotDog.Text, quantity = tbQuantHotDog.Text });
            shop.Add(new Shop() { type = lbChips.Text, price = tbPriceChips.Text, quantity = tbQuantChips.Text });
            shop.Add(new Shop() { type = lbCola.Text, price = tbPriceCola.Text, quantity = tbQuantCola.Text });

            double sum;
            double all=0;
            foreach (Shop s in shop) 
            {

                    if (s.quantity != "")
                    {
                        if (Convert.ToInt32(s.quantity) > 0)
                        {
                            sum = Convert.ToInt32(s.quantity) * Convert.ToDouble(s.price);
                            all += sum;
                        }

                    }

                
            }

            lbSumShop.Text = Convert.ToString(all);

        }

        private void btToPay_Click(object sender, EventArgs e)
        {
            double sumOil = Convert.ToDouble(lbSumOil.Text);
            double sumShop = Convert.ToDouble(lbSumShop.Text);
            double allSum = sumOil + sumShop;
            lbToPay.Text = Convert.ToString(allSum);
        }

        private void lbSumShop_Click(object sender, EventArgs e)
        {

        }
    }
}
