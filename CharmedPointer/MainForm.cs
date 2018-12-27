using CharmedPointer.Properties;
using crdx.Settings;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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

        private static int WM_QUERYENDSESSION = 0x11;

        /// <summary>
        /// パラメータ変更中はtrueとする
        /// その間ValueChangedイベントを抑制する
        /// </summary>
        bool isParameterChanging = false;

        public MainForm()
        {
            InitializeComponent();

            // 実行ファイルのある場所をカレントディレクトリにする
            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);

            ResetCharmList();

            LoadSettings();

            defaultCharm = new Charm(Resources.DefaultCharm);
            defaultCharm.Scale = 0.2;
            defaultCharm.Opacity = 50;


            toolStripMenuItemQuit.Click += ToolStripMenuItemQuit_Click;
            toolStripMenuItemShowSettings.Click += ToolStripMenuItemShowSettings_Click;

            // 自分のバージョン番号を取得
            labelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// ログオフやシャットダウン時には常駐していても終了できるようウィンドウプロシージャでトラップ
        /// 参考： https://docs.microsoft.com/ja-jp/dotnet/api/microsoft.win32.systemevents.sessionending?redirectedfrom=MSDN&view=netframework-4.7.2
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_QUERYENDSESSION)
            {
                isExiting = true;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// 起動時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //pointerForm.Preview();
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

        /// <summary>
        /// 最小化時にはタスクトレイに格納
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                Hide();
            }
        }


        #region Original Methods

        /// <summary>
        /// 標準のチャームリストを作成
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

        /// <summary>
        /// 設定ファイルを読み込み
        /// </summary>
        void LoadSettings()
        {
            numericUpDownVelocityToShow.Value = (Decimal)Settings.Default.VelocityThresholdToShow;
            numericUpDownVelocityToHide.Value = (Decimal)Settings.Default.VelocityThresholdToHide;
            numericUpDownDurationToHide.Value = (Decimal)Settings.Default.DurationToHide;

            checkBoxShowSettingsOnStart.Checked = Settings.Default.ShowFormOnStartup;
            checkBoxUseNotifyIcon.Checked = Settings.Default.UseNotifyIcon;
        }

        /// <summary>
        /// 設定をファイルに保存
        /// </summary>
        void SaveSettings()
        {
            Settings.Default.VelocityThresholdToShow = (int)numericUpDownVelocityToShow.Value;
            Settings.Default.VelocityThresholdToHide = (int)numericUpDownVelocityToHide.Value;
            Settings.Default.DurationToHide = (double)numericUpDownDurationToHide.Value;

            Settings.Default.ShowFormOnStartup = checkBoxShowSettingsOnStart.Checked;
            Settings.Default.UseNotifyIcon = checkBoxUseNotifyIcon.Checked;

            Settings.Default.Save();
        }

        /// <summary>
        /// 常駐していても終了させる
        /// </summary>
        public void Quit()
        {
            isExiting = true;
            Application.Exit();
        }

        /// <summary>
        /// 現在選択されているチャームを取得
        /// </summary>
        /// <returns></returns>
        Charm GetSelectedCharm()
        {
            var selection = listViewCharms.SelectedItems;
            if (selection.Count != 1)
            {
                return defaultCharm;    // 正しく選択されていなければデフォルトのチャームを返す
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

        /// <summary>
        /// 選択されたチャームを適用
        /// </summary>
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

        /// <summary>
        /// フォームのパラメータをチャームに反映させる
        /// </summary>
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

        /// <summary>
        /// チャームのパラメータが変更されたときの処理
        /// </summary>
        void InvalidateCharmParameters()
        {
            ApplyCharmSettings();
        }

        /// <summary>
        /// チャームのパラメータ変更完了時の処理
        /// </summary>
        void ValidateCharmParameters()
        {
            // スライダーのツールチップで値を表示する
            toolTipMain.SetToolTip(trackBarCharmScale, (GetScaleValue() * 100.0).ToString("F0") + "%");
            toolTipMain.SetToolTip(trackBarCharmOpacity, trackBarCharmOpacity.Value.ToString("F0") + "%");

        }

        #endregion


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

        private void buttonCharmEditReset_Click(object sender, EventArgs e)
        {
            SelectCharm();
        }

        private void CharmParameterChanged(object sender, EventArgs e)
        {
            if (isParameterChanging) return;
            InvalidateCharmParameters();
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

        private void buttonCharmScaleReset_Click(object sender, EventArgs e)
        {
            trackBarCharmScale.Value = 0;
            CharmParameterChanged(sender, e);
        }
    }
}
