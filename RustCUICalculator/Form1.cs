using System;
using System.Drawing;
using System.Windows.Forms;

namespace RustCUICalculator
{
    public partial class MainWindow : Form
	{

		public MainWindow()
		{
			InitializeComponent();
			Calc();
		}

		private void Calc()
		{
			if (CenteredButton.Checked) CalcCenter();
			if (CustomPosButton.Checked) CalcCustom();
			previewPanel.Invalidate();
		}

		private void CalcCustom()
		{
			string result = "error";
			float scWidth = 0;
			float.TryParse(InputScWidth.Text, out scWidth);
			float scHeigth = 0;
			float.TryParse(InputScHeigth.Text, out scHeigth);
			float elWidth = 0;
			float.TryParse(panelWidth.Text, out elWidth);
			float elHeigth = 0;
			float.TryParse(panelHeight.Text, out elHeigth);
			var i2 = (((Convert.ToInt32(panelY.Text) + elHeigth) - scHeigth) / scHeigth).ToString();
			var i1 = (Convert.ToInt32(panelX.Text) / scWidth).ToString();
			if (i1.Contains("-")) i1 = i1.Replace("-", "");
			if (i1.Length > 4) i1 = i1.Remove(4);
			if (i2.Contains("-")) i2 = i2.Replace("-", "");
			if (i2.Length > 4) i2 = i2.Remove(4);
			var j1 = ((elWidth + Convert.ToInt32(panelX.Text)) / scWidth).ToString();
			var j2 = ((scHeigth - Convert.ToInt32(panelY.Text)) / scHeigth).ToString();
			if (j1.Contains("-")) j1 = j1.Replace("-", "");
			if (j1.Length > 4) j1 = j1.Remove(4);
			if (j2.Contains("-")) j2 = j2.Replace("-", "");
			if (j2.Length > 4) j2 = j2.Remove(4);
			result = $"AnchorMin = {i1.Replace(",", ".")} {i2.Replace(",", ".")}, AnchorMax = {j1.Replace(",", ".")} {j2.Replace(",", ".")}, Color = {ColorConvert()}";
			outBox.Text = result;
		}

		private void CalcCenter()
		{
			string result = "error";
			float scWidth = 0;
			float.TryParse(InputScWidth.Text, out scWidth);
			float scHeigth = 0;
			float.TryParse(InputScHeigth.Text, out scHeigth);
			float elWidth = 0;
			float.TryParse(panelWidth.Text, out elWidth);
			float elHeigth = 0;
			float.TryParse(panelHeight.Text, out elHeigth);
			string anmin1 = (((scWidth / 2) - (elWidth / 2)) / scWidth).ToString();
			if (anmin1.Length > 4) anmin1 = anmin1.Remove(4);
			string anmin2 = (((scHeigth / 2) - (elHeigth / 2)) / scHeigth).ToString();
			if (anmin2.Length > 4) anmin2 = anmin2.Remove(4);
			string anmax1 = ((((scWidth / 2) - (elWidth / 2)) + elWidth) / scWidth).ToString();
			if (anmax1.Length > 4) anmax1 = anmax1.Remove(4);
			string anmax2 = ((((scHeigth / 2) - (elHeigth / 2)) + elHeigth) / scHeigth).ToString();
			if (anmax2.Length > 4) anmax2 = anmax2.Remove(4);
			result = $"AnchorMin = {anmin1.Replace(",", ".")} {anmin2.Replace(",", ".")}, AnchorMax = {anmax1.Replace(",", ".")} {anmax2.Replace(",", ".")}, Color = {ColorConvert()}";
			outBox.Text = result;
		}

