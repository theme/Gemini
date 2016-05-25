using System;
using System.Windows.Forms;

namespace Gemini.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
