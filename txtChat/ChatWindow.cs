using System;
using System.Windows.Forms;

namespace txtChat
{
    public partial class ChatWindow : Form
    {
        public ChatWindow()
        {
            InitializeComponent();
            chat_input.KeyDown += new KeyEventHandler(chat_input_KeyDown);
        }

        public void ReplaceChat(string text)
        {
            chat_output.Text = text;
            chat_output.SelectionStart = chat_output.Text.Length;
            chat_output.ScrollToCaret();
        }

        public void AppendChat(string[] lines)
        {

        }

        public void btn_send_Click(object sender, EventArgs e)
        {
            Program.SendMessage(chat_input.Text);
            chat_input.Clear();
        }

        public void chat_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.SendMessage(chat_input.Text);
                chat_input.Clear();
            }
        }
    }
}
