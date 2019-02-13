using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_level1
{
    partial class Form1 : Form
    {
        int count;
        int target;
        Random rnd = new Random();
        Stack<int> myStack = new Stack<int>();

        void Clear()
        {
            label1.Text = "0";
            label3.Text = "0";
            count = 0;
            target = int.MaxValue;
            myStack.Clear();
        }

        void Step(int n)
        {
            switch (n)
            {
                case 1:
                    myStack.Push(int.Parse(label1.Text) + 1);
                    break;
                case 2:
                    myStack.Push(int.Parse(label1.Text) * 2);
                    break;
            }
            label1.Text = myStack.Peek().ToString();
            count++;
            label3.Text = count.ToString();
        }

        void Valid()
        {
            if (int.Parse(label1.Text) == target)
            {
                MessageBox.Show("Вы справились!");
                Clear();
            }
            else if (int.Parse(label1.Text) > target)
            {
                MessageBox.Show("Вы проиграли!");
                Clear();
            }
        }

        public Form1()
        {
            InitializeComponent();
            target = int.MaxValue;
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            Step(1);
            Valid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Step(2);
            Valid();
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            target = rnd.Next(1, 50);
            MessageBox.Show("Попробуйте получить число " + target.ToString(), "Задание");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myStack.Peek() > 0)
            {
                myStack.Pop();
                label1.Text = myStack.Peek().ToString();
            }
            if(count > 0)
            { 
                count--;
                label3.Text = count.ToString();
            }
        }
    }
}
