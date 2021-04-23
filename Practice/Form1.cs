using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public int count { get; set; } = 0;
        const int limits = 174;
        bool bCheck = false;
        Color GetRandomColor(int i)
        {

            Random random = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            int limit = random.Next(names.Length) + i;
            if (limit == limits)
                return Color.Transparent;

            KnownColor randomColorName = names[limit];
            

            return Color.FromKnownColor(randomColorName);
        }

        void looping()
        {
            if (bCheck == true)
                timer1.Enabled = true;
            int i = 1;
            
            this.panel1.BackColor = GetRandomColor(count);
            
            this.button1.BackColor = GetRandomColor(count + 1);
            this.ResumeLayout();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bCheck = false;
            timer1.Enabled = false;
            if (foxLabel1.Text == null)
                this.foxLabel1.Text = "눌러보시오";
            this.button1.Text = null;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            bCheck = true;
            timer1.Enabled = true;
            if (button1.Text == null)
                this.button1.Text = "눌러보시오";
            this.foxLabel1.Text = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = 20;
            looping();
        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
