namespace lmv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.confirm = new System.Windows.Forms.Button();
            this.timR = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.PictureBox();
            this.addOrd = new System.Windows.Forms.Button();
            this.FAdrss = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAdrss = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.Label();
            this.timeBefore = new System.Windows.Forms.Label();
            this.PlugCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAdrss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAdrss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(25, 24);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(175, 41);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "ПІДТВЕРДИТИ";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // timR
            // 
            this.timR.AutoSize = true;
            this.timR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.timR.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timR.Location = new System.Drawing.Point(195, 25);
            this.timR.Name = "timR";
            this.timR.Padding = new System.Windows.Forms.Padding(1);
            this.timR.Size = new System.Drawing.Size(100, 40);
            this.timR.TabIndex = 1;
            this.timR.Text = "00:00";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(320, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(90, 41);
            this.close.TabIndex = 2;
            this.close.Text = "close(img)";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // map
            // 
            this.map.ErrorImage = ((System.Drawing.Image)(resources.GetObject("map.ErrorImage")));
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.InitialImage = ((System.Drawing.Image)(resources.GetObject("map.InitialImage")));
            this.map.Location = new System.Drawing.Point(25, 67);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(385, 400);
            this.map.TabIndex = 3;
            this.map.TabStop = false;
            // 
            // addOrd
            // 
            this.addOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrd.Location = new System.Drawing.Point(336, 379);
            this.addOrd.Name = "addOrd";
            this.addOrd.Size = new System.Drawing.Size(64, 56);
            this.addOrd.TabIndex = 4;
            this.addOrd.Text = "+";
            this.addOrd.UseVisualStyleBackColor = true;
            // 
            // FAdrss
            // 
            this.FAdrss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FAdrss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FAdrss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.FAdrss.Location = new System.Drawing.Point(25, 464);
            this.FAdrss.Name = "FAdrss";
            this.FAdrss.RowTemplate.Height = 24;
            this.FAdrss.Size = new System.Drawing.Size(297, 51);
            this.FAdrss.TabIndex = 5;
            this.FAdrss.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FAdrss_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "початкова адреса";
            this.Column1.Name = "Column1";
            // 
            // LAdrss
            // 
            this.LAdrss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LAdrss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LAdrss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.LAdrss.Location = new System.Drawing.Point(25, 515);
            this.LAdrss.Name = "LAdrss";
            this.LAdrss.RowTemplate.Height = 24;
            this.LAdrss.Size = new System.Drawing.Size(297, 52);
            this.LAdrss.TabIndex = 6;
            this.LAdrss.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LAdrss_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "кінцева адреса";
            this.Column2.Name = "Column2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 465);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 102);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2019, 10, 18, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(25, 566);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(385, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(25, 598);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 51);
            this.price.TabIndex = 9;
            this.price.Text = "0 грн";
            this.price.UseMnemonic = false;
            // 
            // timeBefore
            // 
            this.timeBefore.AutoSize = true;
            this.timeBefore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timeBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeBefore.Location = new System.Drawing.Point(155, 610);
            this.timeBefore.Name = "timeBefore";
            this.timeBefore.Size = new System.Drawing.Size(255, 36);
            this.timeBefore.TabIndex = 10;
            this.timeBefore.Text = "до приїзду 00:00";
            this.timeBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlugCard
            // 
            this.PlugCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlugCard.Location = new System.Drawing.Point(25, 663);
            this.PlugCard.Name = "PlugCard";
            this.PlugCard.Size = new System.Drawing.Size(385, 63);
            this.PlugCard.TabIndex = 11;
            this.PlugCard.Text = "ПІДКЛЮЧЕННЯ КАРТИ";
            this.PlugCard.UseVisualStyleBackColor = true;
            this.PlugCard.Click += new System.EventHandler(this.PlugCard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 753);
            this.Controls.Add(this.PlugCard);
            this.Controls.Add(this.timeBefore);
            this.Controls.Add(this.price);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LAdrss);
            this.Controls.Add(this.FAdrss);
            this.Controls.Add(this.addOrd);
            this.Controls.Add(this.map);
            this.Controls.Add(this.close);
            this.Controls.Add(this.timR);
            this.Controls.Add(this.confirm);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAdrss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAdrss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label timR;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Button addOrd;
        private System.Windows.Forms.DataGridView FAdrss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView LAdrss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label timeBefore;
        private System.Windows.Forms.Button PlugCard;
    }
}