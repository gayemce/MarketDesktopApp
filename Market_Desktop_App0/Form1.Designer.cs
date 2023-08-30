namespace Market_Desktop_App0
{
    partial class Form1
    {/// <summary>
     ///  Required designer variable.
     /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox5 = new GroupBox();
            btnComplete = new Button();
            btnReset = new Button();
            lblRemaing = new Label();
            gbPayment = new GroupBox();
            btnCash = new Button();
            btnCreditCard = new Button();
            txtPayment = new TextBox();
            groupBox3 = new GroupBox();
            lblTotal = new Label();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtBarcode = new TextBox();
            groupBox6 = new GroupBox();
            dgPayment = new DataGridView();
            type = new DataGridViewTextBoxColumn();
            Totall = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            raporlToolStripMenuItem = new ToolStripMenuItem();
            receiptsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            groupBox5.SuspendLayout();
            gbPayment.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnComplete);
            groupBox5.Controls.Add(btnReset);
            groupBox5.Controls.Add(lblRemaing);
            groupBox5.Location = new Point(660, 496);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(484, 189);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = " ";
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Times New Roman", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.Image = (Image)resources.GetObject("btnComplete.Image");
            btnComplete.ImageAlign = ContentAlignment.MiddleLeft;
            btnComplete.Location = new Point(242, 102);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(238, 79);
            btnComplete.TabIndex = 4;
            btnComplete.Text = "     Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Brown;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(5, 102);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(236, 79);
            btnReset.TabIndex = 3;
            btnReset.Text = "  Clear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblRemaing
            // 
            lblRemaing.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemaing.ForeColor = Color.Black;
            lblRemaing.Location = new Point(15, 28);
            lblRemaing.Name = "lblRemaing";
            lblRemaing.Size = new Size(442, 70);
            lblRemaing.TabIndex = 1;
            lblRemaing.Text = "0,00 ₺";
            lblRemaing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(btnCash);
            gbPayment.Controls.Add(btnCreditCard);
            gbPayment.Controls.Add(txtPayment);
            gbPayment.Location = new Point(660, 164);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(484, 178);
            gbPayment.TabIndex = 8;
            gbPayment.TabStop = false;
            gbPayment.Text = " ";
            // 
            // btnCash
            // 
            btnCash.Font = new Font("Times New Roman", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.Image = (Image)resources.GetObject("btnCash.Image");
            btnCash.ImageAlign = ContentAlignment.TopLeft;
            btnCash.Location = new Point(242, 91);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(236, 79);
            btnCash.TabIndex = 2;
            btnCash.Text = "Cash";
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // btnCreditCard
            // 
            btnCreditCard.Font = new Font("Times New Roman", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreditCard.Image = (Image)resources.GetObject("btnCreditCard.Image");
            btnCreditCard.ImageAlign = ContentAlignment.TopLeft;
            btnCreditCard.Location = new Point(5, 91);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Size = new Size(236, 79);
            btnCreditCard.TabIndex = 1;
            btnCreditCard.Text = "       Credit Card";
            btnCreditCard.UseVisualStyleBackColor = true;
            btnCreditCard.Click += btnCreditCard_Click;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayment.ForeColor = Color.Teal;
            txtPayment.Location = new Point(5, 22);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(473, 62);
            txtPayment.TabIndex = 0;
            txtPayment.Text = "0";
            txtPayment.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Location = new Point(673, 43);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(471, 115);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(6, 28);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(459, 65);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "0,00 ₺";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(15, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(639, 524);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = SystemColors.ButtonFace;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Count, ProductName, Quantity, Price, TotalPrice });
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(3, 30);
            dgList.Name = "dgList";
            dgList.RowHeadersVisible = false;
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.Size = new Size(633, 491);
            dgList.TabIndex = 0;
            // 
            // Count
            // 
            Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Count.HeaderText = "#";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 230;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 115;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 115;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 140;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(15, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 115);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(5, 28);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(627, 76);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgPayment);
            groupBox6.Location = new Point(660, 340);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(484, 163);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = SystemColors.ButtonFace;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { type, Totall });
            dgPayment.Location = new Point(7, 29);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowHeadersWidth = 51;
            dgPayment.RowTemplate.Height = 29;
            dgPayment.Size = new Size(459, 123);
            dgPayment.TabIndex = 1;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            type.HeaderText = "Type";
            type.MinimumWidth = 6;
            type.Name = "type";
            // 
            // Totall
            // 
            Totall.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Totall.HeaderText = "Total";
            Totall.MinimumWidth = 6;
            Totall.Name = "Totall";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { raporlToolStripMenuItem, productsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1156, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // raporlToolStripMenuItem
            // 
            raporlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { receiptsToolStripMenuItem });
            raporlToolStripMenuItem.Name = "raporlToolStripMenuItem";
            raporlToolStripMenuItem.Size = new Size(74, 24);
            raporlToolStripMenuItem.Text = "Reports";
            // 
            // receiptsToolStripMenuItem
            // 
            receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            receiptsToolStripMenuItem.Size = new Size(224, 26);
            receiptsToolStripMenuItem.Text = "Receipts";
            receiptsToolStripMenuItem.Click += receiptsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(224, 26);
            addProductToolStripMenuItem.Text = "Add Product";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1156, 699);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(gbPayment);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox5.ResumeLayout(false);
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private GroupBox gbPayment;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dgList;
        private GroupBox groupBox1;
        private TextBox txtBarcode;
        private Label lblTotal;
        private TextBox txtPayment;
        private Button btnComplete;
        private Label lblRemaing;
        private Button btnReset;
        private Button btnCash;
        private Button btnCreditCard;
        private GroupBox groupBox6;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn Totall;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem raporlToolStripMenuItem;
        private ToolStripMenuItem receiptsToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}