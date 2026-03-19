using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSending_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtTyppingbox.Text;

            lstChatlist.Items.Add(typed_msg);
        }
    }
}
