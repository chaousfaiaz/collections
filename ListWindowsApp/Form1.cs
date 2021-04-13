using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListWindowsApp
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // create a new List of strings
            List<string> items = new List<string>();

            txtOutput.Text = $"Before adding to items: Count = {items.Count}; Capacity = {items.Capacity}";

            items.Add("red"); // append an item to the List
            items.Insert(0, "yellow"); // insert the value at index 0

            txtOutput.Text += $"\r\nAfter adding two elements to items: Count = {items.Count}; Capacity = {items.Capacity}";

            // display the colors in the list
            txtOutput.Text += "\r\n\r\nDisplay list contents with counter-controlled loop:";

            for (int i = 0; i < items.Count; i++)
                txtOutput.Text += $" {items[i]}";

            // display colors using foreach
            txtOutput.Text += "\r\nDisplay list contents with foreach statement:";
            foreach (string item in items)
                txtOutput.Text += $" {item}";
            
            items.Add("green"); // add "green" to the end of the List
            items.Add("yellow"); // add "yellow" to the end of the List
                                 // display the List

            txtOutput.Text += $"\r\n\r\nAfter adding two more elements to items: Count = {items.Count}; Capacity = {items.Capacity}";

            
            txtOutput.Text += "\r\nList with two new elements:";
            foreach (string item in items)
                txtOutput.Text += $" {item}";


            //while (items.Remove("Yellow")) { }

            items.Remove("yellow"); // remove the first "yellow"

            // display the List
            txtOutput.Text += "\r\n\r\nRemove first instance of yellow:";
            foreach (var item in items)
                txtOutput.Text += $" {item}";

            items.RemoveAt(1); // remove item at index 1

            // display the List
            txtOutput.Text += "\r\nRemove second list element (green):";
            foreach (var item in items)
                txtOutput.Text += $" {item}";


            txtOutput.Text += $"\r\nAfter removing two elements from items: Count = {items.Count}; Capacity = {items.Capacity}";


            // check if a value is in the List
            txtOutput.Text += Environment.NewLine + Environment.NewLine + String.Format("\"red\" is {0}in the list",
                items.Contains("red") ? string.Empty : "not ");

            items.Add("orange");
            items.Add("violet");
            items.Add("blue");

            items.TrimExcess();

            items.Add("blue");

            txtOutput.Text += $"\r\n\r\nAfter adding three more elements to items: Count = {items.Count}; Capacity = {items.Capacity}";

            // display the List
            txtOutput.Text += "\r\nList with three new elements:";
            foreach (var item in items)
                txtOutput.Text += $" {item}";

            return;
        }
    }
}
