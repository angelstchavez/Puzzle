using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluzze
{
    public partial class Pluzze : Form
    {
        public Pluzze()
        {
            string[] numeros = new string[16];
            numeros = GenerarNumerosAleatorios();
            InitializeComponent();
        }

        #region DETALLES
        int posX = 0;
        int posY = 0;

        private void MoverBarra(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { posX = e.X; posY = e.Y; }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region BOTONES PRINCIPALES
        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            else if (button5.Text == "")
            {
                button5.Text = button1.Text;
                button1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            else if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            else if (button6.Text == "")
            {
                button6.Text = button2.Text;
                button2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            else if (button4.Text == "")
            {
                button4.Text = button3.Text;
                button3.Text = "";
            }
            else if (button7.Text == "")
            {
                button7.Text = button3.Text;
                button3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
            }
            else if (button8.Text == "")
            {
                button8.Text = button4.Text;
                button4.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button5.Text;
                button5.Text = "";
            }
            else if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            else if (button9.Text == "")
            {
                button9.Text = button5.Text;
                button5.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button6.Text;
                button6.Text = "";

            }
            else if (button5.Text == "")

            {
                button5.Text = button6.Text;
                button6.Text = "";

            }
            else if (button7.Text == "")

            {
                button7.Text = button6.Text;
                button6.Text = "";
            }
            else if (button10.Text == "")
            {
                button10.Text = button6.Text;
                button6.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button7.Text;
                button7.Text = "";
            }
            else if (button6.Text == "")
            {
                button6.Text = button7.Text;
                button7.Text = "";
            }
            else if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            else if (button11.Text == "")
            {
                button11.Text = button7.Text;
                button7.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button8.Text;
                button8.Text = "";

            }
            else if (button7.Text == "")

            {
                button7.Text = button8.Text;
                button8.Text = "";

            }
            else if (button12.Text == "")

            {
                button12.Text = button8.Text;
                button8.Text = "";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button9.Text;
                button9.Text = "";

            }
            else if (button13.Text == "")

            {
                button13.Text = button9.Text;
                button9.Text = "";

            }
            else if (button10.Text == "")

            {
                button10.Text = button9.Text;
                button9.Text = "";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button10.Text;
                button10.Text = "";

            }
            else if (button9.Text == "")

            {
                button9.Text = button10.Text;
                button10.Text = "";

            }
            else if (button11.Text == "")

            {
                button11.Text = button10.Text;
                button10.Text = "";
            }
            else if (button14.Text == "")

            {
                button14.Text = button10.Text;
                button10.Text = "";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button11.Text;
                button11.Text = "";

            }
            else if (button10.Text == "")

            {
                button10.Text = button11.Text;
                button11.Text = "";

            }
            else if (button12.Text == "")

            {
                button12.Text = button11.Text;
                button11.Text = "";

            }
            else if (button15.Text == "")

            {
                button15.Text = button11.Text;
                button11.Text = "";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = button12.Text;
                button12.Text = "";

            }
            else if (button11.Text == "")

            {
                button11.Text = button12.Text;
                button12.Text = "";

            }
            else if (button16.Text == "")

            {
                button16.Text = button12.Text;
                button12.Text = "";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";

            }
            else if (button14.Text == "")

            {
                button14.Text = button13.Text;
                button13.Text = "";

            }
            else if (button12.Text == "")

            {
                button12.Text = button13.Text;
                button13.Text = "";

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                button10.Text = button14.Text;
                button14.Text = "";

            }
            else if (button13.Text == "")

            {
                button13.Text = button14.Text;
                button14.Text = "";

            }
            else if (button15.Text == "")

            {
                button15.Text = button14.Text;
                button14.Text = "";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (button11.Text == "")
            {
                button11.Text = button15.Text;
                button15.Text = "";

            }
            else if (button14.Text == "")

            {
                button14.Text = button15.Text;
                button15.Text = "";

            }
            else if (button16.Text == "")

            {
                button16.Text = button15.Text;
                button15.Text = "";

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.Text == "")
            {
                button12.Text = button16.Text;
                button16.Text = "";

            }
            else if (button15.Text == "")

            {
                button15.Text = button16.Text;
                button16.Text = "";

            }
        }
        #endregion

        #region METODOS PRIVADOS
        private string[] GenerarNumerosAleatorios()
        {
            bool repetido;
            string n;
            int indice = 0;
            Random a = new Random();
            string[] num = new string[16];
            while (indice < num.Length)
            {
                repetido = false;
                n = Convert.ToString(a.Next(0, 16));
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == n)
                    {
                        repetido = true;
                    }

                }
                if (repetido == false)
                {
                    num[indice] = n;
                    indice++;
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == "0")
                {
                    num[i] = "";
                }
            }
            return num;
        }
        #endregion

    }
}
