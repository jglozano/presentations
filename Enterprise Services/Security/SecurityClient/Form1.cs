namespace SecurityClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.EnterpriseServices;
    using System.Text;
    using System.Windows.Forms;

    using SecurityDemo;

    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISecuredComponent cmp = new SecuredComponent();
                int x = Int32.Parse(txtInputX.Text);
                int y = Int32.Parse(txtInputY.Text);
                int result;

                using (cmp as IDisposable)
                {
                    result = cmp.Add(x, y);
                }

                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}