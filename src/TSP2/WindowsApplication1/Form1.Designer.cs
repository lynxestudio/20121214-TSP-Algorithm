namespace TSP
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
            this.pnControls = new System.Windows.Forms.Panel();
            this.nmMutation = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numPob = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCities = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            
            this.pnDraw = new TSP.pnDraw();
            this.pnControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCities)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControls
            // 
            this.pnControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControls.Controls.Add(this.nmMutation);
            this.pnControls.Controls.Add(this.label3);
            this.pnControls.Controls.Add(this.numPob);
            this.pnControls.Controls.Add(this.label2);
            this.pnControls.Controls.Add(this.numCities);
            this.pnControls.Controls.Add(this.label1);
            this.pnControls.Controls.Add(this.btnStart);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControls.Location = new System.Drawing.Point(0, 617);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(863, 56);
            this.pnControls.TabIndex = 3;
            // 
            // nmMutation
            // 
            this.nmMutation.DecimalPlaces = 2;
            this.nmMutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMutation.Location = new System.Drawing.Point(614, 8);
            this.nmMutation.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            this.nmMutation.Name = "nmMutation";
            this.nmMutation.ReadOnly = true;
            this.nmMutation.Size = new System.Drawing.Size(58, 23);
            this.nmMutation.TabIndex = 20;
            this.nmMutation.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mutation %";
            // 
            // numPob
            // 
            this.numPob.Location = new System.Drawing.Point(393, 11);
            this.numPob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPob.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numPob.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPob.Name = "numPob";
            this.numPob.ReadOnly = true;
            this.numPob.Size = new System.Drawing.Size(55, 23);
            this.numPob.TabIndex = 18;
            this.numPob.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Population ";
            // 
            // numCities
            // 
            this.numCities.Location = new System.Drawing.Point(254, 13);
            this.numCities.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numCities.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numCities.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCities.Name = "numCities";
            this.numCities.ReadOnly = true;
            this.numCities.Size = new System.Drawing.Size(55, 23);
            this.numCities.TabIndex = 16;
            this.numCities.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cities";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.Location = new System.Drawing.Point(24, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            this.lbStatus.Text = "Running...";
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(863, 24);
            this.mnMain.TabIndex = 5;
            this.mnMain.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "&File";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(107, 22);
            this.mnExit.Text = "&Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // pnDraw
            // 
            this.pnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDraw.AutoScroll = true;
            this.pnDraw.AutoSize = true;
            this.pnDraw.BackColor = System.Drawing.Color.White;
            this.pnDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDraw.Location = new System.Drawing.Point(0, 0);
            this.pnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnDraw.Name = "pnDraw";
            this.pnDraw.Size = new System.Drawing.Size(863, 584);
            this.pnDraw.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 673);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnMain);
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.pnDraw);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(300, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic Algorithm for the TSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnControls.ResumeLayout(false);
            this.pnControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCities)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pnDraw pnDraw;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPob;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NumericUpDown nmMutation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
    }
}

