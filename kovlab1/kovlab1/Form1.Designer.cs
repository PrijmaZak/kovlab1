namespace kovlab1
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
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.cmbTrack = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(325, 135);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(198, 34);
            this.txtDriver.TabIndex = 0;
            this.txtDriver.TextChanged += new System.EventHandler(this.txtDriver_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstResults
            // 
            this.lstResults.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lstResults.FormattingEnabled = true;
            this.lstResults.HorizontalScrollbar = true;
            this.lstResults.ItemHeight = 28;
            this.lstResults.Location = new System.Drawing.Point(61, 84);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(258, 452);
            this.lstResults.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(325, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(405, 48);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Введите имя пилота";
            // 
            // lblDriver
            // 
            this.lblDriver.Location = new System.Drawing.Point(56, 43);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(128, 38);
            this.lblDriver.TabIndex = 4;
            this.lblDriver.Text = "Пилот";
            this.lblDriver.Click += new System.EventHandler(this.lblDriver_Click);
            // 
            // cmbCar
            // 
            this.cmbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Items.AddRange(new object[] {
            "Street",
            "Sport",
            "Prototype"});
            this.cmbCar.Location = new System.Drawing.Point(325, 175);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(198, 36);
            this.cmbCar.TabIndex = 1;
            // 
            // cmbTrack
            // 
            this.cmbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrack.FormattingEnabled = true;
            this.cmbTrack.Items.AddRange(new object[] {
            "Учебный овал ",
            "Городское кольцо ",
            "Спринт "});
            this.cmbTrack.Location = new System.Drawing.Point(325, 217);
            this.cmbTrack.Name = "cmbTrack";
            this.cmbTrack.Size = new System.Drawing.Size(198, 36);
            this.cmbTrack.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(325, 259);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(198, 34);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "Время круга, с ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(325, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 68);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить выбранную";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(325, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 622);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cmbTrack);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDriver);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты заездов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.ComboBox cmbTrack;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

