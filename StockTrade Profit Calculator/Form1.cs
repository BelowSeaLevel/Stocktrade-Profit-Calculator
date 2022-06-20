using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrade_Profit_Calculator
{
    public partial class Form1 : Form
    {
        private string buyPrice;
        private string sellPrice;
        private string shares;
        private double differenceInPrice;
        private double profit;
        private double value20Profit;
        private double value8Loss;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets the focus / select to the TextBoxBuyPrice on start up.
            TextBoxBuyPrice.Select();
        }


        private void TextBoxBuyPrice_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBuyPrice.Text.Contains("."))
            {
                MessageBox.Show("Cannot use the dot (.), you must use a comma (,)!");
                TextBoxBuyPrice.Clear();
            }
            else
            {
                buyPrice = TextBoxBuyPrice.Text;
            }

        }

        private void TextBoxSellPrice_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSellPrice.Text.Contains("."))
            {
                MessageBox.Show("Cannot use the dot (.), you must use a comma!");
                TextBoxSellPrice.Clear();
            }
            else
            {
                sellPrice = TextBoxSellPrice.Text;
            }
            
        }

        private void TextBoxAmountOfShares_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxAmountOfShares.Text.Contains("."))
            {
                MessageBox.Show("Cannot use the dot (.), you must use a comma!");
                TextBoxAmountOfShares.Clear();
            }
            else
            {
                shares = TextBoxAmountOfShares.Text;
            }

        }

        private void TextBoxDifferenceInPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateDifference();
                CalculateProfit();
                Calculate20Profit();
                Calculate8Loss();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("All fields must have a number.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Something went wrong. \nDid you input something else then a number?");
            }


            LabelDifferenceInPriceValue.Text = differenceInPrice.ToString();
            LabelProfitValue.Text = profit.ToString();
            Label20Value.Text = value20Profit.ToString();
            Label8Value.Text = value8Loss.ToString();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxBuyPrice.Clear();
            TextBoxSellPrice.Clear();
            TextBoxAmountOfShares.Clear();
            LabelDifferenceInPriceValue.Text = "";
            LabelProfitValue.Text = "";
            Label20Value.Text = "";
            Label8Value.Text = "";
        }

        public void CalculateDifference()
        {
            differenceInPrice = Double.Parse(sellPrice) - Double.Parse(buyPrice);
        }

        public void CalculateProfit()
        {
            profit = Double.Parse(shares) * differenceInPrice;

        }

        private void Calculate20Profit()
        {
            double temp;
            temp = Double.Parse(buyPrice) / 100;
            temp *= 20;

            value20Profit = Double.Parse(buyPrice) + temp;

        }

        private void Calculate8Loss()
        {
            double temp;
            temp = Double.Parse(buyPrice) / 100;
            temp *= 8;

            value8Loss = Double.Parse(buyPrice) - temp;

        }

        
    }
}
