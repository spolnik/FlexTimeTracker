using System;
using System.IO;
using System.Xml.Serialization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using FlexTimeTracker.Properties;

namespace FlexTimeTracker
{
    public partial class FlexTimeTrackerTask : XtraUserControl
    {
        private readonly FlexTaskEntity _flexTaskEntity;
        private bool _isPaused;

        public FlexTimeTrackerTask()
        {
            this.InitializeComponent();
            this._flexTaskEntity = new FlexTaskEntity();
            this._isPaused = false;
        }

        private void firstTaskStartButton_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this._flexTaskEntity.TickOneSecond();

            this.progressBarControl.PerformStep();

            this.minuteLabel.Text = this._flexTaskEntity.Duration.Minutes < 10
                                        ? string.Concat("0", this._flexTaskEntity.Duration.Minutes)
                                        : this._flexTaskEntity.Duration.Minutes.ToString();

            this.hourLabel.Text = this._flexTaskEntity.Duration.Hours < 10
                                      ? string.Concat("0", this._flexTaskEntity.Duration.Hours)
                                      : this._flexTaskEntity.Duration.Hours.ToString();
        }

        private void firstTaskPauseButton_Click(object sender, EventArgs e)
        {
            this.Pause();
        }

        internal void Pause()
        {
            if (this.taskPauseButton.Visible == false)
                return;

            if (this._isPaused)
            {
                this.taskPauseButton.Text = "Pause";
                this._isPaused = false;
                this.timer.Start();
            }
            else
            {
                this.taskPauseButton.Text = "Resume";
                this._isPaused = true;
                this.timer.Stop();
            }
        }

        private void firstTaskFinishButton_Click(object sender, EventArgs e)
        {
            this.Finish();
        }

        internal double Finish()
        {
            if (this.taskFinishButton.Visible == false)
                return 0.0;

            var result = this._flexTaskEntity.Hours + this.GetFromMinutes();

            this.timer.Stop();
            this.progressBarControl.Position = 0;
            this.minuteLabel.Text = "00";
            this.hourLabel.Text = "00";

            CreateRepositoryDictionary();

            this.SerializeTask();

            this.taskName.Text = string.Empty;
            this.timeTodo.Value = 2.0m;

            this.ChangeTrackerState();

            return result;
        }

        private void ChangeTrackerState()
        {
            this.timeTodo.Enabled = !this.timeTodo.Enabled;
            this.taskName.Enabled = !this.taskName.Enabled;
            this.taskStartButton.Visible = !this.taskStartButton.Visible;
            this.taskPauseButton.Visible = !this.taskPauseButton.Visible;
            this.taskFinishButton.Visible = !this.taskFinishButton.Visible;
        }

        private double GetFromMinutes()
        {
            var minutes = (double)this._flexTaskEntity.Minutes;

            return minutes < 15 ? 0.0 : (minutes < 45 ? 0.5 : 1.0);
        }

        private void SerializeTask()
        {
            var xmlSerializer = new XmlSerializer(typeof(FlexTaskEntity));
            var streamWriter =
                new StreamWriter(string.Format("{0}\\{1}-{2}.xml", Settings.Default.FlexTimeTrackerRepository, this._flexTaskEntity.Name,
                                               this._flexTaskEntity.CreatedOn.ToFileTime()));
            xmlSerializer.Serialize(streamWriter, this._flexTaskEntity);
        }

        private static void CreateRepositoryDictionary()
        {
            if (!Directory.Exists(Settings.Default.FlexTimeTrackerRepository))
                Directory.CreateDirectory(Settings.Default.FlexTimeTrackerRepository);
        }

        internal void Start()
        {
            if (this.taskStartButton.Visible == false)
                return;

            this.dxErrorProvider.ClearErrors();

            if (string.IsNullOrEmpty(this.taskName.Text))
            {
                this.dxErrorProvider.SetError(this.taskName, "Task name cannot be empty.", ErrorType.Critical);
                this.Parent.Show();
                return;
            }

            this.progressBarControl.Properties.Maximum = (int)(this.timeTodo.Value * 60 * 60);
            
            this.ChangeTrackerState();

            this._flexTaskEntity.Name = this.taskName.Text;

            this.timer.Start();
        }
    }
}
