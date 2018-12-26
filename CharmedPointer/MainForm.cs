using CharmedPointer.Properties;
using crdx.Settings;
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


        public MainForm()
        {
            InitializeComponent();

            ResetCharmList();

            LoadSettings();

            defaultCharm = new Charm(Resources.DefaultCharmImage);

            toolStripMenuItemQuit.Click += ToolStripMenuItemQuit_Click;
            toolStripMenuItemShowSettings.Click += ToolStripMenuItemShowSettings_Click;

            // 自分のバージョン番号を取得
            labelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pointerForm.Show(this);

            listViewCharms.Items[0].Selected = true;
            SelectCharm();
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
            //listViewCharms.SmallImageList.Images.Clear();

            listViewCharms.Items.Clear();

            image = Image.FromFile("Images/GreenCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            //listViewCharms.SmallImageList.Images.Add(image);
            item = new ListViewCharmItem("Green Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/RedCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            //listViewCharms.SmallImageList.Images.Add(image);
            item = new ListViewCharmItem("Red Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/YellowCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            //listViewCharms.SmallImageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/YellowFilledCircle.png");
            listViewCharms.LargeImageList.Images.Add(image);
            //listViewCharms.SmallImageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Filled Circle", image, index);
            item.Charm.Opacity = 50;
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

        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            isExiting = true;
            Application.Exit();
        }

        private void NumericUpDownVelocityToShow_ValueChanged(object sender, EventArgs e)
        {
            pointerForm.showVelocityThreshold = (double)((NumericUpDown)sender).Value;
        }

        private void numericUpDownVelocityToHide_ValueChanged(object sender, EventArgs e)
        {
            pointerForm.hideVelocityThreshold = (double)((NumericUpDown)sender).Value;
        }

        private void numericUpDownDurationToHide_ValueChanged(object sender, EventArgs e)
        {
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
            trackBarCharmScale.Value = (int)(Math.Log10(val * range * trackBarCharmScale.Minimum / min));
        }

        void SelectCharm()
        {
            var charm = GetSelectedCharm();
            if (charm == null) return;
            var image = charm.Image;

            double opacity = (double)(charm.Opacity) / 100.0;
            double scale = GetScaleValue();

            numericUpDownCharmWidth.Value = charm.Size.Width;
            numericUpDownCharmHeight.Value = charm.Size.Height;
            numericUpDownCharmOriginX.Value = charm.Origin.X;
            numericUpDownCharmOriginY.Value = charm.Origin.Y;
            numericUpDownOpacity.Value = charm.Opacity;
            SetScaleValue(charm.Scale);

            pointerForm.Opacity = opacity;
            pointerForm.Origin = new Point((int)(charm.Origin.X * scale), (int)(charm.Origin.Y * scale));
            pointerForm.SetImage(image);
            pointerForm.Width = (int)(charm.Size.Width * scale);
            pointerForm.Height = (int)(charm.Size.Height * scale);

            pointerForm.Preview();

            ValidateCharmParameters();
        }

        void ApplyCharmSettings()
        {
            var charm = GetSelectedCharm();

            charm.Opacity = (int)(numericUpDownOpacity.Value);
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
        }

        private void numericUpDownCharmWidth_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxCharmSizeLink.Checked)
            {
                Charm charm = GetSelectedCharm();
                numericUpDownCharmHeight.Value = numericUpDownCharmWidth.Value * charm.Size.Height / charm.Size.Width;
            }
            InvalidateCharmParameters();
        }

        private void numericUpDownCharmHeight_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxCharmSizeLink.Checked)
            {
                Charm charm = GetSelectedCharm();
                numericUpDownCharmWidth.Value = numericUpDownCharmHeight.Value * charm.Size.Width / charm.Size.Height;
            }
            InvalidateCharmParameters();
        }

        private void numericUpDownOpacity_ValueChanged(object sender, EventArgs e)
        {
            InvalidateCharmParameters();
        }

        private void trackBarCharmScale_Scroll(object sender, EventArgs e)
        {
            InvalidateCharmParameters();
            toolTipMain.SetToolTip(trackBarCharmScale, (GetScaleValue() * 100.0).ToString("F0") + "%");
        }

        private void buttonCharmScaleReset_Click(object sender, EventArgs e)
        {
            trackBarCharmScale.Value = 0;
            trackBarCharmScale_Scroll(sender, e);
        }
    }
}
