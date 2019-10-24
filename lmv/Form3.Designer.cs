namespace lmv
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashCard = new System.Windows.Forms.RadioButton();
            this.CardCV = new System.Windows.Forms.TextBox();
            this.CardDate = new System.Windows.Forms.TextBox();
            this.CardName = new System.Windows.Forms.TextBox();
            this.CardNum = new System.Windows.Forms.TextBox();
            this.CardCode = new System.Windows.Forms.TextBox();
            this.CardConf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cashCard);
            this.groupBox1.Controls.Add(this.CardCV);
            this.groupBox1.Controls.Add(this.CardDate);
            this.groupBox1.Controls.Add(this.CardName);
            this.groupBox1.Controls.Add(this.CardNum);
            this.groupBox1.Location = new System.Drawing.Point(14, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cashCard
            // 
            this.cashCard.AutoSize = true;
            this.cashCard.Location = new System.Drawing.Point(55, 219);
            this.cashCard.Name = "cashCard";
            this.cashCard.Size = new System.Drawing.Size(110, 21);
            this.cashCard.TabIndex = 4;
            this.cashCard.TabStop = true;
            this.cashCard.Text = "radioButton1";
            this.cashCard.UseVisualStyleBackColor = true;
            this.cashCard.CheckedChanged += new System.EventHandler(this.cashCard_CheckedChanged);
            // 
            // CardCV
            // 
            this.CardCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardCV.Location = new System.Drawing.Point(201, 147);
            this.CardCV.Name = "CardCV";
            this.CardCV.Size = new System.Drawing.Size(153, 38);
            this.CardCV.TabIndex = 3;
            this.CardCV.TextChanged += new System.EventHandler(this.CardCV_TextChanged);
            // 
            // CardDate
            // 
            this.CardDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardDate.Location = new System.Drawing.Point(55, 147);
            this.CardDate.Name = "CardDate";
            this.CardDate.Size = new System.Drawing.Size(140, 38);
            this.CardDate.TabIndex = 2;
            this.CardDate.TextChanged += new System.EventHandler(this.CardDate_TextChanged);
            // 
            // CardName
            // 
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardName.Location = new System.Drawing.Point(52, 87);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(302, 38);
            this.CardName.TabIndex = 1;
            this.CardName.TextChanged += new System.EventHandler(this.CardName_TextChanged);
            // 
            // CardNum
            // 
            this.CardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNum.Location = new System.Drawing.Point(52, 36);
            this.CardNum.Name = "CardNum";
            this.CardNum.Size = new System.Drawing.Size(303, 38);
            this.CardNum.TabIndex = 0;
            this.CardNum.TextChanged += new System.EventHandler(this.CardNum_TextChanged);
            // 
            // CardCode
            // 
            this.CardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardCode.Location = new System.Drawing.Point(110, 490);
            this.CardCode.Name = "CardCode";
            this.CardCode.Size = new System.Drawing.Size(218, 38);
            this.CardCode.TabIndex = 1;
            this.CardCode.TextChanged += new System.EventHandler(this.CardCode_TextChanged);
            // 
            // CardConf
            // 
            this.CardConf.Location = new System.Drawing.Point(77, 398);
            this.CardConf.Name = "CardConf";
            this.CardConf.Size = new System.Drawing.Size(290, 46);
            this.CardConf.TabIndex = 2;
            this.CardConf.Text = "Підтвердити";
            this.CardConf.UseVisualStyleBackColor = true;
            this.CardConf.Click += new System.EventHandler(this.CardConf_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 753);
            this.Controls.Add(this.CardConf);
            this.Controls.Add(this.CardCode);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CardDate;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox CardNum;
        private System.Windows.Forms.RadioButton cashCard;
        private System.Windows.Forms.TextBox CardCV;
        private System.Windows.Forms.TextBox CardCode;
        private System.Windows.Forms.Button CardConf;
    }
}