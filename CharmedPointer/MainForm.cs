using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        /// <summary>
        /// メニューから終了が選ばれたらtrueとなる
        /// </summary>
        bool isExiting = false;

        public MainForm()
        {
            InitializeComponent();

            ResetCharmList();

            toolStripMenuItemQuit.Click += ToolStripMenuItemQuit_Click;
            toolStripMenuItemShowSettings.Click += ToolStripMenuItemShowSettings_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pointerForm.Show(this);

            SelectCharm(0);
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
            var indices = listViewCharms.SelectedIndices;
            if (indices.Count != 1) return;

            SelectCharm(indices[0]);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 常駐する場合は閉じるボタンをキャンセルする
            if (checkBoxUseNotifyIcon.Checked && !isExiting)
            {
                Hide();
                e.Cancel = true;
            }
        }

        void SelectCharm(int index)
        {
            var item = (ListViewCharmItem)listViewCharms.Items[index];
            var charm = item.Charm;
            var image = charm.Image;

            double opacity = (double)(charm.Opacity) / 100.0;

            numericUpDownCharmWidth.Value = charm.Size.Width;
            numericUpDownCharmHeight.Value = charm.Size.Height;
            numericUpDownCharmOriginX.Value = charm.Origin.X;
            numericUpDownCharmOriginY.Value = charm.Origin.Y;
            numericUpDownOpacity.Value = charm.Opacity;

            pointerForm.Opacity = opacity;
            pointerForm.Origin = charm.Origin;
            pointerForm.SetImage(image);
            pointerForm.Width = charm.Size.Width;
            pointerForm.Height = charm.Size.Height;
        }

        void ApplyCharmSettings(int index)
        {
            var item = (ListViewCharmItem)listViewCharms.Items[index];
            var charm = item.Charm;

            charm.Opacity = (int)(numericUpDownOpacity.Value);
            charm.Size.Width = (int)numericUpDownCharmWidth.Value;
            charm.Size.Height = (int)numericUpDownCharmHeight.Value;
            charm.Origin.X = (int)numericUpDownCharmOriginX.Value;
            charm.Origin.Y = (int)numericUpDownCharmOriginY.Value;

            SelectCharm(index);
        }

        private void buttonCharmEditOk_Click(object sender, EventArgs e)
        {
            var indices = listViewCharms.SelectedIndices;
            if (indices.Count != 1) return;

            ApplyCharmSettings(indices[0]);
        }

        private void buttonCharmEditCancel_Click(object sender, EventArgs e)
        {
            var indices = listViewCharms.SelectedIndices;
            if (indices.Count != 1) return;

            SelectCharm(indices[0]);
        }
    }
}
