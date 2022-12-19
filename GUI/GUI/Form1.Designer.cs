namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.arrowButton1 = new ArrowButton.ArrowButton();
            this.arrowButton2 = new ArrowButton.ArrowButton();
            this.arrowButton3 = new ArrowButton.ArrowButton();
            this.arrowButton4 = new ArrowButton.ArrowButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(62, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "auto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(229, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "manual";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(87, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 84);
            this.button3.TabIndex = 3;
            this.button3.Text = "STOP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // arrowButton1
            // 
            this.arrowButton1.ArrowEnabled = true;
            this.arrowButton1.HoverEndColor = System.Drawing.Color.DarkRed;
            this.arrowButton1.HoverStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton1.Location = new System.Drawing.Point(87, 14);
            this.arrowButton1.Name = "arrowButton1";
            this.arrowButton1.NormalEndColor = System.Drawing.Color.DarkGray;
            this.arrowButton1.NormalStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton1.Rotation = 180;
            this.arrowButton1.Size = new System.Drawing.Size(84, 84);
            this.arrowButton1.TabIndex = 6;
            // 
            // arrowButton2
            // 
            this.arrowButton2.ArrowEnabled = true;
            this.arrowButton2.HoverEndColor = System.Drawing.Color.DarkRed;
            this.arrowButton2.HoverStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton2.Location = new System.Drawing.Point(177, 104);
            this.arrowButton2.Name = "arrowButton2";
            this.arrowButton2.NormalEndColor = System.Drawing.Color.DarkGray;
            this.arrowButton2.NormalStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton2.Rotation = 270;
            this.arrowButton2.Size = new System.Drawing.Size(84, 84);
            this.arrowButton2.TabIndex = 7;
            // 
            // arrowButton3
            // 
            this.arrowButton3.ArrowEnabled = true;
            this.arrowButton3.HoverEndColor = System.Drawing.Color.DarkRed;
            this.arrowButton3.HoverStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton3.Location = new System.Drawing.Point(87, 190);
            this.arrowButton3.Name = "arrowButton3";
            this.arrowButton3.NormalEndColor = System.Drawing.Color.DarkGray;
            this.arrowButton3.NormalStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton3.Rotation = 0;
            this.arrowButton3.Size = new System.Drawing.Size(84, 84);
            this.arrowButton3.TabIndex = 8;
            // 
            // arrowButton4
            // 
            this.arrowButton4.ArrowEnabled = true;
            this.arrowButton4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrowButton4.HoverEndColor = System.Drawing.Color.DarkRed;
            this.arrowButton4.HoverStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton4.Location = new System.Drawing.Point(0, 104);
            this.arrowButton4.Name = "arrowButton4";
            this.arrowButton4.NormalEndColor = System.Drawing.Color.DarkGray;
            this.arrowButton4.NormalStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButton4.Rotation = 90;
            this.arrowButton4.Size = new System.Drawing.Size(84, 84);
            this.arrowButton4.TabIndex = 9;
            this.arrowButton4.Click += new System.EventHandler(this.arrowButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.arrowButton1);
            this.groupBox1.Controls.Add(this.arrowButton4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.arrowButton3);
            this.groupBox1.Controls.Add(this.arrowButton2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(62, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 275);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(392, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Autonomous Car Control";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ArrowButton.ArrowButton arrowButton1;
        private ArrowButton.ArrowButton arrowButton2;
        private ArrowButton.ArrowButton arrowButton3;
        private ArrowButton.ArrowButton arrowButton4;
        private GroupBox groupBox1;
    }
}