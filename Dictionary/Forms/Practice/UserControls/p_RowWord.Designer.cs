
namespace Dictionary.Forms.Practice.UserControls
{
    partial class p_RowWord
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
            this.btn_Detail = new System.Windows.Forms.Button();
            this.pic_Img = new System.Windows.Forms.PictureBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Detail
            // 
            this.btn_Detail.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Detail.FlatAppearance.BorderSize = 0;
            this.btn_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detail.ForeColor = System.Drawing.Color.White;
            this.btn_Detail.Location = new System.Drawing.Point(422, 3);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 50);
            this.btn_Detail.TabIndex = 1;
            this.btn_Detail.Text = "Chi tiết";
            this.btn_Detail.UseVisualStyleBackColor = false;
            // 
            // pic_Img
            // 
            this.pic_Img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Img.Image = global::Dictionary.Properties.Resources.Cat_roll;
            this.pic_Img.Location = new System.Drawing.Point(3, 3);
            this.pic_Img.Name = "pic_Img";
            this.pic_Img.Size = new System.Drawing.Size(120, 104);
            this.pic_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Img.TabIndex = 0;
            this.pic_Img.TabStop = false;
            // 
            // btn_Listen
            // 
            this.btn_Listen.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Listen.FlatAppearance.BorderSize = 0;
            this.btn_Listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.ForeColor = System.Drawing.Color.White;
            this.btn_Listen.Location = new System.Drawing.Point(422, 57);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 50);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "Nghe";
            this.btn_Listen.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(129, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(129, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_RowWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.pic_Img);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "p_RowWord";
            this.Size = new System.Drawing.Size(500, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Img;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
