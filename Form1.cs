using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = txtTyppingbox;
        }

        private void btnSending_Click(object sender, EventArgs e)
        {
            string input = txtTyppingbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            string currentTime = DateTime.Now.ToString("tt h:mm");

            string finalMsg = $"{input}  ({currentTime})";

            lstChatlist.Items.Add(finalMsg);

            this.Text = $"EchoMessenger - 메시지 개수: {lstChatlist.Items.Count}개";

            txtTyppingbox.Clear();
            txtTyppingbox.Focus();
        }

        private void txtTyppingbox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSending.PerformClick();
            }
        }
    }
}
