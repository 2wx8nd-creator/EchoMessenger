namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTyppingbox = new TextBox();
            btnSending = new Button();
            lstChatlist = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century", 16F);
            lblTitle.Location = new Point(40, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EchoMessenger";
            // 
            // txtTyppingbox
            // 
            txtTyppingbox.Location = new Point(40, 378);
            txtTyppingbox.Multiline = true;
            txtTyppingbox.Name = "txtTyppingbox";
            txtTyppingbox.Size = new Size(620, 50);
            txtTyppingbox.TabIndex = 2;
            // 
            // btnSending
            // 
            btnSending.Location = new Point(676, 378);
            btnSending.Name = "btnSending";
            btnSending.Size = new Size(84, 50);
            btnSending.TabIndex = 3;
            btnSending.Text = "보내기";
            btnSending.UseVisualStyleBackColor = true;
            btnSending.Click += btnSending_Click;
            // 
            // lstChatlist
            // 
            lstChatlist.FormattingEnabled = true;
            lstChatlist.Location = new Point(38, 79);
            lstChatlist.Name = "lstChatlist";
            lstChatlist.Size = new Size(720, 289);
            lstChatlist.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstChatlist);
            Controls.Add(btnSending);
            Controls.Add(txtTyppingbox);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTyppingbox;
        private Button btnSending;
        private ListBox lstChatlist;
    }
}
