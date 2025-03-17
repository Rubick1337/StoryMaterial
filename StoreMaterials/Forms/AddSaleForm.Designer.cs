namespace StoreMaterials.Forms
{
    partial class AddSaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.DateTimePicker saleDatePicker;
        private System.Windows.Forms.Label materialIdLabel;
        private System.Windows.Forms.TextBox materialIdTextBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label deliveryCostLabel;
        private System.Windows.Forms.TextBox deliveryCostTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox materialComboBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.saleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.materialIdLabel = new System.Windows.Forms.Label();
            this.materialIdTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.deliveryCostLabel = new System.Windows.Forms.Label();
            this.deliveryCostTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(150, 42);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(200, 21);
            this.materialComboBox.TabIndex = 3;

            this.Controls.Add(this.materialComboBox);

            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Location = new System.Drawing.Point(12, 15);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(75, 13);
            this.saleDateLabel.TabIndex = 0;
            this.saleDateLabel.Text = "Дата продажи";

            // 
            // saleDatePicker
            // 
            this.saleDatePicker.Location = new System.Drawing.Point(150, 12);
            this.saleDatePicker.Name = "saleDatePicker";
            this.saleDatePicker.Size = new System.Drawing.Size(200, 20);
            this.saleDatePicker.TabIndex = 1;

            // 
            // materialIdLabel
            // 
            this.materialIdLabel.AutoSize = true;
            this.materialIdLabel.Location = new System.Drawing.Point(12, 45);
            this.materialIdLabel.Name = "materialIdLabel";
            this.materialIdLabel.Size = new System.Drawing.Size(68, 13);
            this.materialIdLabel.TabIndex = 2;
            this.materialIdLabel.Text = "ID материала";

            // 
            // materialIdTextBox
            // 
            this.materialIdTextBox.Location = new System.Drawing.Point(150, 42);
            this.materialIdTextBox.Name = "materialIdTextBox";
            this.materialIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.materialIdTextBox.TabIndex = 3;

            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(12, 75);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(95, 13);
            this.unitLabel.TabIndex = 4;
            this.unitLabel.Text = "Единицы измер";

            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(150, 72);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(200, 20);
            this.unitTextBox.TabIndex = 5;

            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(12, 105);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(80, 13);
            this.unitPriceLabel.TabIndex = 6;
            this.unitPriceLabel.Text = "Цена за единицу";

            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(150, 102);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.unitPriceTextBox.TabIndex = 7;

            // 
            // deliveryCostLabel
            // 
            this.deliveryCostLabel.AutoSize = true;
            this.deliveryCostLabel.Location = new System.Drawing.Point(12, 135);
            this.deliveryCostLabel.Name = "deliveryCostLabel";
            this.deliveryCostLabel.Size = new System.Drawing.Size(98, 13);
            this.deliveryCostLabel.TabIndex = 8;
            this.deliveryCostLabel.Text = "Цена доставки";

            // 
            // deliveryCostTextBox
            // 
            this.deliveryCostTextBox.Location = new System.Drawing.Point(150, 132);
            this.deliveryCostTextBox.Name = "deliveryCostTextBox";
            this.deliveryCostTextBox.Size = new System.Drawing.Size(200, 20);
            this.deliveryCostTextBox.TabIndex = 9;

            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(12, 165);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(44, 13);
            this.discountLabel.TabIndex = 10;
            this.discountLabel.Text = "Скидка";

            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(150, 162);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(200, 20);
            this.discountTextBox.TabIndex = 11;

            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(12, 195);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.customerNameLabel.TabIndex = 12;
            this.customerNameLabel.Text = "ФИО покупателя";

            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(150, 192);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameTextBox.TabIndex = 13;

            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(150, 230);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 30);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(260, 230);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            // 
            // AddSaleForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.deliveryCostTextBox);
            this.Controls.Add(this.deliveryCostLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.materialIdTextBox);
            this.Controls.Add(this.materialIdLabel);
            this.Controls.Add(this.saleDatePicker);
            this.Controls.Add(this.saleDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление продажи";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}