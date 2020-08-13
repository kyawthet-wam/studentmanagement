namespace project
{
    partial class RemoveCourse
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
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRenove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseId.Location = new System.Drawing.Point(196, 178);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(208, 28);
            this.textBoxCourseId.TabIndex = 9;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(30, 178);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(143, 24);
            this.name.TabIndex = 8;
            this.name.Text = "Enter course id:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonRenove);
            this.panel1.Controls.Add(this.textBoxCourseId);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(46, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 283);
            this.panel1.TabIndex = 10;
            // 
            // buttonRenove
            // 
            this.buttonRenove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRenove.AutoSize = true;
            this.buttonRenove.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRenove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRenove.Location = new System.Drawing.Point(472, 167);
            this.buttonRenove.Name = "buttonRenove";
            this.buttonRenove.Size = new System.Drawing.Size(137, 51);
            this.buttonRenove.TabIndex = 17;
            this.buttonRenove.Text = "Remove";
            this.buttonRenove.UseVisualStyleBackColor = false;
            this.buttonRenove.Click += new System.EventHandler(this.buttonRenove_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Remove Course";
            // 
            // RemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(754, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRenove;
        private System.Windows.Forms.Label label3;
    }
}