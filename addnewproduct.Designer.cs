namespace Project
{
    partial class addnewproduct
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
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.Label();
            this.descrip = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.pprice = new System.Windows.Forms.TextBox();
            this.Ilevel = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(53, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(167, 32);
            this.name.TabIndex = 0;
            this.name.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(53, 105);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(146, 32);
            this.price.TabIndex = 1;
            this.price.Text = "Priduct Price";
            // 
            // inventory
            // 
            this.inventory.AutoSize = true;
            this.inventory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventory.Location = new System.Drawing.Point(53, 170);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(177, 32);
            this.inventory.TabIndex = 2;
            this.inventory.Text = "Inventory Level";
            // 
            // descrip
            // 
            this.descrip.AutoSize = true;
            this.descrip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descrip.Location = new System.Drawing.Point(53, 257);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(142, 32);
            this.descrip.TabIndex = 3;
            this.descrip.Text = "Descreption";
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pname.Location = new System.Drawing.Point(268, 42);
            this.pname.Multiline = true;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(276, 44);
            this.pname.TabIndex = 4;
            // 
            // pprice
            // 
            this.pprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pprice.Location = new System.Drawing.Point(268, 102);
            this.pprice.Multiline = true;
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(276, 41);
            this.pprice.TabIndex = 5;
            // 
            // Ilevel
            // 
            this.Ilevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ilevel.Location = new System.Drawing.Point(268, 167);
            this.Ilevel.Multiline = true;
            this.Ilevel.Name = "Ilevel";
            this.Ilevel.Size = new System.Drawing.Size(276, 44);
            this.Ilevel.TabIndex = 6;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(217, 257);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(369, 148);
            this.description.TabIndex = 7;
            this.description.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(654, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addnewproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.Ilevel);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Name = "addnewproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addnewproduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label inventory;
        private System.Windows.Forms.Label descrip;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.TextBox Ilevel;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button button1;
    }
}