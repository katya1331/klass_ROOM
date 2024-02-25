using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zad4_var4.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zad4_var4
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();

        }
        Room room1 = new Room();
        private void button1_Click (object sender, EventArgs e)
        {
            room1.s1 = $"Площадь комнаты { room1.S(room1.x, room1.y)} метров квадратных";
            label1.Text = room1.s1;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            room1.s2 = $"Объем комнаты { room1.V(room1.x, room1.y, room1.z)} метров кубических";
            label1.Text = room1.s2;
        }

        private void button4_Click (object sender, EventArgs e)
        {
           
            room1.s4 = room1.Oboi(room1.x, room1.y, room1.z,  room1.CountWindow,  room1.xWindow,  room1.yWindow,  room1.xdoor,  room1.ydoor);
            label1.Text = room1.s4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           try
           {
                
                room1.x = Double.Parse(textBox1.Text);
                room1.y = Double.Parse(textBox2.Text);
                room1.z = Double.Parse(textBox3.Text);
                room1.CountWindow = Int32.Parse(textBox4.Text);
                room1.xWindow = Double.Parse(textBox5.Text);
                room1.yWindow = Double.Parse(textBox6.Text);
                room1.xdoor = Double.Parse(textBox7.Text);
                room1.ydoor = Double.Parse(textBox8.Text);
                    button5.Enabled = false;
           }
           catch
           {
                    MessageBox.Show("Все поляны должны быть заполнены цифрами");
           }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("x:"+Convert.ToString(room1.x));
            list.Add("y:" + Convert.ToString(room1.y));
            list.Add("z:" + Convert.ToString(room1.z));
            list.Add("CountWindow:" + Convert.ToString(room1.CountWindow));
            list.Add("xWindow:" + Convert.ToString(room1.xWindow));
            list.Add("yWindow:" + Convert.ToString(room1.yWindow));
            list.Add("xdoor:" + Convert.ToString(room1.xdoor));
            list.Add("ydoor:" + Convert.ToString(room1.ydoor));
            list.Add("S:" + Convert.ToString(room1.S(room1.x, room1.y)));
            list.Add("V:" + Convert.ToString(room1.V(room1.x, room1.y, room1.z)));
            list.Add(Convert.ToString(room1.s3)); 
            list.Add(Convert.ToString(room1.s4));
            File.AppendAllLines("Rooms.txt", list);
            button5.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            room1.s3 = room1.Info(room1.x, room1.y);
            label1.Text = room1.s3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            label1.Text="";
        }
    }
}
