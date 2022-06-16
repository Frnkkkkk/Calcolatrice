using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Calcolatrice : Form
    {
        int Operazioni = 0;
        int Operazione = 0;
        float NextOperatione=0;
        float risultato = 0;
        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void Button2_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void Button3_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void Button4_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void Button5_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void Button6_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void Button7_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void Button8_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void Button9_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void Button0_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }
        

        private void ButtonPlus_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "+";
            string lastDigit = Display.Text.Substring(Display.Text.Length - 1);
            Operazioni++;
            if (Operazioni > 1)
            {
                Operazioni--;
                NextOperatione = 1;
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                ButtonEqual_click(sender,e);
            }
            else
            {
                Operazione = 1;
            }
        }

        protected void ButtonEqual_click(object sender, EventArgs e)
        {
            string Display_string = Display.Text;
            string risul;
            char[] Caratteri = { '+', '-', 'x', ':' };
            float [] Numeri_int = new float[20];
            float risLoc = 0;
            string[] Numeri_String = Display_string.Split(Caratteri);
            for(int i = 0; i <= Operazioni; i++)
            {
                Numeri_int[i] = float.Parse(Numeri_String[i]);
            }
            //risultato = Numeri_int[0] + Numeri_int[1];
            //Display.Text = Display.Text + "=" + risultato;

            if (Operazione == 1)
            {
                for (int i = 0; i <= Operazioni; i++)
                {
                    risLoc+= Numeri_int[i];
                }
            }
            else if (Operazione == 2)
            {
                risLoc = Numeri_int[0];
                for (int i = 1; i <= Operazioni; i++)
                {
                    risLoc-= Numeri_int[i];
                }
            }
            else if (Operazione == 3)
            {
                risLoc = Numeri_int[0];
                for (int i = 1; i <= Operazioni; i++)
                {
                    risLoc*= Numeri_int[i];
                }
            }
            else if (Operazione == 4)
            {
                risLoc = Numeri_int[0];
                for (int i = 1; i <= Operazioni; i++)
                {
                    risLoc/= Numeri_int[i];
                }
            }
            else if(Operazione == 0)
            {
                Display.Text = "";
            }
            risultato= risLoc;
            risul = risultato.ToString();
            Display.Text = risul;
            if (NextOperatione == 1)
            {
                Display.Text += "+";
                NextOperatione = 0;
                Operazione = 1;
            }else if(NextOperatione==2){
                Operazioni = 1;
                Display.Text += "-";
                NextOperatione = 0;
                Operazione = 2;
            }
            else if (NextOperatione == 3)
            {
                Operazioni = 1;
                Display.Text += "x";
                NextOperatione = 0;
                Operazione = 3;
            }
            else if (NextOperatione == 4)
            {
                Operazioni = 1;
                Display.Text += ":";
                NextOperatione = 0;
                Operazione = 4;
            }
            else
            {
                Operazione = 0;
                Operazioni = 0;
            }
        }

        private void Buttonminu(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "-";
            Operazioni++;
            if (Operazioni > 1)
            {
                Operazioni--;
                NextOperatione = 2;
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                ButtonEqual_click(sender, e);
            }
            else
            {
                Operazione = 2;
            }
        }

        private void ButtonClear_click(object sender, EventArgs e)
        {
            Display.Text = "";
            Operazione = 0;
            Operazioni = 0;
            risultato = 0;
        }

        private void ButtonBack_click(object sender, EventArgs e)
        {
            string lastDigit = Display.Text.Substring(Display.Text.Length - 1);
            bool equPlus= lastDigit.Equals("+");
            bool equMinus = lastDigit.Equals("-");
            bool equFor = lastDigit.Equals("x");
            bool equDiv = lastDigit.Equals(":");
            if ((equPlus==true)||(equMinus==true)||(equFor==true)||(equDiv==true))
            {
                Operazioni--;
            }
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);


        }

        private void ButtonVirgola_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ",";
        }

        private void ButtonFor_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "x";
            Operazioni++;
            if (Operazioni > 1)
            {
                Operazioni--;
                NextOperatione = 3;
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                ButtonEqual_click(sender, e);
            }
            else
            {
                Operazione = 3;
            }
        }

        private void ButtonDiv_click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ":";
            Operazioni++;
            if (Operazioni > 1)
            {
                Operazioni--;
                NextOperatione = 4;
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                ButtonEqual_click(sender, e);
            }
            else
            {
                Operazione = 4;
            }
        }

        private void ButtonSqrt_click(object sender, EventArgs e)
        {
            double numeroRad=double.Parse(Display.Text);
            numeroRad = Math.Sqrt(numeroRad);
            string risultato = numeroRad.ToString();
            Display.Text = risultato;
        }

        private void Calcolatrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Add)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                ButtonPlus_click(sender, e);
            }
        }
    }
}
