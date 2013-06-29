namespace Sendmail
{
    partial class frmSendmail
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbSrv = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(355, 273);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbSrv
            // 
            this.tbSrv.Location = new System.Drawing.Point(92, 12);
            this.tbSrv.Name = "tbSrv";
            this.tbSrv.Size = new System.Drawing.Size(150, 20);
            this.tbSrv.TabIndex = 1;
            this.tbSrv.Text = "localhost:25";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(92, 38);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(150, 20);
            this.tbFrom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMTP Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bcc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Message:";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(92, 64);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(150, 20);
            this.tbTo.TabIndex = 8;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(12, 139);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(418, 128);
            this.tbMessage.TabIndex = 9;
            // 
            // tbBcc
            // 
            this.tbBcc.Location = new System.Drawing.Point(283, 38);
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(150, 20);
            this.tbBcc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cc:";
            // 
            // tbCc
            // 
            this.tbCc.Location = new System.Drawing.Point(283, 12);
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(150, 20);
            this.tbCc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subject:";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(92, 90);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(338, 20);
            this.tbSubject.TabIndex = 14;
            // 
            // frmSendmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 308);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBcc);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbSrv);
            this.Controls.Add(this.btnSend);
            this.Name = "frmSendmail";
            this.Text = "Sendmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbSrv;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSubject;
    }
}

