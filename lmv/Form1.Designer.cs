namespace lmv
{
    partial class Form1
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
            this.login = new System.Windows.Forms.TextBox();
            this.pswrd = new System.Windows.Forms.TextBox();
            this.regcode = new System.Windows.Forms.TextBox();
            this.EngLang = new System.Windows.Forms.RadioButton();
            this.YkrLang = new System.Windows.Forms.RadioButton();
            this.eMail = new System.Windows.Forms.Label();
            this.PWord = new System.Windows.Forms.Label();
            this.MailCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(53, 262);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(315, 34);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // pswrd
            // 
            this.pswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswrd.Location = new System.Drawing.Point(53, 335);
            this.pswrd.Name = "pswrd";
            this.pswrd.Size = new System.Drawing.Size(315, 34);
            this.pswrd.TabIndex = 1;
            this.pswrd.TextChanged += new System.EventHandler(this.pswrd_TextChanged);
            // 
            // regcode
            // 
            this.regcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regcode.Location = new System.Drawing.Point(92, 410);
            this.regcode.Name = "regcode";
            this.regcode.Size = new System.Drawing.Size(218, 34);
            this.regcode.TabIndex = 2;
            this.regcode.TextChanged += new System.EventHandler(this.regcode_TextChanged);
            // 
            // EngLang
            // 
            this.EngLang.Appearance = System.Windows.Forms.Appearance.Button;
            this.EngLang.AutoSize = true;
            this.EngLang.Location = new System.Drawing.Point(278, 27);
            this.EngLang.Name = "EngLang";
            this.EngLang.Size = new System.Drawing.Size(43, 27);
            this.EngLang.TabIndex = 3;
            this.EngLang.TabStop = true;
            this.EngLang.Text = "Eng";
            this.EngLang.UseVisualStyleBackColor = true;
            this.EngLang.CheckedChanged += new System.EventHandler(this.EngLang_CheckedChanged);
            // 
            // YkrLang
            // 
            this.YkrLang.Appearance = System.Windows.Forms.Appearance.Button;
            this.YkrLang.AutoSize = true;
            this.YkrLang.Location = new System.Drawing.Point(317, 27);
            this.YkrLang.Name = "YkrLang";
            this.YkrLang.Size = new System.Drawing.Size(42, 27);
            this.YkrLang.TabIndex = 4;
            this.YkrLang.TabStop = true;
            this.YkrLang.Text = "Укр";
            this.YkrLang.UseVisualStyleBackColor = true;
            this.YkrLang.CheckedChanged += new System.EventHandler(this.YkrLang_CheckedChanged);
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Location = new System.Drawing.Point(55, 242);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(93, 17);
            this.eMail.TabIndex = 5;
            this.eMail.Text = "e-mail adress";
            // 
            // PWord
            // 
            this.PWord.AutoSize = true;
            this.PWord.Location = new System.Drawing.Point(55, 315);
            this.PWord.Name = "PWord";
            this.PWord.Size = new System.Drawing.Size(68, 17);
            this.PWord.TabIndex = 6;
            this.PWord.Text = "password";
            // 
            // MailCode
            // 
            this.MailCode.AutoSize = true;
            this.MailCode.Location = new System.Drawing.Point(92, 392);
            this.MailCode.Name = "MailCode";
            this.MailCode.Size = new System.Drawing.Size(39, 17);
            this.MailCode.TabIndex = 7;
            this.MailCode.Text = "code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 753);
            this.Controls.Add(this.MailCode);
            this.Controls.Add(this.PWord);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.YkrLang);
            this.Controls.Add(this.EngLang);
            this.Controls.Add(this.regcode);
            this.Controls.Add(this.pswrd);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pswrd;
        private System.Windows.Forms.TextBox regcode;
        private System.Windows.Forms.RadioButton EngLang;
        private System.Windows.Forms.RadioButton YkrLang;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.Label PWord;
        private System.Windows.Forms.Label MailCode;
    }
}

