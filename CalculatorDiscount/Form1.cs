using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDiscount
{
    public partial class CalculatorDiscount : Form
    {

        string numeProdus;
        double pretProdus;
        double discountProdus;
        public CalculatorDiscount()
        {
            InitializeComponent();
        }

        private double CalculareDiscountProdus(double pretProdus, double discountProdus)
        {
            /* if(discountProdus > 100)
             {
                 Console.Write("Reducerea nu poate fi mai mare de 100%");
             }*/
            return pretProdus - (discountProdus / 100 * pretProdus);
        }

        private void numeProdusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            string numeProdus = numeProdusTextBox.Text;


            if (double.TryParse(pretProdusTextBox.Text, out double pretProdus))
            {


                if (double.TryParse(discountProdusTextBox.Text, out double discountProdus))
                {
                    // Calculate the product with the discount
                    double produs = CalculareDiscountProdus(pretProdus, discountProdus);


                    afisaj.Text = $"Nume produs: {numeProdus} \n " +
                                  $"Discount:  {discountProdus} % \n" +
                                  $" Pret produs final: {produs}: ";
                }

                
            }
        }
                private void btnStergeti_Click(object sender, EventArgs e)
                {

                }
            }
    }
