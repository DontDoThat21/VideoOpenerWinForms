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
using System.Windows.Threading;
using WMPLib;

namespace FormsVideoPlayer
{
    public partial class MainForm : Form
    {

        public int hour = 5; // our current hour..
        //string key = "HKEY_LOCAL_MACHINE\\SOFTWARE\\" + Application.ProductName + "\\" + Application.ProductVersion;
        //string valueName = "First Launch";

        //string[] videos = new string[]
        //{
        //    "fireplace.mp4",
        //    "mountainfire.mp4",
        //    "ocean.mp4"
        //};

        public MainForm()
        {
            InitializeComponent();
            StartTimer();
            OpenVideo();           
        }

        private void OpenVideo()
        {
            string videoPath;

            if (hour > 5 && hour < 10)
            {
                axWindowsMediaPlayer1.URL = "fireplace.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //axWindowsMediaPlayer1.fullScreen = true;

            }
            else if (hour > 10 && hour < 13)
            {
                axWindowsMediaPlayer1.URL = "mountainfire.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //axWindowsMediaPlayer1.fullScreen = true;
            }
            else if (hour > 13 && hour < 17)
            {
                axWindowsMediaPlayer1.URL = "ocean.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //axWindowsMediaPlayer1.fullScreen = true;
            }
            else
            {
                axWindowsMediaPlayer1.URL = "mountainfire.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        //private void Aids()
        //{
        //    Yikes frm = new Yikes();
        //    frm.Visible = true;
        //    frm.Enabled = true;
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //Aids();
            //Aids();
        }

        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3); // Every three seconds it should be updating the global time.. doesnt need to be that fast/updated.
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour; // That's it really..
            //OpenVideo();
        }
    }
}
