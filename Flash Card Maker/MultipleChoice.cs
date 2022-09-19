using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flash_Card_Maker
{
    public partial class MultipleChoice : Form
    {
        List<string> front = new List<string>();
        List<string> back = new List<string>();

        private readonly static Random rng = new Random();

        public MultipleChoice(string loadFrom)
        {
            InitializeComponent();
            using (StreamReader sr = File.OpenText(loadFrom))
            {
                string s = "";
                setTitleText.Text = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    front.Add(s.Split("|||")[0]); // possible answers
                    back.Add(s.Split("|||")[1]); // possible "questions"
                }
            }

            // shuffle the questions we will use
            int[] indices = new int[back.Count];
            int i = 0;
            foreach (string card in back)
            {
                indices[i] = i;
                i++;
            }

            List<int> shuffledIndices = indices.OrderBy(a => rng.Next()).ToList();
            List<string> shuffledFront = new List<string>();
            List<string> shuffledBack = new List<string>();

            for (int j = 0; j < shuffledIndices.Count; j++)
            {
                // shuffled questions
                shuffledBack.Add(back[shuffledIndices[j]]);

                // shuffled correct answers to those questions
                shuffledFront.Add(front[shuffledIndices[j]]);
            }

            back = shuffledBack;
            front = shuffledFront;

            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            questionBox.Text = back[0];
            buttonA.Text = "";
            buttonB.Text = "";
            buttonC.Text = "";
            buttonD.Text = "";
            int correctAnswerButton = rng.Next(0, 4);
            switch (correctAnswerButton)
            {
                case 0:
                    buttonA.Text = front[0];
                    break;
                case 1:
                    buttonB.Text = front[0];
                    break;
                case 2:
                    buttonC.Text = front[0];
                    break;
                case 3:
                    buttonD.Text = front[0];
                    break;
                default:
                    MessageBox.Show("We shouldn't be here");
                    break;
            }

            // now get 3 random incorrect answers
            string[] wrongAnswers = new string[3];
            int i = 0;
            while (i < 3)
            {
                do
                {
                    wrongAnswers[i] = front[rng.Next(front.Count)];
                } while (wrongAnswers[i].Equals(front[0]));
                i++;
            }

            // put the wrong answers on the other 3 buttons
            i = 0;
            if (buttonA.Text.Equals(""))
            {
                buttonA.Text = wrongAnswers[i];
                i++;
            }
            if (buttonB.Text.Equals(""))
            {
                buttonB.Text = wrongAnswers[i];
                i++;
            }
            if (buttonC.Text.Equals(""))
            {
                buttonC.Text = wrongAnswers[i];
                i++;
            }
            if (buttonD.Text.Equals(""))
            {
                buttonD.Text = wrongAnswers[i];
            }

            back.RemoveAt(0);
            front.RemoveAt(0);
        }
    }
}
