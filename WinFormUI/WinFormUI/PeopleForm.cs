using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<String> palabras = new List<String>();
        public PeopleForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //listBox1.DataSource = palabras;
            //listBox1.Update();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            palabras.Add(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            //listBox1.ClearSelected();
            listBox1.Update();


        }
    }
}
