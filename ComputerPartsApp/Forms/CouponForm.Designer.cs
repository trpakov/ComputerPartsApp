namespace ComputerPartsApp
{
    partial class CouponForm
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
            this.tableLayoutCoupon = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCoupon = new System.Windows.Forms.TextBox();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.tableLayoutCoupon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutCoupon
            // 
            this.tableLayoutCoupon.BackColor = System.Drawing.Color.Cornsilk;
            this.tableLayoutCoupon.ColumnCount = 1;
            this.tableLayoutCoupon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutCoupon.Controls.Add(this.textBoxCoupon, 0, 0);
            this.tableLayoutCoupon.Controls.Add(this.btnCoupon, 0, 1);
            this.tableLayoutCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCoupon.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutCoupon.Name = "tableLayoutCoupon";
            this.tableLayoutCoupon.RowCount = 2;
            this.tableLayoutCoupon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCoupon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCoupon.Size = new System.Drawing.Size(280, 119);
            this.tableLayoutCoupon.TabIndex = 0;
            // 
            // textBoxCoupon
            // 
            this.textBoxCoupon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCoupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoupon.Location = new System.Drawing.Point(29, 16);
            this.textBoxCoupon.Name = "textBoxCoupon";
            this.textBoxCoupon.Size = new System.Drawing.Size(221, 26);
            this.textBoxCoupon.TabIndex = 0;
            // 
            // btnCoupon
            // 
            this.btnCoupon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCoupon.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoupon.Location = new System.Drawing.Point(87, 68);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(105, 41);
            this.btnCoupon.TabIndex = 1;
            this.btnCoupon.Text = "Въведи";
            this.btnCoupon.UseVisualStyleBackColor = true;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoupon_Click);
            // 
            // CouponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 119);
            this.Controls.Add(this.tableLayoutCoupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CouponForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Код за отстъпка";
            this.tableLayoutCoupon.ResumeLayout(false);
            this.tableLayoutCoupon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutCoupon;
        private System.Windows.Forms.TextBox textBoxCoupon;
        private System.Windows.Forms.Button btnCoupon;
    }
}