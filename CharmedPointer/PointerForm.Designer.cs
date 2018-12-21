namespace CharmedPointer
{
    partial class PointerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointerForm));
            this.timerForMainLoop = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPointer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointer)).BeginInit();
            this.SuspendLayout();
            // 
            // timerForMainLoop
            // 
            this.timerForMainLoop.Interval = 16;
            this.timerForMainLoop.Tick += new System.EventHandler(this.timerForMainLoop_Tick);
            // 
            // pictureBoxPointer
            // 
            this.pictureBoxPointer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPointer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPointer.ErrorImage")));
            this.pictureBoxPointer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPointer.Image")));
            this.pictureBoxPointer.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPointer.Name = "pictureBoxPointer";
            this.pictureBoxPointer.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxPointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPointer.TabIndex = 0;
            this.pictureBoxPointer.TabStop = false;
            // 
            // PointerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(128, 128);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxPointer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PointerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pointer";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.PointerForm_Load);
            this.Shown += new System.EventHandler(this.PointerForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPointer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerForMainLoop;
        private System.Windows.Forms.PictureBox pictureBoxPointer;
    }
}