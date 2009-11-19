namespace LCEClient
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.EnterpriseServices;

    using LCEDemo;

    public class Publisher : Form
    {
        Button m_PublishButton;

        public Publisher()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            this.m_PublishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_PublishButton
            // 
            this.m_PublishButton.Location = new System.Drawing.Point(88, 48);
            this.m_PublishButton.Name = "m_PublishButton";
            this.m_PublishButton.Size = new System.Drawing.Size(88, 56);
            this.m_PublishButton.TabIndex = 0;
            this.m_PublishButton.Text = "Publish Event";
            this.m_PublishButton.Click += new System.EventHandler(this.OnPublish);
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(264, 189);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.m_PublishButton});
            this.Name = "Publisher";
            this.Text = "LCE Publisher";
            this.ResumeLayout(false);

        }
        #endregion

        static void Main()
        {
            Application.Run(new Publisher());
        }

        void OnPublish(object sender, EventArgs e)
        {
            IDateEvent lceDate = new DateEventClass();
            lceDate.OnShowDate();
        }
    }
}
