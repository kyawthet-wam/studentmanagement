namespace project
{
    partial class ManageCourse
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
            this.labelTotalCourse = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHourNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotalCourse);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonEditCourse);
            this.panel1.Controls.Add(this.listBoxCourses);
            this.panel1.Controls.Add(this.textBoxCourseName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonAddCourse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownHourNumber);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCourseId);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 713);
            this.panel1.TabIndex = 11;
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelTotalCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCourse.Location = new System.Drawing.Point(962, 506);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Size = new System.Drawing.Size(215, 54);
            this.labelTotalCourse.TabIndex = 26;
            this.labelTotalCourse.Text = "Total:";
            this.labelTotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.AutoSize = true;
            this.buttonNext.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNext.Location = new System.Drawing.Point(221, 517);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 43);
            this.buttonNext.TabIndex = 25;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.AutoSize = true;
            this.buttonPrevious.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonPrevious.Location = new System.Drawing.Point(346, 517);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(93, 43);
            this.buttonPrevious.TabIndex = 24;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLast.AutoSize = true;
            this.buttonLast.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLast.Location = new System.Drawing.Point(477, 517);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(93, 43);
            this.buttonLast.TabIndex = 23;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFirst.AutoSize = true;
            this.buttonFirst.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonFirst.Location = new System.Drawing.Point(97, 517);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(93, 43);
            this.buttonFirst.TabIndex = 22;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(623, 646);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(137, 51);
            this.buttonRemove.TabIndex = 21;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditCourse.AutoSize = true;
            this.buttonEditCourse.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCourse.Location = new System.Drawing.Point(459, 646);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(137, 51);
            this.buttonEditCourse.TabIndex = 20;
            this.buttonEditCourse.Text = "Edit";
            this.buttonEditCourse.UseVisualStyleBackColor = false;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourses.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 31;
            this.listBoxCourses.Location = new System.Drawing.Point(652, 82);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(525, 376);
            this.listBoxCourses.Sorted = true;
            this.listBoxCourses.TabIndex = 19;
            this.listBoxCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxCourses_SelectedIndexChanged);
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(197, 189);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(288, 28);
            this.textBoxCourseName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(37, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name:";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCourse.AutoSize = true;
            this.buttonAddCourse.BackColor = System.Drawing.Color.Cyan;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(296, 646);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(137, 51);
            this.buttonAddCourse.TabIndex = 16;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Manage Course";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(14, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of Hours:";
            // 
            // numericUpDownHourNumber
            // 
            this.numericUpDownHourNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHourNumber.Location = new System.Drawing.Point(197, 265);
            this.numericUpDownHourNumber.Name = "numericUpDownHourNumber";
            this.numericUpDownHourNumber.Size = new System.Drawing.Size(132, 30);
            this.numericUpDownHourNumber.TabIndex = 10;
            this.numericUpDownHourNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(197, 361);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(399, 125);
            this.textBoxDescription.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description:";
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseId.Location = new System.Drawing.Point(197, 108);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(288, 28);
            this.textBoxCourseId.TabIndex = 7;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(37, 108);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(32, 24);
            this.name.TabIndex = 6;
            this.name.Text = "ID:";
            // 
            // ManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1229, 746);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourse";
            this.Load += new System.EventHandler(this.ManageCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHourNumber;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label labelTotalCourse;
    }
}