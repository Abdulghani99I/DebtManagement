namespace DebtManagement.ClientForms
{
    partial class frmAddUpdateDebtMenu
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
            label1 = new System.Windows.Forms.Label();
            txtMenuName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panelBottomBorder = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            btnAddAndClose = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtCalcTotalAmount = new DevExpress.XtraEditors.CalcEdit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCalcTotalAmount.Properties).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(160, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم القائمة";
            // 
            // txtMenuName
            // 
            txtMenuName.Font = new System.Drawing.Font("Cairo", 14F);
            txtMenuName.ForeColor = System.Drawing.Color.Black;
            txtMenuName.Location = new System.Drawing.Point(46, 47);
            txtMenuName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            txtMenuName.MaxLength = 140;
            txtMenuName.Multiline = true;
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new System.Drawing.Size(350, 174);
            txtMenuName.TabIndex = 0;
            txtMenuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(160, 268);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 37);
            label2.TabIndex = 2;
            label2.Text = "السعر الكلي";
            // 
            // panelBottomBorder
            // 
            panelBottomBorder.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            panelBottomBorder.Location = new System.Drawing.Point(46, 350);
            panelBottomBorder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panelBottomBorder.Name = "panelBottomBorder";
            panelBottomBorder.Size = new System.Drawing.Size(350, 3);
            panelBottomBorder.TabIndex = 4;
            panelBottomBorder.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(btnAddAndClose);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 420);
            panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(443, 77);
            panel2.TabIndex = 5;
            // 
            // btnAddAndClose
            // 
            btnAddAndClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAddAndClose.BackColor = System.Drawing.Color.White;
            btnAddAndClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddAndClose.ForeColor = System.Drawing.Color.Black;
            btnAddAndClose.Image = Properties.Resources.saveandclose_32x32;
            btnAddAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddAndClose.Location = new System.Drawing.Point(9, 14);
            btnAddAndClose.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAddAndClose.Name = "btnAddAndClose";
            btnAddAndClose.Size = new System.Drawing.Size(159, 51);
            btnAddAndClose.TabIndex = 2;
            btnAddAndClose.Text = "اضافة + غلق       ";
            btnAddAndClose.UseVisualStyleBackColor = false;
            btnAddAndClose.Click += btnAddAndClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.BackColor = System.Drawing.Color.White;
            btnAdd.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.Black;
            btnAdd.Image = Properties.Resources.saveto_32x32;
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAdd.Location = new System.Drawing.Point(278, 14);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(159, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCalcTotalAmount
            // 
            txtCalcTotalAmount.Location = new System.Drawing.Point(46, 308);
            txtCalcTotalAmount.Name = "txtCalcTotalAmount";
            txtCalcTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            txtCalcTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtCalcTotalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            txtCalcTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            txtCalcTotalAmount.Properties.Appearance.Options.UseFont = true;
            txtCalcTotalAmount.Properties.Appearance.Options.UseForeColor = true;
            txtCalcTotalAmount.Properties.Appearance.Options.UseTextOptions = true;
            txtCalcTotalAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtCalcTotalAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtCalcTotalAmount.Properties.MaxLength = 12;
            txtCalcTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtCalcTotalAmount.Size = new System.Drawing.Size(350, 42);
            txtCalcTotalAmount.TabIndex = 1;
            txtCalcTotalAmount.Enter += txtTcalc_Enter;
            txtCalcTotalAmount.KeyPress += txtCalcTotalAmount_KeyPress;
            txtCalcTotalAmount.Leave += txtTcalc_Leave;
            // 
            // frmAddUpdateDebtMenu
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            Appearance.ForeColor = System.Drawing.Color.Black;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(443, 497);
            Controls.Add(txtCalcTotalAmount);
            Controls.Add(panel2);
            Controls.Add(panelBottomBorder);
            Controls.Add(label2);
            Controls.Add(txtMenuName);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateDebtMenu";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "عملية شراء";
            Load += frmAddUpdateDebtMenu_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCalcTotalAmount.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottomBorder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraEditors.CalcEdit txtCalcTotalAmount;
        private System.Windows.Forms.Button btnAddAndClose;
    }
}