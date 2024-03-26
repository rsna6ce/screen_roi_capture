﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_roi_capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int offset_x = 0;
        private int offset_y = 0;

        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.Top -= 1;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.Top += 1;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.Top -= 1;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            this.Top += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            offset_y = this.Height - pictureBoxRoi.Height;
            offset_x = this.Width - pictureBoxRoi.Width;
            comboBoxPresetSize.SelectedIndex = 0;
        }

        private void buttonPresetSize_Click(object sender, EventArgs e)
        {
            string[] width_height = comboBoxPresetSize.Text.Split('x');
            int width = int.Parse(width_height[0]);
            int height = int.Parse(width_height[1]);
            this.Width = width + offset_x;
            this.Height = height + offset_y;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBoxRoi.Width, pictureBoxRoi.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bitmap.Size);
            Clipboard.SetImage(bitmap);
            bitmap.Dispose();
            g.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = textBoxSave.Text + numericUpDownSave.Value.ToString("0000") + ".png";
            sfd.Filter = "png|*.png";
            sfd.Title = "画像を保存";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = false;
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                //cancel
                return;
            }

            Bitmap bitmap = new Bitmap(pictureBoxRoi.Width, pictureBoxRoi.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bitmap.Size);
            bitmap.Save(sfd.FileName);
            bitmap.Dispose();
            g.Dispose();
            numericUpDownSave.Value = (int)numericUpDownSave.Value + 1;
        }
    }
}