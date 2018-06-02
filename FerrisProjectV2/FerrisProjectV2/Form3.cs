using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Project Made by Emanuele Siena*/

namespace FerrisProjectV2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static int CH, CM, CS;
        public const int n = 1;

        private void Form3_Load(object sender, EventArgs e)
        {

            CH = 0;
            CM = 0;
            CS = 0;

            this.ControlBox = false;


            label1.Text = "0" + CH;
            label2.Text = "0" + CM;
            label3.Text = "0" + CS;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CM++;
            if (CM < 10)
            {
                label2.Text = "0" + CM;
            }
            else
            {
                label2.Text = CM.ToString();
            }
            if(CM>59)
            {
                CM = 0;
                label2.Text = "0" + CM;
                //MessageBox.Show("Impossibile superare questa cifra.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CS++;
            if (CS < 10)
            {
                label3.Text = "0" + CS;
            }
            else
            {
                label3.Text = CS.ToString();
            }
            if (CS > 59)
            {
                CS = 0;
                label3.Text = "0" + CS;
                //MessageBox.Show("Impossibile superare questa cifra.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CH--;
            if (CH < 10)
            {
                label1.Text = "0" + CH;
            }
            else
            {
                label1.Text = CH.ToString();
            }
            if (CH<0)
            {
                CH = 99;
                label1.Text = CH.ToString();
                //MessageBox.Show("Troppo poco, non credi?");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CM--;
            if (CM < 10)
            {
                label2.Text = "0" + CM;
            }
            else
            {
                label2.Text = CM.ToString();
            }
            if (CM < 0)
            {
                CM = 59;
                label2.Text = CM.ToString();
                //MessageBox.Show("Troppo poco, non credi?");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CS--;
            if (CS < 10)
            {
                label3.Text = "0" + CS;
            }
            else
            {
                label3.Text = CS.ToString();
            }
            if (CS < 0)
            {
                CS = 59;
                label3.Text = CS.ToString();
                //MessageBox.Show("Troppo poco, non credi?");
            }
        }

        private Timer Time;
        private void button7_Click(object sender, EventArgs e)
        {
            /*if(Time != null)
            {
                Time.Enabled = true;
                return;
            }*/
                
            if (CS != 0 || CH != 0 || CM != 0)
            {
                Time = new Timer();


                Time.Tick += new EventHandler(this.FinalCountdown);

                Time.Interval = 1000;
                Time.Enabled = true;

                Disable();

                //Time.Start();


            }
            else
            {
                MessageBox.Show("Inserisci qualcosa!");
            }
                




        }

        private void Disable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
        }

        private void Enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = true;
        }
        

        private void FinalCountdown(object sender, EventArgs e)
        {
            
            CS = CS - n;
            if (CS < 10)
            {
                label3.Text = "0" + CS;
            }
            else
            {
                label3.Text = CS.ToString();
            }

            if (CS<0)
            {
                CS = 59;
                label3.Text = CS.ToString();
                CM = CM - n;
                if (CM < 10)
                {
                    label2.Text = "0" + CM;
                }
                else
                {
                    label2.Text = CM.ToString();
                }
                if(CM<0)
                {
                    CM = 59;
                    label2.Text = CM.ToString();
                    CH = CH - n;
                    if (CH < 10)
                    {
                        label1.Text = "0" + CH;
                    }
                    else
                    {
                        label1.Text = CH.ToString();
                    }
                    if(CH<0)
                    {
                        CH = 0;
                        label1.Text = CH.ToString();
                    }
                }
            }
            if (CH == 0 && CM == 0 && CS == 0)
            {
                Time.Stop();
                CH = 0;
                CM = 0;
                CS = 0;
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";
                MessageBox.Show("TEMPO CONCLUSO.");
                Enable();
                //Time.Enabled = false;
                return;

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CH = 0;
            CM = 0;
            CS = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1.recheck = false;
            this.Close();
            try
            { Time.Stop(); }
            catch
            { Time = new Timer(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CH++;
            if (CH < 10)
            {
                label1.Text = "0" + CH;
            }
            else
            {
                label1.Text = CH.ToString();
            }
            if (CH>99)
            {
                CH = 0;
                label1.Text = "0" + CH;
                //MessageBox.Show("Non pensi sia un po' troppo?");
            }

        }
    }
}
