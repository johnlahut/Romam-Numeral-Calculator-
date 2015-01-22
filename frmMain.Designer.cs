namespace Roman_Numeral
{
    partial class frmMain
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtRoman2 = new System.Windows.Forms.TextBox();
            this.lblRoman2 = new System.Windows.Forms.Label();
            this.txtRoman1 = new System.Windows.Forms.TextBox();
            this.lblRoman1 = new System.Windows.Forms.Label();
            this.grpOps = new System.Windows.Forms.GroupBox();
            this.radioDiff = new System.Windows.Forms.RadioButton();
            this.radioSum = new System.Windows.Forms.RadioButton();
            this.grpCommands = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnToRoman = new System.Windows.Forms.Button();
            this.btnToDec = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOps.SuspendLayout();
            this.grpCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtResult);
            this.grpInput.Controls.Add(this.lblResult);
            this.grpInput.Controls.Add(this.txtRoman2);
            this.grpInput.Controls.Add(this.lblRoman2);
            this.grpInput.Controls.Add(this.txtRoman1);
            this.grpInput.Controls.Add(this.lblRoman1);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(420, 192);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input:";
            this.grpInput.Enter += new System.EventHandler(this.grpInput_Enter);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(177, 138);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(219, 26);
            this.txtResult.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(30, 141);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 20);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // txtRoman2
            // 
            this.txtRoman2.Location = new System.Drawing.Point(177, 92);
            this.txtRoman2.Name = "txtRoman2";
            this.txtRoman2.Size = new System.Drawing.Size(219, 26);
            this.txtRoman2.TabIndex = 2;
            // 
            // lblRoman2
            // 
            this.lblRoman2.AutoSize = true;
            this.lblRoman2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoman2.Location = new System.Drawing.Point(30, 95);
            this.lblRoman2.Name = "lblRoman2";
            this.lblRoman2.Size = new System.Drawing.Size(141, 20);
            this.lblRoman2.TabIndex = 3;
            this.lblRoman2.Text = "Roman Numeral 2:";
            // 
            // txtRoman1
            // 
            this.txtRoman1.Location = new System.Drawing.Point(177, 44);
            this.txtRoman1.Name = "txtRoman1";
            this.txtRoman1.Size = new System.Drawing.Size(219, 26);
            this.txtRoman1.TabIndex = 1;
            // 
            // lblRoman1
            // 
            this.lblRoman1.AutoSize = true;
            this.lblRoman1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoman1.Location = new System.Drawing.Point(30, 47);
            this.lblRoman1.Name = "lblRoman1";
            this.lblRoman1.Size = new System.Drawing.Size(141, 20);
            this.lblRoman1.TabIndex = 1;
            this.lblRoman1.Text = "Roman Numeral 1:";
            // 
            // grpOps
            // 
            this.grpOps.Controls.Add(this.radioDiff);
            this.grpOps.Controls.Add(this.radioSum);
            this.grpOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOps.Location = new System.Drawing.Point(12, 210);
            this.grpOps.Name = "grpOps";
            this.grpOps.Size = new System.Drawing.Size(419, 74);
            this.grpOps.TabIndex = 1;
            this.grpOps.TabStop = false;
            this.grpOps.Text = "Operations:";
            // 
            // radioDiff
            // 
            this.radioDiff.AutoSize = true;
            this.radioDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDiff.Location = new System.Drawing.Point(241, 29);
            this.radioDiff.Name = "radioDiff";
            this.radioDiff.Size = new System.Drawing.Size(101, 24);
            this.radioDiff.TabIndex = 5;
            this.radioDiff.TabStop = true;
            this.radioDiff.Text = "Difference";
            this.radioDiff.UseVisualStyleBackColor = true;
            // 
            // radioSum
            // 
            this.radioSum.AutoSize = true;
            this.radioSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSum.Location = new System.Drawing.Point(123, 29);
            this.radioSum.Name = "radioSum";
            this.radioSum.Size = new System.Drawing.Size(60, 24);
            this.radioSum.TabIndex = 4;
            this.radioSum.TabStop = true;
            this.radioSum.Text = "Sum";
            this.radioSum.UseVisualStyleBackColor = true;
            // 
            // grpCommands
            // 
            this.grpCommands.Controls.Add(this.btnExit);
            this.grpCommands.Controls.Add(this.btnClear);
            this.grpCommands.Controls.Add(this.btnToRoman);
            this.grpCommands.Controls.Add(this.btnToDec);
            this.grpCommands.Controls.Add(this.btnCalc);
            this.grpCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCommands.Location = new System.Drawing.Point(12, 290);
            this.grpCommands.Name = "grpCommands";
            this.grpCommands.Size = new System.Drawing.Size(420, 114);
            this.grpCommands.TabIndex = 6;
            this.grpCommands.TabStop = false;
            this.grpCommands.Text = "Commands:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(282, 66);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(6, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnToRoman
            // 
            this.btnToRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToRoman.Location = new System.Drawing.Point(282, 25);
            this.btnToRoman.Name = "btnToRoman";
            this.btnToRoman.Size = new System.Drawing.Size(132, 35);
            this.btnToRoman.TabIndex = 10;
            this.btnToRoman.Text = "To Roman";
            this.btnToRoman.UseVisualStyleBackColor = true;
            this.btnToRoman.Click += new System.EventHandler(this.btnToRoman_Click);
            // 
            // btnToDec
            // 
            this.btnToDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDec.Location = new System.Drawing.Point(144, 25);
            this.btnToDec.Name = "btnToDec";
            this.btnToDec.Size = new System.Drawing.Size(132, 35);
            this.btnToDec.TabIndex = 9;
            this.btnToDec.Text = "To Decimal";
            this.btnToDec.UseVisualStyleBackColor = true;
            this.btnToDec.Click += new System.EventHandler(this.btnToDec_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(6, 25);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(132, 35);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 420);
            this.Controls.Add(this.grpCommands);
            this.Controls.Add(this.grpOps);
            this.Controls.Add(this.grpInput);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roman Numeral Calculator";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOps.ResumeLayout(false);
            this.grpOps.PerformLayout();
            this.grpCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtRoman2;
        private System.Windows.Forms.Label lblRoman2;
        private System.Windows.Forms.TextBox txtRoman1;
        private System.Windows.Forms.Label lblRoman1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpOps;
        private System.Windows.Forms.RadioButton radioDiff;
        private System.Windows.Forms.RadioButton radioSum;
        private System.Windows.Forms.GroupBox grpCommands;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnToRoman;
        private System.Windows.Forms.Button btnToDec;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtResult;

    }
}

