namespace Project
{
    partial class AdminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.viewmax = new System.Windows.Forms.Label();
            this.viewallzero = new System.Windows.Forms.Label();
            this.addnewproduct = new System.Windows.Forms.Button();
            this.viewallp = new System.Windows.Forms.Button();
            this.viewallord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.viewmax);
            this.panel1.Controls.Add(this.viewallzero);
            this.panel1.Controls.Add(this.addnewproduct);
            this.panel1.Controls.Add(this.viewallp);
            this.panel1.Controls.Add(this.viewallord);
            this.panel1.Location = new System.Drawing.Point(149, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 296);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "View the count of customers of type company";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // viewmax
            // 
            this.viewmax.AutoSize = true;
            this.viewmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewmax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewmax.Location = new System.Drawing.Point(0, 205);
            this.viewmax.Name = "viewmax";
            this.viewmax.Size = new System.Drawing.Size(525, 28);
            this.viewmax.TabIndex = 4;
            this.viewmax.Text = "View the name of customer whose order has the larger cost";
            this.viewmax.Click += new System.EventHandler(this.viewmax_Click);
            // 
            // viewallzero
            // 
            this.viewallzero.AutoSize = true;
            this.viewallzero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewallzero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewallzero.Location = new System.Drawing.Point(0, 164);
            this.viewallzero.Name = "viewallzero";
            this.viewallzero.Size = new System.Drawing.Size(363, 28);
            this.viewallzero.TabIndex = 3;
            this.viewallzero.Text = "View all product with inventory level = 0";
            this.viewallzero.Click += new System.EventHandler(this.viewallzero_Click);
            // 
            // addnewproduct
            // 
            this.addnewproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewproduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addnewproduct.ForeColor = System.Drawing.Color.Black;
            this.addnewproduct.Location = new System.Drawing.Point(-2, 92);
            this.addnewproduct.Name = "addnewproduct";
            this.addnewproduct.Size = new System.Drawing.Size(535, 56);
            this.addnewproduct.TabIndex = 2;
            this.addnewproduct.Text = "Add new product";
            this.addnewproduct.UseVisualStyleBackColor = true;
            this.addnewproduct.Click += new System.EventHandler(this.addnewproduct_Click);
            // 
            // viewallp
            // 
            this.viewallp.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewallp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewallp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.viewallp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewallp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewallp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewallp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewallp.ForeColor = System.Drawing.Color.White;
            this.viewallp.Location = new System.Drawing.Point(275, 0);
            this.viewallp.Name = "viewallp";
            this.viewallp.Size = new System.Drawing.Size(258, 86);
            this.viewallp.TabIndex = 1;
            this.viewallp.Text = "View all pending orders";
            this.viewallp.UseVisualStyleBackColor = false;
            this.viewallp.Click += new System.EventHandler(this.viewallp_Click);
            // 
            // viewallord
            // 
            this.viewallord.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewallord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewallord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.viewallord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewallord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewallord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewallord.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewallord.ForeColor = System.Drawing.Color.White;
            this.viewallord.Location = new System.Drawing.Point(0, 0);
            this.viewallord.Name = "viewallord";
            this.viewallord.Size = new System.Drawing.Size(258, 86);
            this.viewallord.TabIndex = 0;
            this.viewallord.Text = "View all orders detalis";
            this.viewallord.UseVisualStyleBackColor = false;
            this.viewallord.Click += new System.EventHandler(this.viewallord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(235, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dash Board";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewallord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label viewmax;
        private System.Windows.Forms.Label viewallzero;
        private System.Windows.Forms.Button addnewproduct;
        private System.Windows.Forms.Button viewallp;
        private System.Windows.Forms.Button button1;
    }
}