using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaitWndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            button1.Enabled = false;
            waitForm.Show(this);

            string[] strs = new string[1000];
            progressBar1.Value = 0;
            progressBar1.Maximum = 1000;
            for (int i = 0; i < 1000; i++)
                strs[i] = i.ToString();
            foreach (string num in strs)
            {
                textBox1.Text += num + ";";
                textBox1.Refresh();

                progressBar1.Value++;
                progressBar1.Refresh();
            }
            button1.Enabled = true;
            waitForm.Close();
        }
    }
}
