using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DSProject
{
    public partial class Form1 : Form
    {
        public Trie obj1 = new Trie();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void new_()
        {
            StreamReader infile = new StreamReader("../../words.txt");
            string reader;
            reader = infile.ReadLine();
            while (reader != null)
            {
                obj1.insert(reader);
                reader = infile.ReadLine();
            }
            infile.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new_();
            Form2 obj = new Form2(obj1);
            this.Hide();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
