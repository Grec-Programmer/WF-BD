namespace WF_BD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnFindByOrderId = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор заказа";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(144, 17);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(113, 20);
            this.txtOrderId.TabIndex = 1;
            // 
            // btnFindByOrderId
            // 
            this.btnFindByOrderId.Location = new System.Drawing.Point(279, 17);
            this.btnFindByOrderId.Name = "btnFindByOrderId";
            this.btnFindByOrderId.Size = new System.Drawing.Size(98, 23);
            this.btnFindByOrderId.TabIndex = 2;
            this.btnFindByOrderId.Text = "Найти заказ";
            this.btnFindByOrderId.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(279, 80);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(98, 20);
            this.dtpFillDate.TabIndex = 4;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(15, 103);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.ReadOnly = true;
            this.dgvCustomerOrders.RowHeadersVisible = false;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(362, 65);
            this.dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(15, 196);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(106, 23);
            this.btnCancelOrder.TabIndex = 6;
            this.btnCancelOrder.Text = "Отменить заказ";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(127, 196);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(106, 23);
            this.btnFillOrder.TabIndex = 7;
            this.btnFillOrder.Text = "Заполнить заказ";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(302, 196);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(75, 23);
            this.btnFinishUpdates.TabIndex = 8;
            this.btnFinishUpdates.Text = "Готово";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 231);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.dgvCustomerOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindByOrderId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Заполнение или отмена заказов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnFindByOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnFinishUpdates;
    }
}