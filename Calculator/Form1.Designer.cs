namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblslimcent = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtans = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox1.Controls.Add(this.lblslimcent);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblslimcent
            // 
            this.lblslimcent.AutoSize = true;
            this.lblslimcent.Location = new System.Drawing.Point(15, 350);
            this.lblslimcent.Name = "lblslimcent";
            this.lblslimcent.Size = new System.Drawing.Size(55, 13);
            this.lblslimcent.TabIndex = 3;
            this.lblslimcent.Text = "Slimcent";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtans);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.btnequal);
            this.groupBox3.Controls.Add(this.btnminus);
            this.groupBox3.Controls.Add(this.btnmult);
            this.groupBox3.Controls.Add(this.btndivide);
            this.groupBox3.Controls.Add(this.btndot);
            this.groupBox3.Controls.Add(this.btnplus);
            this.groupBox3.Controls.Add(this.btn2);
            this.groupBox3.Controls.Add(this.btn3);
            this.groupBox3.Controls.Add(this.btn5);
            this.groupBox3.Controls.Add(this.btn0);
            this.groupBox3.Controls.Add(this.btn6);
            this.groupBox3.Controls.Add(this.btn1);
            this.groupBox3.Controls.Add(this.btn8);
            this.groupBox3.Controls.Add(this.btn4);
            this.groupBox3.Controls.Add(this.btn9);
            this.groupBox3.Controls.Add(this.btn7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 246);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Red;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnequal.Location = new System.Drawing.Point(235, 199);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(53, 41);
            this.btnequal.TabIndex = 4;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnminus.Location = new System.Drawing.Point(235, 139);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(53, 41);
            this.btnminus.TabIndex = 4;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(235, 79);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(53, 41);
            this.btnmult.TabIndex = 4;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(235, 19);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(53, 41);
            this.btndivide.TabIndex = 4;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(81, 199);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(50, 41);
            this.btndot.TabIndex = 4;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnplus.Location = new System.Drawing.Point(156, 199);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(54, 41);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(81, 139);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 41);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(156, 139);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 41);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(81, 79);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 41);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 199);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 41);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(156, 79);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 41);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 139);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 41);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(81, 19);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 41);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 79);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 41);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(156, 19);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 41);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.buttonClicking);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 19);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 41);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.buttonClicking);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtans
            // 
            this.txtans.Location = new System.Drawing.Point(12, 23);
            this.txtans.Name = "txtans";
            this.txtans.Size = new System.Drawing.Size(282, 20);
            this.txtans.TabIndex = 0;
            this.txtans.Text = "0";
            this.txtans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 401);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lblslimcent;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtans;
    }
}

