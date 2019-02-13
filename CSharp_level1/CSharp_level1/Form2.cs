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
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int target1;
        TextBox answer = new TextBox();
        Form myF = new Form();
        Button bt = new Button();

        public Form2()
        {
            InitializeComponent();
            bt.Location = new System.Drawing.Point(10, 30);
            bt.Text = "OK";
            myF.Size = new System.Drawing.Size(100, 100);
            myF.Text = "Введите число";
            myF.ControlBox = false;
            myF.Controls.Add(answer);
            myF.Controls.Add(bt);
            bt.Click += new System.EventHandler(bt_Click);
            myF.Visible = false;
        } 
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.target1 = rnd.Next(101);
            myF.Visible = true;
            button1.Visible = false;
        }

        void bt_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            myF.Visible = false;
            int x;
            if (int.TryParse(answer.Text, out x))
            {
                if (target1 == x)
                {
                    label1.Text = "Угадали!";
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else if (target1 > x) label1.Text = "Больше";
                else label1.Text = "Меньше";
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myF.Visible = true;
            answer.Text = "";
        }
    }
}
