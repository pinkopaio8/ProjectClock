using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrisProjectV2
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1.OO++;
            if (Form1.OO > 23)
            {
                //MessageBox.Show("Impossibile aumentare ora.");
                Form1.OO = 0;
                textBox1.Text = "0" + Form1.OO.ToString();
            }
            if (Form1.OO < 10)
            {
                textBox1.Text = "0" + Form1.OO.ToString();
            }
            else
            {
                textBox1.Text = Form1.OO.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1.OO--;
            if (Form1.OO < 0)
            {
                //MessageBox.Show("Impossibile diminuire ora.");
                Form1.OO = 23;
                //textBox1.Text = "0" + Form1.OO.ToString();
            }
            if (Form1.OO < 10)
            {
                textBox1.Text = "0" + Form1.OO.ToString();
            }
            else
            {
                textBox1.Text = Form1.OO.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1.MM++;
            if (Form1.MM > 59)
            {
                //MessageBox.Show("Impossibile aggiungere minuti.");
                Form1.MM = 0;
                textBox2.Text = "0" + Form1.MM.ToString();
            }
            if (Form1.MM < 10)
            {
                textBox2.Text = "0" + Form1.MM.ToString();
            }
            else
            {
                textBox2.Text = Form1.MM.ToString();
            } 
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1.MM--;
            if (Form1.MM < 0)
            {
                //MessageBox.Show("Impossibile diminuire minuti.");
                Form1.MM = 59;
                textBox2.Text = Form1.MM.ToString();
            }
            if (Form1.MM < 10)
            {
                textBox2.Text = "0" + Form1.MM.ToString();
            }
            else
            {
                textBox2.Text = Form1.MM.ToString();
            }
            
        }

        /*Project Made by Emanuele Siena*/

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1.SS++;
            if (Form1.SS > 59)
            {
                //MessageBox.Show("Impossibile aumentare secondi.");
                Form1.SS = 0;
                textBox3.Text = "0" + Form1.SS.ToString();
            }
            if (Form1.SS < 10)
            {
                textBox3.Text = "0" + Form1.SS.ToString();
            }
            else
            {
                textBox3.Text = Form1.SS.ToString();
            }
        }

        //public static int NewVarO, NewVarM, NewVarS;

        private void button7_Click(object sender, EventArgs e)
        {


            /*NewVarO = Form1.TO - Form1.O;
            NewVarM = Form1.TM - Form1.M;
            NewVarS = Form1.TS - Form1.S;*/

            Form1.recheck = false;

            Form1.TO = Form1.OO;
            Form1.TM = Form1.MM;
            Form1.TS = Form1.SS;

            Form1.check = true;


            this.Close();

    }

    private void button6_Click_1(object sender, EventArgs e)
        {
            Form1.SS--;
            if (Form1.SS < 0)
            {
                //MessageBox.Show("Impossibile diminuire secondi.");
                Form1.SS = 59;
                textBox3.Text = Form1.SS.ToString();
            }
            if (Form1.SS < 10)
            {
                textBox3.Text = "0" + Form1.SS.ToString();
            }
            else
            {
                textBox3.Text = Form1.SS.ToString();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            Form1.OO = Form1.O;
            Form1.MM = Form1.M;
            Form1.SS = Form1.S;
            if (Form1.O < 10)
            {
                textBox1.Text = "0" + Form1.OO.ToString();
            }
            else
            {
                textBox1.Text = Form1.OO.ToString();
            }
            if (Form1.M < 10)
            {
                textBox2.Text = "0" + Form1.MM.ToString();
            }
            else
            {
                textBox2.Text = Form1.MM.ToString();
            }
            if (Form1.S < 10)
            {
                textBox3.Text = "0" + Form1.SS.ToString();
            }
            else
            {
                textBox3.Text = Form1.SS.ToString();
            }

            /*Form1.OO = int.Parse(textBox1.Text);
            Form1.MM = int.Parse(textBox2.Text);
            Form1.SS = int.Parse(textBox3.Text);*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.recheck = false;
        }
    }
}
