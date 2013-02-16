namespace FlexTimeTracker
{
    partial class FlexTimeTrackerTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.timeTodo = new DevExpress.XtraEditors.SpinEdit();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.minuteLabel = new DevExpress.XtraEditors.LabelControl();
            this.taskName = new DevExpress.XtraEditors.TextEdit();
            this.hourLabel = new DevExpress.XtraEditors.LabelControl();
            this.taskFinishButton = new DevExpress.XtraEditors.SimpleButton();
            this.taskStartButton = new DevExpress.XtraEditors.SimpleButton();
            this.taskPauseButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.groupControl.Appearance.Options.UseBackColor = true;
            this.groupControl.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupControl.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl.Controls.Add(this.timeTodo);
            this.groupControl.Controls.Add(this.progressBarControl);
            this.groupControl.Controls.Add(this.minuteLabel);
            this.groupControl.Controls.Add(this.taskName);
            this.groupControl.Controls.Add(this.hourLabel);
            this.groupControl.Controls.Add(this.taskFinishButton);
            this.groupControl.Controls.Add(this.taskStartButton);
            this.groupControl.Controls.Add(this.taskPauseButton);
            this.groupControl.Location = new System.Drawing.Point(3, 3);
            this.groupControl.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(303, 105);
            this.groupControl.TabIndex = 2;
            this.groupControl.Text = "My Actual Task";
            // 
            // timeTodo
            // 
            this.timeTodo.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.timeTodo.Location = new System.Drawing.Point(5, 55);
            this.timeTodo.Name = "timeTodo";
            this.timeTodo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.timeTodo.Properties.Appearance.Options.UseForeColor = true;
            this.timeTodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeTodo.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timeTodo.Properties.MaxValue = new decimal(new int[] {
            125,
            0,
            0,
            65536});
            this.timeTodo.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timeTodo.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.timeTodo.Size = new System.Drawing.Size(88, 20);
            this.timeTodo.TabIndex = 13;
            // 
            // progressBarControl1
            // 
            this.progressBarControl.Location = new System.Drawing.Point(5, 81);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressBarControl.Properties.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.progressBarControl.Properties.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.progressBarControl.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Properties.Step = 1;
            this.progressBarControl.Size = new System.Drawing.Size(190, 18);
            this.progressBarControl.TabIndex = 10;
            // 
            // minuteLabel
            // 
            this.minuteLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.minuteLabel.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.minuteLabel.Location = new System.Drawing.Point(265, 25);
            this.minuteLabel.LookAndFeel.SkinName = "Money Twins";
            this.minuteLabel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(30, 33);
            this.minuteLabel.TabIndex = 12;
            this.minuteLabel.Text = "00";
            // 
            // taskName
            // 
            this.taskName.Location = new System.Drawing.Point(5, 25);
            this.taskName.Name = "taskName";
            this.taskName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.taskName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.taskName.Properties.Appearance.Options.UseBackColor = true;
            this.taskName.Properties.Appearance.Options.UseForeColor = true;
            this.taskName.Size = new System.Drawing.Size(190, 20);
            this.taskName.TabIndex = 0;
            // 
            // hourLabel
            // 
            this.hourLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.hourLabel.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.hourLabel.Location = new System.Drawing.Point(215, 25);
            this.hourLabel.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.hourLabel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(44, 48);
            this.hourLabel.TabIndex = 2;
            this.hourLabel.Text = "00";
            // 
            // taskFinishButton
            // 
            this.taskFinishButton.Location = new System.Drawing.Point(215, 76);
            this.taskFinishButton.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.taskFinishButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.taskFinishButton.Margin = new System.Windows.Forms.Padding(0);
            this.taskFinishButton.Name = "taskFinishButton";
            this.taskFinishButton.Size = new System.Drawing.Size(83, 23);
            this.taskFinishButton.TabIndex = 8;
            this.taskFinishButton.Text = "Finish";
            this.taskFinishButton.Visible = false;
            this.taskFinishButton.Click += new System.EventHandler(this.firstTaskFinishButton_Click);
            // 
            // taskStartButton
            // 
            this.taskStartButton.Location = new System.Drawing.Point(96, 54);
            this.taskStartButton.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.taskStartButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.taskStartButton.Margin = new System.Windows.Forms.Padding(0);
            this.taskStartButton.Name = "taskStartButton";
            this.taskStartButton.Size = new System.Drawing.Size(44, 23);
            this.taskStartButton.TabIndex = 6;
            this.taskStartButton.Text = "Start";
            this.taskStartButton.Click += new System.EventHandler(this.firstTaskStartButton_Click);
            // 
            // taskPauseButton
            // 
            this.taskPauseButton.Location = new System.Drawing.Point(151, 54);
            this.taskPauseButton.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.taskPauseButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.taskPauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.taskPauseButton.Name = "taskPauseButton";
            this.taskPauseButton.Size = new System.Drawing.Size(44, 23);
            this.taskPauseButton.TabIndex = 7;
            this.taskPauseButton.Text = "Pause";
            this.taskPauseButton.Visible = false;
            this.taskPauseButton.Click += new System.EventHandler(this.firstTaskPauseButton_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FlexTimeTrackerTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl);
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FlexTimeTrackerTask";
            this.Size = new System.Drawing.Size(310, 112);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.SpinEdit timeTodo;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl minuteLabel;
        private DevExpress.XtraEditors.TextEdit taskName;
        private DevExpress.XtraEditors.LabelControl hourLabel;
        private DevExpress.XtraEditors.SimpleButton taskFinishButton;
        private DevExpress.XtraEditors.SimpleButton taskStartButton;
        private DevExpress.XtraEditors.SimpleButton taskPauseButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private System.Windows.Forms.Timer timer;
    }
}
