using CharmedPointer.Properties;
using crdx.Settings;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharmedPointer
{
    public partial class MainForm : Form
    {
        PointerForm pointerForm = new PointerForm();

        Charm defaultCharm;

        /// <summary>
        /// メニューから終了が選ばれたらtrueとなる
        /// </summary>
        bool isExiting = false;

        /// <summary>
        /// パラメータ変更中はtrueとする
        /// その間ValueChangedイベントを抑制する
        /// </summary>
        bool isParameterChanging = false;

        public MainForm()
        {
            InitializeComponent();

            ResetCharmList();

            LoadSettings();

            defaultCharm = new Charm(Resources.DefaultCharm);
            defaultCharm.Scale = 0.2;
            defaultCharm.Opacity = 50;


            toolStripMenuItemQuit.Click += ToolStripMenuItemQuit_Click;
            toolStripMenuItemShowSettings.Click += ToolStripMenuItemShowSettings_Click;

            // 自分のバージョン番号を取得
            labelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // 常駐していても、ログオフ、シャットダウンでは修了できるようにする
            // 参考： https://dobon.net/vb/dotnet/system/sessionending.html
            SystemEvents.SessionEnding += new SessionEndingEventHandler(SystemEvents_SessionEnding);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SystemEvents.SessionEnding -= new SessionEndingEventHandler(SystemEvents_SessionEnding);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // 起動時に設定フォームを開くか
            if (checkBoxShowSettingsOnStart.Checked)
            {
                Show();
            }
            else
            {
                Hide();
            }

            pointerForm.Show(this);

            listViewCharms.Items[0].Selected = true;
            //SelectCharm();
            pointerForm.Preview();
        }

        /// <summary>
        /// 画像リストをデフォルトで作成
        /// </summary>
        private void ResetCharmList()
        {
            ListViewCharmItem item;
            Image image;
            int index = 0;

            listViewCharms.LargeImageList.Images.Clear();
            listViewCharms.Items.Clear();

            image = Image.FromFile("Images/GreenCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("Green Circle", image, index);
            item.Charm.Scale = 0.2;
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/RedCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("Red Circle", image, index);
            item.Charm.Scale = 0.2;
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/YellowCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Circle", image, index);
            item.Charm.Scale = 0.2;
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/YellowFilledCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Filled Circle", image, index);
            item.Charm.Scale = 0.2;
            item.Charm.Opacity = 50;
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/PowerPointLaser.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("PowerPoint Like", image, index);
            item.Charm.Scale = 0.2;
            item.Charm.Opacity = 80;
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/LargeCursor.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("Arrow", image, index);
            item.Charm.Scale = 0.5;
            item.Charm.Opacity = 80;
            item.Charm.Origin.X = 0;
            item.Charm.Origin.Y = 0;
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/Laser.png");
            listViewCharms.LargeImageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Filled Circle", image, index);
            item.Charm.Scale = 0.5;
            item.Charm.Opacity = 80;
            item.Charm.Origin.X = 0;
            item.Charm.Origin.Y = 0;
            listViewCharms.Items.Add(item);
            index++;
        }

        void LoadSettings()
        {
            numericUpDownVelocityToShow.Value = (Decimal)Settings.Default.VelocityThresholdToShow;
            numericUpDownVelocityToHide.Value = (Decimal)Settings.Default.VelocityThresholdToHide;
            numericUpDownDurationToHide.Value = (Decimal)Settings.Default.DurationToHide;

            checkBoxShowSettingsOnStart.Checked = Settings.Default.ShowFormOnStartup;
            checkBoxUseNotifyIcon.Checked = Settings.Default.UseNotifyIcon;
        }

        void SaveSettings()
        {
            Settings.Default.VelocityThresholdToShow = (int)numericUpDownVelocityToShow.Value;
            Settings.Default.VelocityThresholdToHide = (int)numericUpDownVelocityToHide.Value;
            Settings.Default.DurationToHide = (double)numericUpDownDurationToHide.Value;

            Settings.Default.ShowFormOnStartup = checkBoxShowSettingsOnStart.Checked;
            Settings.Default.UseNotifyIcon = checkBoxUseNotifyIcon.Checked;

            Settings.Default.Save();
        }

        private void ToolStripMenuItemShowSettings_Click(object sender, EventArgs e)
        {
            // 設定フォームを表示
            Show();

            // 最小化されていれば戻す
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }

            // 設定フォームにフォーカスをあてる
            Focus();
        }

        /// <summary>
        /// 常駐していても終了させる
        /// </summary>
        public void Quit()
        {
            isExiting = true;
            Application.Exit();
        }

        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void NumericUpDownVelocityToShow_ValueChanged(object sender, EventArgs e)
        {
            if (isParameterChanging) return;
            pointerForm.showVelocityThreshold = (double)((NumericUpDown)sender).Value;
        }

        private void numericUpDownVelocityToHide_ValueChanged(object sender, EventArgs e)
        {
            if (isParameterChanging) return;
            pointerForm.hideVelocityThreshold = (double)((NumericUpDown)sender).Value;
        }

        private void numericUpDownDurationToHide_ValueChanged(object sender, EventArgs e)
        {
            if (isParameterChanging) return;
            pointerForm.ShowDuration = (double)((NumericUpDown)sender).Value;
        }

        /// <summary>
        /// 選択画像が変更された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewCharms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCharm();
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            Quit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 常駐する場合は閉じるボタンをキャンセルする
            if (checkBoxUseNotifyIcon.Checked && !isExiting)
            {
                Hide();
                e.Cancel = true;
            }

            // 終了直前に設定を保存
            SaveSettings();
        }

        Charm GetSelectedCharm()
        {
            var selection = listViewCharms.SelectedItems;
            if (selection.Count != 1)
            {
                //return null;
                return defaultCharm;

                //// 選択状態が異常ならば、最初のチャームを選択しなおす
                //listViewCharms.SelectedItems.Clear();
                //listViewCharms.Items[0].Selected = true;
                //return ((ListViewCharmItem)listViewCharms.Items[0]).Charm;
            }

            return ((ListViewCharmItem)selection[0]).Charm;
        }

        /// <summary>
        /// 指定された倍率を実数で返す
        /// </summary>
        /// <returns></returns>
        double GetScaleValue()
        {
            const double min = -100.0;
            double val = trackBarCharmScale.Value;
            double range = trackBarCharmScale.Maximum - trackBarCharmScale.Minimum;
            return Math.Pow(10, (val / range / trackBarCharmScale.Minimum * min));
        }

        void SetScaleValue(double val)
        {
            const double min = -100.0;
            double range = trackBarCharmScale.Maximum - trackBarCharmScale.Minimum;
            trackBarCharmScale.Value = (int)(Math.Log10(val) * range * trackBarCharmScale.Minimum / min);
        }

        void SelectCharm()
        {
            var charm = GetSelectedCharm();
            if (charm == null) return;
            var image = charm.Image;

            double opacity = (double)(charm.Opacity) / 100.0;

            // フォームの値変更時のイベントはスキップさせる
            isParameterChanging = true;

            numericUpDownCharmWidth.Value = charm.Size.Width;
            numericUpDownCharmHeight.Value = charm.Size.Height;
            numericUpDownCharmOriginX.Value = charm.Origin.X;
            numericUpDownCharmOriginY.Value = charm.Origin.Y;
            trackBarCharmOpacity.Value = charm.Opacity;
            SetScaleValue(charm.Scale);

            pointerForm.Opacity = opacity;
            pointerForm.Origin = new Point((int)(charm.Origin.X * charm.Scale), (int)(charm.Origin.Y * charm.Scale));
            pointerForm.SetImage(image);
            pointerForm.Width = (int)(charm.Size.Width * charm.Scale);
            pointerForm.Height = (int)(charm.Size.Height * charm.Scale);

            pointerForm.Preview();

            // フォームの値変更時のイベントを処理するように戻す
            isParameterChanging = false;

            ValidateCharmParameters();
        }

        void ApplyCharmSettings()
        {
            var charm = GetSelectedCharm();

            charm.Opacity = (int)(trackBarCharmOpacity.Value);
            charm.Size.Width = (int)numericUpDownCharmWidth.Value;
            charm.Size.Height = (int)numericUpDownCharmHeight.Value;
            charm.Origin.X = (int)numericUpDownCharmOriginX.Value;
            charm.Origin.Y = (int)numericUpDownCharmOriginY.Value;
            charm.Scale = GetScaleValue();

            SelectCharm();
        }

        private void buttonCharmEditReset_Click(object sender, EventArgs e)
        {
            SelectCharm();
        }

        private void buttonCharmSizeReset_Click(object sender, EventArgs e)
        {
            Charm charm = GetSelectedCharm();
            numericUpDownCharmWidth.Value = charm.Image.Width;
            numericUpDownCharmHeight.Value = charm.Image.Height;

            InvalidateCharmParameters();
        }

        private void buttonCharmOriginReset_Click(object sender, EventArgs e)
        {
            Charm charm = GetSelectedCharm();
            numericUpDownCharmOriginX.Value = numericUpDownCharmWidth.Value / 2;
            numericUpDownCharmOriginY.Value = numericUpDownCharmHeight.Value / 2;

            InvalidateCharmParameters();
        }

        void InvalidateCharmParameters()
        {
            ApplyCharmSettings();
        }

        void ValidateCharmParameters()
        {
            toolTipMain.SetToolTip(trackBarCharmScale, (GetScaleValue() * 100.0).ToString("F0") + "%");
            toolTipMain.SetToolTip(trackBarCharmOpacity, trackBarCharmOpacity.Value.ToString("F0") + "%");

        }

        private void numericUpDownCharmWidth_ValueChanged(object sender, EventArgs e)
        {
            if (isParameterChanging) return;
            //if (checkBoxCharmSizeLink.Checked)
            //{
            //    Charm charm = GetSelectedCharm();
            //    numericUpDownCharmHeight.Value = numericUpDownCharmWidth.Value * charm.Size.Height / charm.Size.Width;
            //}
            InvalidateCharmParameters();
        }

        private void numericUpDownCharmHeight_ValueChanged(object sender, EventArgs e)
        {
            if (isParameterChanging) return;
            //if (checkBoxCharmSizeLink.Checked)
            //{
            //    Charm charm = GetSelectedCharm();
            //    numericUpDownCharmWidth.Value = numericUpDownCharmHeight.Value * charm.Size.Width / charm.Size.Height;
            //}
            InvalidateCharmParameters();
        }

        private void trackBarCharmScale_Scroll(object sender, EventArgs e)
        {
            //toolTipMain.SetToolTip(trackBarCharmScale, (GetScaleValue() * 100.0).ToString("F0") + "%");
            //if (isParameterChanging) return;
            InvalidateCharmParameters();
        }

        private void buttonCharmScaleReset_Click(object sender, EventArgs e)
        {
            trackBarCharmScale.Value = 0;
            trackBarCharmScale_Scroll(sender, e);
        }

        private void trackBarCharmOpacity_Scroll(object sender, EventArgs e)
        {
            //TrackBar track = (TrackBar)sender;
            //toolTipMain.SetToolTip(track, track.Value.ToString("F0") + "%");
            if (isParameterChanging) return;
            InvalidateCharmParameters();
        }
    }
}
