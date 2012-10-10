namespace Form1_demo
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.txtNum2Guess = new System.Windows.Forms.TextBox();
            this.btnStartGuessing = new System.Windows.Forms.Button();
            this.lblPlease = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(104, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(197, 78);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "&Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(101, 113);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(347, 51);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(50, 50);
            this.picFace.TabIndex = 5;
            this.picFace.TabStop = false;
            // 
            // txtNum2Guess
            // 
            this.txtNum2Guess.Location = new System.Drawing.Point(172, 233);
            this.txtNum2Guess.Name = "txtNum2Guess";
            this.txtNum2Guess.Size = new System.Drawing.Size(100, 20);
            this.txtNum2Guess.TabIndex = 6;
            // 
            // btnStartGuessing
            // 
            this.btnStartGuessing.Location = new System.Drawing.Point(197, 259);
            this.btnStartGuessing.Name = "btnStartGuessing";
            this.btnStartGuessing.Size = new System.Drawing.Size(75, 23);
            this.btnStartGuessing.TabIndex = 7;
            this.btnStartGuessing.Text = "Guess";
            this.btnStartGuessing.UseVisualStyleBackColor = true;
            this.btnStartGuessing.Click += new System.EventHandler(this.btnStartGuessing_Click);
            // 
            // lblPlease
            // 
            this.lblPlease.AutoSize = true;
            this.lblPlease.Location = new System.Drawing.Point(169, 217);
            this.lblPlease.Name = "lblPlease";
            this.lblPlease.Size = new System.Drawing.Size(191, 13);
            this.lblPlease.TabIndex = 8;
            this.lblPlease.Text = "Please enter a number for me to guess:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 373);
            this.Controls.Add(this.lblPlease);
            this.Controls.Add(this.btnStartGuessing);
            this.Controls.Add(this.txtNum2Guess);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.TextBox txtNum2Guess;
        private System.Windows.Forms.Button btnStartGuessing;
        private System.Windows.Forms.Label lblPlease;
    }
}

