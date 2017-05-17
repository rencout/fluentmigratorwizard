﻿namespace FluentMigrator.Wizard
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Geral = new System.Windows.Forms.TabPage();
            this.Options = new System.Windows.Forms.GroupBox();
            this.btnArgument = new System.Windows.Forms.Button();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxVerbose = new System.Windows.Forms.CheckBox();
            this.btnDownAll = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMigrations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRunner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMigrator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.Geral.SuspendLayout();
            this.Options.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Console.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Geral);
            this.tabControl1.Controls.Add(this.Console);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 495);
            this.tabControl1.TabIndex = 1;
            // 
            // Geral
            // 
            this.Geral.Controls.Add(this.progressBar1);
            this.Geral.Controls.Add(this.Options);
            this.Geral.Controls.Add(this.btnDownAll);
            this.Geral.Controls.Add(this.cbxVerbose);
            this.Geral.Controls.Add(this.btnList);
            this.Geral.Controls.Add(this.btnDown);
            this.Geral.Controls.Add(this.btnUp);
            this.Geral.Controls.Add(this.groupBox1);
            this.Geral.Location = new System.Drawing.Point(4, 22);
            this.Geral.Name = "Geral";
            this.Geral.Padding = new System.Windows.Forms.Padding(3);
            this.Geral.Size = new System.Drawing.Size(536, 469);
            this.Geral.TabIndex = 0;
            this.Geral.Text = "General";
            this.Geral.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.btnArgument);
            this.Options.Controls.Add(this.txtArguments);
            this.Options.Controls.Add(this.label8);
            this.Options.Location = new System.Drawing.Point(6, 312);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(524, 75);
            this.Options.TabIndex = 15;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // btnArgument
            // 
            this.btnArgument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArgument.Location = new System.Drawing.Point(384, 34);
            this.btnArgument.Name = "btnArgument";
            this.btnArgument.Size = new System.Drawing.Size(124, 23);
            this.btnArgument.TabIndex = 16;
            this.btnArgument.Text = "Execute";
            this.btnArgument.UseVisualStyleBackColor = true;
            this.btnArgument.Click += new System.EventHandler(this.btnArgument_Click);
            // 
            // txtArguments
            // 
            this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArguments.Location = new System.Drawing.Point(9, 37);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(353, 20);
            this.txtArguments.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Arguments";
            // 
            // cbxVerbose
            // 
            this.cbxVerbose.AutoSize = true;
            this.cbxVerbose.Checked = true;
            this.cbxVerbose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxVerbose.Location = new System.Drawing.Point(459, 399);
            this.cbxVerbose.Name = "cbxVerbose";
            this.cbxVerbose.Size = new System.Drawing.Size(65, 17);
            this.cbxVerbose.TabIndex = 14;
            this.cbxVerbose.Text = "Verbose";
            this.cbxVerbose.UseVisualStyleBackColor = true;
            // 
            // btnDownAll
            // 
            this.btnDownAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownAll.Location = new System.Drawing.Point(293, 440);
            this.btnDownAll.Name = "btnDownAll";
            this.btnDownAll.Size = new System.Drawing.Size(75, 23);
            this.btnDownAll.TabIndex = 6;
            this.btnDownAll.Text = "DOWN ALL";
            this.btnDownAll.UseVisualStyleBackColor = true;
            this.btnDownAll.Click += new System.EventHandler(this.btnDownAll_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.Location = new System.Drawing.Point(212, 440);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(374, 440);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(455, 440);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtContext);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProvider);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtConnection);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMigrations);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRunner);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMigrator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConsole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // txtContext
            // 
            this.txtContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContext.Location = new System.Drawing.Point(270, 264);
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(238, 20);
            this.txtContext.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Context";
            // 
            // txtProvider
            // 
            this.txtProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvider.Location = new System.Drawing.Point(9, 264);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(238, 20);
            this.txtProvider.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Provider";
            // 
            // txtConnection
            // 
            this.txtConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnection.Location = new System.Drawing.Point(9, 220);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(499, 20);
            this.txtConnection.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Connection";
            // 
            // txtMigrations
            // 
            this.txtMigrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMigrations.Location = new System.Drawing.Point(9, 175);
            this.txtMigrations.Name = "txtMigrations";
            this.txtMigrations.Size = new System.Drawing.Size(499, 20);
            this.txtMigrations.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Migrations";
            // 
            // txtRunner
            // 
            this.txtRunner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRunner.Location = new System.Drawing.Point(9, 128);
            this.txtRunner.Name = "txtRunner";
            this.txtRunner.Size = new System.Drawing.Size(499, 20);
            this.txtRunner.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Runner";
            // 
            // txtMigrator
            // 
            this.txtMigrator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMigrator.Location = new System.Drawing.Point(9, 81);
            this.txtMigrator.Name = "txtMigrator";
            this.txtMigrator.Size = new System.Drawing.Size(499, 20);
            this.txtMigrator.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Migrator";
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(9, 42);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(499, 20);
            this.txtConsole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Console";
            // 
            // Console
            // 
            this.Console.Controls.Add(this.txtOutput);
            this.Console.Location = new System.Drawing.Point(4, 22);
            this.Console.Name = "Console";
            this.Console.Padding = new System.Windows.Forms.Padding(3);
            this.Console.Size = new System.Drawing.Size(536, 469);
            this.Console.TabIndex = 1;
            this.Console.Text = "Output";
            this.Console.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(530, 463);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.arquivoToolStripMenuItem.Text = "File";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Open";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "Save as ...";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ajudaToolStripMenuItem.Text = "Help";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "About";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 534);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "FluentMigrator Wizard";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Console.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Geral;
        private System.Windows.Forms.TabPage Console;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMigrations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRunner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMigrator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownAll;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button btnArgument;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxVerbose;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
