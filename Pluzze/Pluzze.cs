using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pluzze
{
    public partial class Pluzze : Form
    {
        //Arreglo principal
        public string[] a = new string[16];

        Stopwatch sw = new Stopwatch();

        public Pluzze()
        {
            a = GenerarNumerosAleatorios();
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

        private void CargarPuzzle(object sender, EventArgs e)
        {
            Restaurar.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
            this.button10.Text = "";
            this.button11.Text = "";
            this.button12.Text = "";
            this.button13.Text = "";
            this.button14.Text = "";
            this.button15.Text = "";
            this.button16.Text = "";
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            Restaurar.Enabled = true;
            Iniciar.Enabled = false;

            string[] a = new string[16];
            a = GenerarNumerosAleatorios();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;

            this.button1.Text = a[0];
            this.button2.Text = a[1];
            this.button3.Text = a[2];
            this.button4.Text = a[3];
            this.button5.Text = a[4];
            this.button6.Text = a[5];
            this.button7.Text = a[6];
            this.button8.Text = a[7];
            this.button9.Text = a[8];
            this.button10.Text = a[9];
            this.button11.Text = a[10];
            this.button12.Text = a[11];
            this.button13.Text = a[12];
            this.button14.Text = a[13];
            this.button15.Text = a[14];
            this.button16.Text = a[15];

            sw.Start();
            timer1.Enabled = true;
        }
        
        private void Restablecer_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;

            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
            this.button10.Text = "";
            this.button11.Text = "";
            this.button12.Text = "";
            this.button13.Text = "";
            this.button14.Text = "";
            this.button15.Text = "";
            this.button16.Text = "";

            sw.Restart();
            temporizador.Text = "00:00";
            Restaurar.Enabled = false;
            Iniciar.Enabled = true;
        }

        private void Temporizador(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)sw.ElapsedMilliseconds);
            string min = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            string sec = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            temporizador.Text = $"{min}:{sec}";
        }
        #endregion
    }
}
