using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var t = new Task(() =>
            {
                while (progressBar1.Value != progressBar1.Maximum)
                {
                    Thread.Sleep(50);
                    progressBar1.Value++;
                }
            });

            t.Start();

            t.Wait();
            
        }
    }
}
