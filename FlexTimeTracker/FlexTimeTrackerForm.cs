using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FlexTimeTracker.Properties;

namespace FlexTimeTracker
{
    public partial class FlexTimeTrackerForm : XtraForm
    {
        private double _todo;
        private double _reported;

        public double Todo
        {
            get { return this._todo; }
            set
            {
                this._todo = value;
                this.todoLabel.Text = this.Todo.ToString();
            }
        }

        public double Reported
        {
            get { return this._reported; }
            set
            {
                this._reported = value;
                this.reportedLabel.Text = this.Reported.ToString();
            }
        }

        public FlexTimeTrackerForm()
        {
            InitializeComponent();
            this.Todo = Settings.Default.EffectiveHours;
            this.Reported = 0d;
        }

        private void FlexTimeTrackerForm_Resize(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.flexTimeTrackerTask1.Start();
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.flexTimeTrackerTask1.Pause();
        }

        private void finishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.flexTimeTrackerTask1.Finish();
        }
    }
}
