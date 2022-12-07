namespace Product_Search
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
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.btnViewByNumber = new System.Windows.Forms.Button();
            this.btnViewByDesc = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Product Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Product Description";
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(177, 71);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(100, 20);
            this.txtProductNumber.TabIndex = 2;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(559, 71);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(100, 20);
            this.txtProductDescription.TabIndex = 3;
            // 
            // btnViewByNumber
            // 
            this.btnViewByNumber.Location = new System.Drawing.Point(151, 155);
            this.btnViewByNumber.Name = "btnViewByNumber";
            this.btnViewByNumber.Size = new System.Drawing.Size(126, 23);
            this.btnViewByNumber.TabIndex = 4;
            this.btnViewByNumber.Text = "View Product";
            this.btnViewByNumber.UseVisualStyleBackColor = true;
            // 
            // btnViewByDesc
            // 
            this.btnViewByDesc.Location = new System.Drawing.Point(559, 155);
            this.btnViewByDesc.Name = "btnViewByDesc";
            this.btnViewByDesc.Size = new System.Drawing.Size(100, 23);
            this.btnViewByDesc.TabIndex = 5;
            this.btnViewByDesc.Text = "View Product";
            this.btnViewByDesc.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(318, 218);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(206, 20);
            this.txtResults.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnViewByDesc);
            this.Controls.Add(this.btnViewByNumber);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductNumber);
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
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Button btnViewByNumber;
        private System.Windows.Forms.Button btnViewByDesc;
        private System.Windows.Forms.TextBox txtResults;
    }
}

