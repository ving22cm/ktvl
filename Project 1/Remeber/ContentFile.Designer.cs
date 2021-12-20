
namespace Project_1
{
    partial class ContentFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuRating1 = new Bunifu.UI.WinForms.BunifuRating();
            this.txtRateContent = new System.Windows.Forms.Label();
            this.txtNameContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.bunifuRating1.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.InnerRadius = 2F;
            this.bunifuRating1.Location = new System.Drawing.Point(541, 33);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.OuterRadius = 10F;
            this.bunifuRating1.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.ReadOnly = false;
            this.bunifuRating1.RightClickToClear = true;
            this.bunifuRating1.Size = new System.Drawing.Size(121, 22);
            this.bunifuRating1.TabIndex = 0;
            this.bunifuRating1.Text = "bunifuRating1";
            this.bunifuRating1.Value = 2;
            // 
            // txtRateContent
            // 
            this.txtRateContent.AutoSize = true;
            this.txtRateContent.Location = new System.Drawing.Point(672, 39);
            this.txtRateContent.Name = "txtRateContent";
            this.txtRateContent.Size = new System.Drawing.Size(49, 13);
            this.txtRateContent.TabIndex = 1;
            this.txtRateContent.Text = "Vừa phải";
            // 
            // txtNameContent
            // 
            this.txtNameContent.AutoSize = true;
            this.txtNameContent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameContent.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNameContent.Location = new System.Drawing.Point(54, 6);
            this.txtNameContent.Name = "txtNameContent";
            this.txtNameContent.Size = new System.Drawing.Size(222, 21);
            this.txtNameContent.TabIndex = 2;
            this.txtNameContent.Text = "Tên Content Của Người Dùng";
            // 
            // ContentFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNameContent);
            this.Controls.Add(this.txtRateContent);
            this.Controls.Add(this.bunifuRating1);
            this.Name = "ContentFile";
            this.Size = new System.Drawing.Size(796, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuRating bunifuRating1;
        private System.Windows.Forms.Label txtRateContent;
        private System.Windows.Forms.Label txtNameContent;
    }
}
