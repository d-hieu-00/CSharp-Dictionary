
namespace Dictionary.Forms.Search.UserControls
{
    partial class s_RowSearch
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
            this.lb_value = new System.Windows.Forms.Label();
            this.lb_dics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_value
            // 
            this.lb_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_value.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_value.Location = new System.Drawing.Point(0, 0);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(127, 25);
            this.lb_value.TabIndex = 0;
            this.lb_value.Text = "Read";
            this.lb_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_value.Click += new System.EventHandler(this.s_RowSearch_Click);
            // 
            // lb_dics
            // 
            this.lb_dics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_dics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_dics.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dics.Location = new System.Drawing.Point(127, 0);
            this.lb_dics.Name = "lb_dics";
            this.lb_dics.Size = new System.Drawing.Size(73, 25);
            this.lb_dics.TabIndex = 1;
            this.lb_dics.Text = "Anh - Việt";
            this.lb_dics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_dics.Click += new System.EventHandler(this.s_RowSearch_Click);
            // 
            // s_RowSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_dics);
            this.Controls.Add(this.lb_value);
            this.Name = "s_RowSearch";
            this.Size = new System.Drawing.Size(200, 25);
            this.Click += new System.EventHandler(this.s_RowSearch_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_value;
        private System.Windows.Forms.Label lb_dics;
    }
}
