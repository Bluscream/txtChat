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
        public void LoadChat(string text)
        {
            chat_output.Text = text;
            chat_output.SelectionStart = chat_output.Text.Length;
            chat_output.ScrollToCaret();
        }
        public void ReplaceChat(string text)
        {
            SetText(text);
            SetSelection();
            BScroll();
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

        delegate void SetBScrollCallback();

        private void BScroll()
        {
            
            if (chat_output.InvokeRequired)
            {
                SetBScrollCallback d = new SetBScrollCallback(chat_output.ScrollToCaret);
                chat_output.Invoke(d);
            }
            else
            {

                chat_output.ScrollToCaret();
            }
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
           
            if (chat_output.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                chat_output.Invoke(d, text);
            }
            else
            {
                chat_output.Text = text;
            }
        }
        delegate void SetSelectionCallback();
        
        private void SetSelection()
        {
            
            if (chat_output.InvokeRequired)
            {
                SetSelectionCallback d = new SetSelectionCallback(SetSelection);
                chat_output.Invoke(d);
            }
            else
            {
                chat_output.SelectionStart = chat_output.Text.Length;
            }
        }
    }
}

