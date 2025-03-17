using System;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class ReportForm : Form
    {
        public string SelectedReportType { get; private set; }
        public DateTime SelectedDateFrom { get; private set; }
        public DateTime SelectedDateTo { get; private set; }

        // Элементы управления
        private ComboBox reportTypeComboBox;
        private DateTimePicker dateFromPicker;
        private DateTimePicker dateToPicker;
        private Button generateReportButton;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Заполняем ComboBox типами отчетов
            reportTypeComboBox.Items.AddRange(new string[] { "Отчет по продажам", "Отчет по покупателям", "Отчет по категориям" });
            reportTypeComboBox.SelectedIndex = 0;

            // Устанавливаем текущую дату по умолчанию
            dateFromPicker.Value = DateTime.Now.AddMonths(-1);
            dateToPicker.Value = DateTime.Now;
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            // Сохраняем выбранные данные
            SelectedReportType = reportTypeComboBox.SelectedItem.ToString();
            SelectedDateFrom = dateFromPicker.Value;
            SelectedDateTo = dateToPicker.Value;

            // Закрываем форму с результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}