using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Flash_Card_Maker
{
    public partial class ViewWin : Form
    {
        readonly string loadFrom = "C:\\Users\\Simon\\Desktop\\first test.fcards";
        List<string> frontContents = new List<string>();
        List<string> backContents = new List<string>();
        int listIterator = 0;
        bool isFront = true;

        public ViewWin()
        {
            InitializeComponent();
            using (StreamReader sr = File.OpenText(loadFrom))
            {
                string s = "";
                setTitleText.Text = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    frontContents.Add(s.Split("|||")[0]);
                    backContents.Add(s.Split("|||")[1]);
                }
            }
            UpdateCardContents(listIterator);
        }

        private void UpdateCardContents(int index)
        {
            isFront = true;
            flashCard.Text = frontContents[index];
        }

        private void flashCard_Click(object sender, System.EventArgs e)
        {
            isFront = !isFront;
            flashCard.Text = !isFront ? backContents[listIterator] : frontContents[listIterator];
            flashCard.Font = new System.Drawing.Font("Segoe UI", !isFront ? 14 : 28);
        }
    }
}
