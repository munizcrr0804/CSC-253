
namespace List_Manipulator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstActual = new System.Windows.Forms.ListBox();
            this.lstPositive = new System.Windows.Forms.ListBox();
            this.lst_1_10 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Removing Negative Values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1097, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elements in The ranges 1 to 10";
            // 
            // lstActual
            // 
            this.lstActual.FormattingEnabled = true;
            this.lstActual.Location = new System.Drawing.Point(195, 213);
            this.lstActual.Name = "lstActual";
            this.lstActual.Size = new System.Drawing.Size(120, 95);
            this.lstActual.TabIndex = 3;
            // 
            // lstPositive
            // 
            this.lstPositive.FormattingEnabled = true;
            this.lstPositive.Location = new System.Drawing.Point(597, 213);
            this.lstPositive.Name = "lstPositive";
            this.lstPositive.Size = new System.Drawing.Size(120, 95);
            this.lstPositive.TabIndex = 4;
            // 
            // lst_1_10
            // 
            this.lst_1_10.FormattingEnabled = true;
            this.lst_1_10.Location = new System.Drawing.Point(1100, 213);
            this.lst_1_10.Name = "lst_1_10";
            this.lst_1_10.Size = new System.Drawing.Size(120, 95);
            this.lst_1_10.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 692);
            this.Controls.Add(this.lst_1_10);
            this.Controls.Add(this.lstPositive);
            this.Controls.Add(this.lstActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstActual;
        private System.Windows.Forms.ListBox lstPositive;
        private System.Windows.Forms.ListBox lst_1_10;
    }
}

