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
namespace log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = File.ReadAllText("Us.txt");
            String[] str= text.Split('@');
            String userName=str[0];
            String password= str[1];
            if(textBox1.Text== userName && textBox2.Text==password){
                Form Form2 = new Form2();
                this.Hide();
                Form2.Show();
       
                
                
            }else{
            
            MessageBox.Show("There is something wrong");
            }


            }
        }
    }

