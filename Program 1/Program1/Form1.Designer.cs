namespace Program1
{
    partial class Form1
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
            this.wallSpaceSqFt = new System.Windows.Forms.Label();
            this.coatsDesired = new System.Windows.Forms.Label();
            this.pricePerGallon = new System.Windows.Forms.Label();
            this.wallSpaceInput = new System.Windows.Forms.TextBox();
            this.coatsInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.totalSqFt = new System.Windows.Forms.Label();
            this.totalSqFtOutput = new System.Windows.Forms.Label();
            this.gallonsOutput = new System.Windows.Forms.Label();
            this.gallonsReqLabel = new System.Windows.Forms.Label();
            this.laborOutput = new System.Windows.Forms.Label();
            this.laborReq = new System.Windows.Forms.Label();
            this.costLaborOutput = new System.Windows.Forms.Label();
            this.laborCost = new System.Windows.Forms.Label();
            this.totalPaintJob = new System.Windows.Forms.Label();
            this.costTotal = new System.Windows.Forms.Label();
            this.costPaintOutput = new System.Windows.Forms.Label();
            this.costPaint = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wallSpaceSqFt
            // 
            this.wallSpaceSqFt.AutoSize = true;
            this.wallSpaceSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallSpaceSqFt.Location = new System.Drawing.Point(38, 17);
            this.wallSpaceSqFt.Name = "wallSpaceSqFt";
            this.wallSpaceSqFt.Size = new System.Drawing.Size(132, 16);
            this.wallSpaceSqFt.TabIndex = 0;
            this.wallSpaceSqFt.Text = "Wall space required:";
            // 
            // coatsDesired
            // 
            this.coatsDesired.AutoSize = true;
            this.coatsDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coatsDesired.Location = new System.Drawing.Point(13, 60);
            this.coatsDesired.Name = "coatsDesired";
            this.coatsDesired.Size = new System.Drawing.Size(158, 16);
            this.coatsDesired.TabIndex = 1;
            this.coatsDesired.Text = "Number of coats desired:";
            // 
            // pricePerGallon
            // 
            this.pricePerGallon.AutoSize = true;
            this.pricePerGallon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerGallon.Location = new System.Drawing.Point(65, 101);
            this.pricePerGallon.Name = "pricePerGallon";
            this.pricePerGallon.Size = new System.Drawing.Size(105, 16);
            this.pricePerGallon.TabIndex = 2;
            this.pricePerGallon.Text = "Price per gallon:";
            // 
            // wallSpaceInput
            // 
            this.wallSpaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallSpaceInput.Location = new System.Drawing.Point(170, 13);
            this.wallSpaceInput.Name = "wallSpaceInput";
            this.wallSpaceInput.Size = new System.Drawing.Size(100, 22);
            this.wallSpaceInput.TabIndex = 3;
            // 
            // coatsInput
            // 
            this.coatsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coatsInput.Location = new System.Drawing.Point(170, 54);
            this.coatsInput.Name = "coatsInput";
            this.coatsInput.Size = new System.Drawing.Size(100, 22);
            this.coatsInput.TabIndex = 4;
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.Location = new System.Drawing.Point(170, 97);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 22);
            this.priceInput.TabIndex = 5;
            // 
            // totalSqFt
            // 
            this.totalSqFt.AutoSize = true;
            this.totalSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSqFt.Location = new System.Drawing.Point(294, 17);
            this.totalSqFt.Name = "totalSqFt";
            this.totalSqFt.Size = new System.Drawing.Size(193, 16);
            this.totalSqFt.TabIndex = 7;
            this.totalSqFt.Text = "Total square feet to be painted:";
            // 
            // totalSqFtOutput
            // 
            this.totalSqFtOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalSqFtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSqFtOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalSqFtOutput.Location = new System.Drawing.Point(494, 13);
            this.totalSqFtOutput.Name = "totalSqFtOutput";
            this.totalSqFtOutput.Size = new System.Drawing.Size(121, 20);
            this.totalSqFtOutput.TabIndex = 8;
            this.totalSqFtOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsOutput
            // 
            this.gallonsOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gallonsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gallonsOutput.Location = new System.Drawing.Point(494, 50);
            this.gallonsOutput.Name = "gallonsOutput";
            this.gallonsOutput.Size = new System.Drawing.Size(121, 20);
            this.gallonsOutput.TabIndex = 10;
            this.gallonsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsReqLabel
            // 
            this.gallonsReqLabel.AutoSize = true;
            this.gallonsReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsReqLabel.Location = new System.Drawing.Point(331, 54);
            this.gallonsReqLabel.Name = "gallonsReqLabel";
            this.gallonsReqLabel.Size = new System.Drawing.Size(156, 16);
            this.gallonsReqLabel.TabIndex = 9;
            this.gallonsReqLabel.Text = "Gallons of paint required:";
            // 
            // laborOutput
            // 
            this.laborOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.laborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laborOutput.Location = new System.Drawing.Point(494, 85);
            this.laborOutput.Name = "laborOutput";
            this.laborOutput.Size = new System.Drawing.Size(121, 20);
            this.laborOutput.TabIndex = 12;
            this.laborOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborReq
            // 
            this.laborReq.AutoSize = true;
            this.laborReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborReq.Location = new System.Drawing.Point(352, 89);
            this.laborReq.Name = "laborReq";
            this.laborReq.Size = new System.Drawing.Size(135, 16);
            this.laborReq.TabIndex = 11;
            this.laborReq.Text = "Labor hours required:";
            // 
            // costLaborOutput
            // 
            this.costLaborOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.costLaborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLaborOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLaborOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.costLaborOutput.Location = new System.Drawing.Point(494, 153);
            this.costLaborOutput.Name = "costLaborOutput";
            this.costLaborOutput.Size = new System.Drawing.Size(121, 20);
            this.costLaborOutput.TabIndex = 14;
            this.costLaborOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborCost
            // 
            this.laborCost.AutoSize = true;
            this.laborCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborCost.Location = new System.Drawing.Point(401, 157);
            this.laborCost.Name = "laborCost";
            this.laborCost.Size = new System.Drawing.Size(86, 16);
            this.laborCost.TabIndex = 13;
            this.laborCost.Text = "Cost of labor:";
            // 
            // totalPaintJob
            // 
            this.totalPaintJob.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalPaintJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPaintJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaintJob.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalPaintJob.Location = new System.Drawing.Point(494, 186);
            this.totalPaintJob.Name = "totalPaintJob";
            this.totalPaintJob.Size = new System.Drawing.Size(121, 20);
            this.totalPaintJob.TabIndex = 16;
            this.totalPaintJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTotal
            // 
            this.costTotal.AutoSize = true;
            this.costTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTotal.Location = new System.Drawing.Point(347, 190);
            this.costTotal.Name = "costTotal";
            this.costTotal.Size = new System.Drawing.Size(138, 16);
            this.costTotal.TabIndex = 15;
            this.costTotal.Text = "Total cost of paint job:";
            // 
            // costPaintOutput
            // 
            this.costPaintOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.costPaintOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPaintOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.costPaintOutput.Location = new System.Drawing.Point(494, 118);
            this.costPaintOutput.Name = "costPaintOutput";
            this.costPaintOutput.Size = new System.Drawing.Size(121, 20);
            this.costPaintOutput.TabIndex = 18;
            this.costPaintOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costPaint
            // 
            this.costPaint.AutoSize = true;
            this.costPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPaint.Location = new System.Drawing.Point(401, 122);
            this.costPaint.Name = "costPaint";
            this.costPaint.Size = new System.Drawing.Size(84, 16);
            this.costPaint.TabIndex = 17;
            this.costPaint.Text = "Cost of paint:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(95, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 19;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(195, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 253);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.costPaintOutput);
            this.Controls.Add(this.costPaint);
            this.Controls.Add(this.totalPaintJob);
            this.Controls.Add(this.costTotal);
            this.Controls.Add(this.costLaborOutput);
            this.Controls.Add(this.laborCost);
            this.Controls.Add(this.laborOutput);
            this.Controls.Add(this.laborReq);
            this.Controls.Add(this.gallonsOutput);
            this.Controls.Add(this.gallonsReqLabel);
            this.Controls.Add(this.totalSqFtOutput);
            this.Controls.Add(this.totalSqFt);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.coatsInput);
            this.Controls.Add(this.wallSpaceInput);
            this.Controls.Add(this.pricePerGallon);
            this.Controls.Add(this.coatsDesired);
            this.Controls.Add(this.wallSpaceSqFt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallSpaceSqFt;
        private System.Windows.Forms.Label coatsDesired;
        private System.Windows.Forms.Label pricePerGallon;
        private System.Windows.Forms.TextBox wallSpaceInput;
        private System.Windows.Forms.TextBox coatsInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label totalSqFt;
        private System.Windows.Forms.Label totalSqFtOutput;
        private System.Windows.Forms.Label gallonsOutput;
        private System.Windows.Forms.Label gallonsReqLabel;
        private System.Windows.Forms.Label laborOutput;
        private System.Windows.Forms.Label laborReq;
        private System.Windows.Forms.Label costLaborOutput;
        private System.Windows.Forms.Label laborCost;
        private System.Windows.Forms.Label totalPaintJob;
        private System.Windows.Forms.Label costTotal;
        private System.Windows.Forms.Label costPaintOutput;
        private System.Windows.Forms.Label costPaint;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
    }
}

