
namespace Dictionary.Forms.Practice.UserControls
{
    partial class p_t_RowResult
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
            this.lb_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_No
            // 
            this.lb_No.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_No.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_No.Location = new System.Drawing.Point(0, 0);
            this.lb_No.Name = "lb_No";
            this.lb_No.Size = new System.Drawing.Size(38, 23);
            this.lb_No.TabIndex = 0;
            this.lb_No.Text = "STT";
            this.lb_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Result
            // 
            this.lb_Result.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Result.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_Result.Location = new System.Drawing.Point(38, 0);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(97, 23);
            this.lb_Result.TabIndex = 1;
            this.lb_Result.Text = "40/45";
            this.lb_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Time
            // 
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Time.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(135, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(47, 23);
            this.lb_Time.TabIndex = 2;
            this.lb_Time.Text = "40:45";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_t_RowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.lb_No);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "p_t_RowResult";
            this.Size = new System.Drawing.Size(182, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_No;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_Time;
    }
}
