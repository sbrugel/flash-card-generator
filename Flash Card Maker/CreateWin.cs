using System;
using System.IO;
using System.Windows.Forms;

namespace Flash_Card_Maker
{
    public partial class CreateWin : Form
    {
        public CreateWin(string loadFrom = "")
        {
            InitializeComponent();
            cardSetData.ColumnCount = 2;
            cardSetData.Columns[0].Name = "Front";
            cardSetData.Columns[1].Name = "Back";

            if (!loadFrom.Equals(""))
            {
                if (SubstringFromTo(loadFrom, loadFrom.Length - 3, loadFrom.Length).Equals("csv"))
                {
                    using (StreamReader sr = File.OpenText(loadFrom))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            // substrings remove the quotes from each item
                            cardSetData.Rows.Add(new object[] { SubstringFromTo(s.Split(",")[0], 1, s.Split(",")[0].Length - 1), 
                                SubstringFromTo(s.Split(",")[1], 1, s.Split(",")[1].Length - 1) });
                        }
                    }
                } else
                {
                    using (StreamReader sr = File.OpenText(loadFrom))
                    {
                        string s = "";
                        setNameText.Text = sr.ReadLine();
                        while ((s = sr.ReadLine()) != null)
                        {
                            cardSetData.Rows.Add(new object[] { s.Split("|||")[0], s.Split("|||")[1] });
                        }
                    }
                }
            }
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            if (cardFrontText.Text.Equals("") || cardBackText.Text.Equals(""))
            {
                MessageBox.Show("Both the front and back text fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cardSetData.Rows.Add(new object[] { cardFrontText.Text, cardBackText.Text });
            cardFrontText.Text = "";
            cardBackText.Text = "";
        }

        private void saveSetButton_Click(object sender, EventArgs e)
        {
            if (setNameText.Text.Equals(""))
            {
                MessageBox.Show("You must give a title to the set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < cardSetData.Rows.Count - 1; i++)
            {
                if (cardSetData.Rows[i].Cells["Front"].Value == null || cardSetData.Rows[i].Cells["Back"].Value == null)
                {
                    MessageBox.Show("One or more cards are missing either front or back contents, cannot save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Flash Card Set|*.fcards";
            dialog.Title = "Save Set";
            DialogResult res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName, false))
                {
                    sw.WriteLine(setNameText.Text);
                    foreach (DataGridViewRow row in cardSetData.Rows)
                    {
                        if (row.Cells["Front"].Value == null) break;

                        sw.WriteLine(row.Cells["Front"].Value + "|||" + row.Cells["Back"].Value);
                    }
                    MessageBox.Show("Set data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Flash Card Set|*.fcards";
            open.Title = "Import Set";
            DialogResult res = open.ShowDialog();

            if (res == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(open.FileName))
                {
                    string s = "";
                    sr.ReadLine(); // don't need the title for this
                    while ((s = sr.ReadLine()) != null)
                    {
                        cardSetData.Rows.Add(new object[] { s.Split("|||")[0], s.Split("|||")[1] });
                    }
                }
            }
        }

        /// <summary>
        /// Finds substring between indices (if that's how the plural is spelt!)
        /// </summary>
        /// <param name="str">The string to search.</param>
        /// <param name="from">The starting index of the string to search</param>
        /// <param name="to">The ending index of the string, stop searching here</param>
        /// <returns>The substring of str from the start to end index specified by the code</returns>
        private string SubstringFromTo(string str, int from, int to)
        {
            try
            {
                if (str.Substring(from, to - from).Equals(""))
                {
                    return "None";
                }
                return str.Substring(from, to - from);
            }
            catch (Exception ex)
            {
                return "None";
            }
        }
    }
}
