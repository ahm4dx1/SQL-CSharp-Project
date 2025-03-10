﻿
namespace Database_Project
{
    partial class FilterPage
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
            this.movietextbox = new System.Windows.Forms.RichTextBox();
            this.releaseyearcombo = new System.Windows.Forms.ComboBox();
            this.genrecombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ratingcombo = new System.Windows.Forms.ComboBox();
            this.filterbutton = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // movietextbox
            // 
            this.movietextbox.Location = new System.Drawing.Point(26, 144);
            this.movietextbox.Name = "movietextbox";
            this.movietextbox.Size = new System.Drawing.Size(249, 24);
            this.movietextbox.TabIndex = 0;
            this.movietextbox.Text = "";
            this.movietextbox.TextChanged += new System.EventHandler(this.movietextbox_TextChanged);
            // 
            // releaseyearcombo
            // 
            this.releaseyearcombo.FormattingEnabled = true;
            this.releaseyearcombo.Location = new System.Drawing.Point(26, 272);
            this.releaseyearcombo.Name = "releaseyearcombo";
            this.releaseyearcombo.Size = new System.Drawing.Size(249, 24);
            this.releaseyearcombo.TabIndex = 1;
            this.releaseyearcombo.SelectedIndexChanged += new System.EventHandler(this.releaseyearcombo_SelectedIndexChanged);
            // 
            // genrecombo
            // 
            this.genrecombo.FormattingEnabled = true;
            this.genrecombo.Location = new System.Drawing.Point(26, 208);
            this.genrecombo.Name = "genrecombo";
            this.genrecombo.Size = new System.Drawing.Size(249, 24);
            this.genrecombo.TabIndex = 2;
            this.genrecombo.SelectedIndexChanged += new System.EventHandler(this.genrecombo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.hide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 73);
            this.label5.TabIndex = 29;
            this.label5.Text = "Filter Page";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(766, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.TabIndex = 98;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hide.Location = new System.Drawing.Point(742, 0);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(28, 34);
            this.hide.TabIndex = 99;
            this.hide.Text = "-";
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Movie Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Release Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Rating";
            // 
            // ratingcombo
            // 
            this.ratingcombo.FormattingEnabled = true;
            this.ratingcombo.Location = new System.Drawing.Point(26, 336);
            this.ratingcombo.Name = "ratingcombo";
            this.ratingcombo.Size = new System.Drawing.Size(249, 24);
            this.ratingcombo.TabIndex = 35;
            this.ratingcombo.SelectedIndexChanged += new System.EventHandler(this.ratingcombo_SelectedIndexChanged);
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.filterbutton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.filterbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filterbutton.Location = new System.Drawing.Point(159, 464);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(116, 41);
            this.filterbutton.TabIndex = 37;
            this.filterbutton.Text = "Filter";
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.GridColor = System.Drawing.SystemColors.Highlight;
            this.datagrid.Location = new System.Drawing.Point(309, 144);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(470, 300);
            this.datagrid.TabIndex = 38;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.SystemColors.WindowText;
            this.back.Location = new System.Drawing.Point(663, 465);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 40);
            this.back.TabIndex = 39;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Alphabetically";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 403);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 24);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FilterPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.filterbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ratingcombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.releaseyearcombo);
            this.Controls.Add(this.movietextbox);
            this.Controls.Add(this.genrecombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterPage";
            this.Text = "FilterPage";
            this.Load += new System.EventHandler(this.FilterPage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox movietextbox;
        private System.Windows.Forms.ComboBox releaseyearcombo;
        private System.Windows.Forms.ComboBox genrecombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label hide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ratingcombo;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}