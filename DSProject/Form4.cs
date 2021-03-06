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
    public partial class Form4 : Form
    {
        public Form4(Trie obj)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trie obj1 = new Trie();
            StreamReader infile = new StreamReader("../../words.txt");
            string reader;
            reader = infile.ReadLine();
            while (reader != null)
            {
                obj1.insert(reader);
                reader = infile.ReadLine();
            }
            infile.Close();
            string word = textBox1.Text;
            if(obj1.Search(word))
            {
                MessageBox.Show("Word exists");
            }
            else
            {
                MessageBox.Show("Word does not exist");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
