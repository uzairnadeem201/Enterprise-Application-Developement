using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string firstName, lastName, subject;
        bool preRequisited;
        List<String> subjects;
        public Form1()
        {
            InitializeComponent();
            this.subjects = new List<String>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = this.textBox1.Text;
            lastName = this.textBox2.Text;
            preRequisited = this.checkBox1.Checked;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                this.label4.Text = "Please fill all fields";
                return;
            }
            this.label4.Text = $"First Name: {firstName}, Last Name: {lastName},preRequisited: {preRequisited}\n" + $"Subjects Added: ";
            foreach (string x in this.subjects)
            {
              this.label4.Text = this.label4.Text + " , " + x ;
             

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String subject;
            if(this.comboBox1.SelectedItem != null)
            {
                subject = this.comboBox1.SelectedItem.ToString();
                if (subjects.Contains(subject))
                {
                    this.label4.Text = $"{subject} is already added";
                    return;
                }
                subjects.Add(subject);
                this.label4.Text = $"{subject} has been added";
                
            }
            else
            {
                this.label4.Text = "Please Select a Subject";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String subject;
            if (this.comboBox1.SelectedItem != null)
            {
                subject = this.comboBox1.SelectedItem.ToString();
                if (!subjects.Contains(subject))
                {
                    this.label4.Text = $"{subject} has not been added yet";
                    return;
                }
                subjects.Remove(subject);
                this.label4.Text = $"{subject} has been removed";

            }
            else
            {
                this.label4.Text = "Please Select a Subject";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }



    }
}
