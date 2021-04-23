using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace base64Decoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void decode(string origin)
        {
            byte[] abc = Convert.FromBase64String(origin);
            string base64  = Encoding.UTF8.GetString(abc);
            rtbDecode.AppendText(base64);
        }

        void encode(string origin)
        {
            byte[] convertOrigin = Encoding.UTF8.GetBytes(origin);
            string base64 = Convert.ToBase64String(convertOrigin);
            rtbDecode.AppendText(base64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decode(rtbOrigin.Text);
            if (rtbOrigin.Text != "")
                rtbOrigin.Clear();
            //if (!(rtbOrigin.Text == null || rtbDecode.Text == null))
            //{
            //    rtbOrigin.Clear();
            //    rtbDecode.Clear();
            //}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            encode(rtbOrigin.Text);
        }

        private void dungeonToggleButton1_ToggledChanged()
        {
            if (dungeonToggleButton1.Toggled)
            {
                rtbOrigin.Clear();
                rtbDecode.Clear();
            }
        }
    }
}
