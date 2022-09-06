using System;
using System.Windows.Forms;

namespace Flash_Card_Maker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateWin().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Flash Card Set|*.fcards";
            open.Title = "Edit Set";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                new CreateWin(open.FileName).Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Flash Card Set|*.fcards";
            open.Title = "Edit Set";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                new ViewWin(open.FileName).Show();
            }
        }
    }
}
