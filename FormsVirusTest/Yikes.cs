using Microsoft.Win32;
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
using WMPLib;

namespace FormsVirusTest
{
    public partial class Yikes : Form
    {
        public int countOpen = 0;
        string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\" + Application.ProductName + "\\" + Application.ProductVersion;
        string valueName = "First Launch";

        string[] videos = new string[]
        {
            "christmas.mp4",
            "duck.mp4",
            "eggdog.mp4",
            "ricardo.mp4"
        };

        public Yikes()
        {
            // 1 is the first open..
            InitializeComponent();
            Thread.Sleep(1000);
            Random rand = new Random();
            string videoPath = videos[rand.Next(0, 3)];
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            double xOffset = rand.NextDouble();
            double yOffSet = rand.NextDouble();

            Point pt = new Point((int)(Screen.PrimaryScreen.Bounds.Width * xOffset), (int)(Screen.PrimaryScreen.Bounds.Height * yOffSet));
            this.Location = pt;
            countOpen++;
        }

        private void Aids()
        {
            Yikes frm = new Yikes();
            frm.Visible = true;
            frm.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Aids();
            Aids();
        }

        private void W(object sender, EventArgs e)
        {

        }
    }
}
