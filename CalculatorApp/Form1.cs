using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnMathAction_Click(object sender, EventArgs e)
        {
            // эти переменные нужны для out параметров float.TryParse(string s, out v)
            float A, B;
            // Эта строковая переменная хранит имя кнопки, 
            // будет использована для определения того, какая кнопка нажата
            string senderName = ((Button)sender).Name;

            // if(bool && bool)
            // оба метода должны вернуть истину
            if (float.TryParse(tbOperand1.Text, out A) && float.TryParse(tbOperand2.Text, out B))
            {
                // Проверяем по имени какая кнопка нажата и в соответствии с выбором
                // вызываем требуемую арифметическую операцию
                switch (senderName)
                {
                    case "bnAdd":
                        tbResult.Text = (A + B).ToString();
                        break;
                    case "bnSubstr":
                        tbResult.Text = (A - B).ToString();
                        break;
                    case "bnMultiply":
                        tbResult.Text = (A * B).ToString();
                        break;
                    case "bnDivide":
                        tbResult.Text = (A / B).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неправильно введено значение оператора!");
            }
        }
    }

}
