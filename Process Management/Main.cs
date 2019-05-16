using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Management
{
    struct PCB
    {
        public string name;
        public int ID;
        public int Priority;
        public int TotalTime;
        public int RunTime;

        public int IOStrat;
        public int IOTotalTime;
        public int IORun;

        public int RA;
        public int RB;
        public int RC;
    }
    public partial class Main : Form
    {
        public static int NumberOfProcess = 0;
        public static int Time = 0;
        public static int TotalNumberOfA;
        public static int TotalNumberOfB;
        public static int TotalNumberOfC;
        public static int NumberOfA;
        public static int NumberOfB;
        public static int NumberOfC;
        public static int TimeOfPriority1;
        public static int TimeOfPriority2;
        public static int TimeOfPriority3;

        public static Queue NewQueue = new Queue();
        public static Queue RunQueue = new Queue();
        public static Queue BlockQueue = new Queue();
        public static Queue Priority1Queue = new Queue();
        public static Queue Priority2Queue = new Queue();
        public static Queue Priority3Queue = new Queue();

        
        private int Flag = 0;
        public int flag
        {
            get { return Flag; }
            set
            {
                if (value != Flag)
                {
                    PrintList();
                }

                Flag = value;
            }
        }

        public void PrintList()
        {
            ProcessList.Clear();
            this.ProcessList.Columns.Add("进程ID", 90, HorizontalAlignment.Left);
            this.ProcessList.Columns.Add("进程名", 60, HorizontalAlignment.Left);
            this.ProcessList.Columns.Add("已运行时间", 80, HorizontalAlignment.Left);
            this.ProcessList.Columns.Add("需要的总时间", 100, HorizontalAlignment.Left);
            this.ProcessList.Columns.Add("I/O状态", 80, HorizontalAlignment.Left);

            this.ProcessList.ShowGroups = true;
            this.ProcessList.BeginUpdate();
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = "新建队列：";
            this.ProcessList.Items.Add(lvi1);
            foreach (PCB x in NewQueue)
            {
              ListViewItem lvi = new ListViewItem();
               lvi.Text =  x.ID+"";
              lvi.SubItems.Add(x.name + "");
              lvi.SubItems.Add(x.RunTime+"");
              lvi.SubItems.Add(x.TotalTime + "");
             if(x.IOStrat==-1)
               lvi.SubItems.Add("不需要");
             else if(x.IOTotalTime>x.IORun)
                lvi.SubItems.Add("未完成");
              else
                   lvi.SubItems.Add("已完成");
            this.ProcessList.Items.Add(lvi);
            }
            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = "运行队列：";
            this.ProcessList.Items.Add(lvi2);
            foreach (PCB x in RunQueue)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = x.ID + "";
                lvi.SubItems.Add(x.name + "");
                lvi.SubItems.Add(x.RunTime + "");
                lvi.SubItems.Add(x.TotalTime + "");
                if (x.IOStrat == -1)
                    lvi.SubItems.Add("不需要");
                else if (x.IOTotalTime == x.IORun)
                    lvi.SubItems.Add("未完成");
                else
                    lvi.SubItems.Add("已完成");
                this.ProcessList.Items.Add(lvi);
            }
            ListViewItem lvi3 = new ListViewItem();
            lvi3.Text = "优先级1队列：";
            this.ProcessList.Items.Add(lvi3);
            foreach (PCB x in Priority1Queue)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = x.ID + "";
                lvi.SubItems.Add(x.name + "");
                lvi.SubItems.Add(x.RunTime + "");
                lvi.SubItems.Add(x.TotalTime + "");
                if (x.IOStrat == -1)
                    lvi.SubItems.Add("不需要");
                else if (x.IOTotalTime == x.IORun)
                    lvi.SubItems.Add("未完成");
                else
                    lvi.SubItems.Add("已完成");
                this.ProcessList.Items.Add(lvi);
            }
            ListViewItem lvi4 = new ListViewItem();
            lvi4.Text = "优先级2队列：";
            this.ProcessList.Items.Add(lvi4);
            foreach (PCB x in Priority2Queue)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = x.ID + "";
                lvi.SubItems.Add(x.name + "");
                lvi.SubItems.Add(x.RunTime + "");
                lvi.SubItems.Add(x.TotalTime + "");
                if (x.IOStrat == -1)
                    lvi.SubItems.Add("不需要");
                else if (x.IOTotalTime == x.IORun)
                    lvi.SubItems.Add("未完成");
                else
                    lvi.SubItems.Add("已完成");
                this.ProcessList.Items.Add(lvi);
            }
            ListViewItem lvi5 = new ListViewItem();
            lvi5.Text = "优先级3队列：";
            this.ProcessList.Items.Add(lvi5);
            foreach (PCB x in Priority3Queue)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = x.ID + "";
                lvi.SubItems.Add(x.name + "");
                lvi.SubItems.Add(x.RunTime + "");
                lvi.SubItems.Add(x.TotalTime + "");
                if (x.IOStrat == -1)
                    lvi.SubItems.Add("不需要");
                else if (x.IOTotalTime == x.IORun)
                    lvi.SubItems.Add("未完成");
                else
                    lvi.SubItems.Add("已完成");
                this.ProcessList.Items.Add(lvi);
            }
            ListViewItem lvi6 = new ListViewItem();
            lvi6.Text = "阻塞队列：";
            this.ProcessList.Items.Add(lvi6);
            foreach (PCB x in BlockQueue)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = x.ID + "";
                lvi.SubItems.Add(x.name + "");
                lvi.SubItems.Add(x.RunTime + "");
                lvi.SubItems.Add(x.TotalTime + "");
                if (x.IOStrat == -1)
                    lvi.SubItems.Add("不需要");
                else if (x.IOTotalTime == x.IORun)
                    lvi.SubItems.Add("未完成");
                else
                    lvi.SubItems.Add("已完成");
                this.ProcessList.Items.Add(lvi);
            }

            this.ProcessList.View = View.Details;
            this.ProcessList.EndUpdate();
        }
        public Main(int i)
        {
            InitializeComponent();
            if (i==0)
            {
                SystemConfiguration SystemConfiguration = new SystemConfiguration();
                SystemConfiguration.Visible = false;
                SystemConfiguration.ShowDialog();
                
            }
            
            this.Hide();
            labelA.Text = NumberOfA + "";
            labelB.Text = NumberOfB + "";
            labelC.Text = NumberOfC + "";
            TotalA.Text = "/" + TotalNumberOfA;
            TotalB.Text = "/" + TotalNumberOfB;
            TotalC.Text = "/" + TotalNumberOfC;


            flag = flag + 1;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateProcessButton_Click(object sender, EventArgs e)
        {
            CreateProcess CreateProcess = new CreateProcess();
            CreateProcess.Show();
            this.Hide();
        }

        private void OutputToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "文本文件|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                FileStream fs = File.Open(fileName,
                        FileMode.Create,
                        FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);

                foreach (string line in OutputText.Lines)
                {
                    wr.WriteLine(line);
                }

                wr.Flush();
                wr.Close();
                fs.Close();
            }
        }

        private void CycleButton_Click(object sender, EventArgs e)
        {
            if((NewQueue.Count == 0) &&(BlockQueue.Count == 0)&&(RunQueue.Count == 0)&&(Priority3Queue.Count == 0)&&
                    (Priority1Queue.Count == 0)&&(Priority2Queue.Count == 0))
            {
                MessageBox.Show("系统中已经没有进程。", "错误");
                OutputText.AppendText("时间"+Time+":  系统中已经没有进程。"+ "\r\n");
                return;
            }

            while (NewQueue.Count != 0)
            {
                PCB temp = (PCB)NewQueue.Dequeue();
                if((NumberOfA>=temp.RA) &&(NumberOfB >= temp.RB)&&(NumberOfC >= temp.RC))
                {
                    NumberOfA -= temp.RA;
                    labelA.Text = NumberOfA + "";
                    NumberOfB -= temp.RB;
                    labelB.Text = NumberOfB + "";
                    NumberOfC -= temp.RC;
                    labelC.Text = NumberOfC + "";

                    if (temp.Priority == 1)
                        Priority1Queue.Enqueue(temp);
                    else if(temp.Priority == 2)
                        Priority2Queue.Enqueue(temp);
                    else
                        Priority3Queue.Enqueue(temp);
                    OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "已申请到所需资源。进入就绪队列排队" + "\r\n");
                }
                else
                {
                    BlockQueue.Enqueue(temp);
                    OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "没有申请到所需资源。进入阻塞队列排队" + "\r\n");
                }
                temp.IORun++;
                    
            }

            if(RunQueue.Count != 0)
            {
                PCB temp = (PCB)RunQueue.Dequeue();
                int p = temp.Priority;
                if (p == 1)
                {
                    if((temp.TotalTime-temp.RunTime)>TimeOfPriority1)
                    {
                        
                        Time += TimeOfPriority1;
                        temp.RunTime += TimeOfPriority1;
                        if ((temp.IOStrat + temp.IOTotalTime) < temp.RunTime)
                            temp.IORun = temp.IOTotalTime;
                        temp.Priority = 2;
                        Priority2Queue.Enqueue(temp);
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "时间片到，进入就绪队列排队" + "\r\n");
                    }
                    else if ((temp.TotalTime - temp.RunTime) == TimeOfPriority1){
                        Time += TimeOfPriority1;
                        NumberOfA += temp.RA;
                        labelA.Text = NumberOfA + "";
                        NumberOfB += temp.RB;
                        labelB.Text = NumberOfB + "";
                        NumberOfC += temp.RC;
                        labelC.Text = NumberOfC + "";
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "运行完毕，进程正常结束" + "\r\n");
                    }
                    else
                    {
                        Time += (temp.TotalTime - temp.RunTime);
                        NumberOfA += temp.RA;
                        labelA.Text = NumberOfA + "";
                        NumberOfB += temp.RB;
                        labelB.Text = NumberOfB + "";
                        NumberOfC += temp.RC;
                        labelC.Text = NumberOfC + "";
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "运行完毕，进程正常结束" + "\r\n");
                    }
                    temp.IORun++;

                }
                    
                else if(p == 2)
                {
                    if ((temp.TotalTime - temp.RunTime) > TimeOfPriority2)
                    {

                        Time += TimeOfPriority2;
                        temp.RunTime += TimeOfPriority2;
                        if ((temp.IOStrat + temp.IOTotalTime) < temp.RunTime)
                            temp.IORun = temp.IOTotalTime;
                        temp.Priority = 3;
                        Priority3Queue.Enqueue(temp);
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "时间片到，进入就绪队列排队" + "\r\n");
                    }
                    else if ((temp.TotalTime - temp.RunTime) == TimeOfPriority2)
                    {
                        Time += TimeOfPriority2;
                        NumberOfA += temp.RA;
                        labelA.Text = NumberOfA + "";
                        NumberOfB += temp.RB;
                        labelB.Text = NumberOfB + "";
                        NumberOfC += temp.RC;
                        labelC.Text = NumberOfC + "";
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "运行完毕，进程正常结束" + "\r\n");
                    }
                    else
                    {
                        Time += (temp.TotalTime - temp.RunTime);
                        NumberOfA += temp.RA;
                        labelA.Text = NumberOfA + "";
                        NumberOfB += temp.RB;
                        labelB.Text = NumberOfB + "";
                        NumberOfC += temp.RC;
                        labelC.Text = NumberOfC + "";
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "运行完毕，进程正常结束" + "\r\n");
                    }
                }
                    
                else
                {
                    if ((temp.TotalTime - temp.RunTime) > TimeOfPriority3)
                    {

                        Time += TimeOfPriority3;
                        temp.RunTime += TimeOfPriority3;
                        if ((temp.IOStrat + temp.IOTotalTime) < temp.RunTime)
                            temp.IORun = temp.IOTotalTime;
                        temp.Priority = 3;
                        Priority3Queue.Enqueue(temp);
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "时间片到，进入就绪队列排队" + "\r\n");
                    }
                    else if ((temp.TotalTime - temp.RunTime) == TimeOfPriority3)
                    {
                        Time += TimeOfPriority3;
                        NumberOfA += temp.RA;
                        labelA.Text = NumberOfA + "";
                        NumberOfB += temp.RB;
                        labelB.Text = NumberOfB + "";
                        NumberOfC += temp.RC;
                        labelC.Text = NumberOfC + "";
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "运行完毕，进程正常结束" + "\r\n");
                    }
                    else
                    {
                        Time += (temp.TotalTime - temp.RunTime);
                        NumberOfA += temp.RA;
                        labelA.Text = NumberOfA + "";
                        NumberOfB += temp.RB;
                        labelB.Text = NumberOfB + "";
                        NumberOfC += temp.RC;
                        labelC.Text = NumberOfC + "";
                        OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "运行完毕，进程正常结束" + "\r\n");
                    }
                }
                labelTime.Text = Time+"";
            }

            int count = BlockQueue.Count;
            for( int i = 0;i<count;i++)
            {
                PCB temp = (PCB)BlockQueue.Dequeue();
                if ((NumberOfA >= temp.RA) && (NumberOfB >= temp.RB) && (NumberOfC >= temp.RC))
                {
                    OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "，申请到所需的资源，进入就绪队列排队" + "\r\n");
                    if (temp.Priority == 1)
                        Priority1Queue.Enqueue(temp);

                    else if (temp.Priority == 2)
                        Priority2Queue.Enqueue(temp);
                    else
                        Priority3Queue.Enqueue(temp);
                    NumberOfA -= temp.RA;
                    labelA.Text = NumberOfA + "";
                    NumberOfB -= temp.RB;
                    labelB.Text = NumberOfB + "";
                    NumberOfC -= temp.RC;
                    labelC.Text = NumberOfC + "";
                }
                else
                    BlockQueue.Enqueue(temp);

            }
            if (Priority1Queue.Count > 0)
            {
                PCB temp = (PCB)Priority1Queue.Dequeue();
                RunQueue.Enqueue(temp);
                OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "进入运行队列，开始运行" + "\r\n");
            }
            else if(Priority2Queue.Count > 0){
                PCB temp = (PCB)Priority2Queue.Dequeue();
                RunQueue.Enqueue(temp);
                OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "进入运行队列，开始运行"  + "\r\n");
            }
            else if (Priority3Queue.Count > 0)
            {
                PCB temp = (PCB)Priority3Queue.Dequeue();
                RunQueue.Enqueue(temp);
                OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "进入运行队列，开始运行" + "\r\n");
            }
            flag++;
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            PCB temp = (PCB)RunQueue.Dequeue();
            BlockQueue.Enqueue(temp);
            NumberOfA += temp.RA;
            labelA.Text = NumberOfA + "";
            NumberOfB += temp.RB;
            labelB.Text = NumberOfB + "";
            NumberOfC += temp.RC;
            labelC.Text = NumberOfC + "";
            OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "（手动）进入阻塞队列" + "\r\n");
            flag++;
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(IDTextBox.Text);
            if (num <= 0) {
                MessageBox.Show("输入数据有误", "警告");
            }
            int count = BlockQueue.Count;
            for (int i = 0; i < count; i++)
            {
                PCB temp = (PCB)BlockQueue.Dequeue();
                if (num== temp.ID)
                {
                    temp.RA = 0;
                    temp.RB = 0;
                    temp.RC = 0;
                    if (temp.Priority == 1)
                        Priority1Queue.Enqueue(temp);

                    else if (temp.Priority == 2)
                        Priority2Queue.Enqueue(temp);
                    else
                        Priority3Queue.Enqueue(temp);
                    num = -1;
                    OutputText.AppendText("时间" + Time + ":  进程ID：" + temp.ID + "（手动）进入就绪队列排队" + "\r\n");
                }
                else
                    BlockQueue.Enqueue(temp);

            }
            if(num!=-1)
                OutputText.AppendText("时间" + Time + ":  错误：未找到用户指定的进程。" + "\r\n");
            flag++;
        }

        private void RandomCreateProcessButton_Click(object sender, EventArgs e)
        {
            System.Random a = new Random(System.DateTime.Now.Millisecond);
            PCB pCB = new PCB();
            pCB.ID = Main.NumberOfProcess + 1;
            pCB.name = "Random" + pCB.ID;
            Main.NumberOfProcess++;
            pCB.Priority = (int)a.Next(1,4);
            pCB.TotalTime = (int)a.Next(1, 30);
            pCB.RunTime = 0;

            pCB.RA = (int)a.Next(0, TotalNumberOfA);
            pCB.RB = (int)a.Next(0, TotalNumberOfB);
            pCB.RC = (int)a.Next(0, TotalNumberOfC);
            pCB.IOStrat = -1;
            pCB.IORun = -1;
            pCB.IOTotalTime = -1;
            Main.NewQueue.Enqueue(pCB);
            flag++;

        }
    }
}
