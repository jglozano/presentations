namespace PooledClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCall = new System.Windows.Forms.Button();
            this.btnJITA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(12, 9);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(91, 48);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "Call Pooled Component";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnJITA
            // 
            this.btnJITA.Location = new System.Drawing.Point(156, 9);
            this.btnJITA.Name = "btnJITA";
            this.btnJITA.Size = new System.Drawing.Size(91, 48);
            this.btnJITA.TabIndex = 1;
            this.btnJITA.Text = "Call JITA Component";
            this.btnJITA.UseVisualStyleBackColor = true;
            this.btnJITA.Click += new System.EventHandler(this.btnJITA_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 67);
            this.Controls.Add(this.btnJITA);
            this.Controls.Add(this.btnCall);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Pooled Client Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnJITA;
    }
}