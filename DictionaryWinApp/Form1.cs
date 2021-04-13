using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryWinApp
{
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {

            // The dictionary of digit names.
            //Dictionary<int, string> groceryCollection = new Dictionary<int, string>();
            SortedDictionary<int, string> groceryCollection = new SortedDictionary<int, string>();


            groceryCollection.Add(3, "Milk");
            groceryCollection.Add(6, "Eggs");
            groceryCollection.Add(4, "Coffee");
            groceryCollection.Add(5, "Juice");
            groceryCollection.Add(0, "Sugar");
            groceryCollection.Add(1, "Bread");
            groceryCollection.Add(2, "Oranges");
            groceryCollection.Add(7, "Bananas");
            groceryCollection.Add(8, "Waffles");
            groceryCollection.Add(9, "Cheese");                       

            // Display the keys and values.
            foreach (int index in groceryCollection.Keys)
            {
                lstKeys.Items.Add(index);
                lstValues.Items.Add(groceryCollection[index]);
                lstKeysAndValues.Items.Add(index.ToString() + ": " + groceryCollection[index]);
            }
        }
    }
}
