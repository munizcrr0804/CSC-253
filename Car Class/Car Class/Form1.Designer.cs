
namespace Car_Class
{
    partial class Car_Class
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
            this.txtMake = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.Label();
            this.makeTxtBox = new System.Windows.Forms.TextBox();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.btnAccelerate_Click = new System.Windows.Forms.Button();
            this.btnBrake_Click = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.Get_Speed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMake
            // 
            this.txtMake.AutoSize = true;
            this.txtMake.Location = new System.Drawing.Point(138, 68);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(34, 13);
            this.txtMake.TabIndex = 0;
            this.txtMake.Text = "Make";
            // 
            // txtYear
            // 
            this.txtYear.AutoSize = true;
            this.txtYear.Location = new System.Drawing.Point(529, 67);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(29, 13);
            this.txtYear.TabIndex = 1;
            this.txtYear.Text = "Year";
            // 
            // makeTxtBox
            // 
            this.makeTxtBox.Location = new System.Drawing.Point(114, 143);
            this.makeTxtBox.Name = "makeTxtBox";
            this.makeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.makeTxtBox.TabIndex = 2;
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(501, 142);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(100, 20);
            this.yearTxtBox.TabIndex = 3;
            // 
            // btnAccelerate_Click
            // 
            this.btnAccelerate_Click.Location = new System.Drawing.Point(114, 223);
            this.btnAccelerate_Click.Name = "btnAccelerate_Click";
            this.btnAccelerate_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate_Click.TabIndex = 4;
            this.btnAccelerate_Click.Text = "Accelerate";
            this.btnAccelerate_Click.UseVisualStyleBackColor = true;
            this.btnAccelerate_Click.Click += new System.EventHandler(this.btnAccelerate_Click_Click);
            // 
            // btnBrake_Click
            // 
            this.btnBrake_Click.Location = new System.Drawing.Point(501, 223);
            this.btnBrake_Click.Name = "btnBrake_Click";
            this.btnBrake_Click.Size = new System.Drawing.Size(75, 23);
            this.btnBrake_Click.TabIndex = 5;
            this.btnBrake_Click.Text = "Brake";
            this.btnBrake_Click.UseVisualStyleBackColor = true;
            this.btnBrake_Click.Click += new System.EventHandler(this.btnBrake_Click_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(300, 364);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "Speed";
            // 
            // Get_Speed
            // 
            this.Get_Speed.AutoSize = true;
            this.Get_Speed.Location = new System.Drawing.Point(419, 364);
            this.Get_Speed.Name = "Get_Speed";
            this.Get_Speed.Size = new System.Drawing.Size(13, 13);
            this.Get_Speed.TabIndex = 7;
            this.Get_Speed.Text = "0";
            // 
            // Car_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Get_Speed);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.btnBrake_Click);
            this.Controls.Add(this.btnAccelerate_Click);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.makeTxtBox);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Name = "Car_Class";
            this.Text = "Car_Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMake;
        private System.Windows.Forms.Label txtYear;
        private System.Windows.Forms.TextBox makeTxtBox;
        private System.Windows.Forms.TextBox yearTxtBox;
        private System.Windows.Forms.Button btnAccelerate_Click;
        private System.Windows.Forms.Button btnBrake_Click;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label Get_Speed;
    }
}

