
namespace RAM_Revit_Cnx2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getRAMResults = new System.Windows.Forms.Button();
            this.floorListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getGridInfo = new System.Windows.Forms.Button();
            this.gridListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getRAMResults
            // 
            this.getRAMResults.Location = new System.Drawing.Point(12, 12);
            this.getRAMResults.Name = "getRAMResults";
            this.getRAMResults.Size = new System.Drawing.Size(227, 34);
            this.getRAMResults.TabIndex = 0;
            this.getRAMResults.Text = "Gather RAM Info";
            this.getRAMResults.UseVisualStyleBackColor = true;
            this.getRAMResults.Click += new System.EventHandler(this.getRAMResults_Click);
            // 
            // floorListBox
            // 
            this.floorListBox.FormattingEnabled = true;
            this.floorListBox.Location = new System.Drawing.Point(12, 89);
            this.floorListBox.Name = "floorListBox";
            this.floorListBox.Size = new System.Drawing.Size(227, 56);
            this.floorListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Floors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grids";
            // 
            // getGridInfo
            // 
            this.getGridInfo.Location = new System.Drawing.Point(12, 172);
            this.getGridInfo.Name = "getGridInfo";
            this.getGridInfo.Size = new System.Drawing.Size(227, 34);
            this.getGridInfo.TabIndex = 0;
            this.getGridInfo.Text = "Gather Level Grids";
            this.getGridInfo.UseVisualStyleBackColor = true;
            this.getGridInfo.Click += new System.EventHandler(this.getGridInfo_Click);
            // 
            // gridListBox
            // 
            this.gridListBox.FormattingEnabled = true;
            this.gridListBox.Location = new System.Drawing.Point(12, 259);
            this.gridListBox.Name = "gridListBox";
            this.gridListBox.Size = new System.Drawing.Size(227, 56);
            this.gridListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridListBox);
            this.Controls.Add(this.floorListBox);
            this.Controls.Add(this.getGridInfo);
            this.Controls.Add(this.getRAMResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RAM Revit Connection Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getRAMResults;
        private System.Windows.Forms.ListBox floorListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getGridInfo;
        private System.Windows.Forms.ListBox gridListBox;
    }
}

