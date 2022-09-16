using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Flash_Card_Maker
{
    public partial class ViewWin : Form
    {
        readonly double SCALE_RATIO = 120.0;

        List<string> frontContents = new List<string>();
        List<string> backContents = new List<string>();

        int listIterator = 0;
        bool isFront = true;

        private static Random rng = new Random();

        public ViewWin(string loadFrom)
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
            flashCard.Text = isFront ? frontContents[index] : backContents[index];
            cardsLeftText.Text = (index + 1) + " / " + frontContents.Count;
            flashCard.Font = new System.Drawing.Font(isFront ? "Segoe UI Black" : "Segoe UI", Convert.ToInt32(28 / Math.Ceiling(flashCard.Text.Length / SCALE_RATIO)));
            flashCard.BackColor = System.Drawing.ColorTranslator.FromHtml(isFront ? "#ffbfbf" : "#bfddff");
        }

        private void flashCard_Click(object sender, System.EventArgs e)
        {
            isFront = !isFront;
            flashCard.Text = !isFront ? backContents[listIterator] : frontContents[listIterator];
            flashCard.Font = new System.Drawing.Font(isFront ? "Segoe UI Black" : "Segoe UI", Convert.ToInt32(28 / Math.Ceiling(flashCard.Text.Length / SCALE_RATIO)));
            flashCard.BackColor = System.Drawing.ColorTranslator.FromHtml(isFront ? "#ffbfbf" : "#bfddff");
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            listIterator--;
            if (listIterator < 0)
            {
                listIterator = frontContents.Count - 1;
                MessageBox.Show("Reached the beginning of the set. Going to the last card of the set.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateCardContents(listIterator);
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            listIterator++;
            if (listIterator == frontContents.Count)
            {
                listIterator = 0;
                DialogResult dr = MessageBox.Show("Reached the end of the set. Going to the first card of the set. Would you like to shuffle the deck before continuing?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) ShuffleDeck();
            }
            UpdateCardContents(listIterator);
        }

        private void ShuffleDeck()
        {
            int[] indices = new int[frontContents.Count];
            int i = 0;
            foreach (string card in frontContents)
            {
                indices[i] = i;
                i++;
            }

            List<int> shuffledIndices = indices.OrderBy(a => rng.Next()).ToList();

            List<string> shuffledFront = new List<string>();
            List<string> shuffledBack = new List<string>();

            for (int j = 0; j < shuffledIndices.Count; j++)
            {
                shuffledFront.Add(frontContents[shuffledIndices[j]]);
                shuffledBack.Add(backContents[shuffledIndices[j]]);
            }

            frontContents = shuffledFront;
            backContents = shuffledBack;

            listIterator = 0;
            UpdateCardContents(listIterator);
        }

        private void shuffleButton_Click(object sender, System.EventArgs e)
        {
            ShuffleDeck();

            MessageBox.Show("Set shuffled. Going to the first card of the set.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
