namespace Market_Desktop_App0
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgReceipts = new DataGridView();
            dgReceiptDetails = new DataGridView();
            RDCount = new DataGridViewTextBoxColumn();
            RDProductName = new DataGridViewTextBoxColumn();
            RDQuantity = new DataGridViewTextBoxColumn();
            RDPrice = new DataGridViewTextBoxColumn();
            RDTotal = new DataGridViewTextBoxColumn();
            dgReceiptPayments = new DataGridView();
            RPCount = new DataGridViewTextBoxColumn();
            RPType = new DataGridViewTextBoxColumn();
            RPAmount = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            ReceiptNumber = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            Remaining = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgReceipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptPayments).BeginInit();
            SuspendLayout();
            // 
            // dgReceipts
            // 
            dgReceipts.AllowUserToAddRows = false;
            dgReceipts.AllowUserToDeleteRows = false;
            dgReceipts.AllowUserToResizeRows = false;
            dgReceipts.BackgroundColor = SystemColors.AppWorkspace;
            dgReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceipts.Columns.AddRange(new DataGridViewColumn[] { Count, ReceiptNumber, Date, Total, Payment, Remaining });
            dgReceipts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgReceipts.Location = new Point(22, 12);
            dgReceipts.Name = "dgReceipts";
            dgReceipts.RowHeadersVisible = false;
            dgReceipts.RowHeadersWidth = 51;
            dgReceipts.RowTemplate.Height = 29;
            dgReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReceipts.Size = new Size(1103, 344);
            dgReceipts.TabIndex = 0;
            dgReceipts.Click += dgReceipts_Click;
            // 
            // dgReceiptDetails
            // 
            dgReceiptDetails.AllowUserToAddRows = false;
            dgReceiptDetails.BackgroundColor = SystemColors.AppWorkspace;
            dgReceiptDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptDetails.Columns.AddRange(new DataGridViewColumn[] { RDCount, RDProductName, RDQuantity, RDPrice, RDTotal });
            dgReceiptDetails.Location = new Point(22, 379);
            dgReceiptDetails.Name = "dgReceiptDetails";
            dgReceiptDetails.RowHeadersVisible = false;
            dgReceiptDetails.RowHeadersWidth = 51;
            dgReceiptDetails.RowTemplate.Height = 29;
            dgReceiptDetails.Size = new Size(633, 321);
            dgReceiptDetails.TabIndex = 1;
            // 
            // RDCount
            // 
            RDCount.HeaderText = "#";
            RDCount.MinimumWidth = 6;
            RDCount.Name = "RDCount";
            RDCount.Width = 50;
            // 
            // RDProductName
            // 
            RDProductName.FillWeight = 347.445251F;
            RDProductName.HeaderText = "Product Name";
            RDProductName.MinimumWidth = 6;
            RDProductName.Name = "RDProductName";
            RDProductName.Width = 250;
            // 
            // RDQuantity
            // 
            RDQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RDQuantity.FillWeight = 17.51825F;
            RDQuantity.HeaderText = "Quantity";
            RDQuantity.MinimumWidth = 6;
            RDQuantity.Name = "RDQuantity";
            // 
            // RDPrice
            // 
            RDPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            RDPrice.DefaultCellStyle = dataGridViewCellStyle5;
            RDPrice.FillWeight = 17.51825F;
            RDPrice.HeaderText = "Price";
            RDPrice.MinimumWidth = 6;
            RDPrice.Name = "RDPrice";
            // 
            // RDTotal
            // 
            RDTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            RDTotal.DefaultCellStyle = dataGridViewCellStyle6;
            RDTotal.FillWeight = 17.51825F;
            RDTotal.HeaderText = "Total";
            RDTotal.MinimumWidth = 6;
            RDTotal.Name = "RDTotal";
            // 
            // dgReceiptPayments
            // 
            dgReceiptPayments.AllowUserToAddRows = false;
            dgReceiptPayments.BackgroundColor = SystemColors.AppWorkspace;
            dgReceiptPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptPayments.Columns.AddRange(new DataGridViewColumn[] { RPCount, RPType, RPAmount });
            dgReceiptPayments.Location = new Point(686, 379);
            dgReceiptPayments.Name = "dgReceiptPayments";
            dgReceiptPayments.RowHeadersVisible = false;
            dgReceiptPayments.RowHeadersWidth = 51;
            dgReceiptPayments.RowTemplate.Height = 29;
            dgReceiptPayments.Size = new Size(439, 321);
            dgReceiptPayments.TabIndex = 2;
            // 
            // RPCount
            // 
            RPCount.HeaderText = "#";
            RPCount.MinimumWidth = 6;
            RPCount.Name = "RPCount";
            RPCount.Width = 50;
            // 
            // RPType
            // 
            RPType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RPType.HeaderText = "Type";
            RPType.MinimumWidth = 6;
            RPType.Name = "RPType";
            // 
            // RPAmount
            // 
            RPAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            RPAmount.DefaultCellStyle = dataGridViewCellStyle7;
            RPAmount.HeaderText = "Amount";
            RPAmount.MinimumWidth = 6;
            RPAmount.Name = "RPAmount";
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 50;
            // 
            // ReceiptNumber
            // 
            ReceiptNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ReceiptNumber.HeaderText = "ReceiptNumber";
            ReceiptNumber.MinimumWidth = 6;
            ReceiptNumber.Name = "ReceiptNumber";
            ReceiptNumber.Width = 450;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Date.DefaultCellStyle = dataGridViewCellStyle1;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 200;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle2;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // Payment
            // 
            Payment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Payment.DefaultCellStyle = dataGridViewCellStyle3;
            Payment.HeaderText = "Payment";
            Payment.MinimumWidth = 6;
            Payment.Name = "Payment";
            // 
            // Remaining
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            Remaining.DefaultCellStyle = dataGridViewCellStyle4;
            Remaining.HeaderText = "Remaining";
            Remaining.MinimumWidth = 6;
            Remaining.Name = "Remaining";
            Remaining.Width = 125;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1156, 712);
            Controls.Add(dgReceiptPayments);
            Controls.Add(dgReceiptDetails);
            Controls.Add(dgReceipts);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgReceipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgReceipts;
        private DataGridView dgReceiptDetails;
        private DataGridView dgReceiptPayments;
        private DataGridViewTextBoxColumn RPCount;
        private DataGridViewTextBoxColumn RPType;
        private DataGridViewTextBoxColumn RPAmount;
        private DataGridViewTextBoxColumn Remaining;
        private DataGridViewTextBoxColumn RDCount;
        private DataGridViewTextBoxColumn RDProductName;
        private DataGridViewTextBoxColumn RDQuantity;
        private DataGridViewTextBoxColumn RDPrice;
        private DataGridViewTextBoxColumn RDTotal;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn ReceiptNumber;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Payment;
    }
}