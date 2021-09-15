using System;
using System.Linq;
using System.Windows.Forms;

namespace SprintOneV1
{
    public partial class AstronomicalProcessing : Form
    {
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
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
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
                MessageBox.Show("Error: Input is empty or not an integer", "Error");
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit) && (nextEmptyTask > 0))
            {
                int currentNumber = int.Parse(TextBoxInput.Text);
                int taskIndex = Array.IndexOf(arrayOfNumbers, currentNumber);

                if (taskIndex != -1)
                {
                    arrayOfNumbers[taskIndex] = arrayOfNumbers[nextEmptyTask - 1];
                    nextEmptyTask--;
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
            for (int x = 0; x < (24); x++)
            {
                if (nextEmptyTask < 24)
                {
                    arrayOfNumbers[nextEmptyTask] = rand.Next(10, 100);
                    nextEmptyTask++;
                }
            }
            DisplayTasks();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
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
                    if (target == arrayOfNumbers[mid])
                    {
                        targetFound = true;
                        break;
                    }
                    else if (target < arrayOfNumbers[mid])
                    {
                        max = mid - 1;
                    }
                    else
                        min = mid + 1;
                }
                if (targetFound)
                {
                    ListBoxNumbers.SelectedIndex = mid;
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                    ToolStripStatusLabel1.Text = "Target found";
                }
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
            for (int x = 0; x < nextEmptyTask; x++)
            {
                for (int i = x + 1; i < nextEmptyTask; i++)
                {
                    if (arrayOfNumbers[x] > arrayOfNumbers[i])
                    {
                        int temp = arrayOfNumbers[i];
                        arrayOfNumbers[i] = arrayOfNumbers[x];
                        arrayOfNumbers[x] = temp;
                    }
                }
            }
            DisplayTasks();
        }
        #endregion
    }
}
