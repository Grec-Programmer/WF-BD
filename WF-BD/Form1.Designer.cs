namespace WF_BD
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите нужное меню";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить учётную запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFillOrCancel
            // 
            this.btnFillOrCancel.Location = new System.Drawing.Point(38, 96);
            this.btnFillOrCancel.Name = "btnFillOrCancel";
            this.btnFillOrCancel.Size = new System.Drawing.Size(187, 23);
            this.btnFillOrCancel.TabIndex = 2;
            this.btnFillOrCancel.Text = "Заполнить или отменить заказ";
            this.btnFillOrCancel.UseVisualStyleBackColor = true;
            this.btnFillOrCancel.Click += new System.EventHandler(this.btnFillOrCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 178);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFillOrCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Навигация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFillOrCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

