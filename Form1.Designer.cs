using System.Drawing;
using System.Windows.Forms;

namespace Graphics1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            file_ToolStripMenuItem = new ToolStripMenuItem();
            open_ToolStripMenuItem = new ToolStripMenuItem();
            saveAs_ToolStripMenuItem = new ToolStripMenuItem();
            filters_lr5_ToolStripMenuItem = new ToolStripMenuItem();
            invert_ToolStripMenuItem = new ToolStripMenuItem();
            grayScale_ToolStripMenuItem = new ToolStripMenuItem();
            binarization_ToolStripMenuItem = new ToolStripMenuItem();
            increaseBrightness_ЯркостьToolStripMenuItem = new ToolStripMenuItem();
            decreaseBrightness_ЯркостьToolStripMenuItem = new ToolStripMenuItem();
            increase_contrast_ToolStripMenuItem = new ToolStripMenuItem();
            decrease_contrast_ToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            amountTextBox = new TextBox();
            Label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { file_ToolStripMenuItem, filters_lr5_ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1379, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // file_ToolStripMenuItem
            // 
            file_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { open_ToolStripMenuItem, saveAs_ToolStripMenuItem });
            file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            file_ToolStripMenuItem.Size = new Size(95, 20);
            file_ToolStripMenuItem.Text = "Изображение";
            // 
            // open_ToolStripMenuItem
            // 
            open_ToolStripMenuItem.Name = "open_ToolStripMenuItem";
            open_ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            open_ToolStripMenuItem.Size = new Size(203, 22);
            open_ToolStripMenuItem.Text = "Открыть";
            open_ToolStripMenuItem.Click += Open_ToolStripMenuItem_Click;
            // 
            // saveAs_ToolStripMenuItem
            // 
            saveAs_ToolStripMenuItem.Name = "saveAs_ToolStripMenuItem";
            saveAs_ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveAs_ToolStripMenuItem.Size = new Size(203, 22);
            saveAs_ToolStripMenuItem.Text = "Сохранить как...";
            saveAs_ToolStripMenuItem.Click += Save_as_ToolStripMenuItem_Click;
            // 
            // filters_lr5_ToolStripMenuItem
            // 
            filters_lr5_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { invert_ToolStripMenuItem, grayScale_ToolStripMenuItem, binarization_ToolStripMenuItem, increaseBrightness_ЯркостьToolStripMenuItem, decreaseBrightness_ЯркостьToolStripMenuItem, increase_contrast_ToolStripMenuItem, decrease_contrast_ToolStripMenuItem });
            filters_lr5_ToolStripMenuItem.Name = "filters_lr5_ToolStripMenuItem";
            filters_lr5_ToolStripMenuItem.Size = new Size(69, 20);
            filters_lr5_ToolStripMenuItem.Text = "Фильтры";
            // 
            // invert_ToolStripMenuItem
            // 
            invert_ToolStripMenuItem.Name = "invert_ToolStripMenuItem";
            invert_ToolStripMenuItem.Size = new Size(212, 22);
            invert_ToolStripMenuItem.Text = "Негатив";
            invert_ToolStripMenuItem.Click += Inverse_ToolStripMenuItem_Click;
            // 
            // grayScale_ToolStripMenuItem
            // 
            grayScale_ToolStripMenuItem.Name = "grayScale_ToolStripMenuItem";
            grayScale_ToolStripMenuItem.Size = new Size(212, 22);
            grayScale_ToolStripMenuItem.Text = "Оттенки серого";
            grayScale_ToolStripMenuItem.Click += GrayScale_ToolStripMenuItem_Click;
            // 
            // binarization_ToolStripMenuItem
            // 
            binarization_ToolStripMenuItem.Name = "binarization_ToolStripMenuItem";
            binarization_ToolStripMenuItem.Size = new Size(212, 22);
            binarization_ToolStripMenuItem.Text = "Бинаризация";
            binarization_ToolStripMenuItem.Click += Binarization_ToolStripMenuItem_Click;
            // 
            // increaseBrightness_ЯркостьToolStripMenuItem
            // 
            increaseBrightness_ЯркостьToolStripMenuItem.Name = "increaseBrightness_ЯркостьToolStripMenuItem";
            increaseBrightness_ЯркостьToolStripMenuItem.Size = new Size(212, 22);
            increaseBrightness_ЯркостьToolStripMenuItem.Text = "Увеличить яркость";
            increaseBrightness_ЯркостьToolStripMenuItem.Click += IncreaseBrightness_ToolStripMenuItem_Click;
            // 
            // decreaseBrightness_ЯркостьToolStripMenuItem
            // 
            decreaseBrightness_ЯркостьToolStripMenuItem.Name = "decreaseBrightness_ЯркостьToolStripMenuItem";
            decreaseBrightness_ЯркостьToolStripMenuItem.Size = new Size(212, 22);
            decreaseBrightness_ЯркостьToolStripMenuItem.Text = "Уменьшить яркость";
            decreaseBrightness_ЯркостьToolStripMenuItem.Click += DecreaseBrightness_ToolStripMenuItem_Click;
            // 
            // increase_contrast_ToolStripMenuItem
            // 
            increase_contrast_ToolStripMenuItem.Name = "increase_contrast_ToolStripMenuItem";
            increase_contrast_ToolStripMenuItem.Size = new Size(212, 22);
            increase_contrast_ToolStripMenuItem.Text = "Повысить контрастность";
            increase_contrast_ToolStripMenuItem.Click += IncreaseContrast_ToolStripMenuItem_Click;
            // 
            // decrease_contrast_ToolStripMenuItem
            // 
            decrease_contrast_ToolStripMenuItem.Name = "decrease_contrast_ToolStripMenuItem";
            decrease_contrast_ToolStripMenuItem.Size = new Size(212, 22);
            decrease_contrast_ToolStripMenuItem.Text = "Понизить контрастность";
            decrease_contrast_ToolStripMenuItem.Click += DecreaseContrast_ToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image files | *.png; *.jpg; *.bmp; | All files(*.*) | *.*";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0, 0, 9, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1015, 683);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 355F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(amountTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(Label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(1379, 725);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(1033, 0);
            pictureBox2.Margin = new Padding(9, 0, 18, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 683);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            amountTextBox.Location = new Point(982, 692);
            amountTextBox.Margin = new Padding(9);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(33, 23);
            amountTextBox.TabIndex = 4;
            amountTextBox.Text = "50";
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(786, 696);
            Label1.Name = "Label1";
            Label1.Size = new Size(184, 15);
            Label1.TabIndex = 1;
            Label1.Text = "Интенсивность фильтра (0-255):";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "filename.png";
            saveFileDialog1.Filter = "Image files | *.png; *.jpg; *.bmp; | All files(*.*) | *.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 749);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(527, 471);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лаба №5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filters_lr5_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invert_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem grayScale_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarization_ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem saveAs_ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem increaseBrightness_ЯркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseBrightness_ЯркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increase_contrast_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrease_contrast_ToolStripMenuItem;
        private Label Label1;
        private TextBox amountTextBox;
        private PictureBox pictureBox2;
    }
}

