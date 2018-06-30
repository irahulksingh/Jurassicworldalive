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

namespace iFaceRecognition
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
        //    Thread t = new Thread(new ThreadStart(startForm));
        //    t.Start();
        //    Thread.Sleep(5000);
        //    InitializeComponent();
        //    t.Abort();
        //    InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {


            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            InitializeComponent();
            //frmiFace fc = new frmiFace();
            //fc.Show();
            //this.Hide();
            //frmSplashScreen fs = new frmSplashScreen();

        }
        public void startForm()
        {
            Application.Run(new frmSplashScreen());
        }
    }
}
