namespace StockTrade_Profit_Calculator
{
    partial class Form1
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
            this.TextBoxBuyPrice = new System.Windows.Forms.TextBox();
            this.LabelBuyPrice = new System.Windows.Forms.Label();
            this.LabelSellPrice = new System.Windows.Forms.Label();
            this.TextBoxSellPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelAmountOfShares = new System.Windows.Forms.Label();
            this.TextBoxAmountOfShares = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelDifferenceInPrice = new System.Windows.Forms.Label();
            this.LabelProfit = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.LabelCommissions = new System.Windows.Forms.Label();
            this.LabelUseCommaNotDot = new System.Windows.Forms.Label();
            this.LabelDifferenceInPriceValue = new System.Windows.Forms.Label();
            this.LabelProfitValue = new System.Windows.Forms.Label();
            this.Label20Profit = new System.Windows.Forms.Label();
            this.Label8Loss = new System.Windows.Forms.Label();
            this.Label20Value = new System.Windows.Forms.Label();
            this.Label8Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxBuyPrice
            // 
            this.TextBoxBuyPrice.Location = new System.Drawing.Point(143, 3);
            this.TextBoxBuyPrice.Name = "TextBoxBuyPrice";
            this.TextBoxBuyPrice.Size = new System.Drawing.Size(100, 22);
            this.TextBoxBuyPrice.TabIndex = 0;
            this.TextBoxBuyPrice.TextChanged += new System.EventHandler(this.TextBoxBuyPrice_TextChanged);
            // 
            // LabelBuyPrice
            // 
            this.LabelBuyPrice.AutoSize = true;
            this.LabelBuyPrice.Location = new System.Drawing.Point(3, 0);
            this.LabelBuyPrice.Name = "LabelBuyPrice";
            this.LabelBuyPrice.Size = new System.Drawing.Size(67, 16);
            this.LabelBuyPrice.TabIndex = 20;
            this.LabelBuyPrice.Text = "Buy Price:";
            // 
            // LabelSellPrice
            // 
            this.LabelSellPrice.AutoSize = true;
            this.LabelSellPrice.Location = new System.Drawing.Point(3, 50);
            this.LabelSellPrice.Name = "LabelSellPrice";
            this.LabelSellPrice.Size = new System.Drawing.Size(67, 16);
            this.LabelSellPrice.TabIndex = 20;
            this.LabelSellPrice.Text = "Sell Price:";
            // 
            // TextBoxSellPrice
            // 
            this.TextBoxSellPrice.Location = new System.Drawing.Point(143, 53);
            this.TextBoxSellPrice.Name = "TextBoxSellPrice";
            this.TextBoxSellPrice.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSellPrice.TabIndex = 1;
            this.TextBoxSellPrice.TextChanged += new System.EventHandler(this.TextBoxSellPrice_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.LabelBuyPrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelSellPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxSellPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxBuyPrice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelAmountOfShares, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAmountOfShares, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 149);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // LabelAmountOfShares
            // 
            this.LabelAmountOfShares.AutoSize = true;
            this.LabelAmountOfShares.Location = new System.Drawing.Point(3, 100);
            this.LabelAmountOfShares.Name = "LabelAmountOfShares";
            this.LabelAmountOfShares.Size = new System.Drawing.Size(117, 16);
            this.LabelAmountOfShares.TabIndex = 20;
            this.LabelAmountOfShares.Text = "Amount Of Shares:";
            // 
            // TextBoxAmountOfShares
            // 
            this.TextBoxAmountOfShares.Location = new System.Drawing.Point(143, 103);
            this.TextBoxAmountOfShares.Name = "TextBoxAmountOfShares";
            this.TextBoxAmountOfShares.Size = new System.Drawing.Size(100, 22);
            this.TextBoxAmountOfShares.TabIndex = 2;
            this.TextBoxAmountOfShares.TextChanged += new System.EventHandler(this.TextBoxAmountOfShares_TextChanged);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(415, 103);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(102, 23);
            this.ButtonCalculate.TabIndex = 3;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelDifferenceInPrice
            // 
            this.LabelDifferenceInPrice.AutoSize = true;
            this.LabelDifferenceInPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDifferenceInPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDifferenceInPrice.Location = new System.Drawing.Point(20, 270);
            this.LabelDifferenceInPrice.Name = "LabelDifferenceInPrice";
            this.LabelDifferenceInPrice.Size = new System.Drawing.Size(119, 18);
            this.LabelDifferenceInPrice.TabIndex = 20;
            this.LabelDifferenceInPrice.Text = "Difference in price:";
            // 
            // LabelProfit
            // 
            this.LabelProfit.AutoSize = true;
            this.LabelProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProfit.Location = new System.Drawing.Point(20, 315);
            this.LabelProfit.Name = "LabelProfit";
            this.LabelProfit.Size = new System.Drawing.Size(42, 18);
            this.LabelProfit.TabIndex = 20;
            this.LabelProfit.Text = "Profit:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(415, 153);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(102, 23);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LabelCommissions
            // 
            this.LabelCommissions.AutoSize = true;
            this.LabelCommissions.Location = new System.Drawing.Point(18, 13);
            this.LabelCommissions.Name = "LabelCommissions";
            this.LabelCommissions.Size = new System.Drawing.Size(286, 16);
            this.LabelCommissions.TabIndex = 21;
            this.LabelCommissions.Text = "Commissions are not included in this calculator.";
            // 
            // LabelUseCommaNotDot
            // 
            this.LabelUseCommaNotDot.AutoSize = true;
            this.LabelUseCommaNotDot.Location = new System.Drawing.Point(18, 43);
            this.LabelUseCommaNotDot.Name = "LabelUseCommaNotDot";
            this.LabelUseCommaNotDot.Size = new System.Drawing.Size(225, 16);
            this.LabelUseCommaNotDot.TabIndex = 22;
            this.LabelUseCommaNotDot.Text = "Use [Comma] for decimals. Not [Dot]";
            // 
            // LabelDifferenceInPriceValue
            // 
            this.LabelDifferenceInPriceValue.AutoSize = true;
            this.LabelDifferenceInPriceValue.Location = new System.Drawing.Point(157, 270);
            this.LabelDifferenceInPriceValue.Name = "LabelDifferenceInPriceValue";
            this.LabelDifferenceInPriceValue.Size = new System.Drawing.Size(0, 16);
            this.LabelDifferenceInPriceValue.TabIndex = 23;
            // 
            // LabelProfitValue
            // 
            this.LabelProfitValue.AutoSize = true;
            this.LabelProfitValue.Location = new System.Drawing.Point(157, 318);
            this.LabelProfitValue.Name = "LabelProfitValue";
            this.LabelProfitValue.Size = new System.Drawing.Size(0, 16);
            this.LabelProfitValue.TabIndex = 24;
            // 
            // Label20Profit
            // 
            this.Label20Profit.AutoSize = true;
            this.Label20Profit.BackColor = System.Drawing.SystemColors.Control;
            this.Label20Profit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label20Profit.ForeColor = System.Drawing.Color.Black;
            this.Label20Profit.Location = new System.Drawing.Point(340, 270);
            this.Label20Profit.Name = "Label20Profit";
            this.Label20Profit.Size = new System.Drawing.Size(71, 18);
            this.Label20Profit.TabIndex = 25;
            this.Label20Profit.Text = "20% Profit:";
            // 
            // Label8Loss
            // 
            this.Label8Loss.AutoSize = true;
            this.Label8Loss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8Loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8Loss.ForeColor = System.Drawing.Color.Black;
            this.Label8Loss.Location = new System.Drawing.Point(340, 315);
            this.Label8Loss.Name = "Label8Loss";
            this.Label8Loss.Size = new System.Drawing.Size(63, 18);
            this.Label8Loss.TabIndex = 26;
            this.Label8Loss.Text = "8% Loss:";
            // 
            // Label20Value
            // 
            this.Label20Value.AutoSize = true;
            this.Label20Value.Location = new System.Drawing.Point(429, 270);
            this.Label20Value.Name = "Label20Value";
            this.Label20Value.Size = new System.Drawing.Size(0, 16);
            this.Label20Value.TabIndex = 27;
            // 
            // Label8Value
            // 
            this.Label8Value.AutoSize = true;
            this.Label8Value.Location = new System.Drawing.Point(429, 315);
            this.Label8Value.Name = "Label8Value";
            this.Label8Value.Size = new System.Drawing.Size(0, 16);
            this.Label8Value.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(541, 384);
            this.Controls.Add(this.Label8Value);
            this.Controls.Add(this.Label20Value);
            this.Controls.Add(this.Label8Loss);
            this.Controls.Add(this.Label20Profit);
            this.Controls.Add(this.LabelProfitValue);
            this.Controls.Add(this.LabelDifferenceInPriceValue);
            this.Controls.Add(this.LabelUseCommaNotDot);
            this.Controls.Add(this.LabelCommissions);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.LabelProfit);
            this.Controls.Add(this.LabelDifferenceInPrice);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "StockTrade Profit Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxBuyPrice;
        private System.Windows.Forms.Label LabelBuyPrice;
        private System.Windows.Forms.Label LabelSellPrice;
        private System.Windows.Forms.TextBox TextBoxSellPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelAmountOfShares;
        private System.Windows.Forms.TextBox TextBoxAmountOfShares;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label LabelDifferenceInPrice;
        private System.Windows.Forms.Label LabelProfit;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label LabelCommissions;
        private System.Windows.Forms.Label LabelUseCommaNotDot;
        private System.Windows.Forms.Label LabelDifferenceInPriceValue;
        private System.Windows.Forms.Label LabelProfitValue;
        private System.Windows.Forms.Label Label20Profit;
        private System.Windows.Forms.Label Label8Loss;
        private System.Windows.Forms.Label Label20Value;
        private System.Windows.Forms.Label Label8Value;
    }
}

