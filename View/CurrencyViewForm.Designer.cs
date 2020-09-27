namespace Currency_MVC
{
    partial class CurrencyView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.usdLabel = new System.Windows.Forms.Label();
            this.usdValueLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usdLabel
            // 
            this.usdLabel.AutoSize = true;
            this.usdLabel.Location = new System.Drawing.Point(8, 26);
            this.usdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usdLabel.Name = "usdLabel";
            this.usdLabel.Size = new System.Drawing.Size(50, 22);
            this.usdLabel.TabIndex = 0;
            this.usdLabel.Text = "USD:";
            // 
            // usdValueLabel
            // 
            this.usdValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usdValueLabel.AutoSize = true;
            this.usdValueLabel.Location = new System.Drawing.Point(75, 26);
            this.usdValueLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usdValueLabel.Name = "usdValueLabel";
            this.usdValueLabel.Size = new System.Drawing.Size(0, 22);
            this.usdValueLabel.TabIndex = 1;
            this.usdValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(50, 36);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = ">";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Location = new System.Drawing.Point(122, 12);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(50, 36);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "||";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.usdValueLabel);
            this.groupBox1.Controls.Add(this.usdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency";
            // 
            // CurrencyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 131);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 170);
            this.Name = "CurrencyView";
            this.ShowIcon = false;
            this.Text = "Exchange";
            this.Shown += new System.EventHandler(this.CurrencyView_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usdLabel;
        private System.Windows.Forms.Label usdValueLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

