using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "";
            groupBox2.Text = "";
            label1.Text = "チェックボックス１：" + chkCheck1.Checked;
            label2.Text = "ラジオボタン１：" + rboRadio1.Checked;
            label3.Text = "ラジオボタン２：" + rboRadio2.Checked;
            label4.Text = "ラジオボタン３：" + rboRadio3.Checked;
            label5.Text = "ラジオボタン４：" + rboRadio4.Checked;
            label6.Text = "数値：" + numericUpDown1.Value;
        }

        private void chkCheck1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "チェックボックス１：" + chkCheck1.Checked;
        }

        private void rboRadio1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "ラジオボタン１：" + rboRadio1.Checked;
            label3.Text = "ラジオボタン２：" + rboRadio2.Checked;
        }

        private void rboRadio3_CheckedChanged_1(object sender, EventArgs e)
        {
            label4.Text = "ラジオボタン３：" + rboRadio3.Checked;
            label5.Text = "ラジオボタン４：" + rboRadio4.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = "数値：" + numericUpDown1.Value;
        }
    }
}
