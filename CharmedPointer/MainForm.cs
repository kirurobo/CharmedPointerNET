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

        ImageList imageList = new ImageList();

        public MainForm()
        {
            InitializeComponent();

            ResetCharmList();

            toolStripMenuItemQuit.Click += ToolStripMenuItemQuit_Click;
            toolStripMenuItemShowSettings.Click += ToolStripMenuItemShowSettings_Click;
        }

        /// <summary>
        /// 画像リストをデフォルトで作成
        /// </summary>
        private void ResetCharmList()
        {
            ListViewCharmItem item;
            Image image;
            int index = 0;

            imageList.Images.Clear();
            listViewCharms.LargeImageList = imageList;
            listViewCharms.SmallImageList = imageList;

            listViewCharms.Items.Clear();

            image = Image.FromFile("Images/GreenCircle.gif");
            imageList.Images.Add(image);
            item = new ListViewCharmItem("Green Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/RedCircle.gif");
            imageList.Images.Add(image);
            item = new ListViewCharmItem("Red Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/YellowCircle.gif");
            imageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;

            image = Image.FromFile("Images/YellowFilledCircle.gif");
            imageList.Images.Add(image);
            item = new ListViewCharmItem("Yellow Filled Circle", image, index);
            listViewCharms.Items.Add(item);
            index++;
        }

        private void ToolStripMenuItemShowSettings_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pointerForm.Show(this);
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
            var selection = listViewCharms.SelectedItems;
            if (selection.Count != 1) return;

            var item = (ListViewCharmItem)selection[0];
            var image = imageList.Images[item.ImageIndex];
            var charm = item.Charm;

            double opacity = (double)(numericUpDownOpacity.Value) / 100.0;

            numericUpDownCharmWidth.Value = charm.Size.Width;
            numericUpDownCharmHeight.Value = charm.Size.Height;
            numericUpDownCharmOriginX.Value = charm.Origin.X;
            numericUpDownCharmOriginY.Value = charm.Origin.Y;

            pointerForm.Opacity = opacity;
            pointerForm.Origin = charm.Origin;
            pointerForm.SetImage(image);
        }
    }
}
