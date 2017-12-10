namespace txtChat
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.btn_send = new System.Windows.Forms.Button();
            this.chat_output = new System.Windows.Forms.RichTextBox();
            this.chat_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(797, 585);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // chat_output
            // 
            this.chat_output.Location = new System.Drawing.Point(13, 13);
            this.chat_output.Name = "chat_output";
            this.chat_output.ReadOnly = true;
            this.chat_output.Size = new System.Drawing.Size(859, 566);
            this.chat_output.TabIndex = 1;
            this.chat_output.Text = "";
            // 
            // chat_input
            // 
            this.chat_input.Location = new System.Drawing.Point(13, 587);
            this.chat_input.Name = "chat_input";
            this.chat_input.Size = new System.Drawing.Size(778, 20);
            this.chat_input.TabIndex = 2;
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 620);
            this.Controls.Add(this.chat_input);
            this.Controls.Add(this.chat_output);
            this.Controls.Add(this.btn_send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatWindow";
            this.Opacity = 0.95D;
            this.Text = "txtChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_send;
        public System.Windows.Forms.RichTextBox chat_output;
        public System.Windows.Forms.TextBox chat_input;
    }
}

