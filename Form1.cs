using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace nehisa
{
    public partial class Form1 : Form
    {
        public proces proces1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox1.Text = of.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.proces1 = new proces();

            StreamReader sr = new StreamReader(textBox1.Text);
            textBox2.Text = sr.ReadToEnd();
            sr.Close();

            string test;

            int i, j;
            int s;
            char[] c = null;
            c = new char[5];

            StreamReader sr2 = new StreamReader(textBox1.Text);
            test = sr2.ReadLine();
            this.proces1.n = Convert.ToInt32(test);

            this.proces1.NT = new Int32[this.proces1.n];
            this.proces1.NM = new Int32[this.proces1.n];
            this.proces1.P = new Int32[this.proces1.n];
            


            test = sr2.ReadLine();
            string[] exploded2 = test.Split(' ');
            
            for (i = 0; i < this.proces1.n; i++)
            {
                this.proces1.NT[i] = Convert.ToInt32(exploded2[i]);
            }

            test = sr2.ReadLine();
            string[] exploded3 = test.Split(' ');

            for (i = 0; i < this.proces1.n; i++)
            {
                this.proces1.NM[i] = Convert.ToInt32(exploded3[i]);
            }

            test = sr2.ReadLine();
            string[] exploded4 = test.Split(' ');

            for (i = 0; i < this.proces1.n; i++)
            {
                this.proces1.NM[i] = Convert.ToInt32(exploded4[i]);
            }

            test = sr2.ReadLine();
            this.proces1.m = Convert.ToInt32(test);

            this.proces1.permutacja = new Int32[this.proces1.n + this.proces1.m];

            test = sr2.ReadLine();
            string[] exploded5 = test.Split(' ');

            for (i = 0; i < this.proces1.n+this.proces1.m; i++)
            {
                this.proces1.permutacja[i] = Convert.ToInt32(exploded5[i]);
            }

            sr2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;

            StreamWriter writer = new StreamWriter("wyniki1.txt");

            for (i = 0; i < this.proces1.n; i++)
            {
                writer.Write(this.proces1.S[i]);
                writer.Write(' ');
                writer.WriteLine(this.proces1.C[i]);
            }

            writer.WriteLine(this.proces1.cmax);
            
            writer.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;

            this.proces1.C = new Int32[this.proces1.n];
            this.proces1.S = new Int32[this.proces1.n];

            for (i = 0; i < this.proces1.n; i++)
            {
                this.proces1.C[i] = i;
                this.proces1.S[i] = i;
            }
                this.proces1.cmax = 472057;
        }
    }

    public class proces
    {
        public int n = 0;
        public int m = 0;
        public int[] NT;
        public int[] NM;
        public int[] P;
        public int[] permutacja;

        public int[] C;
        public int[] S;

        public int cmax;
        
        
    }
}
