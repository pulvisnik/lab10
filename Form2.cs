using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form2 : Form
    {
         ProcessorClass cpu = new ProcessorClass(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cpu.modelCPU = textBox1.Text;
            cpu.country = textBox2.Text;
            cpu.kernel = int.Parse(textBox3.Text);
            cpu.typeMemor = textBox4.Text;
            cpu.potokiv = int.Parse(textBox5.Text);
            cpu.VidCard = checkBox1.Checked;
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(cpu != null)
            {
                textBox1.Text = cpu.modelCPU;
                textBox2.Text = cpu.country;
                textBox3.Text = Convert.ToString(cpu.kernel);
                textBox4.Text = cpu.typeMemor;
                textBox5.Text = Convert.ToString(cpu.potokiv);
                checkBox1.Checked = cpu.VidCard;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
