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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class AddressBook
        {
            string name;
            string phone;
            string emil;
            public AddressBook(string name,string phone,string emil)
            {
                this.name = name;
                this.emil = emil;
                this.phone = phone;
            }//构造函数
            //========******属性设定*****=========//
            public string Name
            {
                get { return name; }
            }

            public string Phone
            {
                get
                {
                    if (phone == null) return "未输入！";
                    else return phone;
                }
                set
                {
                    phone = value;
                }
            }

            public string Emil
            {
                get
                {
                    if (emil == null) return "未输入！";
                    else return emil;
                }
                set
                {
                    emil = value;
                }
            }
            //=========****属性设定***=============//
            //=========***函数***========//
            public string GetMessage()
            {
                return string.Format("姓名：{0}\n电话：{1}\n电子邮箱：{2}", name, phone, emil);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "实验1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressBook addressBook = new AddressBook(textBox1.Text, textBox2.Text, textBox3.Text);
            label4.Text = addressBook.GetMessage();
        }


    }
}
