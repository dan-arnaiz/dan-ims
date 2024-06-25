namespace interventory
{
    partial class InventoryControl
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
            this.components = new System.ComponentModel.Container();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this._dan_imsDataSet = new interventory._dan_imsDataSet();
            this.danimsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dan_imsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danimsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablePanel.Controls.Add(this.dataGridView1);
            this.tablePanel.Location = new System.Drawing.Point(0, 140);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(967, 441);
            this.tablePanel.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.danimsDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(961, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 28);
            this.textBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deleteButton);
            this.panel5.Controls.Add(this.exportButton);
            this.panel5.Controls.Add(this.importButton);
            this.panel5.Controls.Add(this.addNewItemButton);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 56);
            this.panel5.TabIndex = 7;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.exportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.ForeColor = System.Drawing.Color.Black;
            this.exportButton.Location = new System.Drawing.Point(735, 13);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(89, 31);
            this.exportButton.TabIndex = 14;
            this.exportButton.Text = "Export";
            this.exportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.importButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.importButton.FlatAppearance.BorderSize = 0;
            this.importButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.importButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importButton.ForeColor = System.Drawing.Color.Black;
            this.importButton.Location = new System.Drawing.Point(640, 13);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(89, 31);
            this.importButton.TabIndex = 13;
            this.importButton.Text = "Import";
            this.importButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(125)))));
            this.addNewItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewItemButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.addNewItemButton.FlatAppearance.BorderSize = 0;
            this.addNewItemButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.addNewItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addNewItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewItemButton.ForeColor = System.Drawing.Color.White;
            this.addNewItemButton.Location = new System.Drawing.Point(830, 13);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(135, 31);
            this.addNewItemButton.TabIndex = 12;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addNewItemButton.UseVisualStyleBackColor = false;
            this.addNewItemButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(967, 71);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(830, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Refresh List";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(545, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 31);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // _dan_imsDataSet
            // 
            this._dan_imsDataSet.DataSetName = "_dan_imsDataSet";
            this._dan_imsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danimsDataSetBindingSource
            // 
            this.danimsDataSetBindingSource.AllowNew = true;
            this.danimsDataSetBindingSource.DataSource = this._dan_imsDataSet;
            this.danimsDataSetBindingSource.Position = 0;
            this.danimsDataSetBindingSource.CurrentChanged += new System.EventHandler(this.danimsDataSetBindingSource_CurrentChanged);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(967, 581);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dan_imsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danimsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource danimsDataSetBindingSource;
        private _dan_imsDataSet _dan_imsDataSet;
    }
}
