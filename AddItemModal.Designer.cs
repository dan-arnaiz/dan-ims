namespace interventory
{
    partial class AddItemModal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewItemButtonModal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.cancelAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 549);
            this.panel1.TabIndex = 1;
            // 
            // addNewItemButtonModal
            // 
            this.addNewItemButtonModal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(45)))));
            this.addNewItemButtonModal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.addNewItemButtonModal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.addNewItemButtonModal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addNewItemButtonModal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewItemButtonModal.ForeColor = System.Drawing.Color.White;
            this.addNewItemButtonModal.Location = new System.Drawing.Point(459, 457);
            this.addNewItemButtonModal.Name = "addNewItemButtonModal";
            this.addNewItemButtonModal.Size = new System.Drawing.Size(156, 31);
            this.addNewItemButtonModal.TabIndex = 1;
            this.addNewItemButtonModal.Text = "Add New Item";
            this.addNewItemButtonModal.UseVisualStyleBackColor = false;
            this.addNewItemButtonModal.Click += new System.EventHandler(this.addNewItemButtonModal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Supplier";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(258, 103);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(357, 26);
            this.nametextBox.TabIndex = 10;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(258, 223);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(357, 26);
            this.priceTextBox.TabIndex = 11;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(258, 261);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(357, 26);
            this.quantityTextBox.TabIndex = 12;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(258, 188);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(357, 26);
            this.categoryTextBox.TabIndex = 13;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(258, 149);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(357, 26);
            this.brandTextBox.TabIndex = 14;
            this.brandTextBox.TextChanged += new System.EventHandler(this.brandTextBox_TextChanged);
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Location = new System.Drawing.Point(258, 304);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(357, 26);
            this.supplierTextBox.TabIndex = 15;
            this.supplierTextBox.TextChanged += new System.EventHandler(this.supplierTextBox_TextChanged);
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(258, 352);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(357, 60);
            this.descriptionTextbox.TabIndex = 16;
            this.descriptionTextbox.TextChanged += new System.EventHandler(this.descriptionTextbox_TextChanged);
            // 
            // cancelAddButton
            // 
            this.cancelAddButton.BackColor = System.Drawing.Color.White;
            this.cancelAddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.cancelAddButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.cancelAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelAddButton.ForeColor = System.Drawing.Color.Black;
            this.cancelAddButton.Location = new System.Drawing.Point(258, 457);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(156, 31);
            this.cancelAddButton.TabIndex = 17;
            this.cancelAddButton.Text = "Cancel";
            this.cancelAddButton.UseVisualStyleBackColor = false;
            this.cancelAddButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // AddItemModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelAddButton);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewItemButtonModal);
            this.Controls.Add(this.panel1);
            this.Name = "AddItemModal";
            this.Size = new System.Drawing.Size(690, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewItemButtonModal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Button cancelAddButton;
    }
}
