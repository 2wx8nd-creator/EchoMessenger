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

            if (string.IsNullOrWhiteSpace(txtTyppingbox.Text))
            {
                return;
            }

            string typed_msg;
            typed_msg = txtTyppingbox.Text;

            lstChatlist.Items.Add(typed_msg);

            txtTyppingbox.Clear();
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
