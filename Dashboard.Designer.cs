
namespace DesktopApp
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumOfTwoNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPrimeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputNumbersAndFindSumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.structureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.arrayToolStripMenuItem,
            this.structureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumOfTwoNumberToolStripMenuItem,
            this.checkPrimeNumberToolStripMenuItem,
            this.inputNumbersAndFindSumToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.billingSoftwareToolStripMenuItem,
            this.studentDataToolStripMenuItem,
            this.imageSliderToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // sumOfTwoNumberToolStripMenuItem
            // 
            this.sumOfTwoNumberToolStripMenuItem.Name = "sumOfTwoNumberToolStripMenuItem";
            this.sumOfTwoNumberToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.sumOfTwoNumberToolStripMenuItem.Text = "Sum of two number";
            this.sumOfTwoNumberToolStripMenuItem.Click += new System.EventHandler(this.sumOfTwoNumberToolStripMenuItem_Click);
            // 
            // checkPrimeNumberToolStripMenuItem
            // 
            this.checkPrimeNumberToolStripMenuItem.Name = "checkPrimeNumberToolStripMenuItem";
            this.checkPrimeNumberToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.checkPrimeNumberToolStripMenuItem.Text = "Check prime number";
            this.checkPrimeNumberToolStripMenuItem.Click += new System.EventHandler(this.checkPrimeNumberToolStripMenuItem_Click);
            // 
            // inputNumbersAndFindSumToolStripMenuItem
            // 
            this.inputNumbersAndFindSumToolStripMenuItem.Name = "inputNumbersAndFindSumToolStripMenuItem";
            this.inputNumbersAndFindSumToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.inputNumbersAndFindSumToolStripMenuItem.Text = "Input numbers and find sum";
            this.inputNumbersAndFindSumToolStripMenuItem.Click += new System.EventHandler(this.inputNumbersAndFindSumToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // billingSoftwareToolStripMenuItem
            // 
            this.billingSoftwareToolStripMenuItem.Name = "billingSoftwareToolStripMenuItem";
            this.billingSoftwareToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.billingSoftwareToolStripMenuItem.Text = "Billing Software";
            this.billingSoftwareToolStripMenuItem.Click += new System.EventHandler(this.billingSoftwareToolStripMenuItem_Click_1);
            // 
            // studentDataToolStripMenuItem
            // 
            this.studentDataToolStripMenuItem.Name = "studentDataToolStripMenuItem";
            this.studentDataToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.studentDataToolStripMenuItem.Text = "Student Data";
            this.studentDataToolStripMenuItem.Click += new System.EventHandler(this.studentDataToolStripMenuItem_Click);
            // 
            // imageSliderToolStripMenuItem
            // 
            this.imageSliderToolStripMenuItem.Name = "imageSliderToolStripMenuItem";
            this.imageSliderToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.imageSliderToolStripMenuItem.Text = "Image Slider";
            this.imageSliderToolStripMenuItem.Click += new System.EventHandler(this.imageSliderToolStripMenuItem_Click);
            // 
            // arrayToolStripMenuItem
            // 
            this.arrayToolStripMenuItem.Name = "arrayToolStripMenuItem";
            this.arrayToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.arrayToolStripMenuItem.Text = "Array";
            // 
            // structureToolStripMenuItem
            // 
            this.structureToolStripMenuItem.Name = "structureToolStripMenuItem";
            this.structureToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.structureToolStripMenuItem.Text = "Structure";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumOfTwoNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPrimeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem structureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputNumbersAndFindSumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSliderToolStripMenuItem;
    }
}