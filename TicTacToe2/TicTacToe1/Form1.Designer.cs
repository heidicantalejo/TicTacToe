namespace TicTacToe1
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
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.chkX = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnA1
            // 
            this.btnA1.Location = new System.Drawing.Point(185, 99);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(70, 60);
            this.btnA1.TabIndex = 0;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(261, 99);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(70, 60);
            this.btnB1.TabIndex = 1;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(337, 99);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(70, 60);
            this.btnC1.TabIndex = 2;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(337, 165);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(70, 60);
            this.btnC2.TabIndex = 5;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(261, 165);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(70, 60);
            this.btnB2.TabIndex = 4;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.Location = new System.Drawing.Point(185, 165);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(70, 60);
            this.btnA2.TabIndex = 3;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(337, 231);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(70, 60);
            this.btnC3.TabIndex = 8;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(261, 231);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(70, 60);
            this.btnB3.TabIndex = 7;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA3
            // 
            this.btnA3.Location = new System.Drawing.Point(185, 231);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(70, 60);
            this.btnA3.TabIndex = 6;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // chkX
            // 
            this.chkX.AutoSize = true;
            this.chkX.Checked = true;
            this.chkX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkX.Location = new System.Drawing.Point(185, 36);
            this.chkX.Name = "chkX";
            this.chkX.Size = new System.Drawing.Size(172, 21);
            this.chkX.TabIndex = 9;
            this.chkX.Text = "X goes first. Play as X.";
            this.chkX.UseVisualStyleBackColor = true;
            this.chkX.CheckedChanged += new System.EventHandler(this.chkX_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(185, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 57);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(388, 424);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 55);
            this.lblWinner.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 564);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chkX);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.CheckBox chkX;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWinner;
    }
}

