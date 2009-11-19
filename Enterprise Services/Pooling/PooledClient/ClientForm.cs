namespace PooledClient
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.EnterpriseServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    using PooledComponent;

    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            using (PoolComponent cmp = new PoolComponent())
            {
            //    PoolComponent cmp = new PoolComponent();
                DateTime dt = cmp.GetDateTime();
                MessageBox.Show(dt.ToString(), "Message from component.");
            }
        }

        private void btnJITA_Click(object sender, EventArgs e)
        {
            JITAComponent cmp = new JITAComponent();

            for (int i = 0; i < 4; i++)
            {
                DateTime dt = cmp.GetDateTime();
                string message = "Call #" + (i+1).ToString() + "\n" + dt.ToString();
                MessageBox.Show(message, "Message from component.");

                Thread.Sleep(1000);
            }
        }
    }
}