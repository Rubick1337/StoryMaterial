using System.ComponentModel;

namespace StoreMaterials.Forms
{

    partial class ReportForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private System.Windows.Forms.Label labelStartDate; // Метка "Начало"
        private System.Windows.Forms.Label labelEndDate; // Метка "Конец"

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


        private void InitializeComponent()
        {
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker(); // Начальная дата
            this.dateToPicker = new System.Windows.Forms.DateTimePicker(); // Конечная дата
            this.generateReportButton = new System.Windows.Forms.Button();
            this.labelStartDate = new System.Windows.Forms.Label(); // Метка "Начало"
            this.labelEndDate = new System.Windows.Forms.Label(); // Метка "Конец"
            this.SuspendLayout();

            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Location = new System.Drawing.Point(50, 20);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(300, 28);
            this.reportTypeComboBox.TabIndex = 0;

            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(50, 60);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(60, 20);
            this.labelStartDate.TabIndex = 1;
            this.labelStartDate.Text = "Начало";

            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Location = new System.Drawing.Point(50, 80);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(300, 26);
            this.dateFromPicker.TabIndex = 2;
            this.dateFromPicker.Format = DateTimePickerFormat.Short; // Формат даты

            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(50, 120);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(54, 20);
            this.labelEndDate.TabIndex = 3;
            this.labelEndDate.Text = "Конец";

            // 
            // dateToPicker
            // 
            this.dateToPicker.Location = new System.Drawing.Point(50, 140);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(300, 26);
            this.dateToPicker.TabIndex = 4;
            this.dateToPicker.Format = DateTimePickerFormat.Short; // Формат даты

            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(50, 190);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(200, 40);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Сгенерировать отчет";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);

            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.reportTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор отчета";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}