		private void InputScWidth_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(InputScWidth.Text, "[^0-9]")) InputScWidth.Text = InputScWidth.Text.Remove(InputScWidth.Text.Length - 1);
			var i = Convert.ToInt32(InputScWidth.Text);
			if (i > 1920) InputScWidth.Text = "1920";
			previewPanel.Width = i / 2;
			Calc();
		}

		private void InputScHeigth_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(InputScHeigth.Text, "[^0-9]")) InputScHeigth.Text = InputScHeigth.Text.Remove(InputScHeigth.Text.Length - 1);
			var i = Convert.ToInt32(InputScHeigth.Text);
			if (i > 1080) InputScHeigth.Text = "1080";
			previewPanel.Height = i / 2;
			Calc();
		}

		private void panelWidth_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(panelWidth.Text, "[^0-9]")) panelWidth.Text = panelWidth.Text.Remove(panelWidth.Text.Length - 1);
			var i = Convert.ToInt32(panelWidth.Text);
			var b = Convert.ToInt32(InputScWidth.Text);
			if (i > b) panelWidth.Text = InputScWidth.Text;
			Calc();
		}

		private void panelHeight_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(panelHeight.Text, "[^0-9]")) panelHeight.Text = panelHeight.Text.Remove(panelWidth.Text.Length - 1);
			var i = Convert.ToInt32(panelHeight.Text);
			var b = Convert.ToInt32(InputScHeigth.Text);
			if (i > b) panelHeight.Text = InputScHeigth.Text;
			Calc();
		}

		private void previewPanel_Paint(object sender, PaintEventArgs e)
		{
			Brush test = new SolidBrush(Color.FromArgb(opacityPicker.Value, colorButton.BackColor.R, colorButton.BackColor.G, colorButton.BackColor.B));
			Graphics g;
			g = e.Graphics;
			Pen blackPen = new Pen(colorButton.BackColor, 1);
			Rectangle rect = new Rectangle(GetPreviewX(), GetPreviewY(), Convert.ToInt32(panelWidth.Text) / 2, Convert.ToInt32(panelHeight.Text) / 2);
			g.DrawRectangle(blackPen, rect);
			g.FillRectangle(test, rect);
		}

		private int GetPreviewX()
		{
			int i = 0;
			if (CenteredButton.Checked)	i = (previewPanel.Width / 2) - ((Convert.ToInt32(panelWidth.Text) / 2) / 2);
			if (CustomPosButton.Checked) i = Convert.ToInt32(panelX.Text) / 2;
			return i;
		}

		private int GetPreviewY()
		{
			int i = 0;
			if (CenteredButton.Checked)	i = (previewPanel.Height / 2) - ((Convert.ToInt32(panelHeight.Text) / 2) / 2);
			if (CustomPosButton.Checked) i = Convert.ToInt32(panelY.Text) / 2;
			return i;
		}

		private void colorButton_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				colorButton.BackColor = colorDialog1.Color;
                Calc();
			}
		}

		private void changeImageButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				previewPanel.BackgroundImage = ImageOpen(openFileDialog1.FileName);
			}
		}

		public Image ImageOpen(string filename)
		{
			return Image.FromFile(filename);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.LinkVisited = true;
			System.Diagnostics.Process.Start("https://vk.com/vkbotrust");
		}

		private void CenteredButton_CheckedChanged(object sender, EventArgs e)
		{
			Calc();
			if (CenteredButton.Checked)
			{
				labelX.Visible = false;
				labelY.Visible = false;
				panelX.Visible = false;
				panelY.Visible = false;
			}
		}
		private void CustomPosButton_CheckedChanged(object sender, EventArgs e)
		{
			Calc();
			if (CustomPosButton.Checked)
			{
				labelX.Visible = true;
				labelY.Visible = true;
				panelX.Visible = true;
				panelY.Visible = true;
			}
		}

		private void panelX_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(panelX.Text, "[^0-9]")) panelX.Text = panelX.Text.Remove(panelX.Text.Length - 1);
			int value = Convert.ToInt32(panelX.Text);
			int value2 = Convert.ToInt32(InputScWidth.Text) - Convert.ToInt32(panelWidth.Text);
			if (value > value2) { value = value2; panelX.Text = value2.ToString(); }
			Calc();
		}

		private void panelY_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(panelY.Text, "[^0-9]")) panelY.Text = panelY.Text.Remove(panelY.Text.Length - 1);
			int value = Convert.ToInt32(panelY.Text);
			int value2 = Convert.ToInt32(InputScHeigth.Text) - Convert.ToInt32(panelHeight.Text);
			if (value > value2) { value = value2; panelY.Text = value2.ToString(); }
			Calc();
		}

        private void opacityPicker_ValueChanged(object sender, EventArgs e) => Calc();

        private string ColorConvert()
        {
            string r = ((float)colorButton.BackColor.R / 255).ToString();
            r = r.Replace(",", ".");
            if (r.Length > 5) r = r.Remove(4);
            string g = ((float)colorButton.BackColor.G / 255).ToString();
            g = g.Replace(",", ".");
            if (g.Length > 5) g = g.Remove(4);
            string b = ((float)colorButton.BackColor.B / 255).ToString();
            b = b.Replace(",", ".");
            if (b.Length > 5) b = b.Remove(4);
            string a = ((float)opacityPicker.Value / 255).ToString();
            a = a.Replace(",", ".");
            if (a.Length > 5) a = a.Remove(4);
            string color = $"{r} {g} {b} {a}";
            return color;
        }
    }
}
