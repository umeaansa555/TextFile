using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace TextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region colours

        //used to store all the colours from the list locally
        List<string> colours = new List<string>();

        private void loadColoursButton_Click(object sender, EventArgs e)
        {
            colours = File.ReadAllLines("colourFile.txt").ToList();
            
            DisplayColours();
        }

        private void saveColoursButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("colourFile.txt", colours);
        }

        private void sortColoursButton_Click(object sender, EventArgs e)
        {

        }

        private void addColourButton_Click(object sender, EventArgs e)
        {
            colours.Add(colourInput.Text);
            DisplayColours();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        public void DisplayColours()
        {
            colourOutput.Text = "";

            foreach(string colour in colours)
            {
                colourOutput.Text += $"{colour}\n";
            }
        }

        #endregion


        #region scores

        List<HighScore> scores = new List<HighScore>();

        private void loadScoresButton_Click(object sender, EventArgs e)
        {
            List<string> scoreList = File.ReadAllLines("scoreFile.txt").ToList();

            for(int i = 0; i < scoreList.Count; i +=2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i+1]);

                scores.Add(new HighScore(name, score));
            }

            DisplayScores();
        }

        private void saveScoresButton_Click(object sender, EventArgs e)
        {

        }

        private void sortScoresButton_Click(object sender, EventArgs e)
        {

        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int score = Convert.ToInt32(scoreInput.Text);

            HighScore newScore = new HighScore(name, score);
            scores.Add(newScore);

            DisplayScores();
        }

        private void removeScoresButton_Click(object sender, EventArgs e)
        {

        }

        public void DisplayScores()
        {
            scoreOutput.Text = "";

            foreach (HighScore hs in scores)
            {
                scoreOutput.Text += $"{hs.name} {hs.score}\n";
            }
        }

        #endregion
    }
}
