﻿namespace CharmedPointer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseNotifyIcon = new System.Windows.Forms.CheckBox();
            this.checkBoxShowSettingsOnStart = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDurationToHide = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownVelocityToHide = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVelocityToShow = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainerCharms = new System.Windows.Forms.SplitContainer();
            this.toolStripEditCharms = new System.Windows.Forms.ToolStrip();
            this.listViewCharms = new System.Windows.Forms.ListView();
            this.columnHeaderImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListCharms = new System.Windows.Forms.ImageList(this.components);
            this.buttonCharmEditOk = new System.Windows.Forms.Button();
            this.buttonCharmEditCancel = new System.Windows.Forms.Button();
            this.buttonCharmOriginReset = new System.Windows.Forms.Button();
            this.buttonCharmSizeReset = new System.Windows.Forms.Button();
            this.checkBoxCharmOriginLink = new System.Windows.Forms.CheckBox();
            this.checkBoxCharmSizeLink = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCharmHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCharmOriginY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCharmWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOpacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCharmOriginX = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxLicense = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStripButtonAddCharm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveCharm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShowSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorBeforeQuit = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogAddCharm = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationToHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocityToHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocityToShow)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharms)).BeginInit();
            this.splitContainerCharms.Panel1.SuspendLayout();
            this.splitContainerCharms.Panel2.SuspendLayout();
            this.splitContainerCharms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmOriginY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmOriginX)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(464, 241);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "全般";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxUseNotifyIcon);
            this.groupBox2.Controls.Add(this.checkBoxShowSettingsOnStart);
            this.groupBox2.Location = new System.Drawing.Point(8, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "動作";
            // 
            // checkBoxUseNotifyIcon
            // 
            this.checkBoxUseNotifyIcon.AutoSize = true;
            this.checkBoxUseNotifyIcon.Checked = true;
            this.checkBoxUseNotifyIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseNotifyIcon.Location = new System.Drawing.Point(8, 40);
            this.checkBoxUseNotifyIcon.Name = "checkBoxUseNotifyIcon";
            this.checkBoxUseNotifyIcon.Size = new System.Drawing.Size(108, 16);
            this.checkBoxUseNotifyIcon.TabIndex = 1;
            this.checkBoxUseNotifyIcon.Text = "タスクトレイに常駐";
            this.checkBoxUseNotifyIcon.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowSettingsOnStart
            // 
            this.checkBoxShowSettingsOnStart.AutoSize = true;
            this.checkBoxShowSettingsOnStart.Checked = true;
            this.checkBoxShowSettingsOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowSettingsOnStart.Location = new System.Drawing.Point(8, 18);
            this.checkBoxShowSettingsOnStart.Name = "checkBoxShowSettingsOnStart";
            this.checkBoxShowSettingsOnStart.Size = new System.Drawing.Size(144, 16);
            this.checkBoxShowSettingsOnStart.TabIndex = 0;
            this.checkBoxShowSettingsOnStart.Text = "起動時に設定画面を開く";
            this.checkBoxShowSettingsOnStart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownDurationToHide);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownVelocityToHide);
            this.groupBox1.Controls.Add(this.numericUpDownVelocityToShow);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カーソル";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "[s]  この時間後に消えます";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "[px/s]  この速度未満になると一定時間後に消えます";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "[px/s]  この速度以上でマウスが動くと表示されます";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "消失時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "消失速度";
            // 
            // numericUpDownDurationToHide
            // 
            this.numericUpDownDurationToHide.DecimalPlaces = 1;
            this.numericUpDownDurationToHide.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDurationToHide.Location = new System.Drawing.Point(75, 75);
            this.numericUpDownDurationToHide.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownDurationToHide.Name = "numericUpDownDurationToHide";
            this.numericUpDownDurationToHide.Size = new System.Drawing.Size(55, 19);
            this.numericUpDownDurationToHide.TabIndex = 7;
            this.numericUpDownDurationToHide.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDurationToHide.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.numericUpDownDurationToHide.ValueChanged += new System.EventHandler(this.numericUpDownDurationToHide_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出現速度";
            // 
            // numericUpDownVelocityToHide
            // 
            this.numericUpDownVelocityToHide.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVelocityToHide.Location = new System.Drawing.Point(75, 47);
            this.numericUpDownVelocityToHide.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVelocityToHide.Name = "numericUpDownVelocityToHide";
            this.numericUpDownVelocityToHide.Size = new System.Drawing.Size(55, 19);
            this.numericUpDownVelocityToHide.TabIndex = 4;
            this.numericUpDownVelocityToHide.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownVelocityToHide.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVelocityToHide.ValueChanged += new System.EventHandler(this.numericUpDownVelocityToHide_ValueChanged);
            // 
            // numericUpDownVelocityToShow
            // 
            this.numericUpDownVelocityToShow.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVelocityToShow.Location = new System.Drawing.Point(75, 22);
            this.numericUpDownVelocityToShow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVelocityToShow.Name = "numericUpDownVelocityToShow";
            this.numericUpDownVelocityToShow.Size = new System.Drawing.Size(55, 19);
            this.numericUpDownVelocityToShow.TabIndex = 1;
            this.numericUpDownVelocityToShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownVelocityToShow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVelocityToShow.ValueChanged += new System.EventHandler(this.NumericUpDownVelocityToShow_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainerCharms);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "カーソル変更";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainerCharms
            // 
            this.splitContainerCharms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCharms.Location = new System.Drawing.Point(3, 3);
            this.splitContainerCharms.Name = "splitContainerCharms";
            // 
            // splitContainerCharms.Panel1
            // 
            this.splitContainerCharms.Panel1.Controls.Add(this.toolStripEditCharms);
            this.splitContainerCharms.Panel1.Controls.Add(this.listViewCharms);
            // 
            // splitContainerCharms.Panel2
            // 
            this.splitContainerCharms.Panel2.Controls.Add(this.buttonCharmEditOk);
            this.splitContainerCharms.Panel2.Controls.Add(this.buttonCharmEditCancel);
            this.splitContainerCharms.Panel2.Controls.Add(this.buttonCharmOriginReset);
            this.splitContainerCharms.Panel2.Controls.Add(this.buttonCharmSizeReset);
            this.splitContainerCharms.Panel2.Controls.Add(this.checkBoxCharmOriginLink);
            this.splitContainerCharms.Panel2.Controls.Add(this.checkBoxCharmSizeLink);
            this.splitContainerCharms.Panel2.Controls.Add(this.label12);
            this.splitContainerCharms.Panel2.Controls.Add(this.label9);
            this.splitContainerCharms.Panel2.Controls.Add(this.label11);
            this.splitContainerCharms.Panel2.Controls.Add(this.label8);
            this.splitContainerCharms.Panel2.Controls.Add(this.label10);
            this.splitContainerCharms.Panel2.Controls.Add(this.label13);
            this.splitContainerCharms.Panel2.Controls.Add(this.label7);
            this.splitContainerCharms.Panel2.Controls.Add(this.numericUpDownCharmHeight);
            this.splitContainerCharms.Panel2.Controls.Add(this.numericUpDownCharmOriginY);
            this.splitContainerCharms.Panel2.Controls.Add(this.numericUpDownCharmWidth);
            this.splitContainerCharms.Panel2.Controls.Add(this.numericUpDownOpacity);
            this.splitContainerCharms.Panel2.Controls.Add(this.numericUpDownCharmOriginX);
            this.splitContainerCharms.Size = new System.Drawing.Size(450, 209);
            this.splitContainerCharms.SplitterDistance = 135;
            this.splitContainerCharms.TabIndex = 1;
            // 
            // toolStripEditCharms
            // 
            this.toolStripEditCharms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEditCharms.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEditCharms.Location = new System.Drawing.Point(0, 184);
            this.toolStripEditCharms.Name = "toolStripEditCharms";
            this.toolStripEditCharms.Size = new System.Drawing.Size(135, 25);
            this.toolStripEditCharms.TabIndex = 1;
            this.toolStripEditCharms.Text = "toolStrip1";
            this.toolStripEditCharms.Visible = false;
            // 
            // listViewCharms
            // 
            this.listViewCharms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImage,
            this.columnHeaderName});
            this.listViewCharms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCharms.HideSelection = false;
            this.listViewCharms.LargeImageList = this.imageListCharms;
            this.listViewCharms.Location = new System.Drawing.Point(0, 0);
            this.listViewCharms.MultiSelect = false;
            this.listViewCharms.Name = "listViewCharms";
            this.listViewCharms.Size = new System.Drawing.Size(135, 209);
            this.listViewCharms.SmallImageList = this.imageListCharms;
            this.listViewCharms.TabIndex = 0;
            this.listViewCharms.UseCompatibleStateImageBehavior = false;
            this.listViewCharms.SelectedIndexChanged += new System.EventHandler(this.listViewCharms_SelectedIndexChanged);
            // 
            // columnHeaderImage
            // 
            this.columnHeaderImage.Text = "Image";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 300;
            // 
            // imageListCharms
            // 
            this.imageListCharms.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCharms.ImageStream")));
            this.imageListCharms.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCharms.Images.SetKeyName(0, "GreenCircle.gif");
            this.imageListCharms.Images.SetKeyName(1, "RedCircle.gif");
            this.imageListCharms.Images.SetKeyName(2, "YellowCircle.gif");
            this.imageListCharms.Images.SetKeyName(3, "YellowFilledCircle.gif");
            // 
            // buttonCharmEditOk
            // 
            this.buttonCharmEditOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCharmEditOk.Location = new System.Drawing.Point(99, 175);
            this.buttonCharmEditOk.Name = "buttonCharmEditOk";
            this.buttonCharmEditOk.Size = new System.Drawing.Size(75, 29);
            this.buttonCharmEditOk.TabIndex = 12;
            this.buttonCharmEditOk.Text = "OK";
            this.buttonCharmEditOk.UseVisualStyleBackColor = true;
            this.buttonCharmEditOk.Click += new System.EventHandler(this.buttonCharmEditOk_Click);
            // 
            // buttonCharmEditCancel
            // 
            this.buttonCharmEditCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCharmEditCancel.Location = new System.Drawing.Point(190, 175);
            this.buttonCharmEditCancel.Name = "buttonCharmEditCancel";
            this.buttonCharmEditCancel.Size = new System.Drawing.Size(75, 29);
            this.buttonCharmEditCancel.TabIndex = 13;
            this.buttonCharmEditCancel.Text = "キャンセル";
            this.buttonCharmEditCancel.UseVisualStyleBackColor = true;
            this.buttonCharmEditCancel.Click += new System.EventHandler(this.buttonCharmEditCancel_Click);
            // 
            // buttonCharmOriginReset
            // 
            this.buttonCharmOriginReset.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonCharmOriginReset.Location = new System.Drawing.Point(229, 62);
            this.buttonCharmOriginReset.Name = "buttonCharmOriginReset";
            this.buttonCharmOriginReset.Size = new System.Drawing.Size(20, 20);
            this.buttonCharmOriginReset.TabIndex = 17;
            this.buttonCharmOriginReset.Text = "Q";
            this.toolTipMain.SetToolTip(this.buttonCharmOriginReset, "画像の中心になるようリセット");
            this.buttonCharmOriginReset.UseVisualStyleBackColor = true;
            this.buttonCharmOriginReset.Click += new System.EventHandler(this.buttonCharmOriginReset_Click);
            // 
            // buttonCharmSizeReset
            // 
            this.buttonCharmSizeReset.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonCharmSizeReset.Location = new System.Drawing.Point(229, 11);
            this.buttonCharmSizeReset.Name = "buttonCharmSizeReset";
            this.buttonCharmSizeReset.Size = new System.Drawing.Size(20, 20);
            this.buttonCharmSizeReset.TabIndex = 16;
            this.buttonCharmSizeReset.Text = "Q";
            this.toolTipMain.SetToolTip(this.buttonCharmSizeReset, "元のサイズにリセット");
            this.buttonCharmSizeReset.UseVisualStyleBackColor = true;
            this.buttonCharmSizeReset.Click += new System.EventHandler(this.buttonCharmSizeReset_Click);
            // 
            // checkBoxCharmOriginLink
            // 
            this.checkBoxCharmOriginLink.Checked = true;
            this.checkBoxCharmOriginLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCharmOriginLink.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxCharmOriginLink.Location = new System.Drawing.Point(134, 82);
            this.checkBoxCharmOriginLink.Name = "checkBoxCharmOriginLink";
            this.checkBoxCharmOriginLink.Size = new System.Drawing.Size(75, 20);
            this.checkBoxCharmOriginLink.TabIndex = 15;
            this.checkBoxCharmOriginLink.Text = "比率固定";
            this.checkBoxCharmOriginLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipMain.SetToolTip(this.checkBoxCharmOriginLink, "縦横の比率を維持します");
            this.checkBoxCharmOriginLink.UseVisualStyleBackColor = true;
            // 
            // checkBoxCharmSizeLink
            // 
            this.checkBoxCharmSizeLink.Checked = true;
            this.checkBoxCharmSizeLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCharmSizeLink.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxCharmSizeLink.Location = new System.Drawing.Point(134, 32);
            this.checkBoxCharmSizeLink.Name = "checkBoxCharmSizeLink";
            this.checkBoxCharmSizeLink.Size = new System.Drawing.Size(75, 20);
            this.checkBoxCharmSizeLink.TabIndex = 14;
            this.checkBoxCharmSizeLink.Text = "比率固定";
            this.checkBoxCharmSizeLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipMain.SetToolTip(this.checkBoxCharmSizeLink, "縦横の比率を維持します");
            this.checkBoxCharmSizeLink.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "画像サイズ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "不透明度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "カーソル原点";
            // 
            // numericUpDownCharmHeight
            // 
            this.numericUpDownCharmHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCharmHeight.Location = new System.Drawing.Point(173, 12);
            this.numericUpDownCharmHeight.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.numericUpDownCharmHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCharmHeight.Name = "numericUpDownCharmHeight";
            this.numericUpDownCharmHeight.Size = new System.Drawing.Size(50, 19);
            this.numericUpDownCharmHeight.TabIndex = 4;
            this.numericUpDownCharmHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCharmHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCharmHeight.ValueChanged += new System.EventHandler(this.numericUpDownCharmHeight_ValueChanged);
            // 
            // numericUpDownCharmOriginY
            // 
            this.numericUpDownCharmOriginY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCharmOriginY.Location = new System.Drawing.Point(173, 63);
            this.numericUpDownCharmOriginY.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.numericUpDownCharmOriginY.Name = "numericUpDownCharmOriginY";
            this.numericUpDownCharmOriginY.Size = new System.Drawing.Size(50, 19);
            this.numericUpDownCharmOriginY.TabIndex = 9;
            this.numericUpDownCharmOriginY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCharmOriginY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownCharmWidth
            // 
            this.numericUpDownCharmWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCharmWidth.Location = new System.Drawing.Point(99, 11);
            this.numericUpDownCharmWidth.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.numericUpDownCharmWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCharmWidth.Name = "numericUpDownCharmWidth";
            this.numericUpDownCharmWidth.Size = new System.Drawing.Size(50, 19);
            this.numericUpDownCharmWidth.TabIndex = 2;
            this.numericUpDownCharmWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCharmWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCharmWidth.ValueChanged += new System.EventHandler(this.numericUpDownCharmWidth_ValueChanged);
            // 
            // numericUpDownOpacity
            // 
            this.numericUpDownOpacity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOpacity.Location = new System.Drawing.Point(99, 119);
            this.numericUpDownOpacity.Name = "numericUpDownOpacity";
            this.numericUpDownOpacity.Size = new System.Drawing.Size(50, 19);
            this.numericUpDownOpacity.TabIndex = 11;
            this.numericUpDownOpacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipMain.SetToolTip(this.numericUpDownOpacity, "0で完全に透明医、100で不透明です");
            this.numericUpDownOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownOpacity.ValueChanged += new System.EventHandler(this.numericUpDownOpacity_ValueChanged);
            // 
            // numericUpDownCharmOriginX
            // 
            this.numericUpDownCharmOriginX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCharmOriginX.Location = new System.Drawing.Point(99, 62);
            this.numericUpDownCharmOriginX.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.numericUpDownCharmOriginX.Name = "numericUpDownCharmOriginX";
            this.numericUpDownCharmOriginX.Size = new System.Drawing.Size(50, 19);
            this.numericUpDownCharmOriginX.TabIndex = 7;
            this.numericUpDownCharmOriginX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCharmOriginX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxLicense);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(456, 215);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "情報";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLicense
            // 
            this.richTextBoxLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLicense.Location = new System.Drawing.Point(8, 65);
            this.richTextBoxLicense.Name = "richTextBoxLicense";
            this.richTextBoxLicense.Size = new System.Drawing.Size(440, 142);
            this.richTextBoxLicense.TabIndex = 5;
            this.richTextBoxLicense.Text = resources.GetString("richTextBoxLicense.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelVersion);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "情報";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "マウスを素早く動かすと目立たせるソフト\r\n";
            // 
            // toolStripButtonAddCharm
            // 
            this.toolStripButtonAddCharm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddCharm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddCharm.Image")));
            this.toolStripButtonAddCharm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddCharm.Name = "toolStripButtonAddCharm";
            this.toolStripButtonAddCharm.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddCharm.Text = "＋";
            // 
            // toolStripButtonRemoveCharm
            // 
            this.toolStripButtonRemoveCharm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRemoveCharm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveCharm.Image")));
            this.toolStripButtonRemoveCharm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveCharm.Name = "toolStripButtonRemoveCharm";
            this.toolStripButtonRemoveCharm.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveCharm.Text = "ー";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton1.Text = "標準に戻す";
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.BalloonTipText = "チャームポインター (Chrmed Pointer)";
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripMain;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "チャームポインター";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.ToolStripMenuItemShowSettings_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowSettings,
            this.toolStripSeparatorBeforeQuit,
            this.toolStripMenuItemQuit});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(111, 54);
            // 
            // toolStripMenuItemShowSettings
            // 
            this.toolStripMenuItemShowSettings.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemShowSettings.Name = "toolStripMenuItemShowSettings";
            this.toolStripMenuItemShowSettings.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItemShowSettings.Text = "設定 ...";
            // 
            // toolStripSeparatorBeforeQuit
            // 
            this.toolStripSeparatorBeforeQuit.Name = "toolStripSeparatorBeforeQuit";
            this.toolStripSeparatorBeforeQuit.Size = new System.Drawing.Size(107, 6);
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItemQuit.Text = "終了";
            // 
            // openFileDialogAddCharm
            // 
            this.openFileDialogAddCharm.Filter = "画像|*.png,*.gif|すべてのファイル|*.*";
            this.openFileDialogAddCharm.Multiselect = true;
            this.openFileDialogAddCharm.Title = "画像の追加";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "バージョン";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(64, 35);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(35, 12);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "0.0.0.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "チャームポインター";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurationToHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocityToHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocityToShow)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainerCharms.Panel1.ResumeLayout(false);
            this.splitContainerCharms.Panel1.PerformLayout();
            this.splitContainerCharms.Panel2.ResumeLayout(false);
            this.splitContainerCharms.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharms)).EndInit();
            this.splitContainerCharms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmOriginY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharmOriginX)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownVelocityToHide;
        private System.Windows.Forms.NumericUpDown numericUpDownVelocityToShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDurationToHide;
        private System.Windows.Forms.SplitContainer splitContainerCharms;
        private System.Windows.Forms.ToolStrip toolStripEditCharms;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddCharm;
        private System.Windows.Forms.ListView listViewCharms;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ImageList imageListCharms;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveCharm;
        private System.Windows.Forms.Button buttonCharmSizeReset;
        private System.Windows.Forms.CheckBox checkBoxCharmSizeLink;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownCharmHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownCharmOriginY;
        private System.Windows.Forms.NumericUpDown numericUpDownCharmWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownCharmOriginX;
        private System.Windows.Forms.CheckBox checkBoxCharmOriginLink;
        private System.Windows.Forms.Button buttonCharmOriginReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownOpacity;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorBeforeQuit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxShowSettingsOnStart;
        private System.Windows.Forms.CheckBox checkBoxUseNotifyIcon;
        private System.Windows.Forms.Button buttonCharmEditCancel;
        private System.Windows.Forms.Button buttonCharmEditOk;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddCharm;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBoxLicense;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

