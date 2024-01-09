namespace Tic_Tac_Toe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNewgame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblPlayerY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPlayerX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btntic9 = new System.Windows.Forms.Button();
            this.btntic8 = new System.Windows.Forms.Button();
            this.btntic6 = new System.Windows.Forms.Button();
            this.btntic5 = new System.Windows.Forms.Button();
            this.btntic3 = new System.Windows.Forms.Button();
            this.btntic7 = new System.Windows.Forms.Button();
            this.btntic2 = new System.Windows.Forms.Button();
            this.btntic4 = new System.Windows.Forms.Button();
            this.btntic1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 120);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC TAC TOE GAME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 551);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(686, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 510);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnNewgame);
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.Resetbtn);
            this.panel6.Location = new System.Drawing.Point(4, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(644, 282);
            this.panel6.TabIndex = 1;
            // 
            // btnNewgame
            // 
            this.btnNewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewgame.Location = new System.Drawing.Point(0, 4);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(644, 156);
            this.btnNewgame.TabIndex = 2;
            this.btnNewgame.Text = "New Game";
            this.btnNewgame.UseVisualStyleBackColor = true;
            this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(313, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(331, 127);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button11_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.Location = new System.Drawing.Point(0, 157);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(315, 127);
            this.Resetbtn.TabIndex = 0;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LblPlayerY);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.LblPlayerX);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(4, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 182);
            this.panel5.TabIndex = 0;
            // 
            // LblPlayerY
            // 
            this.LblPlayerY.BackColor = System.Drawing.Color.White;
            this.LblPlayerY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPlayerY.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerY.Location = new System.Drawing.Point(263, 94);
            this.LblPlayerY.Name = "LblPlayerY";
            this.LblPlayerY.Size = new System.Drawing.Size(277, 64);
            this.LblPlayerY.TabIndex = 0;
            this.LblPlayerY.Text = "0";
            this.LblPlayerY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player O:";
            // 
            // LblPlayerX
            // 
            this.LblPlayerX.BackColor = System.Drawing.Color.White;
            this.LblPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerX.Location = new System.Drawing.Point(263, 12);
            this.LblPlayerX.Name = "LblPlayerX";
            this.LblPlayerX.Size = new System.Drawing.Size(282, 64);
            this.LblPlayerX.TabIndex = 0;
            this.LblPlayerX.Text = "0";
            this.LblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btntic9);
            this.panel3.Controls.Add(this.btntic8);
            this.panel3.Controls.Add(this.btntic6);
            this.panel3.Controls.Add(this.btntic5);
            this.panel3.Controls.Add(this.btntic3);
            this.panel3.Controls.Add(this.btntic7);
            this.panel3.Controls.Add(this.btntic2);
            this.panel3.Controls.Add(this.btntic4);
            this.panel3.Controls.Add(this.btntic1);
            this.panel3.Location = new System.Drawing.Point(10, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 506);
            this.panel3.TabIndex = 0;
            // 
            // btntic9
            // 
            this.btntic9.Location = new System.Drawing.Point(415, 331);
            this.btntic9.Name = "btntic9";
            this.btntic9.Size = new System.Drawing.Size(200, 158);
            this.btntic9.TabIndex = 0;
            this.btntic9.UseVisualStyleBackColor = true;
            this.btntic9.Click += new System.EventHandler(this.btntic9_Click);
            // 
            // btntic8
            // 
            this.btntic8.Location = new System.Drawing.Point(209, 331);
            this.btntic8.Name = "btntic8";
            this.btntic8.Size = new System.Drawing.Size(200, 158);
            this.btntic8.TabIndex = 0;
            this.btntic8.UseVisualStyleBackColor = true;
            this.btntic8.Click += new System.EventHandler(this.btntic8_Click);
            // 
            // btntic6
            // 
            this.btntic6.Location = new System.Drawing.Point(415, 167);
            this.btntic6.Name = "btntic6";
            this.btntic6.Size = new System.Drawing.Size(200, 158);
            this.btntic6.TabIndex = 0;
            this.btntic6.UseVisualStyleBackColor = true;
            this.btntic6.Click += new System.EventHandler(this.btntic6_Click);
            // 
            // btntic5
            // 
            this.btntic5.Location = new System.Drawing.Point(209, 167);
            this.btntic5.Name = "btntic5";
            this.btntic5.Size = new System.Drawing.Size(200, 158);
            this.btntic5.TabIndex = 0;
            this.btntic5.UseVisualStyleBackColor = true;
            this.btntic5.Click += new System.EventHandler(this.btntic5_Click);
            // 
            // btntic3
            // 
            this.btntic3.Location = new System.Drawing.Point(415, 3);
            this.btntic3.Name = "btntic3";
            this.btntic3.Size = new System.Drawing.Size(200, 158);
            this.btntic3.TabIndex = 0;
            this.btntic3.UseVisualStyleBackColor = true;
            this.btntic3.Click += new System.EventHandler(this.btntic3_Click);
            // 
            // btntic7
            // 
            this.btntic7.Location = new System.Drawing.Point(3, 331);
            this.btntic7.Name = "btntic7";
            this.btntic7.Size = new System.Drawing.Size(200, 158);
            this.btntic7.TabIndex = 0;
            this.btntic7.UseVisualStyleBackColor = true;
            this.btntic7.Click += new System.EventHandler(this.btntic7_Click);
            // 
            // btntic2
            // 
            this.btntic2.Location = new System.Drawing.Point(209, 3);
            this.btntic2.Name = "btntic2";
            this.btntic2.Size = new System.Drawing.Size(200, 158);
            this.btntic2.TabIndex = 0;
            this.btntic2.UseVisualStyleBackColor = true;
            this.btntic2.Click += new System.EventHandler(this.btntic2_Click);
            // 
            // btntic4
            // 
            this.btntic4.Location = new System.Drawing.Point(3, 167);
            this.btntic4.Name = "btntic4";
            this.btntic4.Size = new System.Drawing.Size(200, 158);
            this.btntic4.TabIndex = 0;
            this.btntic4.UseVisualStyleBackColor = true;
            this.btntic4.Click += new System.EventHandler(this.btntic4_Click);
            // 
            // btntic1
            // 
            this.btntic1.Location = new System.Drawing.Point(3, 3);
            this.btntic1.Name = "btntic1";
            this.btntic1.Size = new System.Drawing.Size(200, 158);
            this.btntic1.TabIndex = 0;
            this.btntic1.UseVisualStyleBackColor = true;
            this.btntic1.Click += new System.EventHandler(this.btntic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1376, 732);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntic1;
        private System.Windows.Forms.Button btntic9;
        private System.Windows.Forms.Button btntic8;
        private System.Windows.Forms.Button btntic6;
        private System.Windows.Forms.Button btntic5;
        private System.Windows.Forms.Button btntic3;
        private System.Windows.Forms.Button btntic7;
        private System.Windows.Forms.Button btntic2;
        private System.Windows.Forms.Button btntic4;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button btnNewgame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPlayerY;
        private System.Windows.Forms.Label LblPlayerX;
    }
}

