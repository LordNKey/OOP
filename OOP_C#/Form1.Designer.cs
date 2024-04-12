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
            ((System.ComponentModel.ISupportInitialize)pbMainField).BeginInit();
            SuspendLayout();
            // 
            // pbMainField
            // 
            pbMainField.BorderStyle = BorderStyle.FixedSingle;
            pbMainField.Location = new Point(1, 77);
            pbMainField.Name = "pbMainField";
            pbMainField.Size = new Size(799, 372);
            pbMainField.TabIndex = 0;
            pbMainField.TabStop = false;
            pbMainField.Paint += pbMainField_Paint;
            // 
            // fMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbMainField);
            Name = "fMainForm";
            Text = "ООП";
            ((System.ComponentModel.ISupportInitialize)pbMainField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbMainField;
    }
}
