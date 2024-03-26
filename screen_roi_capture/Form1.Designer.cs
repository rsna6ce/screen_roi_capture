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
            this.pictureBoxRoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            "640x480",
            "800x600",
            "1024x768"});
            this.comboBoxPresetSize.Location = new System.Drawing.Point(4, 8);
            this.comboBoxPresetSize.Name = "comboBoxPresetSize";
            this.comboBoxPresetSize.Size = new System.Drawing.Size(68, 20);
            this.comboBoxPresetSize.TabIndex = 1;
            // 
            // buttonPresetSize
            // 
            this.buttonPresetSize.Location = new System.Drawing.Point(76, 8);
            this.buttonPresetSize.Name = "buttonPresetSize";
            this.buttonPresetSize.Size = new System.Drawing.Size(48, 20);
            this.buttonPresetSize.TabIndex = 2;
            this.buttonPresetSize.Text = "set";
            this.buttonPresetSize.UseVisualStyleBackColor = true;
            this.buttonPresetSize.Click += new System.EventHandler(this.buttonPresetSize_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(292, 8);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(48, 20);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(240, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(48, 20);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownSave
            // 
            this.numericUpDownSave.Location = new System.Drawing.Point(188, 8);
            this.numericUpDownSave.Name = "numericUpDownSave";
            this.numericUpDownSave.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownSave.TabIndex = 5;
            this.numericUpDownSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(144, 8);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(44, 19);
            this.textBoxSave.TabIndex = 6;
            this.textBoxSave.Text = "image";
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(364, 8);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(31, 20);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(396, 8);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(31, 20);
            this.buttonDown.TabIndex = 8;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(428, 8);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(31, 20);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(460, 8);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(31, 20);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelRoiSize
            // 
            this.labelRoiSize.AutoSize = true;
            this.labelRoiSize.Location = new System.Drawing.Point(684, 12);
            this.labelRoiSize.Name = "labelRoiSize";
            this.labelRoiSize.Size = new System.Drawing.Size(25, 12);
            this.labelRoiSize.TabIndex = 11;
            this.labelRoiSize.Text = "size";
            // 
            // buttonWidthUp
            // 
            this.buttonWidthUp.Location = new System.Drawing.Point(652, 8);
            this.buttonWidthUp.Name = "buttonWidthUp";
            this.buttonWidthUp.Size = new System.Drawing.Size(31, 20);
            this.buttonWidthUp.TabIndex = 15;
            this.buttonWidthUp.Text = "→";
            this.buttonWidthUp.UseVisualStyleBackColor = true;
            this.buttonWidthUp.Click += new System.EventHandler(this.buttonWidthUp_Click);
            // 
            // buttonWidthDown
            // 
            this.buttonWidthDown.Location = new System.Drawing.Point(620, 8);
            this.buttonWidthDown.Name = "buttonWidthDown";
            this.buttonWidthDown.Size = new System.Drawing.Size(31, 20);
            this.buttonWidthDown.TabIndex = 14;
            this.buttonWidthDown.Text = "←";
            this.buttonWidthDown.UseVisualStyleBackColor = true;
            this.buttonWidthDown.Click += new System.EventHandler(this.buttonWidthDown_Click);
            // 
            // buttonHeightDown
            // 
            this.buttonHeightDown.Location = new System.Drawing.Point(588, 8);
            this.buttonHeightDown.Name = "buttonHeightDown";
            this.buttonHeightDown.Size = new System.Drawing.Size(31, 20);
            this.buttonHeightDown.TabIndex = 13;
            this.buttonHeightDown.Text = "↓";
            this.buttonHeightDown.UseVisualStyleBackColor = true;
            this.buttonHeightDown.Click += new System.EventHandler(this.buttonHeightDown_Click);
            // 
            // buttonHeightUp
            // 
            this.buttonHeightUp.Location = new System.Drawing.Point(556, 8);
            this.buttonHeightUp.Name = "buttonHeightUp";
            this.buttonHeightUp.Size = new System.Drawing.Size(31, 20);
            this.buttonHeightUp.TabIndex = 12;
            this.buttonHeightUp.Text = "↑";
            this.buttonHeightUp.UseVisualStyleBackColor = true;
            this.buttonHeightUp.Click += new System.EventHandler(this.buttonHeightUp_Click);
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(492, 12);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(23, 12);
            this.labelPos.TabIndex = 16;
            this.labelPos.Text = "pos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 640);
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
    }
}

