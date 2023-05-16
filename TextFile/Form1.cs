using System;
using System.Linq;
using System.Windows.Forms;
using System.IO; // relevant
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

        //Create list to store strings from the file
        List<string> colourList;

        private void loadColoursButton_Click(object sender, EventArgs e)
        {
            colourList = File.ReadAllLines("Colours.txt").ToList();
            DisplayColours();
        }

        private void saveColoursButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("Colours.txt", colourList);
        }

        private void sortColoursButton_Click(object sender, EventArgs e)
        {

        }

        private void addColourButton_Click(object sender, EventArgs e)
        {
            string newColour = colourInput.Text;
            colourList.Add(newColour);

            DisplayColours();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        public void DisplayColours()
        {
            colourOutput.Text = "";

            foreach (string colour in colourList)
            {
                colourOutput.Text += $"{colour}\n";
            }
        }

        #endregion


        #region scores

        //Create a list to hold HighScore objects
        List<HighScore> scores = new List<HighScore>();

        private void loadScoresButton_Click(object sender, EventArgs e)
        {
            // create list to gather stuff to be put into the list of objects (like a translator middleman from string to object)
            List<string> scoreList = File.ReadAllLines("ScoreFile.txt").ToList();

            for(int i = 0; i < scoreList.Count; i += 2) // move up by 2 lines
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i +1]);
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

            //DisplayScores();
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
