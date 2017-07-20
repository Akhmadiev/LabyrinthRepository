using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int port = Convert.ToInt32(PortTextBox.Text);
            string server = ServerTextBox.Text;
            
            GameForm form = new GameForm(name, port, server);
            form.Show();
            this.Hide();
        }
    }
}
