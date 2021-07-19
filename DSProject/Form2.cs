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
    public partial class Form2 : Form
    {
        Trie obj2 = new Trie();
        public Form2(Trie obj2)
        {
            InitializeComponent();
            StreamReader infile = new StreamReader("../../words.txt");
            string reader;
            reader = infile.ReadLine();
            while (reader != null)
            {
                obj2.insert(reader);
                reader = infile.ReadLine();
            }
            infile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3(obj2);
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4(obj2);
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5(obj2);
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6(obj2);
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
