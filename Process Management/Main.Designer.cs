namespace Process_Management
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateProcessButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.OutputToFileButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CycleButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.TotalA = new System.Windows.Forms.Label();
            this.TotalB = new System.Windows.Forms.Label();
            this.TotalC = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomCreateProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessList
            // 
            this.ProcessList.Location = new System.Drawing.Point(35, 54);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(631, 616);
            this.ProcessList.TabIndex = 0;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "系统中存在的进程";
            // 
            // CreateProcessButton
            // 
            this.CreateProcessButton.Location = new System.Drawing.Point(675, 288);
            this.CreateProcessButton.Name = "CreateProcessButton";
            this.CreateProcessButton.Size = new System.Drawing.Size(206, 44);
            this.CreateProcessButton.TabIndex = 2;
            this.CreateProcessButton.Text = "手动新建进程";
            this.CreateProcessButton.UseVisualStyleBackColor = true;
            this.CreateProcessButton.Click += new System.EventHandler(this.CreateProcessButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(675, 425);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(206, 48);
            this.BlockButton.TabIndex = 3;
            this.BlockButton.Text = "阻塞当前进程";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(685, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前经历时间：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(892, 34);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(31, 36);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "0";
            // 
            // OutputToFileButton
            // 
            this.OutputToFileButton.Location = new System.Drawing.Point(958, 102);
            this.OutputToFileButton.Name = "OutputToFileButton";
            this.OutputToFileButton.Size = new System.Drawing.Size(257, 48);
            this.OutputToFileButton.TabIndex = 7;
            this.OutputToFileButton.Text = "运行结果输出到文件";
            this.OutputToFileButton.UseVisualStyleBackColor = true;
            this.OutputToFileButton.Click += new System.EventHandler(this.OutputToFileButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1265, 102);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(287, 48);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "退出程序";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CycleButton
            // 
            this.CycleButton.Location = new System.Drawing.Point(958, 34);
            this.CycleButton.Name = "CycleButton";
            this.CycleButton.Size = new System.Drawing.Size(594, 48);
            this.CycleButton.TabIndex = 9;
            this.CycleButton.Text = "经过1个时间片";
            this.CycleButton.UseVisualStyleBackColor = true;
            this.CycleButton.Click += new System.EventHandler(this.CycleButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.AcceptsTab = true;
            this.OutputText.Location = new System.Drawing.Point(940, 230);
            this.OutputText.MaxLength = 3276700;
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(612, 440);
            this.OutputText.TabIndex = 10;
            // 
            // ReadyButton
            // 
            this.ReadyButton.Location = new System.Drawing.Point(675, 622);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(195, 48);
            this.ReadyButton.TabIndex = 13;
            this.ReadyButton.Text = "就绪选中进程";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(937, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "系统运行情况";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(685, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "资源B剩余:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(685, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "资源A剩余:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(685, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "资源C剩余:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA.Location = new System.Drawing.Point(789, 102);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 21);
            this.labelA.TabIndex = 19;
            this.labelA.Text = "0";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB.Location = new System.Drawing.Point(789, 145);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 21);
            this.labelB.TabIndex = 20;
            this.labelB.Text = "0";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelC.Location = new System.Drawing.Point(789, 195);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(21, 21);
            this.labelC.TabIndex = 21;
            this.labelC.Text = "0";
            // 
            // TotalA
            // 
            this.TotalA.AutoSize = true;
            this.TotalA.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalA.Location = new System.Drawing.Point(825, 102);
            this.TotalA.Name = "TotalA";
            this.TotalA.Size = new System.Drawing.Size(32, 21);
            this.TotalA.TabIndex = 22;
            this.TotalA.Text = "/0";
            // 
            // TotalB
            // 
            this.TotalB.AutoSize = true;
            this.TotalB.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalB.Location = new System.Drawing.Point(825, 145);
            this.TotalB.Name = "TotalB";
            this.TotalB.Size = new System.Drawing.Size(32, 21);
            this.TotalB.TabIndex = 23;
            this.TotalB.Text = "/0";
            // 
            // TotalC
            // 
            this.TotalC.AutoSize = true;
            this.TotalC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalC.Location = new System.Drawing.Point(825, 195);
            this.TotalC.Name = "TotalC";
            this.TotalC.Size = new System.Drawing.Size(32, 21);
            this.TotalC.TabIndex = 24;
            this.TotalC.Text = "/0";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(792, 573);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(78, 28);
            this.IDTextBox.TabIndex = 25;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "输入ID：";
            // 
            // RandomCreateProcessButton
            // 
            this.RandomCreateProcessButton.Location = new System.Drawing.Point(675, 351);
            this.RandomCreateProcessButton.Name = "RandomCreateProcessButton";
            this.RandomCreateProcessButton.Size = new System.Drawing.Size(206, 50);
            this.RandomCreateProcessButton.TabIndex = 27;
            this.RandomCreateProcessButton.Text = "随机创建进程";
            this.RandomCreateProcessButton.UseVisualStyleBackColor = true;
            this.RandomCreateProcessButton.Click += new System.EventHandler(this.RandomCreateProcessButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1678, 716);
            this.Controls.Add(this.RandomCreateProcessButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.TotalC);
            this.Controls.Add(this.TotalB);
            this.Controls.Add(this.TotalA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.CycleButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputToFileButton);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.CreateProcessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessList);
            this.MinimumSize = new System.Drawing.Size(1700, 772);
            this.Name = "Main";
            this.Text = "进程管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.ListView ProcessList;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Button CreateProcessButton;
        private global::System.Windows.Forms.Button BlockButton;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label labelTime;
        private global::System.Windows.Forms.Button OutputToFileButton;
        private global::System.Windows.Forms.Button ExitButton;
        private global::System.Windows.Forms.Button CycleButton;
        private global::System.Windows.Forms.TextBox OutputText;
        private global::System.Windows.Forms.Button ReadyButton;
        private global::System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label TotalA;
        private System.Windows.Forms.Label TotalB;
        private System.Windows.Forms.Label TotalC;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RandomCreateProcessButton;
    }
}

