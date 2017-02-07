namespace ISchool.Teacher
{
    partial class setiing
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
            this.p4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.p4.SuspendLayout();
            this.SuspendLayout();
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p4.Controls.Add(this.label4);
            this.p4.Location = new System.Drawing.Point(-143, -1);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(935, 563);
            this.p4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "هذا الضبط لسا ما عدلت عليه (:";
            // 
            // setiing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 551);
            this.Controls.Add(this.p4);
            this.Name = "setiing";
            this.Text = "setiing";
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Label label4;
    }
}