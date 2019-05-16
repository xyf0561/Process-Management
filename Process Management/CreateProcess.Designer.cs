namespace Process_Management
{
    partial class CreateProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NeedButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.NotNeedButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IOC = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.IOS = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Ptime = new System.Windows.Forms.NumericUpDown();
            this.Priority = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RA = new System.Windows.Forms.NumericUpDown();
            this.RB = new System.Windows.Forms.NumericUpDown();
            this.RC = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "进程名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "初始优先级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "总运行时间：";
            // 
            // NeedButton
            // 
            this.NeedButton.AutoSize = true;
            this.NeedButton.Location = new System.Drawing.Point(475, 32);
            this.NeedButton.Name = "NeedButton";
            this.NeedButton.Size = new System.Drawing.Size(69, 22);
            this.NeedButton.TabIndex = 3;
            this.NeedButton.TabStop = true;
            this.NeedButton.Text = "需要";
            this.NeedButton.UseVisualStyleBackColor = true;
            this.NeedButton.CheckedChanged += new System.EventHandler(this.NeedButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "是否需要I/O：";
            // 
            // NotNeedButton
            // 
            this.NotNeedButton.AutoSize = true;
            this.NotNeedButton.Location = new System.Drawing.Point(564, 32);
            this.NotNeedButton.Name = "NotNeedButton";
            this.NotNeedButton.Size = new System.Drawing.Size(87, 22);
            this.NotNeedButton.TabIndex = 5;
            this.NotNeedButton.TabStop = true;
            this.NotNeedButton.Text = "不需要";
            this.NotNeedButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IOC);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.IOS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(357, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 118);
            this.panel1.TabIndex = 7;
            // 
            // IOC
            // 
            this.IOC.Location = new System.Drawing.Point(151, 59);
            this.IOC.Name = "IOC";
            this.IOC.Size = new System.Drawing.Size(65, 28);
            this.IOC.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "I/O持续时间：";
            // 
            // IOS
            // 
            this.IOS.Location = new System.Drawing.Point(151, 20);
            this.IOS.Name = "IOS";
            this.IOS.Size = new System.Drawing.Size(65, 28);
            this.IOS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "I/O开始时刻";
            // 
            // Ptime
            // 
            this.Ptime.Location = new System.Drawing.Point(186, 134);
            this.Ptime.Name = "Ptime";
            this.Ptime.Size = new System.Drawing.Size(65, 28);
            this.Ptime.TabIndex = 11;
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(186, 83);
            this.Priority.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Priority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(65, 28);
            this.Priority.TabIndex = 12;
            this.Priority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "A类资源需求：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "B类资源需求：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "C类资源需求：";
            // 
            // RA
            // 
            this.RA.Location = new System.Drawing.Point(186, 181);
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(65, 28);
            this.RA.TabIndex = 16;
            // 
            // RB
            // 
            this.RB.Location = new System.Drawing.Point(186, 228);
            this.RB.Name = "RB";
            this.RB.Size = new System.Drawing.Size(65, 28);
            this.RB.TabIndex = 17;
            // 
            // RC
            // 
            this.RC.Location = new System.Drawing.Point(186, 273);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(65, 28);
            this.RC.TabIndex = 18;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(421, 232);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(194, 61);
            this.ConfirmButton.TabIndex = 19;
            this.ConfirmButton.Text = "创建完毕";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(145, 31);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(106, 28);
            this.PName.TabIndex = 20;
            // 
            // CreateProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 352);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.RB);
            this.Controls.Add(this.RA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.Ptime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NotNeedButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NeedButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateProcess";
            this.Text = "创建新进程";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.RadioButton NeedButton;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.RadioButton NotNeedButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown IOC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown IOS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Ptime;
        private System.Windows.Forms.NumericUpDown Priority;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown RA;
        private System.Windows.Forms.NumericUpDown RB;
        private System.Windows.Forms.NumericUpDown RC;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox PName;
    }
}