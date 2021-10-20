using System;
using System.Linq;
using System.Diagnostics;
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
        // S1 CR All data is stored as an integer in an array
        // S1 PR The array is of type integer.
        // S1 PR The array has 24 elements to reflect the number of hours per day.
        static int maxSize = 24;
        int[] arrayOfNumbers = new int[maxSize];
        int nextEmptyTask = 0;
        // S1 CR There is an input field (text box) so data can be deleted, added and edited.
        // S1 PR The program must be able to add, edit and delete data values.
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // if input is anything other than integer or if text box is empty display error 
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
                if (int.Parse(TextBoxInput.Text) > 9 && int.Parse(TextBoxInput.Text) < 100)
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
                        MessageBox.Show("Error: Limit reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Error: Please enter a number between 10 and 99","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Error: Input is empty or not a whole number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //arrayOfNumbers[taskIndex] = arrayOfNumbers[nextEmptyTask - 1];
                    for (int i = taskIndex; i < nextEmptyTask-1; i++)
                    {
                        arrayOfNumbers[i] = arrayOfNumbers[i + 1];
                    }
                    nextEmptyTask--;
                    // calls DisplayTasks method
                    DisplayTasks();
                    ToolStripStatusLabel1.Text = "Item deleted";
                }
                else
                    MessageBox.Show("Item doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Textbox is either empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }
        private void ButonFill_Click(object sender, EventArgs e)
        {
            // S1 PR The array is filled with random integers to simulate the data stream (numbers between 10 and 99).
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
                MessageBox.Show("Error: Limit reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DisplayTasks();
            TextBoxInput.Focus();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // S1 PR if input is anything other than integer or nothing is selected  display error 
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit) && (ListBoxNumbers.SelectedIndex != -1))
            {
                int currentNumber = int.Parse(ListBoxNumbers.SelectedIndex.ToString());
                arrayOfNumbers[currentNumber] = int.Parse(TextBoxInput.Text);
                DisplayTasks();
            }
            else
                MessageBox.Show("Error: Texbox is either empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }
        // S1 CR There are buttons that can sort and search the data.
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Sort();
            DisplayTasks();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // S! PR If Integer is not selected or if letter or control is entered display error
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
                // S1 CR The client can use a text box input to search the array.
                // S1 PR A single text box is provided for the search input.
                int target = int.Parse(TextBoxInput.Text);
                bool targetFound = false;
                int min = 0;
                int max = nextEmptyTask - 1;
                int mid = 0;
                // S1 PR The search method must be coded using the Binary Search algorithm.
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
                    // S1 PR The program must generate an error message if the search is not successful.
                    MessageBox.Show("Error: Target not found","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }
            }
            // S1 PR The program must generate an error message if the text box is empty.
            else
                MessageBox.Show("Text box is either empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // S1 PR The sort method must be coded using the Bubble Sort algorithm.
            // loops through current elements in the array
            for (int x = 0; x < nextEmptyTask; x++)
            {
                // loops through current elements in the array +1 
                for (int i = x + 1; i < nextEmptyTask; i++)
                {
                    // compares value of first for loop with value of the second for loop
                    // if value of first is larger than the second it swaps them.
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

        #region Sprint Two

        // S2 CR A button to initiate a sequential search 
        //S2 PRThe sequential sort method must be coded using a single FOR loop and one IF condition
        private void ButtonSeqSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                for (int i = 0; i < arrayOfNumbers.Length; i++)
                {
                    if (int.Parse(TextBoxInput.Text) == arrayOfNumbers[i])
                    {
                        ListBoxNumbers.SelectedIndex = i;
                        // S2 PR The program must generate a message if the search is successful.
                        ToolStripStatusLabel1.Text = "Target Found";
                        TextBoxInput.Clear();
                        TextBoxInput.Focus();
                        break;
                    }
                    else if (i == arrayOfNumbers.Length - 1)
                    {
                        ToolStripStatusLabel1.Text = "";
                        MessageBox.Show("Target Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TextBoxInput.Clear();
                        TextBoxInput.Focus();
                    }
                }
            }
            else
                MessageBox.Show("Text box is either empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        // S2 CR a button to calculate the mode
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            int element;
            int frequency = 1;
            int mode = 0;
            int counter;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                counter = 0;
                element = arrayOfNumbers[i];
                for (int j = 0; j < arrayOfNumbers.Length; j++)
                {
                    if (element == arrayOfNumbers[j])
                    {
                        counter++;
                    }
                    if (counter >= frequency)
                    {
                        frequency = counter;
                        mode = element;
                    }
                }
            }
            //The mathematic calculations will display in separate text boxes formatted to 2 decimal places as appropriate.
            TextBoxModeOutput.Text = mode.ToString();
        }
        // S2 CR a button to calculate the range
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            //The mathematic calculations will display in separate text boxes formatted to 2 decimal places as appropriate.
            TextBoxRangeOutput.Text = (findMax() - findMin()).ToString();
        }
        // formula to find max value or array
        private int findMax()
        {
            int maxValue = 0;
           // Trace.TraceInformation("maxValue {0}", maxValue);// output trace information
            for (int i = 0; i < nextEmptyTask; i++)
            {
                if (arrayOfNumbers[i] >= maxValue)
                {
                    maxValue = arrayOfNumbers[i];
                }
            }
            return maxValue;
        }
        // formula to find minimum value of array 
        private int findMin()
        {
            int minValue = 100;
            //Trace.TraceInformation("minValue {0}", minValue);// output trace information
            for (int i = 0; i < nextEmptyTask; i++)
            {
                if (arrayOfNumbers[i] <= minValue)
                {
                    minValue = arrayOfNumbers[i];
                }
            }
            return minValue;
        }
        // S2 CR a button to calculate the mid extreme
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            //The mathematic calculations will display in separate text boxes formatted to 2 decimal places as appropriate.
            TextBoxMidExtremeOutput.Text = ((findMax() + findMin())/ 2).ToString();
        }
        // S2 CR a button to calculate the average
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i=0;i< nextEmptyTask; i++)
            {
                sum += arrayOfNumbers[i];
               
            }
            float avg = sum / nextEmptyTask; // uses float division 
            // PR The mathematic calculations will display in separate text boxes formatted to 2 decimal places as appropriate.
            TextBoxAverageOutput.Text = avg.ToString("F");
        }
        #endregion
    }
}

