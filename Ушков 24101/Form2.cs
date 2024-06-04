using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ушков_24101
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox_TextChanged;
            textBox2.TextChanged += textBox_TextChanged;
        }

        double num1, num2, res = 0;
        

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ушков Глеб Александрович группа 24101");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            res = num1 - num2;
            textBox3.Text = res.ToString();
            textBox4.AppendText($"{res.ToString()}\r\n");
        }

        private void multyply_Click(object sender, EventArgs e)
        {
            res = num1 * num2;
            textBox3.Text = res.ToString();
            textBox4.AppendText($"{res.ToString()}\r\n");
        }

        private void division_Click(object sender, EventArgs e)
        {
            
            res = num1 / num2;
            textBox3.Text = res.ToString();
            textBox4.AppendText($"{res.ToString()}\r\n");
        }

        private void button6_Click(object sender, EventArgs e) // Очищаем все поля
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void func_Click(object sender, EventArgs e)
        {
            if (num1 <= 0 || num2 <= 0)
            {   
                res = Double.NaN; // Чтобы избежать деления на ноль
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("Введены некорректные значения, значения аргументов функции должны быть положительны, попробуйте ввести значения заново");
            }
         
            else
            {
                textBox3.Clear();
                res = Math.Pow(num1, num2 / 2.0) * (Math.Sqrt(num1) - Math.Sqrt(num2)) * (Math.Pow(num1 * num2, 1.0 / 3.0) / (num1 * num2));
                textBox3.Text += res.ToString();
                textBox4.AppendText($"{res.ToString()}\r\n");
            }
            
        }

        public void textBox_TextChanged(object sender, EventArgs e)
        {
            
            // Определение, является ли содержимое textBox1 числом
            bool isNumeric1 = double.TryParse(textBox1.Text, out num1);

            bool isNumeric2 = double.TryParse(textBox2.Text, out num2);

            // Проверка, пустая ли строка или содержит только пробелы
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Установка текста по умолчанию, может быть любая строка или пустая
                label2.Text = "Комментарий";  // Задайте сообщение по умолчанию здесь

            }
            else if (isNumeric1&&isNumeric2)
            {
                // Включаем функциональные кнопки, если значения введены корректно
                multyply.Enabled = true;
                plus.Enabled = true;
                minus.Enabled = true;
               
                division.Enabled = num2 != 0; // Дивизия неактивна, если num2 равно 0
                
            }
            else
            {
                // Если текст не является числом, выводим сообщение об ошибке
                label2.Text = "Введено неверное значение";
                multyply.Enabled = false;
                plus.Enabled = false;
                minus.Enabled = false;
                division.Enabled = false;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            res = num1+num2;
            textBox3.Text = res.ToString();
            textBox4.AppendText($"{res.ToString()}\r\n");
        }
        

    }
}
