
namespace Dictionary.Forms.Practice.UserControls
{
    partial class p_t_RowDetailResult
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
            this.lb_No = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lb_asw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_No
            // 
            this.lb_No.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_No.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_No.Location = new System.Drawing.Point(0, 0);
            this.lb_No.Name = "lb_No";
            this.lb_No.Size = new System.Drawing.Size(55, 23);
            this.lb_No.TabIndex = 0;
            this.lb_No.Text = "STT";
            this.lb_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Result
            // 
            this.lb_Result.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Result.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Result.Location = new System.Drawing.Point(55, 0);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(91, 23);
            this.lb_Result.TabIndex = 1;
            this.lb_Result.Text = "hello";
            this.lb_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_asw
            // 
            this.lb_asw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_asw.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_asw.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lb_asw.Location = new System.Drawing.Point(146, 0);
            this.lb_asw.Name = "lb_asw";
            this.lb_asw.Size = new System.Drawing.Size(100, 23);
            this.lb_asw.TabIndex = 2;
            this.lb_asw.Text = "xin chào";
            this.lb_asw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_t_RowDetailResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_asw);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.lb_No);
            this.Name = "p_t_RowDetailResult";
            this.Size = new System.Drawing.Size(246, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_No;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_asw;
    }
}
