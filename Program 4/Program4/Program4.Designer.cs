namespace Program4
{
    partial class Program4
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
            this.entryBox = new System.Windows.Forms.GroupBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zipOriginLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.zipDestBox = new System.Windows.Forms.TextBox();
            this.zipOriginBox = new System.Windows.Forms.TextBox();
            this.endPackListBox = new System.Windows.Forms.ListBox();
            this.detailsBox = new System.Windows.Forms.Button();
            this.toCardsBox = new System.Windows.Forms.Button();
            this.fromCardsBox = new System.Windows.Forms.Button();
            this.entryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryBox
            // 
            this.entryBox.Controls.Add(this.weightLabel);
            this.entryBox.Controls.Add(this.heightLabel);
            this.entryBox.Controls.Add(this.widthLabel);
            this.entryBox.Controls.Add(this.lengthLabel);
            this.entryBox.Controls.Add(this.label1);
            this.entryBox.Controls.Add(this.zipOriginLabel);
            this.entryBox.Controls.Add(this.addBtn);
            this.entryBox.Controls.Add(this.weightBox);
            this.entryBox.Controls.Add(this.heightBox);
            this.entryBox.Controls.Add(this.widthBox);
            this.entryBox.Controls.Add(this.lengthBox);
            this.entryBox.Controls.Add(this.zipDestBox);
            this.entryBox.Controls.Add(this.zipOriginBox);
            this.entryBox.Location = new System.Drawing.Point(13, 13);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(225, 210);
            this.entryBox.TabIndex = 0;
            this.entryBox.TabStop = false;
            this.entryBox.Text = "Enter Package Values";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(28, 152);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 13);
            this.weightLabel.TabIndex = 12;
            this.weightLabel.Text = "Weight (pounds):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(35, 126);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 13);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "Height (inches):";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(38, 100);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(78, 13);
            this.widthLabel.TabIndex = 10;
            this.widthLabel.Text = "Width (inches):";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(33, 74);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(83, 13);
            this.lengthLabel.TabIndex = 9;
            this.lengthLabel.Text = "Length (inches):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zip Code (destination):";
            // 
            // zipOriginLabel
            // 
            this.zipOriginLabel.AutoSize = true;
            this.zipOriginLabel.Location = new System.Drawing.Point(29, 22);
            this.zipOriginLabel.Name = "zipOriginLabel";
            this.zipOriginLabel.Size = new System.Drawing.Size(87, 13);
            this.zipOriginLabel.TabIndex = 7;
            this.zipOriginLabel.Text = "Zip Code (origin):";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(87, 175);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add to List";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(119, 149);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 5;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(119, 123);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 4;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(119, 97);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 3;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(119, 71);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 2;
            // 
            // zipDestBox
            // 
            this.zipDestBox.Location = new System.Drawing.Point(119, 45);
            this.zipDestBox.Name = "zipDestBox";
            this.zipDestBox.Size = new System.Drawing.Size(100, 20);
            this.zipDestBox.TabIndex = 1;
            // 
            // zipOriginBox
            // 
            this.zipOriginBox.Location = new System.Drawing.Point(119, 19);
            this.zipOriginBox.Name = "zipOriginBox";
            this.zipOriginBox.Size = new System.Drawing.Size(100, 20);
            this.zipOriginBox.TabIndex = 0;
            // 
            // endPackListBox
            // 
            this.endPackListBox.FormattingEnabled = true;
            this.endPackListBox.Location = new System.Drawing.Point(248, 24);
            this.endPackListBox.Name = "endPackListBox";
            this.endPackListBox.Size = new System.Drawing.Size(197, 199);
            this.endPackListBox.TabIndex = 1;
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(460, 51);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(94, 23);
            this.detailsBox.TabIndex = 2;
            this.detailsBox.Text = "Details";
            this.detailsBox.UseVisualStyleBackColor = true;
            this.detailsBox.Click += new System.EventHandler(this.detailsBox_Click);
            // 
            // toCardsBox
            // 
            this.toCardsBox.Location = new System.Drawing.Point(460, 103);
            this.toCardsBox.Name = "toCardsBox";
            this.toCardsBox.Size = new System.Drawing.Size(94, 23);
            this.toCardsBox.TabIndex = 3;
            this.toCardsBox.Text = "Send to UofL";
            this.toCardsBox.UseVisualStyleBackColor = true;
            this.toCardsBox.Click += new System.EventHandler(this.toCardsBox_Click);
            // 
            // fromCardsBox
            // 
            this.fromCardsBox.Location = new System.Drawing.Point(460, 155);
            this.fromCardsBox.Name = "fromCardsBox";
            this.fromCardsBox.Size = new System.Drawing.Size(94, 23);
            this.fromCardsBox.TabIndex = 4;
            this.fromCardsBox.Text = "Send From UofL";
            this.fromCardsBox.UseVisualStyleBackColor = true;
            this.fromCardsBox.Click += new System.EventHandler(this.fromCardsBox_Click);
            // 
            // Program4
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 235);
            this.Controls.Add(this.fromCardsBox);
            this.Controls.Add(this.toCardsBox);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.endPackListBox);
            this.Controls.Add(this.entryBox);
            this.Name = "Program4";
            this.Text = "Ground Package";
            this.entryBox.ResumeLayout(false);
            this.entryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox entryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zipOriginLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox zipDestBox;
        private System.Windows.Forms.TextBox zipOriginBox;
        private System.Windows.Forms.ListBox endPackListBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button detailsBox;
        private System.Windows.Forms.Button toCardsBox;
        private System.Windows.Forms.Button fromCardsBox;
    }
}

