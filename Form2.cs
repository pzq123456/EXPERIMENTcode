using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验一
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "加秒器";
        }

        class Time
        {
            //======***私有成员***=====//
            int hour;
            int minute;
            int second;
            //======***私有成员***=====//
            //======***两个构造函数（重载）***====//
            public Time()
            {
                hour = System.DateTime.Now.Hour;
                minute = System.DateTime.Now.Minute;
                second = System.DateTime.Now.Second;
            }
            public Time(string h,string m,string s)
            {
                this.hour=  Convert.ToInt32(h);
                this.minute = Convert.ToInt32(m);
                this.second = Convert.ToInt32(s);
            }
            //======***两个构造函数（重载）***====//
            //======***写三个只读字段***=======//
            public int Hour
            {
                get { return hour; }
            }
            public int Second
            {
                get { return second; }
            }
            public int Minute
            {
                get { return minute; }
            }
            //======***写三个只读字段***=======//
            //======***方法***=====//
            public void AddSecond()
            {
                second++;
                if (second >= 60)
                {
                    second = second % 60;
                    minute ++;
                }
                if (minute >= 60)
                {
                    minute = minute % 60;
                    hour++;
                }
                if (hour >= 24)
                {
                    hour =hour % 60;
                    hour++;
                }
            }
            //======***方法***=====//  
        }
        private void button1_Click(object sender, EventArgs e)
        {

           if(textBox1.Text!=""&& textBox2.Text != ""&& textBox3.Text != "")
            {
                Time time = new Time(textBox1.Text, textBox2.Text, textBox3.Text);
                time.AddSecond();
                textBox1.Text = Convert.ToString(time.Hour);
                textBox2.Text = Convert.ToString(time.Minute);
                textBox3.Text = Convert.ToString(time.Second);
            }
            else
            {
                Time time = new Time();
                time.AddSecond();
                textBox1.Text = Convert.ToString(time.Hour);
                textBox2.Text = Convert.ToString(time.Minute);
                textBox3.Text = Convert.ToString(time.Second);
            }
        }
    }
}
