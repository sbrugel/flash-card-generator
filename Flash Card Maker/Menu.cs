using System;
using System.IO;
using System.Windows.Forms;

namespace Flash_Card_Maker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            // handler for version checking here
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

        private void exportCSVButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Flash Card Set|*.fcards";
            open.Title = "Select Set";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(open.FileName))
                {
                    MessageBox.Show(sr.ReadLine() + " has been selected. Now choose where to save the CSV.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "CSV|*.csv";
                    dialog.Title = "Export CSV";
                    DialogResult save = dialog.ShowDialog();

                    if (res == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(dialog.FileName, false))
                        {
                            string contents = "";
                            string s;
                            while ((s = sr.ReadLine()) != null)
                            {
                                contents += "\"" + s.Replace("|||", "\",\"") + "\"\n";
                            }
                            sw.Write(contents);
                        }
                        MessageBox.Show("Exported CSV.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
