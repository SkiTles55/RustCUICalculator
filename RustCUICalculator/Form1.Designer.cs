using System.Windows.Forms;

namespace RustCUICalculator
{
	partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHeight = new System.Windows.Forms.TextBox();
            this.outBox = new System.Windows.Forms.RichTextBox();
            this.InputScHeigth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InputScWidth = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelY = new System.Windows.Forms.Label();
            this.panelX = new System.Windows.Forms.TextBox();
            this.CustomPosButton = new System.Windows.Forms.RadioButton();
            this.labelX = new System.Windows.Forms.Label();
            this.CenteredButton = new System.Windows.Forms.RadioButton();
            this.panelY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.previewBox = new System.Windows.Forms.GroupBox();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opacityPicker = new System.Windows.Forms.TrackBar();
            this.mainWindowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.previewBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWidth
            // 
            this.panelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelWidth.Location = new System.Drawing.Point(30, 28);
            this.panelWidth.Name = "panelWidth";
            this.panelWidth.Size = new System.Drawing.Size(59, 23);
            this.panelWidth.TabIndex = 4;
            this.panelWidth.Text = "600";
            this.panelWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelWidth.TextChanged += new System.EventHandler(this.panelWidth_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "x";
            // 
            // panelHeight
            // 
            this.panelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHeight.Location = new System.Drawing.Point(115, 28);
            this.panelHeight.Name = "panelHeight";
            this.panelHeight.Size = new System.Drawing.Size(59, 23);
            this.panelHeight.TabIndex = 6;
            this.panelHeight.Text = "600";
            this.panelHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelHeight.TextChanged += new System.EventHandler(this.panelHeight_TextChanged);
            // 
            // outBox
            // 
            this.outBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outBox.Location = new System.Drawing.Point(8, 649);
            this.outBox.Name = "outBox";
            this.outBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outBox.Size = new System.Drawing.Size(1204, 64);
            this.outBox.TabIndex = 10;
            this.outBox.Text = "";
            // 
            // InputScHeigth
            // 
            this.InputScHeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputScHeigth.Location = new System.Drawing.Point(115, 28);
            this.InputScHeigth.Name = "InputScHeigth";
            this.InputScHeigth.Size = new System.Drawing.Size(59, 23);
            this.InputScHeigth.TabIndex = 15;
            this.InputScHeigth.Text = "1080";
            this.InputScHeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputScHeigth.TextChanged += new System.EventHandler(this.InputScHeigth_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(95, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "x";
            // 
            // InputScWidth
            // 
            this.InputScWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputScWidth.Location = new System.Drawing.Point(30, 28);
            this.InputScWidth.Name = "InputScWidth";
            this.InputScWidth.Size = new System.Drawing.Size(59, 23);
            this.InputScWidth.TabIndex = 13;
            this.InputScWidth.Text = "1920";
            this.InputScWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputScWidth.TextChanged += new System.EventHandler(this.InputScWidth_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelY);
            this.groupBox2.Controls.Add(this.panelX);
            this.groupBox2.Controls.Add(this.CustomPosButton);
            this.groupBox2.Controls.Add(this.labelX);
            this.groupBox2.Controls.Add(this.CenteredButton);
            this.groupBox2.Controls.Add(this.panelY);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(8, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 146);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Положение панели";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(137, 88);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 17);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "Y";
            this.labelY.Visible = false;
            // 
            // panelX
            // 
            this.panelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelX.Location = new System.Drawing.Point(30, 108);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(59, 23);
            this.panelX.TabIndex = 7;
            this.panelX.Text = "0";
            this.panelX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelX.Visible = false;
            this.panelX.TextChanged += new System.EventHandler(this.panelX_TextChanged);
            // 
            // CustomPosButton
            // 
            this.CustomPosButton.AutoSize = true;
            this.CustomPosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomPosButton.Location = new System.Drawing.Point(7, 56);
            this.CustomPosButton.Name = "CustomPosButton";
            this.CustomPosButton.Size = new System.Drawing.Size(130, 21);
            this.CustomPosButton.TabIndex = 1;
            this.CustomPosButton.Text = "Настраиваемое";
            this.CustomPosButton.UseVisualStyleBackColor = true;
            this.CustomPosButton.CheckedChanged += new System.EventHandler(this.CustomPosButton_CheckedChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(53, 88);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 17);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "X";
            this.labelX.Visible = false;
            // 
            // CenteredButton
            // 
            this.CenteredButton.AutoSize = true;
            this.CenteredButton.Checked = true;
            this.CenteredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenteredButton.Location = new System.Drawing.Point(7, 29);
            this.CenteredButton.Name = "CenteredButton";
            this.CenteredButton.Size = new System.Drawing.Size(94, 21);
            this.CenteredButton.TabIndex = 0;
            this.CenteredButton.TabStop = true;
            this.CenteredButton.Text = "По центру";
            this.CenteredButton.UseVisualStyleBackColor = true;
            this.CenteredButton.CheckedChanged += new System.EventHandler(this.CenteredButton_CheckedChanged);
            // 
            // panelY
            // 
            this.panelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelY.Location = new System.Drawing.Point(115, 108);
            this.panelY.Name = "panelY";
            this.panelY.Size = new System.Drawing.Size(59, 23);
            this.panelY.TabIndex = 9;
            this.panelY.Text = "0";
            this.panelY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.panelY.Visible = false;
            this.panelY.TextChanged += new System.EventHandler(this.panelY_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelWidth);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.panelHeight);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(8, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 65);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Размер панели";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.InputScWidth);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.InputScHeigth);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 60);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Разрешение экрана";
            // 
            // previewBox
            // 
            this.previewBox.Controls.Add(this.changeImageButton);
            this.previewBox.Controls.Add(this.previewPanel);
            this.previewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewBox.Location = new System.Drawing.Point(219, 3);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(993, 624);
            this.previewBox.TabIndex = 19;
            this.previewBox.TabStop = false;
            this.previewBox.Text = "Предпросмотр";
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(701, 586);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(286, 32);
            this.changeImageButton.TabIndex = 1;
            this.changeImageButton.Text = "Выбрать изображение";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.SystemColors.Window;
            this.previewPanel.BackgroundImage = global::RustCUICalculator.Properties.Resources.previewBackground;
            this.previewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewPanel.Location = new System.Drawing.Point(16, 36);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(960, 540);
            this.previewPanel.TabIndex = 0;
            this.previewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewPanel_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.colorButton);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(8, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 67);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Цвет панели";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.Location = new System.Drawing.Point(6, 28);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(193, 27);
            this.colorButton.TabIndex = 20;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "pic.jpg";
            this.openFileDialog1.Filter = "|*.jpg|*.bmp|*.png|*.jpeg|";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(1098, 716);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "vk.com/vkbotrust";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opacityPicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Прозрачность";
            // 
            // opacityPicker
            // 
            this.opacityPicker.Location = new System.Drawing.Point(7, 29);
            this.opacityPicker.Maximum = 255;
            this.opacityPicker.Minimum = 1;
            this.opacityPicker.Name = "opacityPicker";
            this.opacityPicker.Size = new System.Drawing.Size(187, 45);
            this.opacityPicker.TabIndex = 0;
            this.opacityPicker.Value = 255;
            this.opacityPicker.ValueChanged += new System.EventHandler(this.opacityPicker_ValueChanged);
            // 
            // mainWindowBindingSource
            // 
            this.mainWindowBindingSource.DataSource = typeof(RustCUICalculator.MainWindow);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1221, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.outBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1237, 774);
            this.Name = "MainWindow";
            this.Text = "RustCUICalculator by SkiTles";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.previewBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox panelWidth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox panelHeight;
		private System.Windows.Forms.RichTextBox outBox;
		private System.Windows.Forms.BindingSource mainWindowBindingSource;
		private TextBox InputScHeigth;
		private Label label7;
		private TextBox InputScWidth;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private GroupBox previewBox;
		private Panel previewPanel;
		private GroupBox groupBox5;
		private ColorDialog colorDialog1;
		private Button colorButton;
		private Button changeImageButton;
		private OpenFileDialog openFileDialog1;
		private LinkLabel linkLabel1;
		private RadioButton CustomPosButton;
		private RadioButton CenteredButton;
		private Label labelY;
		private TextBox panelX;
		private Label labelX;
		private TextBox panelY;
		private GroupBox groupBox1;
        private TrackBar opacityPicker;
    }
}

