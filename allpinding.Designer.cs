﻿namespace Project
{
    partial class allpinding
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
            this.AllPindingOrders = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllPindingOrders
            // 
            this.AllPindingOrders.FormattingEnabled = true;
            this.AllPindingOrders.ItemHeight = 20;
            this.AllPindingOrders.Location = new System.Drawing.Point(0, 1);
            this.AllPindingOrders.Name = "AllPindingOrders";
            this.AllPindingOrders.Size = new System.Drawing.Size(303, 304);
            this.AllPindingOrders.TabIndex = 0;
            this.AllPindingOrders.SelectedIndexChanged += new System.EventHandler(this.AllPindingOrders_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Deliver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allpinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllPindingOrders);
            this.Name = "allpinding";
            this.Text = "allpinding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AllPindingOrders;
        private System.Windows.Forms.Button button1;
    }
}