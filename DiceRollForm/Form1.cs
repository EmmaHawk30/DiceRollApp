using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollForm
{
    public partial class Form1 : Form
    {

        public string die1Path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DieOne.png";
        public string die2Path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DieTwo.png";
        public string die3Path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DieThree.png";
        public string die4Path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DieFour.png";
        public string die5Path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DieFive.png";
        public string die6Path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DieSix.png";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pbxDie.ImageLocation = "C:\\Users\\Emma\\Documents\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage";
            Image die1 = Image.FromFile(die1Path);
            pbxDie.SizeMode = PictureBoxSizeMode.AutoSize;
            Image die2 = Image.FromFile(die2Path);
            Image die3 = Image.FromFile(die3Path);
            Image die4 = Image.FromFile(die4Path);
            Image die5 = Image.FromFile(die5Path);
            Image die6 = Image.FromFile(die6Path);

            Random r = new Random();
            int dieRoll = r.Next(1, 6);
            lblResult.Text = dieRoll.ToString();

            

            if(dieRoll == 1)
            {
                pbxDie.Image = die1;
            }
            else if(dieRoll == 2)
            {
                pbxDie.Image = die2;
            }
            else if(dieRoll == 3)
            {
                pbxDie.Image = die3;
            }
            else if(dieRoll == 4)
            {
                pbxDie.Image = die4;
            }
            else if(dieRoll == 5)
            {
                pbxDie.Image = die5;
            }
            else
            {
                pbxDie.Image = die6;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
