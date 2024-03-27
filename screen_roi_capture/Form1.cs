using System;
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
            this.Left -= 1;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            this.Left += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            offset_y = this.Height - pictureBoxRoi.Height;
            offset_x = this.Width - pictureBoxRoi.Width;
            comboBoxPresetSize.SelectedIndex = 0;
            buttonPresetSize_Click(sender, e);

            int h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Top = (h - this.Height) / 2;
            this.Left = (w - this.Width) / 2;
        }

        private void SetPresetScreen(int width, int height)
        {
            this.Width = width + offset_x;
            this.Height = height + offset_y;
            labelRoiSize.Text = pictureBoxRoi.Width.ToString() + "x" + pictureBoxRoi.Height.ToString();
        }

        private void buttonPresetSize_Click(object sender, EventArgs e)
        {
            string[] width_height = comboBoxPresetSize.Text.Split('x');
            int width = int.Parse(width_height[0]);
            int height = int.Parse(width_height[1]);
            SetPresetScreen(width, height);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBoxRoi.Width, pictureBoxRoi.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(pictureBoxRoi.PointToScreen(new Point(0, 0)).X, pictureBoxRoi.PointToScreen(new Point(0, 0)).Y), new Point(0, 0), bitmap.Size);
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

            // capture
            Bitmap bitmap = new Bitmap(pictureBoxRoi.Width, pictureBoxRoi.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(pictureBoxRoi.PointToScreen(new Point(0, 0)).X, pictureBoxRoi.PointToScreen(new Point(0, 0)).Y), new Point(0, 0), bitmap.Size);

            // dialog
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                // cancel
                return;
            }
            
            // save
            bitmap.Save(sfd.FileName);
            bitmap.Dispose();
            g.Dispose();
            numericUpDownSave.Value = (int)numericUpDownSave.Value + 1;
        }

        private void pictureBoxRoi_SizeChanged(object sender, EventArgs e)
        {
            labelRoiSize.Text = pictureBoxRoi.Width.ToString() + "x" + pictureBoxRoi.Height.ToString();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            labelPos.Text = this.Top.ToString() + "," + this.Left.ToString();
        }

        private void buttonHeightUp_Click(object sender, EventArgs e)
        {
            this.Height -= 1;
        }

        private void buttonHeightDown_Click(object sender, EventArgs e)
        {
            this.Height += 1;
        }

        private void buttonWidthDown_Click(object sender, EventArgs e)
        {
            this.Width -= 1;
        }

        private void buttonWidthUp_Click(object sender, EventArgs e)
        {
            this.Width += 1;
        }
    }
}
