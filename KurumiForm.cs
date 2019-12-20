using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kurumi {
    public partial class KurumiForm : Form {
        public KurumiForm() {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        TimeSpan offset;

        /// <summary>
        /// Obtains the time and displays it.
        /// </summary>
        private void ObtainTime() {
            ObtainTime(false, new TimeSpan(0));
        }
        private void ObtainTime(bool wasFixed, TimeSpan originalOffset) {
            activityIcon.Image = Properties.Resources.waiting;
            topLabel.Text = "Obtaining network time...";
            Difference.Text = "Obtaining...";
            serverClock.Text = "Obtaining...";
            ownClock.Text = DateTime.Now.ToLongTimeString();
            btnFix.Enabled = false;

            Invalidate();
            Refresh();

            DateTime net = DateTime.Now;
            try {
                net = Program.TryGetNetworkTime();
            } catch {
                activityIcon.Image = Properties.Resources.error;
                topLabel.Text = "Could not connect to time server";
                Difference.Text = "???";
                serverClock.Text = "???";
                return;
            }
            
            DateTime self = DateTime.Now;
            ownClock.Text = self.ToLongTimeString();
            serverClock.Text = net.ToLongTimeString();

            offset = self - net;
            Difference.Text = (offset.Ticks >= 0 ? "+" : "-") + Math.Floor(Math.Abs(offset.TotalMinutes)) + ":" + Math.Abs(offset.Seconds).ToString().PadLeft(2, '0') + "." + Math.Abs(offset.Milliseconds).ToString().PadLeft(3, '0');

            if (offset.TotalSeconds <= -60) {
                activityIcon.Image = Properties.Resources.behind;
                topLabel.Text = "Your clock is " + Math.Floor(Math.Abs(offset.TotalMinutes)) + " minute" + (Math.Floor(Math.Abs(offset.TotalMinutes)) == 1 ? "" : "s") + " and " + Math.Abs(offset.Seconds) + " second" + (Math.Abs(offset.Seconds) == 1 ? "" : "s") + " behind.";
            } else if (offset.TotalSeconds <= -1) {
                activityIcon.Image = Properties.Resources.behind;
                topLabel.Text = "Your clock is " + Math.Abs(offset.Seconds) + " second" + (Math.Abs(offset.Seconds) == 1 ? "" : "s") + " behind.";
            } else if (offset.TotalSeconds >= 60) {
                activityIcon.Image = Properties.Resources.ahead;
                topLabel.Text = "Your clock is " + Math.Floor(Math.Abs(offset.TotalMinutes)) + " minute" + (Math.Floor(Math.Abs(offset.TotalMinutes)) == 1 ? "" : "s") + " and " + Math.Abs(offset.Seconds) + " second" + (Math.Abs(offset.Seconds) == 1 ? "" : "s") + " ahead.";
            } else if (offset.TotalSeconds >= 1) {
                activityIcon.Image = Properties.Resources.ahead;
                topLabel.Text = "Your clock is " + Math.Abs(offset.Seconds) + " second" + (Math.Abs(offset.Seconds) == 1 ? "" : "s") + " ahead.";
            } else {
                if (!wasFixed) {
                    activityIcon.Image = Properties.Resources.exact;
                    topLabel.Text = "Your clock is exact!";
                } else {
                    topLabel.Text = "Your clock is now exact!";

                    if (originalOffset.TotalSeconds <= -1) {
                        activityIcon.Image = Properties.Resources.behind_fixed;
                    } else if (originalOffset.TotalSeconds >= 1) {
                        activityIcon.Image = Properties.Resources.ahead_fixed;
                    } else {
                        activityIcon.Image = Properties.Resources.exact_fixed;
                    }
                }
            }

            if (Math.Abs(offset.TotalMilliseconds) < 10) {
                Difference.Text = "±0:00.000";
                btnFix.Enabled = false;
            } else {
                btnFix.Enabled = true;
            }
        }

        /// <summary>
        /// Sets the system time to the new time.
        /// </summary>
        private void Fix() {
            DateTime target = DateTime.UtcNow;
            target = target.Subtract(offset);

            Program.SYSTEMTIME systime = new Program.SYSTEMTIME(target);
            Program.SetSystemTime(ref systime);
        }

        Timer t;
        private void KurumiForm_Load(object sender, EventArgs e) {
            t = new Timer();
            t.Interval = 1;
            t.Tick += t_Tick;
            t.Enabled = true;
            // hey, it works
        }

        private void t_Tick(object sender, EventArgs e) {
            t.Enabled = false;
            ObtainTime();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnFix_Click(object sender, EventArgs e) {
            TimeSpan oldoffset = offset;
            Fix();

            ObtainTime(true, oldoffset);
        }

        private void oskLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://osk.sh/");
        }
    }
}
