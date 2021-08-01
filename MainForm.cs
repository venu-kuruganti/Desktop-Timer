using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;


namespace DesktopTimer
{
    public partial class frmMain : Form
    {
        protected static int secondsCounter = -1;
        protected static int minutesCounter = -1;
        protected static int hoursCounter = -1;
        protected SoundPlayer player = new SoundPlayer();
        
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)            
                comboHours.Items.Add(i.ToString("00"));
            

            for (int i = 0; i < 60; i++)
            {
                
                comboMinutes.Items.Add(i.ToString("00"));
                comboSeconds.Items.Add(i.ToString("00"));
            }

            comboHours.SelectedIndex = comboMinutes.SelectedIndex = comboSeconds.SelectedIndex = 0;


            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows\Media");
            FileInfo[] mediaFiles = directoryInfo.GetFiles("Alarm*.wav");            

            string AlarmSound = ConfigurationSettings.AppSettings["AlarmSound"].ToString();
            player.SoundLocation = mediaFiles.First(f => f.Name.ToLower() == AlarmSound.ToLower()).FullName;

            foreach (FileInfo file in mediaFiles)
            {
                comboBoxItem item = new comboBoxItem(file.Name, file.FullName);
                comboAlarmSound.Items.Add(item);

                if (file.Name == AlarmSound)                
                    comboAlarmSound.SelectedItem = item;
                
            }//foreach

            comboAlarmSound.DisplayMember = "Text";
            comboAlarmSound.ValueMember = "Value";
            
        }

        private void comboMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMinutes.SelectedItem != null)
            {
                lblMinutes.Text = comboMinutes.SelectedItem.ToString();
                minutesCounter = Convert.ToInt32(comboMinutes.SelectedItem);
            }
        }

        private void comboSeconds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSeconds.SelectedItem != null)
            {
                lblSeconds.Text = comboSeconds.SelectedItem.ToString();
                secondsCounter = Convert.ToInt32(comboSeconds.SelectedItem);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {       
            if (lblHours.Text == string.Empty|| lblMinutes.Text == string.Empty || lblSeconds.Text == string.Empty)
            {
                if (comboHours.SelectedIndex == -1)
                {
                    hoursCounter = 0;
                    lblHours.Text = hoursCounter.ToString("00");
                }

                if (comboMinutes.SelectedIndex == -1)
                {
                    minutesCounter = 0;
                    lblMinutes.Text = minutesCounter.ToString("00");
                }

                if (comboSeconds.SelectedIndex == -1)
                {
                    secondsCounter = 0;
                    lblSeconds.Text = secondsCounter.ToString("00");
                }
            }            

            MyTimer.Enabled = true;
            MyTimer.Start();
            comboHours.Enabled = comboMinutes.Enabled = comboSeconds.Enabled = false;
            btnOptions.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            LabelTimer.Stop();
            lblAlarm.Hide();
            MyTimer.Stop();
            MyTimer.Enabled = false;
            player.Stop();
            btnOptions.Enabled = true;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {

            if (secondsCounter > 0)
            {
                secondsCounter--;   
            }//End of big if
            else
            { //secondsCounter is 0

                if (minutesCounter > 0)
                {
                    minutesCounter--;

                    //Reset seconds to 59
                    secondsCounter = 59;
                }
                else
                { //minutesCounter is 0
                    if (hoursCounter > 0)
                    {
                        hoursCounter--;

                        //Reset seconds and minutes to 59
                        secondsCounter = minutesCounter = 59;
                    }
                    else
                    {   //Time is up!
                        //Ring alarm!             
                        player.PlayLooping();

                        //Show label
                        LabelTimer.Enabled = true;
                        LabelTimer.Start();

                        //Stop timer
                        MyTimer.Stop();

                        notifyIcon.Text = "Ended";
                    }//End of inner else of else 
                    
                }//End of inner else             
               
            }//End of outer big else

            lblHours.Text = hoursCounter.ToString("00");
            lblMinutes.Text = minutesCounter.ToString("00");
            lblSeconds.Text = secondsCounter.ToString("00");
            notifyIcon.Text = lblHours.Text + ":" + lblMinutes.Text + ":" + lblSeconds.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            MyTimer.Enabled = false;
            player.Stop();
            lblHours.Text = lblMinutes.Text = lblSeconds.Text = "00";
            comboHours.SelectedIndex = 0;
            comboMinutes.SelectedIndex = 0;
            comboSeconds.SelectedIndex = 0;
            hoursCounter = secondsCounter = minutesCounter = 0;
            comboHours.Enabled = comboMinutes.Enabled = comboSeconds.Enabled = true;
            lblAlarm.Hide();
            btnOptions.Enabled = true;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Timer";

                if (MyTimer.Enabled)
                {
                    notifyIcon.BalloonTipText = "Running....";
                }
                else
                {
                    notifyIcon.BalloonTipText = "Stopped";
                }

                notifyIcon.ShowBalloonTip(1000);

            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            lblAlarm.Visible = !(lblAlarm.Visible);
        }

        private void comboHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHours.SelectedItem != null)
            {
                lblHours.Text = comboHours.SelectedItem.ToString();
                hoursCounter = Convert.ToInt32(comboHours.SelectedItem.ToString());
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form mainWindow = frmMain.ActiveForm;

            if (mainWindow.Width < 1100)
            {
                while (frmMain.ActiveForm.Width < 1100)
                {
                    frmMain.ActiveForm.Width += 25;
                    frmMain.ActiveForm.Refresh();
                }                
            }
            else
            {
                while (frmMain.ActiveForm.Width > 750)
                {
                    frmMain.ActiveForm.Width -= 25;
                    frmMain.ActiveForm.Refresh();
                }                
            }

            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            comboBoxItem selectedItem = (comboBoxItem)comboAlarmSound.SelectedItem;

            player.SoundLocation = selectedItem.Value;

            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            configuration.AppSettings.Settings["AlarmSound"].Value = selectedItem.Text;
            configuration.Save(ConfigurationSaveMode.Minimal);
            
        }

        private void btnStopPlayback_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void btnStartPlayback_Click(object sender, EventArgs e)
        {   
            using (SoundPlayer tempPlayer = 
                new SoundPlayer(comboAlarmSound.SelectedItem.ToString()))
            {
                tempPlayer.Play();
            }                                 
        }

        protected class comboBoxItem
        {
            public comboBoxItem()     {   }

            public comboBoxItem(string _text, string _value)
            {
                Text = _text;
                Value = _value;
            }

            public string Text { get; set; }

            public string Value { get; set; }

            public override string ToString()
            {
                return Value;
            }   
            
            public string GetText()
            {
                return Text;
            }
        }
    }
}
