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
    public partial class Form3 : Form
    {
        public class Account
        {
            private int creditNo;
            private decimal balance;// balance 余额
            public List<string> flow=new List<string>();//账户流水

            public Account()
            {
                Random r = new Random();
                creditNo = r.Next(100000, 500000);
                balance = 100;
            }
            public decimal Balance
            {
                get
                {
                    return this.balance;
                }
            }

            public int CreditNo
            {
                get
                {
                    return this.creditNo;
                }
            }

            public bool WithDraw(decimal money, out string message)
            {
                if (money < 0)
                {
                    message = "操作失败！\n请输入正确金额！";
                    return false;
                }
                else if (balance >= money)
                {
                    balance -= money;
                    //message = "取款成功！\n取款" + money + "元\n当前余额：" + balance ;
                    //this.flow.Add(string.Format("于{0}年{1}月{2}日{3}：{4}取款{5}元", System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, money));
                    message = string.Format("于{0}年{1}月{2}日{3}:{4} 取款: {5}元 余额：{6}元", System.DateTime.Now.Year,System.DateTime.Now.Month,System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, money,balance);
                    return true;
                }

                else
                {
                    message = "操作失败！\n余额不足！\n您只有："+balance+"元！";
                    return false;
                }

            }

            public bool Deposit(decimal money, out string message)
            {
                if (money <= 0)
                {
                    message = "操作失败！\n请输入正确金额！";
                    return false;
                }
                else
                {
                    balance += money;
                    message = string.Format("于{0}年{1}月{2}日{3}:{4} 存款: {5}元 余额：{6}元", System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute, money,balance);
                    return true;
                }

            }

        }

        Account account;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.Text = "银行账户";
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            account = new Account();
            string message = string.Format("创建账户成功！\n用户卡号为：{0}", account.CreditNo);
            lblShow.Text = "\n" + message + "\n";
            account.flow.Add(message);
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null) { message = "请先创建账户！";lblShow.Text = message; }
            else if(textBox1.Text=="")
            {
                message = "请先输入金额！";lblShow.Text = message;
            }
            else
            {
                decimal money = decimal.Parse(textBox1.Text);
                account.WithDraw(money,out message);
                lblShow.Text = message;
            }
            account.flow.Add(message);
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null) { message = "请先创建账户！";lblShow.Text = message; }
            else if (textBox2.Text == "")
            {
                message = "请先输入金额！"; lblShow.Text = message;
            }
            else
            {
                decimal money = decimal.Parse(textBox2.Text);
                account.Deposit(money, out message);
                lblShow.Text = message;
            }
            account.flow.Add(message);
        }

        private void Inquiry_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null) { message = "请先创建账户！";lblShow.Text = message; }
            else
            {
                lblShow.Text = string.Format("账户：{1}\n账户余额：{0}元", account.Balance,account.CreditNo);
            }
            
        }

        private void ShowFlow_Click(object sender, EventArgs e)
        {
            string message;
            message = account.flow[0];
            for(int i = 1; i < account.flow.Count; i++)
            {
                message += "\n" + account.flow[i];

            }
            lebShow2.Text = message;
        }
    }
}
