using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Process_Management;

namespace Process_Management
{
    public partial class CreateProcess : Form
    {
        public CreateProcess()
        {
            InitializeComponent();
        }

        private void NeedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NeedButton.Checked == true)
                panel1.Show();
            if(NotNeedButton.Checked == true)
                panel1.Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int temp = (int)IOS.Value + (int)IOC.Value;
            if (temp > (int)Ptime.Value)
            {
                MessageBox.Show("检查I/O操作的时间。", "错误");
                return;
            }
            if ((int)RA.Value > Main.TotalNumberOfA)
            {
                MessageBox.Show("对资源A需求过多。", "错误");
                return;
            }
            if ((int)RB.Value > Main.TotalNumberOfB)
            {
                MessageBox.Show("对资源B需求过多。", "错误");
                return;
            }
            if ((int)RC.Value > Main.TotalNumberOfC)
            {
                MessageBox.Show("对资源C需求过多。","错误");
                return;
            }
            PCB pCB = new PCB();
            pCB.name = PName.Text;
            pCB.ID = Main.NumberOfProcess + 1;
            Main.NumberOfProcess++;
            pCB.Priority = (int)Priority.Value;
            pCB.TotalTime = (int)Ptime.Value;
            pCB.RunTime = 0;

            pCB.RA = (int)RA.Value;
            pCB.RB = (int)RB.Value;
            pCB.RC = (int)RC.Value;

            if (NotNeedButton.Checked == true)
            {
                pCB.IOStrat = -1;
                pCB.IORun = -1;
                pCB.IOTotalTime = -1;
            }
            else
            {
                pCB.IOStrat = (int)IOS.Value;
                pCB.IORun = 0;
                pCB.IOTotalTime = (int)IOC.Value;
            }

            Main.NewQueue.Enqueue(pCB);
            this.Close();

            Main main = new Main(1);
            main.flag++;
            main.Show();

        }
    } 
}
