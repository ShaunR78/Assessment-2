
namespace SprintOneV1
{
    partial class AstronomicalProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButonFill = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ListBoxNumbers = new System.Windows.Forms.ListBox();
            this.StatusStripFeedback = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonSeqSearch = new System.Windows.Forms.Button();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextBoxMidExtremeOutput = new System.Windows.Forms.TextBox();
            this.TextBoxModeOutput = new System.Windows.Forms.TextBox();
            this.TextBoxAverageOutput = new System.Windows.Forms.TextBox();
            this.TextBoxRangeOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StatusStripFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(147, 27);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.ButtonAdd, "Click to add data to list");
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(147, 56);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.ButtonEdit, "Click to edit selected data");
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(228, 27);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.ButtonDelete, "Click to delete selected data");
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(228, 56);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.ButtonSort, "Click to sort list of data");
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(228, 85);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Bin Search";
            this.toolTip1.SetToolTip(this.ButtonSearch, "Click to carry out a Binary search of data in list. \r\nEnsure List is sorted prior" +
        " to doing Binary Search.");
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButonFill
            // 
            this.ButonFill.Location = new System.Drawing.Point(228, 359);
            this.ButonFill.Name = "ButonFill";
            this.ButonFill.Size = new System.Drawing.Size(75, 23);
            this.ButonFill.TabIndex = 7;
            this.ButonFill.Text = "Auto Fill";
            this.toolTip1.SetToolTip(this.ButonFill, "Click to fill the list with 24 random numbers between 10 & 99 ");
            this.ButonFill.UseVisualStyleBackColor = true;
            this.ButonFill.Click += new System.EventHandler(this.ButonFill_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 27);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(129, 20);
            this.TextBoxInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TextBoxInput, "Enter Data Here");
            this.TextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            // 
            // ListBoxNumbers
            // 
            this.ListBoxNumbers.FormattingEnabled = true;
            this.ListBoxNumbers.Location = new System.Drawing.Point(12, 53);
            this.ListBoxNumbers.Name = "ListBoxNumbers";
            this.ListBoxNumbers.Size = new System.Drawing.Size(129, 329);
            this.ListBoxNumbers.TabIndex = 8;
            this.toolTip1.SetToolTip(this.ListBoxNumbers, "Data Displayed Here ");
            this.ListBoxNumbers.Click += new System.EventHandler(this.ListBoxNumbers_Click);
            // 
            // StatusStripFeedback
            // 
            this.StatusStripFeedback.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStripFeedback.Location = new System.Drawing.Point(0, 396);
            this.StatusStripFeedback.Name = "StatusStripFeedback";
            this.StatusStripFeedback.Size = new System.Drawing.Size(318, 22);
            this.StatusStripFeedback.TabIndex = 8;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ButtonSeqSearch
            // 
            this.ButtonSeqSearch.Location = new System.Drawing.Point(148, 84);
            this.ButtonSeqSearch.Name = "ButtonSeqSearch";
            this.ButtonSeqSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSeqSearch.TabIndex = 9;
            this.ButtonSeqSearch.Text = "Seq Search";
            this.toolTip1.SetToolTip(this.ButtonSeqSearch, "Click to carry out a sequential search of data in list");
            this.ButtonSeqSearch.UseVisualStyleBackColor = true;
            this.ButtonSeqSearch.Click += new System.EventHandler(this.ButtonSeqSearch_Click);
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(148, 209);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(75, 23);
            this.ButtonMidExtreme.TabIndex = 10;
            this.ButtonMidExtreme.Text = "Mid Extreme";
            this.toolTip1.SetToolTip(this.ButtonMidExtreme, "Click to find the Mid extreme of data in list");
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(148, 239);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(75, 23);
            this.ButtonMode.TabIndex = 11;
            this.ButtonMode.Text = "Mode";
            this.toolTip1.SetToolTip(this.ButtonMode, "Click to find the Mode of data in list ");
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(148, 269);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(75, 23);
            this.ButtonAverage.TabIndex = 12;
            this.ButtonAverage.Text = "Average";
            this.toolTip1.SetToolTip(this.ButtonAverage, "Click to calculate the avergae of data in the list ");
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(148, 299);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(75, 23);
            this.ButtonRange.TabIndex = 13;
            this.ButtonRange.Text = "Range";
            this.toolTip1.SetToolTip(this.ButtonRange, "Click to calculate the Range of data in the list");
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // TextBoxMidExtremeOutput
            // 
            this.TextBoxMidExtremeOutput.Location = new System.Drawing.Point(228, 209);
            this.TextBoxMidExtremeOutput.Name = "TextBoxMidExtremeOutput";
            this.TextBoxMidExtremeOutput.ReadOnly = true;
            this.TextBoxMidExtremeOutput.Size = new System.Drawing.Size(78, 20);
            this.TextBoxMidExtremeOutput.TabIndex = 14;
            // 
            // TextBoxModeOutput
            // 
            this.TextBoxModeOutput.Location = new System.Drawing.Point(230, 239);
            this.TextBoxModeOutput.Name = "TextBoxModeOutput";
            this.TextBoxModeOutput.ReadOnly = true;
            this.TextBoxModeOutput.Size = new System.Drawing.Size(76, 20);
            this.TextBoxModeOutput.TabIndex = 15;
            // 
            // TextBoxAverageOutput
            // 
            this.TextBoxAverageOutput.Location = new System.Drawing.Point(228, 271);
            this.TextBoxAverageOutput.Name = "TextBoxAverageOutput";
            this.TextBoxAverageOutput.ReadOnly = true;
            this.TextBoxAverageOutput.Size = new System.Drawing.Size(78, 20);
            this.TextBoxAverageOutput.TabIndex = 16;
            // 
            // TextBoxRangeOutput
            // 
            this.TextBoxRangeOutput.Location = new System.Drawing.Point(228, 301);
            this.TextBoxRangeOutput.Name = "TextBoxRangeOutput";
            this.TextBoxRangeOutput.ReadOnly = true;
            this.TextBoxRangeOutput.Size = new System.Drawing.Size(78, 20);
            this.TextBoxRangeOutput.TabIndex = 17;
            // 
            // AstronomicalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 418);
            this.Controls.Add(this.TextBoxRangeOutput);
            this.Controls.Add(this.TextBoxAverageOutput);
            this.Controls.Add(this.TextBoxModeOutput);
            this.Controls.Add(this.TextBoxMidExtremeOutput);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonMidExtreme);
            this.Controls.Add(this.ButtonSeqSearch);
            this.Controls.Add(this.StatusStripFeedback);
            this.Controls.Add(this.ListBoxNumbers);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButonFill);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Name = "AstronomicalProcessing";
            this.Text = "Astronomical Processing";
            this.StatusStripFeedback.ResumeLayout(false);
            this.StatusStripFeedback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButonFill;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.ListBox ListBoxNumbers;
        private System.Windows.Forms.StatusStrip StatusStripFeedback;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.Button ButtonSeqSearch;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox TextBoxMidExtremeOutput;
        private System.Windows.Forms.TextBox TextBoxModeOutput;
        private System.Windows.Forms.TextBox TextBoxAverageOutput;
        private System.Windows.Forms.TextBox TextBoxRangeOutput;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

