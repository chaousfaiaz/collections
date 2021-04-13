using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedDictionaryWinApp
{
    public partial class frmSortedDictionary : Form
    {

        private SortedDictionary<string, int> wordDictionary;

        public frmSortedDictionary()
        {
            InitializeComponent();
        }

        //Process button
        //sample words: red green blue yellow red black orange red black
        private void btnProcess_Click(object sender, EventArgs e)
        {
            wordDictionary = new SortedDictionary<string, int>();

            // split input text into tokens
            string[] words = txtWords.Text.Split(' ');

            // processing input words
            foreach (var word in words)
            {
                if (word != "")
                { 
                    string wordKey = word.ToLower(); // get word in lowercase

                    // if the dictionary contains the word
                    if (wordDictionary.ContainsKey(wordKey))
                    {
                        //increase the counter
                        wordDictionary[wordKey] = wordDictionary[wordKey] + 1;
                        //or ++wordDictionary[wordKey]
                    }
                    else
                        // add new word with a count of 1 to the dictionary
                        wordDictionary.Add(wordKey, 1);

                }
            }

            txtAssessment.Text = "";
            //show the items in the dictionary
            foreach (string key in wordDictionary.Keys)
                txtAssessment.Text += String.Format("{0} - {1}", key, wordDictionary[key]) + "\r\n";

            //alternative looping
            //foreach (KeyValuePair<string, int> pair in wordDictionary)
            //    txtAssessment.Text += String.Format("{0} - {1}", pair.Key, pair.Value) + "\r\n";

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (wordDictionary.ContainsKey(txtWord.Text))
                txtCount.Text = wordDictionary[txtWord.Text].ToString();
            else
            {
                txtCount.Text = "0";
                MessageBox.Show("Word Not Found!");
            }
        }
    }
}
