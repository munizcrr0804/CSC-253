
namespace House_Price_Analysis
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBedRoom1 = new System.Windows.Forms.TextBox();
            this.txtBathRoom1 = new System.Windows.Forms.TextBox();
            this.txtSquareFeet1 = new System.Windows.Forms.TextBox();
            this.txtBedRoom2 = new System.Windows.Forms.TextBox();
            this.txtBathRoom2 = new System.Windows.Forms.TextBox();
            this.txtSquareFeet2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of BedRooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of BathRooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of SquareFeet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "To";
            // 
            // txtBedRoom1
            // 
            this.txtBedRoom1.Location = new System.Drawing.Point(197, 41);
            this.txtBedRoom1.Name = "txtBedRoom1";
            this.txtBedRoom1.Size = new System.Drawing.Size(100, 20);
            this.txtBedRoom1.TabIndex = 6;
            // 
            // txtBathRoom1
            // 
            this.txtBathRoom1.Location = new System.Drawing.Point(197, 85);
            this.txtBathRoom1.Name = "txtBathRoom1";
            this.txtBathRoom1.Size = new System.Drawing.Size(100, 20);
            this.txtBathRoom1.TabIndex = 7;
            // 
            // txtSquareFeet1
            // 
            this.txtSquareFeet1.Location = new System.Drawing.Point(197, 121);
            this.txtSquareFeet1.Name = "txtSquareFeet1";
            this.txtSquareFeet1.Size = new System.Drawing.Size(100, 20);
            this.txtSquareFeet1.TabIndex = 8;
            // 
            // txtBedRoom2
            // 
            this.txtBedRoom2.Location = new System.Drawing.Point(489, 50);
            this.txtBedRoom2.Name = "txtBedRoom2";
            this.txtBedRoom2.Size = new System.Drawing.Size(100, 20);
            this.txtBedRoom2.TabIndex = 9;
            // 
            // txtBathRoom2
            // 
            this.txtBathRoom2.Location = new System.Drawing.Point(489, 88);
            this.txtBathRoom2.Name = "txtBathRoom2";
            this.txtBathRoom2.Size = new System.Drawing.Size(100, 20);
            this.txtBathRoom2.TabIndex = 10;
            // 
            // txtSquareFeet2
            // 
            this.txtSquareFeet2.Location = new System.Drawing.Point(489, 120);
            this.txtSquareFeet2.Name = "txtSquareFeet2";
            this.txtSquareFeet2.Size = new System.Drawing.Size(100, 20);
            this.txtSquareFeet2.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(308, 201);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(252, 268);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(184, 95);
            this.lbResults.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSquareFeet2);
            this.Controls.Add(this.txtBathRoom2);
            this.Controls.Add(this.txtBedRoom2);
            this.Controls.Add(this.txtSquareFeet1);
            this.Controls.Add(this.txtBathRoom1);
            this.Controls.Add(this.txtBedRoom1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "House Price Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBedRoom1;
        private System.Windows.Forms.TextBox txtBathRoom1;
        private System.Windows.Forms.TextBox txtSquareFeet1;
        private System.Windows.Forms.TextBox txtBedRoom2;
        private System.Windows.Forms.TextBox txtBathRoom2;
        private System.Windows.Forms.TextBox txtSquareFeet2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbResults;
    }
}

