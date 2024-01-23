using System.Net.NetworkInformation;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InitPanel1();
            //InitPanel2();


        }

        //void InitPanel1()
        //{
        //    this.panel1.Controls.Add(new RadioButton()
        //    {
        //        Text = "Value 1",
        //        BackColor = Color.Coral,
        //        Name = "value_1_Radio"
        //    });
        //    this.panel1.Controls.Add(new RadioButton()
        //    {
        //        Text = "Value 2",
        //        BackColor = Color.Coral,
        //        Name = "value_2_RB",
        //        Location = new Point(0, 50)
        //    });
        //}


        //void InitPanel2()
        //{
        //    this.panel2.Controls.Add(new CheckBox()
        //    {
        //        Text = "Value 1",
        //        BackColor = Color.Coral,
        //        Name = "value_1_CheckBox"
        //    });
        //    this.panel2.Controls.Add(new CheckBox()
        //    {
        //        Text = "Value 2",
        //        BackColor = Color.Coral,
        //        Name = "value_2_CB",
        //        Location = new Point(0, 50)
        //    });
        //}

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    label1.Text = trackBar1.Value.ToString();
        //    progressBar1.Value = trackBar1.Value;
        //}

        //private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        //{
        //    this.Text = monthCalendar1.SelectionStart.ToString();
        //}
    }
}