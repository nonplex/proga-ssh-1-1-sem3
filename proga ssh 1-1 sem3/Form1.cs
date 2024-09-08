using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proga_ssh_1_1_sem3
{
    public partial class Form1 : Form
    {
        private double radius;
        private double angle;
        private double x;
        private double y;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out radius) && radius >= 0 &&
                 double.TryParse(textBox2.Text, out angle) && angle >= 0 && angle <= 360)
            {
                // перевод
                x = radius * Math.Cos(angle * Math.PI / 180); // преобразуем угол из градусов в радианы
                y = radius * Math.Sin(angle * Math.PI / 180); // преобразуем угол из градусов в радианы

                label5.Text = x.ToString(); // установите текст Label5 равным значению x
                label6.Text = y.ToString(); // установите текст Label6 равным значению y
            }
            else
            {
                MessageBox.Show("Неверное значение. Пожалуйста, введите неотрицательные числа для радиуса и угла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Ввод радиуса
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out radius) || radius < 0)
            {
                radius = 0;
                textBox1.Text = "";
                MessageBox.Show("Неверное значение. Пожалуйста, введите неотрицательное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out angle) || angle < 0 || angle > 360)
            {
                angle = 0;
                textBox2.Text = "";
                MessageBox.Show("Неверное значение. Пожалуйста, введите число от 0 до 360.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value) && value >= 0)
            {
                x = value;
                label5.Text = x.ToString(); // установите текст Label равным значению x
            }
            else
            {
                x = 0;

                MessageBox.Show("Неверное значение. Пожалуйста, введите неотрицательное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value) && value >= 0)
            {
                y = value;
                label6.Text = y.ToString(); // установите текст Label равным значению y
            }
            else
            {
                y = 0;

                MessageBox.Show("Неверное значение. Пожалуйста, введите неотрицательное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
