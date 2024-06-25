namespace interventory
{
    partial class StoreInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backInfoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "INTERVENTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "by Dan Arnaiz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backInfoButton
            // 
            this.backInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(45)))));
            this.backInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(49)))));
            this.backInfoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(90)))));
            this.backInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backInfoButton.ForeColor = System.Drawing.Color.White;
            this.backInfoButton.Location = new System.Drawing.Point(316, 348);
            this.backInfoButton.Name = "backInfoButton";
            this.backInfoButton.Size = new System.Drawing.Size(109, 37);
            this.backInfoButton.TabIndex = 15;
            this.backInfoButton.Text = "Back";
            this.backInfoButton.UseVisualStyleBackColor = false;
            this.backInfoButton.Click += new System.EventHandler(this.backInfoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Object Oriented Programming";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backInfoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StoreInformation";
            this.Size = new System.Drawing.Size(690, 549);
            this.Load += new System.EventHandler(this.StoreInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backInfoButton;
        private System.Windows.Forms.Label label3;
    }
}
