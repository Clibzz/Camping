namespace Camping
{
    partial class Import
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
            this.importBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SpotsBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costsBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateCosts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(347, 35);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Importeren";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsToolStripMenuItem,
            this.importToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.reservationsToolStripMenuItem.Text = " Home";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(175, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Spots";
            // 
            // SpotsBox
            // 
            this.SpotsBox.FormattingEnabled = true;
            this.SpotsBox.Location = new System.Drawing.Point(180, 79);
            this.SpotsBox.Name = "SpotsBox";
            this.SpotsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SpotsBox.Size = new System.Drawing.Size(242, 251);
            this.SpotsBox.TabIndex = 17;
            this.SpotsBox.TabStop = false;
            this.SpotsBox.SelectedIndexChanged += new System.EventHandler(this.SpotsBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "SpotName | Car | Available | PeopleAmount | Surface";
            // 
            // costsBox
            // 
            this.costsBox.FormattingEnabled = true;
            this.costsBox.Location = new System.Drawing.Point(20, 118);
            this.costsBox.Name = "costsBox";
            this.costsBox.Size = new System.Drawing.Size(120, 173);
            this.costsBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Costs";
            // 
            // calculateCosts
            // 
            this.calculateCosts.Location = new System.Drawing.Point(20, 297);
            this.calculateCosts.Name = "calculateCosts";
            this.calculateCosts.Size = new System.Drawing.Size(75, 23);
            this.calculateCosts.TabIndex = 22;
            this.calculateCosts.Text = "Calculate";
            this.calculateCosts.UseVisualStyleBackColor = true;
            this.calculateCosts.Click += new System.EventHandler(this.calculateCosts_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = " (Max. 5 items)";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(20, 60);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(134, 20);
            this.startDate.TabIndex = 24;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(20, 92);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(134, 20);
            this.endDate.TabIndex = 25;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateCosts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpotsBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.importBtn);
            this.Name = "Import";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SpotsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox costsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateCosts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
    }
}