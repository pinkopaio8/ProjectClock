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
    public partial class Form1 : Form
    {


        public static int OO, MM, SS;
        public static int TO, TM, TS;
        public static int S, M, O;

        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.HappyDay);

        Timer Tempo = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
            Tempo.Interval = 1000; 

            Tempo.Tick += new EventHandler(this.Tempo_Clock);


            Tempo.Start();

        }

        /*Project Made by Emanuele Siena*/

        public static bool _musica = true;
        public static bool check = false;
        public void Sveglia()
        {
            if (Form1.O == TO && Form1.M == TM && Form1.S == TS && check == true)
                {
                    player.Play();
                    check = false;
                    MessageBox.Show("Tempo di alzarsi!");
                }
        }

        public override string ToString()
        {
            return "0";
        }

        /*public void ContaTempo()
        {

            

            Form2.NewVarS = Form2.NewVarS - 1;

            if (Form2.NewVarS < 0)
            {
                Form2.NewVarS = 60 - (Form2.NewVarS * -1);

                Form2.NewVarM = Form2.NewVarM - 1;

                if (Form2.NewVarM < 0)
                {
                    Form2.NewVarM = 0;

                    Form2.NewVarO = Form2.NewVarO - 1;

                    if (Form2.NewVarO < 0)
                    {
                        Form2.NewVarO = 0;

                    }
                }
            }

            if (Form2.NewVarS <0)
            {
                label3.Text = "Tempo rimanente: " + Form2.NewVarO.ToString() + " ore, " + Form2.NewVarM.ToString() + " minuti.";
            }
            else
            {
                label3.Text = "Tempo rimanente: " + Form2.NewVarO.ToString() + " ore, " + Form2.NewVarM.ToString() + " minuti e " + Form2.NewVarS.ToString() + " secondi.";
            }
            if(Form2.NewVarM < 0 && Form2.NewVarS < 0)
            {
                label3.Text = "Tempo rimanente: " + Form2.NewVarO.ToString() + " ore.";
            }
        }*/

        private void Tempo_Clock(object sender, EventArgs e)
        {
            //string ORAS, MINS, SECS;

            if (check == true)
            {
                /*if(Form1.O < 10)
                {
                    ORAS = "0" + Form1.TO.ToString();
                }
                else
                {
                    ORAS = Form1.TO.ToString();
                }
                if(Form1.M < 10)
                {
                    MINS = "0" + Form1.TM.ToString();
                }
                else
                {
                    MINS = Form1.TM.ToString();
                }
                if(Form1.S < 10)
                {
                    SECS = "0" + Form1.TS.ToString();
                }
                else
                {
                    SECS = Form1.TS.ToString();
                }*/
                label2.Text = "Sveglia settata alle " + Form1.TO.ToString() + ":" + Form1.TM.ToString() + ":" + Form1.TS.ToString();
                //ContaTempo();
            }
            if(check==false)
            {
                label2.Text = "Sveglia non settata.";
                label3.Text = "";
            }

            S = DateTime.Now.Second;
            O = DateTime.Now.Hour;
            M = DateTime.Now.Minute;

            ORA.Text = O.ToString();
            MIN.Text = M.ToString();
            SEC.Text = S.ToString();



            if (O < 10)
            {
                ORA.Text = "0" + O;
            }


            if (M < 10)
            {
                MIN.Text = "0" + M;
            }


            if (S < 10)
            {
                SEC.Text = "0" + S;
            }

            Sveglia();

        }

        private void DOT_Click(object sender, EventArgs e)
        {

        }

        private void setTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recheck == false)
            {
                Form3 thirdForm = new Form3();
                thirdForm.Show();
                recheck = true;
            }
            else
            {

            }
        }

        private void ORA_Click(object sender, EventArgs e)
        {

        }

        private void MIN_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SEC_Click(object sender, EventArgs e)
        {

        }

        public static bool recheck = false;
        private void setSvegliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recheck == false)
            {
                Form2 secondForm = new Form2();
                secondForm.Show();
                recheck = true;
            }
            else
            {

            }
        }

        

    }
}
