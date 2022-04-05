
namespace hedh
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabThread = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTestThread = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.tabThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProcess);
            this.tabControl1.Controls.Add(this.tabThread);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.btnStart);
            this.tabProcess.Controls.Add(this.btnStop);
            this.tabProcess.Controls.Add(this.btnGet);
            this.tabProcess.Controls.Add(this.textBox1);
            this.tabProcess.Controls.Add(this.listBox1);
            this.tabProcess.Location = new System.Drawing.Point(4, 25);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(791, 419);
            this.tabProcess.TabIndex = 0;
            this.tabProcess.Text = "Process";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(645, 357);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 36);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(645, 217);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(645, 147);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 34);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Process";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 357);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(543, 36);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(48, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(543, 292);
            this.listBox1.TabIndex = 0;
            // 
            // tabThread
            // 
            this.tabThread.Controls.Add(this.checkBox1);
            this.tabThread.Controls.Add(this.button2);
            this.tabThread.Controls.Add(this.label1);
            this.tabThread.Controls.Add(this.button1);
            this.tabThread.Controls.Add(this.txtTestThread);
            this.tabThread.Location = new System.Drawing.Point(4, 25);
            this.tabThread.Name = "tabThread";
            this.tabThread.Padding = new System.Windows.Forms.Padding(3);
            this.tabThread.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabThread.Size = new System.Drawing.Size(791, 419);
            this.tabThread.TabIndex = 1;
            this.tabThread.Text = "Thread";
            this.tabThread.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(362, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 39);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Stop";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTestThread
            // 
            this.txtTestThread.Location = new System.Drawing.Point(44, 46);
            this.txtTestThread.Multiline = true;
            this.txtTestThread.Name = "txtTestThread";
            this.txtTestThread.Size = new System.Drawing.Size(139, 39);
            this.txtTestThread.TabIndex = 0;
            this.txtTestThread.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Run notepad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            this.tabThread.ResumeLayout(false);
            this.tabThread.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.TabPage tabThread;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTestThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}

