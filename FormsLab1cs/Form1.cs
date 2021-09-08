using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsLab1cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        string xString, yString, zString;
        private void Form1_Load(object sender, EventArgs e)
        {
            BoxOfX.Text = "3,4";
            BoxOfY.Text = "0,74";
            BoxOfZ.Text = "19,43";
        }

        

        private string Execution(string xString, string yString, string zString)
        {
            try
            {
                double xDouble, yDouble, zDouble, fResultDouble;
                xDouble = Convert.ToDouble(xString);
                yDouble = Convert.ToDouble(yString);
                zDouble = Convert.ToDouble(zString);
                fResultDouble = Math.Pow((yDouble + Math.Pow((xDouble - 1), 1 / 3)), 1 / 4) / (Math.Abs(xDouble - yDouble) * (Math.Pow(Math.Sin(zDouble), 2) + Math.Tan(zDouble)));

                string fResultString = Convert.ToString(fResultDouble);
                return fResultString;
            }
            catch
            {
                MessageBox.Show("Перепроверьте введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            finally
            {
            }
        }

        //блок блокировки ввода символов не являющихся цифрами
       
        private void PressX(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
        }

        private void PressY(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
        }

        private void PressZ(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
        }
        
        //конец блока

        private void BoxOfX_TextChanged(object sender, EventArgs e)
        {
            xString = BoxOfX.Text;
        }

        private void BoxOfY_TextChanged(object sender, EventArgs e)
        {
            yString = BoxOfY.Text;
        }

        private void BoxOfZ_TextChanged(object sender, EventArgs e)
        {
            zString = BoxOfZ.Text;
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ResultBox.ResetText();
            ResultBox.Text = "Лаб. раб №1 10702220 Невыглас П.Ю.\n" + Execution(xString, yString, zString);
        }
    }
}
