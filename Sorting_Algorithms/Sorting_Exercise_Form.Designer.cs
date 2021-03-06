﻿namespace Sorting_Algorithms
{
    partial class Sorting_Exercise_Form
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnAvg = new System.Windows.Forms.Button();
            this.NumberDisplayLabel = new System.Windows.Forms.Label();
            this.BtnContains = new System.Windows.Forms.Button();
            this.BtnBinary = new System.Windows.Forms.Button();
            this.BtnSelection = new System.Windows.Forms.Button();
            this.BtnBubbleSort = new System.Windows.Forms.Button();
            this.BtnInsertion = new System.Windows.Forms.Button();
            this.BtnFastEditing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBox.Location = new System.Drawing.Point(13, 16);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 31);
            this.TextBox.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(119, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 35);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(12, 109);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(100, 45);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.Text = "Min";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Location = new System.Drawing.Point(118, 109);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(100, 45);
            this.BtnMax.TabIndex = 3;
            this.BtnMax.Text = "Max";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(11, 160);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(100, 45);
            this.BtnSum.TabIndex = 4;
            this.BtnSum.Text = "Sum";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnAvg
            // 
            this.BtnAvg.Location = new System.Drawing.Point(118, 160);
            this.BtnAvg.Name = "BtnAvg";
            this.BtnAvg.Size = new System.Drawing.Size(100, 45);
            this.BtnAvg.TabIndex = 5;
            this.BtnAvg.Text = "Avg";
            this.BtnAvg.UseVisualStyleBackColor = true;
            this.BtnAvg.Click += new System.EventHandler(this.BtnAvg_Click);
            // 
            // NumberDisplayLabel
            // 
            this.NumberDisplayLabel.AutoSize = true;
            this.NumberDisplayLabel.Location = new System.Drawing.Point(12, 243);
            this.NumberDisplayLabel.Name = "NumberDisplayLabel";
            this.NumberDisplayLabel.Size = new System.Drawing.Size(49, 13);
            this.NumberDisplayLabel.TabIndex = 6;
            this.NumberDisplayLabel.Text = "Numbers";
            // 
            // BtnContains
            // 
            this.BtnContains.Location = new System.Drawing.Point(12, 58);
            this.BtnContains.Name = "BtnContains";
            this.BtnContains.Size = new System.Drawing.Size(207, 45);
            this.BtnContains.TabIndex = 7;
            this.BtnContains.Text = "Contains";
            this.BtnContains.UseVisualStyleBackColor = true;
            this.BtnContains.Click += new System.EventHandler(this.BtnContains_Click);
            // 
            // BtnBinary
            // 
            this.BtnBinary.Location = new System.Drawing.Point(234, 7);
            this.BtnBinary.Name = "BtnBinary";
            this.BtnBinary.Size = new System.Drawing.Size(100, 45);
            this.BtnBinary.TabIndex = 8;
            this.BtnBinary.Text = "Contains Bintary";
            this.BtnBinary.UseVisualStyleBackColor = true;
            this.BtnBinary.Click += new System.EventHandler(this.BtnBinary_Click);
            // 
            // BtnSelection
            // 
            this.BtnSelection.Location = new System.Drawing.Point(234, 58);
            this.BtnSelection.Name = "BtnSelection";
            this.BtnSelection.Size = new System.Drawing.Size(100, 45);
            this.BtnSelection.TabIndex = 9;
            this.BtnSelection.Text = "Edit with Selection";
            this.BtnSelection.UseVisualStyleBackColor = true;
            this.BtnSelection.Click += new System.EventHandler(this.BtnSelection_Click);
            // 
            // BtnBubbleSort
            // 
            this.BtnBubbleSort.Location = new System.Drawing.Point(234, 160);
            this.BtnBubbleSort.Name = "BtnBubbleSort";
            this.BtnBubbleSort.Size = new System.Drawing.Size(100, 45);
            this.BtnBubbleSort.TabIndex = 11;
            this.BtnBubbleSort.Text = "Edit with BubbleSort";
            this.BtnBubbleSort.UseVisualStyleBackColor = true;
            this.BtnBubbleSort.Click += new System.EventHandler(this.BtnBubbleSort_Click);
            // 
            // BtnInsertion
            // 
            this.BtnInsertion.Location = new System.Drawing.Point(234, 109);
            this.BtnInsertion.Name = "BtnInsertion";
            this.BtnInsertion.Size = new System.Drawing.Size(100, 45);
            this.BtnInsertion.TabIndex = 10;
            this.BtnInsertion.Text = "Edit with Insertion";
            this.BtnInsertion.UseVisualStyleBackColor = true;
            this.BtnInsertion.Click += new System.EventHandler(this.BtnInsertion_Click);
            // 
            // BtnFastEditing
            // 
            this.BtnFastEditing.Location = new System.Drawing.Point(234, 211);
            this.BtnFastEditing.Name = "BtnFastEditing";
            this.BtnFastEditing.Size = new System.Drawing.Size(100, 45);
            this.BtnFastEditing.TabIndex = 12;
            this.BtnFastEditing.Text = "Fast Editing";
            this.BtnFastEditing.UseVisualStyleBackColor = true;
            this.BtnFastEditing.Click += new System.EventHandler(this.BtnFastEditing_Click);
            // 
            // Sorting_Exercise_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 274);
            this.Controls.Add(this.BtnFastEditing);
            this.Controls.Add(this.BtnBubbleSort);
            this.Controls.Add(this.BtnInsertion);
            this.Controls.Add(this.BtnSelection);
            this.Controls.Add(this.BtnBinary);
            this.Controls.Add(this.BtnContains);
            this.Controls.Add(this.NumberDisplayLabel);
            this.Controls.Add(this.BtnAvg);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TextBox);
            this.Name = "Sorting_Exercise_Form";
            this.Text = "Table Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnAvg;
        private System.Windows.Forms.Label NumberDisplayLabel;
        private System.Windows.Forms.Button BtnContains;
        private System.Windows.Forms.Button BtnBinary;
        private System.Windows.Forms.Button BtnSelection;
        private System.Windows.Forms.Button BtnBubbleSort;
        private System.Windows.Forms.Button BtnInsertion;
        private System.Windows.Forms.Button BtnFastEditing;
    }
}

