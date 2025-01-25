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
        private List<Label> gridline_list = new List<Label>();

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
            var grid_enable = this.checkBoxGrid.Checked;
            this.checkBoxGrid.Checked = false;
            Application.DoEvents();

            Bitmap bitmap = new Bitmap(pictureBoxRoi.Width, pictureBoxRoi.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(pictureBoxRoi.PointToScreen(new Point(0, 0)).X, pictureBoxRoi.PointToScreen(new Point(0, 0)).Y), new Point(0, 0), bitmap.Size);
            Clipboard.SetImage(bitmap);
            bitmap.Dispose();
            g.Dispose();

            this.checkBoxGrid.Checked = grid_enable;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var grid_enable = this.checkBoxGrid.Checked;
            this.checkBoxGrid.Checked = false;
            Application.DoEvents();

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

            this.checkBoxGrid.Checked = grid_enable;
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

        private void AddGridLine(int start_x, int start_y, int end_x, int end_y)
        {
            var label_temp = new Label();
            label_temp.BorderStyle = BorderStyle.FixedSingle;
            label_temp.AutoSize = false;
            label_temp.ForeColor = Color.Yellow;
            label_temp.BackColor = Color.Yellow;
            label_temp.Left = Math.Min(start_x, end_x);
            label_temp.Top = Math.Min(start_y, end_y);
            if (start_x == end_x)
            {
                label_temp.Width = 1;
                label_temp.Height = Math.Abs(end_y - start_y);
            }
            else if( start_y == end_y)
            {
                label_temp.Width = Math.Abs(end_x - start_x);
                label_temp.Height = 1;
            }
            else
            {
                label_temp = null;
                return;
            }
            this.gridline_list.Add(label_temp);
            this.Controls.Add(label_temp);
            label_temp.BringToFront();
        }

        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrid.Checked)
            {
                // 16:9のアスペクト比のとき、左右の4:3両端
                if (pictureBoxRoi.Height / 9 == pictureBoxRoi.Width / 16)
                {
                    AddGridLine(
                        pictureBoxRoi.Left + (pictureBoxRoi.Width - pictureBoxRoi.Height * 4 / 3) / 2,
                        pictureBoxRoi.Top,
                        pictureBoxRoi.Left + (pictureBoxRoi.Width - pictureBoxRoi.Height * 4 / 3) / 2,
                        pictureBoxRoi.Top + pictureBoxRoi.Height);
                    AddGridLine(
                        pictureBoxRoi.Left + pictureBoxRoi.Width - (pictureBoxRoi.Width - pictureBoxRoi.Height * 4 / 3) / 2,
                        pictureBoxRoi.Top,
                        pictureBoxRoi.Left + pictureBoxRoi.Width - (pictureBoxRoi.Width - pictureBoxRoi.Height * 4 / 3) / 2,
                        pictureBoxRoi.Top + pictureBoxRoi.Height);
                }
                // 縦横三分割
                AddGridLine(
                    pictureBoxRoi.Left + (pictureBoxRoi.Width / 3 * 1),
                    pictureBoxRoi.Top,
                    pictureBoxRoi.Left + (pictureBoxRoi.Width / 3 * 1),
                    pictureBoxRoi.Top + pictureBoxRoi.Height);
                AddGridLine(
                    pictureBoxRoi.Left + (pictureBoxRoi.Width / 3 * 2),
                    pictureBoxRoi.Top,
                    pictureBoxRoi.Left + (pictureBoxRoi.Width / 3 * 2),
                    pictureBoxRoi.Top + pictureBoxRoi.Height);
                AddGridLine(
                    pictureBoxRoi.Left,
                    pictureBoxRoi.Top + (pictureBoxRoi.Height / 3 * 1),
                    pictureBoxRoi.Left + pictureBoxRoi.Width,
                    pictureBoxRoi.Top + (pictureBoxRoi.Height / 3 * 1));
                AddGridLine(
                    pictureBoxRoi.Left,
                    pictureBoxRoi.Top + (pictureBoxRoi.Height / 3 * 2),
                    pictureBoxRoi.Left + pictureBoxRoi.Width,
                    pictureBoxRoi.Top + (pictureBoxRoi.Height / 3 * 2));
            }
            else
            {
                // オブジェクトを消す
                while (this.gridline_list.Count > 0)
                {
                    var line = this.gridline_list[0];
                    this.Controls.Remove(line);
                    line = null;
                    this.gridline_list.RemoveAt(0);
                }

            }
        }
    }
}
