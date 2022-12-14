using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (!(
                Double.TryParse(textBoxXReadValue.Text, out double x) &&
                Double.TryParse(textBoxYReadValue.Text, out double y) && 
                Double.TryParse(textBoxZReadValue.Text, out double z) &&
                Double.TryParse(degreeXRead.Text, out double degreeX) &&
                Double.TryParse(degreeYRead.Text, out double degreeY) &&
                Double.TryParse(degreeZRead.Text, out double degreeZ)))
            {
                MessageBox.Show("Введено неправильное значение либо пустая строка, пожалуйста, проверьте вхродные данные");
            }
            else
            {
                x *= Math.Pow(10, degreeX);
                y *= Math.Pow(10, degreeY); 
                z *= Math.Pow(10, degreeZ);

                double result;
                double f = 0.33056;

                double firstFraction, secondFraction, thirdFraction;

                firstFraction = (Math.Pow(y, (x + 1.0))) / (Math.Pow(Math.Abs(y - 2.0), 1.0 / 3) + 3.0);
                secondFraction = (x + (y / 2.0)) / (2.0 * Math.Abs(x + y));
                thirdFraction = Math.Pow(x + 1, -1.0 / Math.Sin(z));

                result = firstFraction + secondFraction * thirdFraction;

                theIntendedAnswerOutput.Text = result.ToString();
                theRealAnswerOutput.Text = f.ToString();

            }

        }

        private void TextBoxReadValueKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44 && number != 45) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
