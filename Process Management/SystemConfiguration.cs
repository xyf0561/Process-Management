using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Process_Management;

namespace Process_Management
{
    public partial class SystemConfiguration : Form
    {
        public SystemConfiguration()
        {
            InitializeComponent();
            string NumberOfA = ConfigurationManager.AppSettings["NumberOfA"];
            string NumberOfB = ConfigurationManager.AppSettings["NumberOfB"];
            string NumberOfC = ConfigurationManager.AppSettings["NumberOfC"];
            string TimeOfPriority1 = ConfigurationManager.AppSettings["TimeOfPriority1"];
            string TimeOfPriority2 = ConfigurationManager.AppSettings["TimeOfPriority2"];
            string TimeOfPriority3 = ConfigurationManager.AppSettings["TimeOfPriority3"];

            NumberA.Value = Convert.ToInt32(NumberOfA);
            NumberB.Value = Convert.ToInt32(NumberOfB);
            NumberC.Value = Convert.ToInt32(NumberOfC);
            Priority1.Value = Convert.ToInt32(TimeOfPriority1);
            Priority2.Value = Convert.ToInt32(TimeOfPriority2);
            Priority3.Value = Convert.ToInt32(TimeOfPriority3);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Main.NumberOfA = (int)NumberA.Value;
            Main.NumberOfB = (int)NumberB.Value;
            Main.NumberOfC = (int)NumberC.Value;
            Main.TotalNumberOfA = Main.NumberOfA;
            Main.TotalNumberOfB = Main.NumberOfB;
            Main.TotalNumberOfC = Main.NumberOfC;
            Main.TimeOfPriority1 = (int)Priority1.Value;
            Main.TimeOfPriority2 = (int)Priority2.Value;
            Main.TimeOfPriority3 = (int)Priority3.Value;
            this.Close();
        }
    }
}
