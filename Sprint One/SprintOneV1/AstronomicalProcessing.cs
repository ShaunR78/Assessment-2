using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int[] listofNumbers = new int[maxSize];
        int nextEmptyTask = 0;
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
                listofNumbers[nextEmptyTask] = int.Parse(TextBoxInput.Text);
                nextEmptyTask++;
                ToolStripStatusLabel1.Text = "Input added";
                DisplayTasks();
            }
            else
                ToolStripStatusLabel1.Text = "Error: Input is empty or not an integer";
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxNumbers.SelectedIndex != -1)
            {
                int currentNumber = int.Parse(ListBoxNumbers.SelectedIndex.ToString());
                //int taskIndex = Array.IndexOf(listofNumbers, currentNumber);

                listofNumbers[currentNumber] = listofNumbers[nextEmptyTask-1];
                nextEmptyTask--;
                DisplayTasks();
                ToolStripStatusLabel1.Text = "Item deleted";
            }
            else
                StatusStripFeedback.Text = "Error";
        }
        private void ButonFill_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < (24); x++)
            {
                listofNumbers[nextEmptyTask] = rand.Next(0, 25);
                nextEmptyTask++;
            }
            DisplayTasks();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text) && TextBoxInput.Text.All(Char.IsDigit))
            {
                int currentNumber = int.Parse(ListBoxNumbers.SelectedIndex.ToString());
                listofNumbers[currentNumber] = int.Parse(TextBoxInput.Text);
                DisplayTasks();
            }
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
                    if (target == listofNumbers[mid])
                    {
                        targetFound = true;
                        break;
                    }
                    else if (target < listofNumbers[mid])
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
                    ToolStripStatusLabel1.Text = "Target not found";
                    TextBoxInput.Clear();
                    TextBoxInput.Focus();
                }   
            }
        }
        private void DisplayTasks()
        {
            Sort();
            ListBoxNumbers.Items.Clear();
            for (int x = 0; x < nextEmptyTask; x++)
            {
                ListBoxNumbers.Items.Add(listofNumbers[x]);
            }
        }
        private void Sort()
        {
            for (int x = 0; x < nextEmptyTask; x++)
            {
                for (int i = x + 1; i < nextEmptyTask; i++)
                {
                    if (listofNumbers[x] > listofNumbers[i])
                    {
                        int temp = listofNumbers[i];
                        listofNumbers[i] = listofNumbers[x];
                        listofNumbers[x] = temp;
                    }
                }
            }
        }

        #endregion
    }
}
