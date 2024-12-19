using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] fruits = { "Банан", "Ананас", "Манго", "Папайя", "Дуриан" };
            listBox1.Items.AddRange(fruits);
            string[] Fruits2 = { "Апельсин", "Арбуз", "Маракуйя", "Лонган", "Личи" };
            listBox2.Items.AddRange(Fruits2);
        }

        private void button1_Click(object sender, EventArgs e) // Сохранение
        {
            string result = "";
            if (listBox2.Items.Count == 0)
                MessageBox.Show($"Нет выбранных элементов");
            else
            {
                foreach (var item in listBox2.Items)
                    result += $"{item.ToString()}\n";
                MessageBox.Show($"Список покупок:\n{result}");
            }

        }

        private void button2_Click(object sender, EventArgs e) // Вернуть изначальные списки
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string[] fruits = { "Банан", "Ананас", "Манго", "Папайя", "Дуриан" };
            listBox1.Items.AddRange(fruits);
            string[] fruits2 = { "Апельсин", "Арбуз", "Маракуйя", "Лонган", "Личи" };
            listBox2.Items.AddRange(fruits2);
        }

        private void button3_Click(object sender, EventArgs e) // Выбранный элемент в правый список
        {
            var selectedItems = listBox1.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(selectedItems[i]);
                listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Все элементы в правый список
        {
            var selectedItems = listBox1.Items;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(selectedItems[i]);
                listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e) // Выбранный элемент в левый список
        {
            var selectedItems = listBox2.SelectedItems;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(selectedItems[i]);
                listBox2.Items.Remove(selectedItems[i]);
            }

        }
        private void button6_Click(object sender, EventArgs e) // Все элементы в левый список
        {
            var selectedItems = listBox2.Items;

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(selectedItems[i]);
                listBox2.Items.Remove(selectedItems[i]);
            }
        }

    }
}
