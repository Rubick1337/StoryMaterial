namespace StoreMaterials.Forms
{
    partial class EditMaterialForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label materialIdLabel;
        private System.Windows.Forms.ComboBox materialIdComboBox;
        private System.Windows.Forms.Label materialNameLabel;
        private System.Windows.Forms.TextBox materialNameTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;

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
            this.materialIdLabel = new System.Windows.Forms.Label();
            this.materialIdComboBox = new System.Windows.Forms.ComboBox();
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.materialNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // materialIdLabel
            // 
            this.materialIdLabel.AutoSize = true;
            this.materialIdLabel.Location = new System.Drawing.Point(12, 15);
            this.materialIdLabel.Name = "materialIdLabel";
            this.materialIdLabel.Size = new System.Drawing.Size(18, 13);
            this.materialIdLabel.TabIndex = 0;
            this.materialIdLabel.Text = "ID";

            // 
            // materialIdComboBox
            // 
            this.materialIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialIdComboBox.FormattingEnabled = true;
            this.materialIdComboBox.Location = new System.Drawing.Point(150, 12);
            this.materialIdComboBox.Name = "materialIdComboBox";
            this.materialIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.materialIdComboBox.TabIndex = 1;
            this.materialIdComboBox.SelectedIndexChanged += new System.EventHandler(this.materialIdComboBox_SelectedIndexChanged);

            // 
            // materialNameLabel
            // 
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Location = new System.Drawing.Point(12, 45);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(98, 13);
            this.materialNameLabel.TabIndex = 2;
            this.materialNameLabel.Text = "Материал";

            // 
            // materialNameTextBox
            // 
            this.materialNameTextBox.Location = new System.Drawing.Point(150, 42);
            this.materialNameTextBox.Name = "materialNameTextBox";
            this.materialNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.materialNameTextBox.TabIndex = 3;

            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 75);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 13);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Категория";

            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(150, 72);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoryComboBox.TabIndex = 5;

            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(150, 110);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(260, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 30);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            // 
            // EditMaterialForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 150);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.materialNameTextBox);
            this.Controls.Add(this.materialNameLabel);
            this.Controls.Add(this.materialIdComboBox);
            this.Controls.Add(this.materialIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование материала";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}