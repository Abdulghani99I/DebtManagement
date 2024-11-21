namespace DebtManagement.Supplier
{
    partial class AddPayment
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
            labTitle = new System.Windows.Forms.Label();
            txtCalcTotalAmount = new DevExpress.XtraEditors.CalcEdit();
            panelBottomBorder = new System.Windows.Forms.Panel();
            btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)txtCalcTotalAmount.Properties).BeginInit();
            SuspendLayout();
            // 
            // labTitle
            // 
            labTitle.AutoSize = true;
            labTitle.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labTitle.ForeColor = System.Drawing.Color.Black;
            labTitle.Location = new System.Drawing.Point(138, 29);
            labTitle.Name = "labTitle";
            labTitle.Size = new System.Drawing.Size(190, 36);
            labTitle.TabIndex = 1;
            labTitle.Text = "ادخل المبلغ المدفوع:";
            // 
            // txtCalcTotalAmount
            // 
            txtCalcTotalAmount.Location = new System.Drawing.Point(60, 80);
            txtCalcTotalAmount.Name = "txtCalcTotalAmount";
            txtCalcTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtCalcTotalAmount.Properties.Appearance.Options.UseFont = true;
            txtCalcTotalAmount.Properties.Appearance.Options.UseTextOptions = true;
            txtCalcTotalAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtCalcTotalAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtCalcTotalAmount.Properties.MaxLength = 12;
            txtCalcTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCalcTotalAmount.Size = new System.Drawing.Size(350, 42);
            txtCalcTotalAmount.TabIndex = 2;
            txtCalcTotalAmount.Enter += txtCalcTotalAmount_Enter;
            txtCalcTotalAmount.KeyPress += txtCalcTotalAmount_KeyPress;
            txtCalcTotalAmount.Leave += txtCalcTotalAmount_Leave;
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(60, 119);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(350, 3);
            panelBottomBorder.TabIndex = 5;
            panelBottomBorder.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.BackColor = System.Drawing.Color.White;
            btnAdd.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.Black;
            btnAdd.Image = Properties.Resources.saveto_32x32;
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.Location = new System.Drawing.Point(156, 172);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(159, 51);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddPayment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 243);
            Controls.Add(btnAdd);
            Controls.Add(panelBottomBorder);
            Controls.Add(txtCalcTotalAmount);
            Controls.Add(labTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPayment";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ادخال القيمة";
            Load += AddPayment_Load;
            ((System.ComponentModel.ISupportInitialize)txtCalcTotalAmount.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private DevExpress.XtraEditors.CalcEdit txtCalcTotalAmount;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Button btnAdd;
    }
}