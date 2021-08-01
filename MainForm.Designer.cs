namespace DesktopTimer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblMinutes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.comboMinutes = new System.Windows.Forms.ComboBox();
            this.comboSeconds = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LabelTimer = new System.Windows.Forms.Timer(this.components);
            this.lblHours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboHours = new System.Windows.Forms.ComboBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.optionsGrpBox = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnStartPlayback = new System.Windows.Forms.Button();
            this.btnStopPlayback = new System.Windows.Forms.Button();
            this.comboAlarmSound = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinutes.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.Location = new System.Drawing.Point(283, 168);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(75, 81);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 81);
            this.label3.TabIndex = 0;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeconds.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.White;
            this.lblSeconds.Location = new System.Drawing.Point(442, 168);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(75, 81);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboMinutes
            // 
            this.comboMinutes.BackColor = System.Drawing.Color.Maroon;
            this.comboMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboMinutes.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMinutes.ForeColor = System.Drawing.Color.White;
            this.comboMinutes.FormattingEnabled = true;
            this.comboMinutes.ItemHeight = 16;
            this.comboMinutes.Location = new System.Drawing.Point(283, 254);
            this.comboMinutes.Margin = new System.Windows.Forms.Padding(5);
            this.comboMinutes.Name = "comboMinutes";
            this.comboMinutes.Size = new System.Drawing.Size(76, 24);
            this.comboMinutes.TabIndex = 1;
            this.comboMinutes.SelectedIndexChanged += new System.EventHandler(this.comboMinutes_SelectedIndexChanged);
            // 
            // comboSeconds
            // 
            this.comboSeconds.BackColor = System.Drawing.Color.Maroon;
            this.comboSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeconds.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSeconds.ForeColor = System.Drawing.Color.White;
            this.comboSeconds.FormattingEnabled = true;
            this.comboSeconds.ItemHeight = 16;
            this.comboSeconds.Location = new System.Drawing.Point(442, 254);
            this.comboSeconds.Margin = new System.Windows.Forms.Padding(5);
            this.comboSeconds.Name = "comboSeconds";
            this.comboSeconds.Size = new System.Drawing.Size(76, 24);
            this.comboSeconds.TabIndex = 1;
            this.comboSeconds.SelectedIndexChanged += new System.EventHandler(this.comboSeconds_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(249)))));
            this.btnStart.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(630, 129);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 80);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(249)))));
            this.btnStop.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(630, 247);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 80);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(249)))));
            this.btnReset.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(630, 365);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 80);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAlarm
            // 
            this.lblAlarm.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlarm.Location = new System.Drawing.Point(204, 107);
            this.lblAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(234, 56);
            this.lblAlarm.TabIndex = 4;
            this.lblAlarm.Text = "ALARM!";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarm.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // LabelTimer
            // 
            this.LabelTimer.Interval = 500;
            this.LabelTimer.Tick += new System.EventHandler(this.LabelTimer_Tick);
            // 
            // lblHours
            // 
            this.lblHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(124, 168);
            this.lblHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(75, 81);
            this.lblHours.TabIndex = 0;
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(204, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 81);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboHours
            // 
            this.comboHours.BackColor = System.Drawing.Color.Maroon;
            this.comboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboHours.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHours.ForeColor = System.Drawing.Color.White;
            this.comboHours.FormattingEnabled = true;
            this.comboHours.ItemHeight = 16;
            this.comboHours.Location = new System.Drawing.Point(123, 254);
            this.comboHours.Margin = new System.Windows.Forms.Padding(5);
            this.comboHours.Name = "comboHours";
            this.comboHours.Size = new System.Drawing.Size(76, 24);
            this.comboHours.TabIndex = 1;
            this.comboHours.SelectedIndexChanged += new System.EventHandler(this.comboHours_SelectedIndexChanged);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(630, 11);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(90, 80);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // optionsGrpBox
            // 
            this.optionsGrpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(210)))));
            this.optionsGrpBox.Controls.Add(this.btnSet);
            this.optionsGrpBox.Controls.Add(this.btnStartPlayback);
            this.optionsGrpBox.Controls.Add(this.btnStopPlayback);
            this.optionsGrpBox.Controls.Add(this.comboAlarmSound);
            this.optionsGrpBox.Controls.Add(this.label1);
            this.optionsGrpBox.Location = new System.Drawing.Point(748, 73);
            this.optionsGrpBox.Name = "optionsGrpBox";
            this.optionsGrpBox.Size = new System.Drawing.Size(270, 110);
            this.optionsGrpBox.TabIndex = 6;
            this.optionsGrpBox.TabStop = false;
            this.optionsGrpBox.Text = "Alarm Options";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(123, 68);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(115, 24);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set Alarm Sound";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnStartPlayback
            // 
            this.btnStartPlayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStartPlayback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPlayback.Image = ((System.Drawing.Image)(resources.GetObject("btnStartPlayback.Image")));
            this.btnStartPlayback.Location = new System.Drawing.Point(80, 68);
            this.btnStartPlayback.Name = "btnStartPlayback";
            this.btnStartPlayback.Size = new System.Drawing.Size(27, 25);
            this.btnStartPlayback.TabIndex = 3;
            this.btnStartPlayback.UseVisualStyleBackColor = false;
            this.btnStartPlayback.Click += new System.EventHandler(this.btnStartPlayback_Click);
            // 
            // btnStopPlayback
            // 
            this.btnStopPlayback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStopPlayback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopPlayback.Image = ((System.Drawing.Image)(resources.GetObject("btnStopPlayback.Image")));
            this.btnStopPlayback.Location = new System.Drawing.Point(47, 68);
            this.btnStopPlayback.Name = "btnStopPlayback";
            this.btnStopPlayback.Size = new System.Drawing.Size(27, 24);
            this.btnStopPlayback.TabIndex = 2;
            this.btnStopPlayback.UseVisualStyleBackColor = false;
            this.btnStopPlayback.Click += new System.EventHandler(this.btnStopPlayback_Click);
            // 
            // comboAlarmSound
            // 
            this.comboAlarmSound.FormattingEnabled = true;
            this.comboAlarmSound.Location = new System.Drawing.Point(47, 31);
            this.comboAlarmSound.Name = "comboAlarmSound";
            this.comboAlarmSound.Size = new System.Drawing.Size(191, 21);
            this.comboAlarmSound.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 457);
            this.Controls.Add(this.optionsGrpBox);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboSeconds);
            this.Controls.Add(this.comboHours);
            this.Controls.Add(this.comboMinutes);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.optionsGrpBox.ResumeLayout(false);
            this.optionsGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.ComboBox comboMinutes;
        private System.Windows.Forms.ComboBox comboSeconds;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer LabelTimer;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboHours;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.GroupBox optionsGrpBox;
        private System.Windows.Forms.Button btnStartPlayback;
        private System.Windows.Forms.Button btnStopPlayback;
        private System.Windows.Forms.ComboBox comboAlarmSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSet;
    }
}

