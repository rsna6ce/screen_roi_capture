namespace screen_roi_capture
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxRoi = new System.Windows.Forms.PictureBox();
            this.comboBoxPresetSize = new System.Windows.Forms.ComboBox();
            this.buttonPresetSize = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownSave = new System.Windows.Forms.NumericUpDown();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelRoiSize = new System.Windows.Forms.Label();
            this.buttonWidthUp = new System.Windows.Forms.Button();
            this.buttonWidthDown = new System.Windows.Forms.Button();
            this.buttonHeightDown = new System.Windows.Forms.Button();
            this.buttonHeightUp = new System.Windows.Forms.Button();
            this.labelPos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSave)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRoi
            // 
            this.pictureBoxRoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRoi.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxRoi.Location = new System.Drawing.Point(4, 36);
            this.pictureBoxRoi.Name = "pictureBoxRoi";
            this.pictureBoxRoi.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxRoi.TabIndex = 0;
            this.pictureBoxRoi.TabStop = false;
            this.pictureBoxRoi.SizeChanged += new System.EventHandler(this.pictureBoxRoi_SizeChanged);
            // 
            // comboBoxPresetSize
            // 
            this.comboBoxPresetSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPresetSize.FormattingEnabled = true;
            this.comboBoxPresetSize.Items.AddRange(new object[] {
            "1280x720",
            "1024x768",
            "800x600",
            "640x480"});
            this.comboBoxPresetSize.Location = new System.Drawing.Point(4, 8);
            this.comboBoxPresetSize.Name = "comboBoxPresetSize";
            this.comboBoxPresetSize.Size = new System.Drawing.Size(76, 20);
            this.comboBoxPresetSize.TabIndex = 1;
            // 
            // buttonPresetSize
            // 
            this.buttonPresetSize.Location = new System.Drawing.Point(80, 8);
            this.buttonPresetSize.Name = "buttonPresetSize";
            this.buttonPresetSize.Size = new System.Drawing.Size(36, 20);
            this.buttonPresetSize.TabIndex = 2;
            this.buttonPresetSize.Text = "set";
            this.buttonPresetSize.UseVisualStyleBackColor = true;
            this.buttonPresetSize.Click += new System.EventHandler(this.buttonPresetSize_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(276, 8);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(40, 20);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(216, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(40, 20);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownSave
            // 
            this.numericUpDownSave.Location = new System.Drawing.Point(168, 8);
            this.numericUpDownSave.Name = "numericUpDownSave";
            this.numericUpDownSave.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownSave.TabIndex = 5;
            this.numericUpDownSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(124, 8);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(44, 19);
            this.textBoxSave.TabIndex = 6;
            this.textBoxSave.Text = "image";
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(336, 8);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(20, 20);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(356, 8);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(20, 20);
            this.buttonDown.TabIndex = 8;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(376, 8);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(396, 8);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(20, 20);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelRoiSize
            // 
            this.labelRoiSize.AutoSize = true;
            this.labelRoiSize.Location = new System.Drawing.Point(552, 16);
            this.labelRoiSize.Name = "labelRoiSize";
            this.labelRoiSize.Size = new System.Drawing.Size(25, 12);
            this.labelRoiSize.TabIndex = 11;
            this.labelRoiSize.Text = "size";
            // 
            // buttonWidthUp
            // 
            this.buttonWidthUp.Location = new System.Drawing.Point(532, 8);
            this.buttonWidthUp.Name = "buttonWidthUp";
            this.buttonWidthUp.Size = new System.Drawing.Size(20, 20);
            this.buttonWidthUp.TabIndex = 15;
            this.buttonWidthUp.Text = "→";
            this.buttonWidthUp.UseVisualStyleBackColor = true;
            this.buttonWidthUp.Click += new System.EventHandler(this.buttonWidthUp_Click);
            // 
            // buttonWidthDown
            // 
            this.buttonWidthDown.Location = new System.Drawing.Point(512, 8);
            this.buttonWidthDown.Name = "buttonWidthDown";
            this.buttonWidthDown.Size = new System.Drawing.Size(20, 20);
            this.buttonWidthDown.TabIndex = 14;
            this.buttonWidthDown.Text = "←";
            this.buttonWidthDown.UseVisualStyleBackColor = true;
            this.buttonWidthDown.Click += new System.EventHandler(this.buttonWidthDown_Click);
            // 
            // buttonHeightDown
            // 
            this.buttonHeightDown.Location = new System.Drawing.Point(492, 8);
            this.buttonHeightDown.Name = "buttonHeightDown";
            this.buttonHeightDown.Size = new System.Drawing.Size(20, 20);
            this.buttonHeightDown.TabIndex = 13;
            this.buttonHeightDown.Text = "↓";
            this.buttonHeightDown.UseVisualStyleBackColor = true;
            this.buttonHeightDown.Click += new System.EventHandler(this.buttonHeightDown_Click);
            // 
            // buttonHeightUp
            // 
            this.buttonHeightUp.Location = new System.Drawing.Point(472, 8);
            this.buttonHeightUp.Name = "buttonHeightUp";
            this.buttonHeightUp.Size = new System.Drawing.Size(20, 20);
            this.buttonHeightUp.TabIndex = 12;
            this.buttonHeightUp.Text = "↑";
            this.buttonHeightUp.UseVisualStyleBackColor = true;
            this.buttonHeightUp.Click += new System.EventHandler(this.buttonHeightUp_Click);
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(416, 16);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(23, 12);
            this.labelPos.TabIndex = 16;
            this.labelPos.Text = "pos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "pos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "size";
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Location = new System.Drawing.Point(620, 12);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(43, 16);
            this.checkBoxGrid.TabIndex = 20;
            this.checkBoxGrid.Text = "grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(256, 8);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(20, 20);
            this.buttonTimer.TabIndex = 3;
            this.buttonTimer.Text = "T";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // timerSave
            // 
            this.timerSave.Interval = 1000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 640);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.buttonWidthUp);
            this.Controls.Add(this.buttonWidthDown);
            this.Controls.Add(this.buttonHeightDown);
            this.Controls.Add(this.buttonHeightUp);
            this.Controls.Add(this.labelRoiSize);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.numericUpDownSave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonPresetSize);
            this.Controls.Add(this.comboBoxPresetSize);
            this.Controls.Add(this.pictureBoxRoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "screen_roi_capture";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRoi;
        private System.Windows.Forms.ComboBox comboBoxPresetSize;
        private System.Windows.Forms.Button buttonPresetSize;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownSave;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelRoiSize;
        private System.Windows.Forms.Button buttonWidthUp;
        private System.Windows.Forms.Button buttonWidthDown;
        private System.Windows.Forms.Button buttonHeightDown;
        private System.Windows.Forms.Button buttonHeightUp;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Timer timerSave;
    }
}

