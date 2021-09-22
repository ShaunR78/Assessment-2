using System;
using System.Linq;
using System.Windows.Forms;
// Shaun Rawlings & Scott King, Sprint Number One
// Date:22/09/21
// Version: V1.3
// Name: Astronomical Processing
// Program to record and process the number of neutrino interactions per hour
// Inputs integer data, Sort, Search, Delete, Edit, Add, Output displays integer data in list box. 

namespace SprintOneV1
{
    public partial class AstronomicalProcessing : Form
    {
        // S1 CR The name of the application should be Astronomical Processing.
        public AstronomicalProcessing()
        {
            InitializeComponent();
        }
        #region Sprint One
        Random rand = new Random();
        static int maxSize = 24;
        int[] arrayOfNumbers = new int[maxSize];
        int nextEmptyTask = 0;
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // if input is anything other than integer or if text box is empty display error 
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
                // if list exceeds 24 display error
                if (nextEmptyTask < 24)
                {
                    arrayOfNumbers[nextEmptyTask] = int.Parse(TextBoxInput.Text);
                    nextEmptyTask++;
                    ToolStripStatusLabel1.Text = "Input added";
                    DisplayTasks();
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }
                else
                    MessageBox.Show("Error: Limit reached", "Error");
            }
            else
                MessageBox.Show("Error: Input is empty or not a whole number", "Error");
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // if input is anything other than integer or if text box is empty,or next empty task is less than 0, display error
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit) && (nextEmptyTask > 0))
            {
                // sets the currentNumber to the TextBoxInput parses it as an Int
                int currentNumber = int.Parse(TextBoxInput.Text);
                // sets the value of task index to the index of the current number in the array
                int taskIndex = Array.IndexOf(arrayOfNumbers, currentNumber);
                
                if (taskIndex != -1)
                {
                    // sets the index of the element in the array to the next index in the array -1 
                    arrayOfNumbers[taskIndex] = arrayOfNumbers[nextEmptyTask - 1];
                    nextEmptyTask--;
                    // calls DisplayTasks method
                    DisplayTasks();
                    ToolStripStatusLabel1.Text = "Item deleted";
                }
                else
                    MessageBox.Show("Item doesn't exist", "Error");
            }
            else
                MessageBox.Show("Textbox is either empty or invalid", "Error");
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }
        private void ButonFill_Click(object sender, EventArgs e)
        {
            // if nextEmptyTask is more than 24 it won't run and will display an error
            if (nextEmptyTask < 24)
            {
                // fills array with 24 random integers between 10 and 99 
                for (int x = 0; x < (24); x++)
                {
                    if (nextEmptyTask < 24)
                    {
                        arrayOfNumbers[nextEmptyTask] = rand.Next(10, 100);
                        nextEmptyTask++;
                    }
                }
            }
            else
                MessageBox.Show("Error: Limit reached", "Error");
            DisplayTasks();
            TextBoxInput.Focus();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // if input is anything other than integer or nothing is selected  display error 
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit) && (ListBoxNumbers.SelectedIndex != -1))
            {
                int currentNumber = int.Parse(ListBoxNumbers.SelectedIndex.ToString());
                arrayOfNumbers[currentNumber] = int.Parse(TextBoxInput.Text);
                DisplayTasks();
            }
            else
                MessageBox.Show("Error: Texbox is either empty or invalid", "Error");
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Sort();
            DisplayTasks();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // If Integer is not selected or if letter or control is entered display error
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
                int target = int.Parse(TextBoxInput.Text);
                bool targetFound = false;
                int min = 0;
                int max = nextEmptyTask - 1;
                int mid = 0;
                while (min <= max)
                {
                    mid = (min + max) / 2;
                    // if target equals current mid point of array
                    if (target == arrayOfNumbers[mid])
                    {
                        targetFound = true;
                        break;
                    }
                    // if target is less than mid point of array 
                    else if (target < arrayOfNumbers[mid])
                    {
                        max = mid - 1;
                    }
                    // if, if statements aren't true, runs.
                    else
                        min = mid + 1;
                }
                // if targetFound = true then display message & selects in listBox
                if (targetFound)
                {
                    ListBoxNumbers.SelectedIndex = mid;
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                    // S1 Pr The program must generate a message if the search is successful.
                    ToolStripStatusLabel1.Text = "Target found";
                }
                // if target not found 
                else
                {
                    MessageBox.Show("Error: Target not found", "Error");
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }
            }
            else
                MessageBox.Show("Text box is either empty or invalid", "Error");
        }
        private void ListBoxNumbers_Click(object sender, EventArgs e)
        {
            if (ListBoxNumbers.SelectedIndex != -1)
            {
                int currentNumber = int.Parse(ListBoxNumbers.SelectedIndex.ToString());
                TextBoxInput.Text = arrayOfNumbers[currentNumber].ToString();
            }
        }
        private void DisplayTasks()
        {
            ListBoxNumbers.Items.Clear();
            for (int x = 0; x < nextEmptyTask; x++)
            {
                ListBoxNumbers.Items.Add(arrayOfNumbers[x]);
            }
        }
        private void Sort()
        {
            // loops through current elements in the array
            for (int x = 0; x < nextEmptyTask; x++)
            {
                // loops through current elements in the array +1 
                for (int i = x + 1; i < nextEmptyTask; i++)
                {
                    // compares value of first for loop with value of the second for loop
                    // if value of forst is larger than the second it swaps them.
                    if (arrayOfNumbers[x] > arrayOfNumbers[i])
                    {
                        int temp = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[x];
                        arrayOfNumbers[x] = temp;
                    }
                }
            }
            DisplayTasks();
            TextBoxInput.Focus();
        }
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // stops letters and control characters from being entered
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion 
    }
}
