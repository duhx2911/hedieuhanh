using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // Gọi thư viện Process
using System.Threading;

namespace hedh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public void GetProcess()
        {
            listBox1.Items.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                listBox1.Items.Add(p.ProcessName + " - " + p.Id);
            }
        }

        public void stopProcess()
        {
            foreach (Process p in Process.GetProcesses())
            {
                string[] arr = listBox1.SelectedItem.ToString().Split('-');
                string sProcess = arr[0].Trim();
                int iID = Convert.ToInt32(arr[1].Trim());
                if (p.ProcessName == sProcess && p.Id == iID)
                {
                    try
                    {
                        p.Kill();
                        MessageBox.Show("Process Killed", "Task");
                    }
                    catch
                    {
                        MessageBox.Show("Failed", "Task");
                    }

                }
            }
            GetProcess();
        }
        public void startProcess()
        {
            string text = textBox1.Text;
            Process process = new Process();
            process.StartInfo.FileName = text;
            process.Start();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopProcess();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startProcess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart thrs = new ThreadStart(testThread);
            Thread thr = new Thread(thrs);
            thr.Start();
        }
        void testThread()
        {
            for (int i = 0; i < Convert.ToInt32(txtTestThread.Text); i++)
            {
                label1.Text = i.ToString();
                if(checkBox1.Checked == true)
                {
                    break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
    }
}
