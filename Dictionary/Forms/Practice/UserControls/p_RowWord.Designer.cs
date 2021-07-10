
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
            this.lb_Vocabulary = new System.Windows.Forms.Label();
            this.lb_Pronounce = new System.Windows.Forms.Label();
            this.lb_Mean = new System.Windows.Forms.Label();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.pic_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Vocabulary
            // 
            this.lb_Vocabulary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Vocabulary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Vocabulary.Location = new System.Drawing.Point(129, 3);
            this.lb_Vocabulary.Name = "lb_Vocabulary";
            this.lb_Vocabulary.Size = new System.Drawing.Size(287, 25);
            this.lb_Vocabulary.TabIndex = 3;
            this.lb_Vocabulary.Text = "Hello";
            this.lb_Vocabulary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Pronounce
            // 
            this.lb_Pronounce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Pronounce.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pronounce.ForeColor = System.Drawing.Color.Red;
            this.lb_Pronounce.Location = new System.Drawing.Point(129, 28);
            this.lb_Pronounce.Name = "lb_Pronounce";
            this.lb_Pronounce.Size = new System.Drawing.Size(287, 20);
            this.lb_Pronounce.TabIndex = 4;
            this.lb_Pronounce.Text = "label2";
            this.lb_Pronounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Mean
            // 
            this.lb_Mean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mean.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mean.ForeColor = System.Drawing.Color.DimGray;
            this.lb_Mean.Location = new System.Drawing.Point(129, 48);
            this.lb_Mean.Name = "lb_Mean";
            this.lb_Mean.Size = new System.Drawing.Size(287, 59);
            this.lb_Mean.TabIndex = 5;
            this.lb_Mean.Text = "-- Chưa có nghĩa --";
            this.lb_Mean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Listen
            // 
            this.btn_Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Listen.FlatAppearance.BorderSize = 0;
            this.btn_Listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.ForeColor = System.Drawing.Color.White;
            this.btn_Listen.Image = global::Dictionary.Properties.Resources.icons8_audio_50px;
            this.btn_Listen.Location = new System.Drawing.Point(422, 57);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 50);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.UseVisualStyleBackColor = false;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Detail.FlatAppearance.BorderSize = 0;
            this.btn_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detail.ForeColor = System.Drawing.Color.White;
            this.btn_Detail.Image = global::Dictionary.Properties.Resources.icons8_show_property_40px;
            this.btn_Detail.Location = new System.Drawing.Point(422, 3);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 50);
            this.btn_Detail.TabIndex = 1;
            this.btn_Detail.UseVisualStyleBackColor = false;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
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
            // p_RowWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lb_Mean);
            this.Controls.Add(this.lb_Pronounce);
            this.Controls.Add(this.lb_Vocabulary);
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
        private System.Windows.Forms.Label lb_Vocabulary;
        private System.Windows.Forms.Label lb_Pronounce;
        private System.Windows.Forms.Label lb_Mean;
    }
}
