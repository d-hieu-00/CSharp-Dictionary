
namespace Dictionary.Forms.Practice.UserControls
{
    partial class p_RowLession
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
            this.lb_InfoTopic = new System.Windows.Forms.Label();
            this.lb_TitleTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_InfoTopic
            // 
            this.lb_InfoTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_InfoTopic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InfoTopic.Location = new System.Drawing.Point(0, 24);
            this.lb_InfoTopic.Name = "lb_InfoTopic";
            this.lb_InfoTopic.Size = new System.Drawing.Size(180, 41);
            this.lb_InfoTopic.TabIndex = 1;
            this.lb_InfoTopic.Text = "Số từ vựng : 12";
            this.lb_InfoTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_InfoTopic.Click += new System.EventHandler(this.lb_InfoTopic_Click);
            // 
            // lb_TitleTopic
            // 
            this.lb_TitleTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_TitleTopic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TitleTopic.Location = new System.Drawing.Point(0, 0);
            this.lb_TitleTopic.Name = "lb_TitleTopic";
            this.lb_TitleTopic.Size = new System.Drawing.Size(180, 24);
            this.lb_TitleTopic.TabIndex = 0;
            this.lb_TitleTopic.Text = "Lession 1 : Contract";
            this.lb_TitleTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_TitleTopic.Click += new System.EventHandler(this.lb_InfoTopic_Click);
            // 
            // p_RowLession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.lb_InfoTopic);
            this.Controls.Add(this.lb_TitleTopic);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "p_RowLession";
            this.Size = new System.Drawing.Size(180, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_InfoTopic;
        private System.Windows.Forms.Label lb_TitleTopic;
    }
}
