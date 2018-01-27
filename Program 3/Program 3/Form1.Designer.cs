namespace Program_3
{
    partial class Program3
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
            this.gradeLevelBox = new System.Windows.Forms.GroupBox();
            this.seniorGradeLvl = new System.Windows.Forms.RadioButton();
            this.juniorGradeLvl = new System.Windows.Forms.RadioButton();
            this.sophGradeLvl = new System.Windows.Forms.RadioButton();
            this.freshGradeLvl = new System.Windows.Forms.RadioButton();
            this.uoflPic = new System.Windows.Forms.PictureBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfRegOut = new System.Windows.Forms.Label();
            this.descOutput = new System.Windows.Forms.Label();
            this.calcOutButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.gradeLevelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uoflPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeLevelBox
            // 
            this.gradeLevelBox.Controls.Add(this.seniorGradeLvl);
            this.gradeLevelBox.Controls.Add(this.juniorGradeLvl);
            this.gradeLevelBox.Controls.Add(this.sophGradeLvl);
            this.gradeLevelBox.Controls.Add(this.freshGradeLvl);
            this.gradeLevelBox.Location = new System.Drawing.Point(229, 48);
            this.gradeLevelBox.Name = "gradeLevelBox";
            this.gradeLevelBox.Size = new System.Drawing.Size(179, 67);
            this.gradeLevelBox.TabIndex = 0;
            this.gradeLevelBox.TabStop = false;
            this.gradeLevelBox.Text = "Select Grade Level";
            // 
            // seniorGradeLvl
            // 
            this.seniorGradeLvl.AutoSize = true;
            this.seniorGradeLvl.Location = new System.Drawing.Point(98, 42);
            this.seniorGradeLvl.Name = "seniorGradeLvl";
            this.seniorGradeLvl.Size = new System.Drawing.Size(55, 17);
            this.seniorGradeLvl.TabIndex = 3;
            this.seniorGradeLvl.TabStop = true;
            this.seniorGradeLvl.Text = "Senior";
            this.seniorGradeLvl.UseVisualStyleBackColor = true;
            // 
            // juniorGradeLvl
            // 
            this.juniorGradeLvl.AutoSize = true;
            this.juniorGradeLvl.Location = new System.Drawing.Point(21, 42);
            this.juniorGradeLvl.Name = "juniorGradeLvl";
            this.juniorGradeLvl.Size = new System.Drawing.Size(53, 17);
            this.juniorGradeLvl.TabIndex = 2;
            this.juniorGradeLvl.TabStop = true;
            this.juniorGradeLvl.Text = "Junior";
            this.juniorGradeLvl.UseVisualStyleBackColor = true;
            // 
            // sophGradeLvl
            // 
            this.sophGradeLvl.AutoSize = true;
            this.sophGradeLvl.Location = new System.Drawing.Point(98, 19);
            this.sophGradeLvl.Name = "sophGradeLvl";
            this.sophGradeLvl.Size = new System.Drawing.Size(79, 17);
            this.sophGradeLvl.TabIndex = 1;
            this.sophGradeLvl.TabStop = true;
            this.sophGradeLvl.Text = "Sophomore";
            this.sophGradeLvl.UseVisualStyleBackColor = true;
            // 
            // freshGradeLvl
            // 
            this.freshGradeLvl.AutoSize = true;
            this.freshGradeLvl.Location = new System.Drawing.Point(21, 19);
            this.freshGradeLvl.Name = "freshGradeLvl";
            this.freshGradeLvl.Size = new System.Drawing.Size(71, 17);
            this.freshGradeLvl.TabIndex = 0;
            this.freshGradeLvl.TabStop = true;
            this.freshGradeLvl.Text = "Freshman";
            this.freshGradeLvl.UseVisualStyleBackColor = true;
            // 
            // uoflPic
            // 
            this.uoflPic.Image = global::Program_3.Properties.Resources.Uofl;
            this.uoflPic.Location = new System.Drawing.Point(13, 13);
            this.uoflPic.Name = "uoflPic";
            this.uoflPic.Size = new System.Drawing.Size(199, 198);
            this.uoflPic.TabIndex = 1;
            this.uoflPic.TabStop = false;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(361, 10);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(43, 20);
            this.lastNameInput.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(218, 13);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(140, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Enter first letter of last name:";
            // 
            // dateOfRegOut
            // 
            this.dateOfRegOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateOfRegOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOfRegOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOfRegOut.Location = new System.Drawing.Point(222, 188);
            this.dateOfRegOut.Name = "dateOfRegOut";
            this.dateOfRegOut.Size = new System.Drawing.Size(193, 23);
            this.dateOfRegOut.TabIndex = 4;
            this.dateOfRegOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descOutput
            // 
            this.descOutput.AutoSize = true;
            this.descOutput.Location = new System.Drawing.Point(226, 175);
            this.descOutput.Name = "descOutput";
            this.descOutput.Size = new System.Drawing.Size(104, 13);
            this.descOutput.TabIndex = 5;
            this.descOutput.Text = "Date of Registration:";
            // 
            // calcOutButton
            // 
            this.calcOutButton.Location = new System.Drawing.Point(229, 135);
            this.calcOutButton.Name = "calcOutButton";
            this.calcOutButton.Size = new System.Drawing.Size(84, 23);
            this.calcOutButton.TabIndex = 6;
            this.calcOutButton.Text = "Find My Date!";
            this.calcOutButton.UseVisualStyleBackColor = true;
            this.calcOutButton.Click += new System.EventHandler(this.calcOutButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(328, 134);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear App";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Program3
            // 
            this.AcceptButton = this.calcOutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 223);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcOutButton);
            this.Controls.Add(this.descOutput);
            this.Controls.Add(this.dateOfRegOut);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.uoflPic);
            this.Controls.Add(this.gradeLevelBox);
            this.Name = "Program3";
            this.Text = "Registration Dates";
            this.gradeLevelBox.ResumeLayout(false);
            this.gradeLevelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uoflPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gradeLevelBox;
        private System.Windows.Forms.RadioButton seniorGradeLvl;
        private System.Windows.Forms.RadioButton juniorGradeLvl;
        private System.Windows.Forms.RadioButton sophGradeLvl;
        private System.Windows.Forms.RadioButton freshGradeLvl;
        private System.Windows.Forms.PictureBox uoflPic;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfRegOut;
        private System.Windows.Forms.Label descOutput;
        private System.Windows.Forms.Button calcOutButton;
        private System.Windows.Forms.Button clearButton;
    }
}

