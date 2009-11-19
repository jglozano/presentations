namespace MyClient
{
    using System;
    using System.Windows.Forms;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    using QueueDemo;

    public class QCClient : Form
    {
        Button m_CallButton;

        public QCClient()
        {
            InitializeComponent();
            //Trigger registration
            QueuedComponent obj = new QueuedComponent();
            ServicedComponent.DisposeObject(obj);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            this.m_CallButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_CallButton
            // 
            this.m_CallButton.Location = new System.Drawing.Point(87, 12);
            this.m_CallButton.Name = "m_CallButton";
            this.m_CallButton.Size = new System.Drawing.Size(96, 58);
            this.m_CallButton.TabIndex = 0;
            this.m_CallButton.Text = "Call Queued Component";
            this.m_CallButton.Click += new System.EventHandler(this.OnCallQC);
            // 
            // QCClient
            // 
            this.ClientSize = new System.Drawing.Size(274, 81);
            this.Controls.Add(this.m_CallButton);
            this.Name = "QCClient";
            this.Text = "Queued Component Demo";
            this.ResumeLayout(false);

        }
        #endregion

        [STAThread]
        static void Main()
        {
            Application.Run(new QCClient());
        }

        void OnCallQC(object sender, EventArgs e)
        {
            IDateInterface dateCmp;
            dateCmp = (IDateInterface)Marshal.BindToMoniker("queue:/new:QueueDemo.QueuedComponent");
            dateCmp.ShowDateTime();
            MessageBox.Show("Made call at " + DateTime.Now.ToString());

            Marshal.ReleaseComObject(dateCmp);
        }
    }
}

