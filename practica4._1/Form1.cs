using System;
using System.Text;
using System.Windows.Forms;

namespace practica4._1
{
    public partial class Form1 : Form
    {
        private LinkedList linkedList = new LinkedList();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNumber.Text, out double parsedValue))
            {
                linkedList.Add(parsedValue);
                UpdateList();
                textBoxNumber.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное числовое значение.");
            }
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            linkedList.RemoveBeforeFirstPositive();
            UpdateList();
        }

        private void UpdateList()
        {
            listBoxNumbers.Items.Clear();
            ListNode? current = linkedList.Head; // Добавляем вопросительный знак
            while (current != null)
            {
                listBoxNumbers.Items.Add(current.Value);
                current = current.Next;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
