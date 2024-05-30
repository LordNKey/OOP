using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    partial class KeyInputForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbKey = new System.Windows.Forms.TextBox();
            bOK = new System.Windows.Forms.Button();
            tbIV = new System.Windows.Forms.TextBox();
            lKey = new System.Windows.Forms.Label();
            lIV = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // tbKey
            // 
            tbKey.Location = new System.Drawing.Point(76, 58);
            tbKey.Name = "tbKey";
            tbKey.Size = new System.Drawing.Size(260, 27);
            tbKey.TabIndex = 0;
            // 
            // bOK
            // 
            bOK.Location = new System.Drawing.Point(375, 95);
            bOK.Name = "bOK";
            bOK.Size = new System.Drawing.Size(75, 29);
            bOK.TabIndex = 3;
            bOK.Text = "OK";
            bOK.UseVisualStyleBackColor = true;
            bOK.Click += bOK_Click;
            // 
            // tbIV
            // 
            tbIV.Location = new System.Drawing.Point(76, 130);
            tbIV.Name = "tbIV";
            tbIV.Size = new System.Drawing.Size(260, 27);
            tbIV.TabIndex = 2;
            // 
            // lKey
            // 
            lKey.AutoSize = true;
            lKey.Location = new System.Drawing.Point(188, 35);
            lKey.Name = "lKey";
            lKey.Size = new System.Drawing.Size(46, 20);
            lKey.TabIndex = 4;
            lKey.Text = "Ключ";
            // 
            // lIV
            // 
            lIV.AutoSize = true;
            lIV.Location = new System.Drawing.Point(199, 107);
            lIV.Name = "lIV";
            lIV.Size = new System.Drawing.Size(22, 20);
            lIV.TabIndex = 5;
            lIV.Text = "IV";
            // 
            // KeyInputForm
            // 
            ClientSize = new System.Drawing.Size(523, 230);
            Controls.Add(lIV);
            Controls.Add(lKey);
            Controls.Add(bOK);
            Controls.Add(tbIV);
            Controls.Add(tbKey);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "KeyInputForm";
            Text = "Ввод ключа";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.Label lIV;
    }
}
