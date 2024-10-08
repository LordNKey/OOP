﻿namespace OOP_C_
{
    partial class fMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainForm));
            pbMainField = new PictureBox();
            pMainPanel = new Panel();
            bDelete = new Button();
            bBorder_color = new Button();
            bFill_color = new Button();
            lFigure = new Label();
            cbFigure = new ComboBox();
            msMainMenu = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem1 = new ToolStripMenuItem();
            bINToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            bINToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbMainField).BeginInit();
            pMainPanel.SuspendLayout();
            msMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pbMainField
            // 
            pbMainField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbMainField.BorderStyle = BorderStyle.FixedSingle;
            pbMainField.Location = new Point(1, 77);
            pbMainField.Name = "pbMainField";
            pbMainField.Size = new Size(1200, 550);
            pbMainField.TabIndex = 0;
            pbMainField.TabStop = false;
            pbMainField.Paint += pbMainField_Paint;
            pbMainField.MouseDown += pbMainField_MouseDown;
            pbMainField.MouseMove += pbMainField_MouseMove;
            pbMainField.MouseUp += pbMainField_MouseUp;
            // 
            // pMainPanel
            // 
            pMainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pMainPanel.BorderStyle = BorderStyle.FixedSingle;
            pMainPanel.Controls.Add(bDelete);
            pMainPanel.Controls.Add(bBorder_color);
            pMainPanel.Controls.Add(bFill_color);
            pMainPanel.Controls.Add(lFigure);
            pMainPanel.Controls.Add(cbFigure);
            pMainPanel.Controls.Add(msMainMenu);
            pMainPanel.Location = new Point(1, 1);
            pMainPanel.Name = "pMainPanel";
            pMainPanel.Size = new Size(1200, 77);
            pMainPanel.TabIndex = 1;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(527, 21);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(161, 28);
            bDelete.TabIndex = 4;
            bDelete.Text = "Удалить";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bBorder_color
            // 
            bBorder_color.Location = new Point(778, 40);
            bBorder_color.Name = "bBorder_color";
            bBorder_color.Size = new Size(220, 29);
            bBorder_color.TabIndex = 3;
            bBorder_color.Text = "Выберите цвет границы";
            bBorder_color.UseVisualStyleBackColor = true;
            bBorder_color.Click += bBorder_color_Click;
            // 
            // bFill_color
            // 
            bFill_color.Location = new Point(778, 5);
            bFill_color.Name = "bFill_color";
            bFill_color.Size = new Size(220, 29);
            bFill_color.TabIndex = 2;
            bFill_color.Text = "Выберите цвет заливки";
            bFill_color.UseVisualStyleBackColor = true;
            bFill_color.Click += bFill_color_Click;
            // 
            // lFigure
            // 
            lFigure.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lFigure.AutoSize = true;
            lFigure.Location = new Point(295, 17);
            lFigure.Name = "lFigure";
            lFigure.Size = new Size(59, 20);
            lFigure.TabIndex = 1;
            lFigure.Text = "Фигура";
            // 
            // cbFigure
            // 
            cbFigure.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbFigure.FormattingEnabled = true;
            cbFigure.Location = new Point(250, 40);
            cbFigure.Name = "cbFigure";
            cbFigure.Size = new Size(151, 28);
            cbFigure.TabIndex = 0;
            cbFigure.Text = "Выберете фигуру";
            // 
            // msMainMenu
            // 
            msMainMenu.ImageScalingSize = new Size(20, 20);
            msMainMenu.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, настройкиToolStripMenuItem });
            msMainMenu.Location = new Point(0, 0);
            msMainMenu.Name = "msMainMenu";
            msMainMenu.Size = new Size(1198, 28);
            msMainMenu.TabIndex = 5;
            msMainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, toolStripSeparator1, toolStripSeparator2 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jSONToolStripMenuItem1, bINToolStripMenuItem1 });
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShowShortcutKeys = false;
            открытьToolStripMenuItem.Size = new Size(157, 26);
            открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // jSONToolStripMenuItem1
            // 
            jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            jSONToolStripMenuItem1.Size = new Size(127, 26);
            jSONToolStripMenuItem1.Text = "JSON";
            jSONToolStripMenuItem1.Click += jSONToolStripMenuOpen_Click;
            // 
            // bINToolStripMenuItem1
            // 
            bINToolStripMenuItem1.Name = "bINToolStripMenuItem1";
            bINToolStripMenuItem1.Size = new Size(127, 26);
            bINToolStripMenuItem1.Text = "BIN";
            bINToolStripMenuItem1.Click += bINToolStripMenuOpen_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(154, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jSONToolStripMenuItem, bINToolStripMenuItem });
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShowShortcutKeys = false;
            сохранитьToolStripMenuItem.Size = new Size(157, 26);
            сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(127, 26);
            jSONToolStripMenuItem.Text = "JSON";
            jSONToolStripMenuItem.Click += jSONToolStripMenuSave_Click;
            // 
            // bINToolStripMenuItem
            // 
            bINToolStripMenuItem.Name = "bINToolStripMenuItem";
            bINToolStripMenuItem.Size = new Size(127, 26);
            bINToolStripMenuItem.Text = "BIN";
            bINToolStripMenuItem.Click += bINToolStripMenuSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(154, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(154, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(98, 24);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // fMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 627);
            Controls.Add(pMainPanel);
            Controls.Add(pbMainField);
            MainMenuStrip = msMainMenu;
            Name = "fMainForm";
            Text = "ООП";
            ((System.ComponentModel.ISupportInitialize)pbMainField).EndInit();
            pMainPanel.ResumeLayout(false);
            pMainPanel.PerformLayout();
            msMainMenu.ResumeLayout(false);
            msMainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbMainField;
        private Panel pMainPanel;
        private Label lFigure;
        private ComboBox cbFigure;
        private Button bBorder_color;
        private Button bFill_color;
        private Button bDelete;
        private MenuStrip msMainMenu;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem bINToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem jSONToolStripMenuItem1;
        private ToolStripMenuItem bINToolStripMenuItem1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
    }
}
