namespace OOP_C_
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
            pbMainField = new PictureBox();
            pMainPanel = new Panel();
            bBorder_color = new Button();
            bFill_color = new Button();
            lFigure = new Label();
            cbFigure = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbMainField).BeginInit();
            pMainPanel.SuspendLayout();
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
            pMainPanel.Controls.Add(bBorder_color);
            pMainPanel.Controls.Add(bFill_color);
            pMainPanel.Controls.Add(lFigure);
            pMainPanel.Controls.Add(cbFigure);
            pMainPanel.Location = new Point(1, 1);
            pMainPanel.Name = "pMainPanel";
            pMainPanel.Size = new Size(1200, 77);
            pMainPanel.TabIndex = 1;
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
            cbFigure.Items.AddRange(new object[] { "Квадрат", "Прямоугольник", "Круг", "Овал", "Равносторонний треугольник", "Равнобедренный треугольник", "Прямоугольный треугольник" });
            cbFigure.Location = new Point(250, 40);
            cbFigure.Name = "cbFigure";
            cbFigure.Size = new Size(151, 28);
            cbFigure.TabIndex = 0;
            cbFigure.Text = "Выберете фигуру";
            // 
            // fMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 627);
            Controls.Add(pMainPanel);
            Controls.Add(pbMainField);
            Name = "fMainForm";
            Text = "ООП";
            ((System.ComponentModel.ISupportInitialize)pbMainField).EndInit();
            pMainPanel.ResumeLayout(false);
            pMainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbMainField;
        private Panel pMainPanel;
        private Label lFigure;
        private ComboBox cbFigure;
        private Button bBorder_color;
        private Button bFill_color;
    }
}
