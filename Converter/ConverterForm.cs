using System;
using System.Windows.Forms;

namespace Converter
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void RateChange(TextBox rate, KeyPressEventArgs e)
        {
            string rateString = rate.Text;
            decimal rateDecimal = 0.0m;
            if (e.KeyChar == (char)13 &&
                Decimal.TryParse(rateString, out rateDecimal))
            {
                UpdateUSD();
            }
        }

        private void rateCAD_Enter(object sender, KeyPressEventArgs e)
        {
            RateChange(rateCAD, e);
        }
        private void rateGBP_Enter(object sender, KeyPressEventArgs e)
        {
            RateChange(rateGBP, e);
        }
        private void rateEUR_Enter(object sender, KeyPressEventArgs e)
        {
            RateChange(rateEUR, e);
        }
        private void rateNIS_Enter(object sender, KeyPressEventArgs e)
        {
            RateChange(rateNIS, e);
        }
        private void rateJPY_Enter(object sender, KeyPressEventArgs e)
        {
            RateChange(rateJPY, e);
        }
        private void rateAUD_Enter(object sender, KeyPressEventArgs e)
        {
            RateChange(rateAUD, e);
        }



        private void QuantityChange(TextBox quantity, TextBox rate, KeyPressEventArgs e)
        {
            String quantityString = quantity.Text;
            decimal quantityDecimal = 0.0m;

            String rateString = rate.Text;
            decimal rateDecimal = 0.0m;

            if (e.KeyChar == (char)13 &&
                Decimal.TryParse(quantityString, out quantityDecimal) && 
                Decimal.TryParse(rateString, out rateDecimal))
            {
                decimal qUSD = quantityDecimal / rateDecimal;
                quantityUSD.Text = qUSD.ToString();

                UpdateUSD();
            }
        }

        private void quantityCAD_Enter(object sender, KeyPressEventArgs e)
        {
            QuantityChange(quantityCAD, rateCAD, e);
        }
        private void quantityGBP_Enter(object sender, KeyPressEventArgs e)
        {
            QuantityChange(quantityGBP, rateGBP, e);
        }
        private void quantityEUR_Enter(object sender, KeyPressEventArgs e)
        {
            QuantityChange(quantityEUR, rateEUR, e);
        }
        private void quantityNIS_Enter(object sender, KeyPressEventArgs e)
        {
            QuantityChange(quantityNIS, rateNIS, e);
        }
        private void quantityJPY_Enter(object sender, KeyPressEventArgs e)
        {
            QuantityChange(quantityJPY, rateJPY, e);
        }
        private void quantityAUD_Enter(object sender, KeyPressEventArgs e)
        {
            QuantityChange(quantityAUD, rateAUD, e);
        }


        private void quantityUSD_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                UpdateUSD();
            }
        }

        private void UpdateUSD()
        {
            String qUSDString = quantityUSD.Text;
            decimal qUSDDecimal = 0.0m;

            if (Decimal.TryParse(qUSDString, out qUSDDecimal))
            {
                ConvertFromUSD(quantityCAD, rateCAD, qUSDDecimal);
                ConvertFromUSD(quantityNIS, rateNIS, qUSDDecimal);
                ConvertFromUSD(quantityAUD, rateAUD, qUSDDecimal);
                ConvertFromUSD(quantityJPY, rateJPY, qUSDDecimal);
                ConvertFromUSD(quantityEUR, rateEUR, qUSDDecimal);
                ConvertFromUSD(quantityGBP, rateGBP, qUSDDecimal);
            }
        }

        private void ConvertFromUSD(TextBox quantity, TextBox rate, decimal quantityUSD)
        {
            decimal rateDecimal = 0.0m;
            if (Decimal.TryParse(rate.Text, out rateDecimal))
            {
                quantity.Text = (quantityUSD * rateDecimal).ToString();
            }
        }

        private void lblJPY_Click(object sender, EventArgs e)
        {

        }
    }
}
