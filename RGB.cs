using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class RGB : Form
    {
        public RGB()
        {
            InitializeComponent();
            string strStart = File.ReadAllText("value.json");
            string[] userFromFile = JsonSerializer.Deserialize<string[]>(strStart);
            trackBar1.Value = int.Parse(userFromFile[0]);
            trackBar2.Value = int.Parse(userFromFile[1]);
            trackBar3.Value = int.Parse(userFromFile[2]);
            redCB.Checked = bool.Parse(userFromFile[3]);
            greenCB.Checked = bool.Parse(userFromFile[4]);
            blueCB.Checked = bool.Parse(userFromFile[5]);

            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            
            if (redCB.Checked == true)
            {
                this.BackColor = Color.FromArgb(trackBar1.Value = 0, trackBar2.Value, trackBar3.Value);
            }
            else
            {
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                redValLB.Text = trackBar1.Value.ToString();
            }

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
            if (greenCB.Checked == true)
            {
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value = 0, trackBar3.Value);
            }
            else
            {
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                greenValLB.Text = trackBar2.Value.ToString();
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            
            if (blueCB.Checked == true)
            {
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value = 0);
            }
            else
            {
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                blValLB.Text = trackBar3.Value.ToString();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void redCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void blueCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void redValLB_Click(object sender, EventArgs e)
        {
            redLB.Text = trackBar1.Value.ToString();
        }

        private void greenValLB_Click(object sender, EventArgs e)
        {
            greenLB.Text = trackBar2.Value.ToString();
        }

        private void blValLB_Click(object sender, EventArgs e)
        {
            blueLB.Text = trackBar3.Value.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string[] str = new string[6];
            str[0] = trackBar1.Value.ToString();
            str[1] = trackBar2.Value.ToString();
            str[2] = trackBar2.Value.ToString();
            str[3] = redCB.Checked.ToString();
            str[4] = greenCB.Checked.ToString();
            str[5] = blueCB.Checked.ToString();



            string userInText = JsonSerializer.Serialize(str);
            File.WriteAllText("value.json", userInText);

        }
    }
}
