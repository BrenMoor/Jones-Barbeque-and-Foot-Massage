using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
//Brendan Moorehead
//March 5th, 2018
//Jones BBQ and Foot Massage Cash Register

namespace Jones_Barbeque_and_Foot_Massage
{
    public partial class Form1 : Form
    {
        //Setting up constants
        const double BURGER = 2.89;
        const double HOTDOG = 1.49;
        const double FOOTMASSAGE = 9.45;
        const double TAX = 0.13;
        //Setting up non-decimal variables
        int burgerNumber, hotdogNumber, massageNumber = 0;
        //Setting up variables that require decimal values
        double total, change, tendered, subtotal, taxTotal;
        //setting up soundplayer for song
        SoundPlayer BBQSong = new SoundPlayer(Properties.Resources.JONESBBQ);
        SoundPlayer Printer = new SoundPlayer(Properties.Resources.printer);
        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.FromArgb(255, 192, 192));
            textboxBurger.Text = "0";
            textboxFootMassage.Text = "0";
            textboxHotdog.Text = "0";
            textboxTendered.Text = "";
            labelChangeNumber.Text = "0.00";
            labelSubtotalNumbers.Text = "0.00";
            labelTaxNumbers.Text = "0.00";
            labelTotalNumbers.Text = "0.00";
            labelCatch.Text = "";
            BBQSong.Play();

        }

        private void buttonPrintReciept_Click(object sender, EventArgs e)
        {
            if (change > 0)
            {   //Make catch label dissapear
                labelCatch.Visible = false;
                //Setting up graphics
                Graphics g = this.CreateGraphics();
                Font textFont = new Font("Consolas", 7, FontStyle.Bold);
                SolidBrush textBrush = new SolidBrush(Color.Black);
                SolidBrush rectangleBrush = new SolidBrush(Color.White);
                Printer.Play();
                g.FillRectangle(rectangleBrush, 217, 50, 200, 325);
                Thread.Sleep(550);
                g.DrawString("Jones Barbeque and Foot Massage", textFont, textBrush, 235, 60);
                Thread.Sleep(550);
                g.DrawString("Order Number 722", textFont, textBrush, 270, 73);
                Thread.Sleep(550);
                g.DrawString("March 6th, 2018", textFont, textBrush, 273, 86);
                Thread.Sleep(550);
                g.DrawString("Burgers X" + burgerNumber + " @ 2.89", textFont, textBrush, 268, 120);
                Thread.Sleep(550);
                g.DrawString("Hot Dogs X" + hotdogNumber + " @ 1.49", textFont, textBrush, 266, 140);
                Thread.Sleep(550);
                g.DrawString("Foot Massage X" + massageNumber + " @ 9.45", textFont, textBrush, 256, 160);
                Thread.Sleep(550);
                g.DrawString("Subtotal                   " + subtotal.ToString("C"), textFont, textBrush, 220, 190);
                Thread.Sleep(550);
                g.DrawString("Taxes                      " + taxTotal.ToString("C"), textFont, textBrush, 220, 210);
                Thread.Sleep(550);
                g.DrawString("Total                      " + total.ToString("C"), textFont, textBrush, 220, 230);
                Thread.Sleep(550);
                g.DrawString("Tendered                   " + tendered.ToString("C"), textFont, textBrush, 220, 270);
                Thread.Sleep(550);
                g.DrawString("Change                     " + change.ToString("C"), textFont, textBrush, 220, 290);
                Thread.Sleep(550);
                g.DrawString("Have a nice day!", textFont, textBrush, 273, 320);
            }
            
            else
                labelCatch.Text = "Insufficient Funds.";
            
        }

        private void buttonCalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                labelCatch.Text = "";
                tendered = Convert.ToDouble(textboxTendered.Text);
                change = tendered - total;
                if (change < 0)
                {
                    labelCatch.Text = "Insufficient Funds.";
                    labelChangeNumber.Text = ("0.00");
                }

                else
                {
                    labelChangeNumber.Text = change.ToString("C");
                }
            }
            catch
            {
                labelCatch.Text = "Please make sure you are inputting a numerical value for amount tendered.";
                labelChangeNumber.Text = "0.00";
            }
    
        }

        public Form1()
        {
            InitializeComponent();
            textboxBurger.Text = "0";
            textboxHotdog.Text = "0";
            textboxFootMassage.Text = "0";
            BBQSong.Play();




        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textboxBurger.Text == "")
                textboxBurger.Text = "0";
            if (textboxHotdog.Text == "")
                textboxHotdog.Text = "0";
            if (textboxFootMassage.Text == "")
                textboxFootMassage.Text = "0";
            try
            {
                
                
                burgerNumber = Convert.ToInt16(textboxBurger.Text);
                hotdogNumber = Convert.ToInt16(textboxHotdog.Text);
                massageNumber = Convert.ToInt16(textboxFootMassage.Text);
                
                subtotal = burgerNumber * BURGER + hotdogNumber * HOTDOG + massageNumber * FOOTMASSAGE;
                labelSubtotalNumbers.Text = subtotal.ToString("C");
                labelCatch.Text = "";

                taxTotal = subtotal * TAX;
                labelTaxNumbers.Text = taxTotal.ToString("C");
                total = subtotal + taxTotal;
                labelTotalNumbers.Text = total.ToString("C");
            }
            catch
            {
                labelCatch.Text = "Please make sure you are inputting whole numbers.";
                
            }

            

        }


    }
}
