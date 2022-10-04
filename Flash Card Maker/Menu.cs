using System;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Flash_Card_Maker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            string latestVersion = versionNumber.Text;
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load("https://github.com/sbrugel/flash-card-generator/blob/master/VERSION.txt");
                var nodes = document.DocumentNode.SelectNodes("//td");
                foreach (var node in nodes)
                {
                    if (!node.InnerText.Equals(""))
                    {
                        latestVersion = node.InnerText;
                        break;
                    }
                }
            } catch (Exception ex)
            {
                // ignore it - probably no internet
            }
            
            if (!latestVersion.Equals(versionNumber.Text))
            {
                versionNumber.Text += " (update available)";
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            new CreateWin().Show();
        }

        private void editButton_Click(object sender, EventArgs e)
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Flash Card Set|*.fcards";
            open.Title = "View Set";
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

        private void importCSVButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "CSV|*.csv";
            open.Title = "Select CSV";
            DialogResult res = open.ShowDialog();

            // TODO: import CSV and open up contents in CreateWin (untitled set)
        }

        private void mcButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Flash Card Set|*.fcards";
            open.Title = "Multiple Choice";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                new MultipleChoice(open.FileName).Show();
            }
        }
    }
}
