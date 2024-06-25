namespace interventory
{
    partial class SalesControl
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
            this.tablePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablePanel.Location = new System.Drawing.Point(0, 140);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(967, 441);
            this.tablePanel.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 28);
            this.textBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 56);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(967, 71);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales";
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(967, 581);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}
