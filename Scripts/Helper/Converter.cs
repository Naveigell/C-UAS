using iTextSharp.text.pdf;
using System;
using iTextSharp.text;
using System.Windows.Forms;
using System.IO;

namespace UAS.Scripts.Helper {
    public partial class Converter : Form {

        private DataGridView dataGridView;
        private String projectPathDirectory;
        private String[] crystalReportPath = new String[] { 
            "\\Reports\\EventsReport.rpt", 
            "\\Reports\\ParticipantReport.rpt",
            "\\Reports\\ScheduleReport.rpt",
            "\\Reports\\ScheduleReportVS.rpt",
            "\\Reports\\ScheduleReportVS.rpt"
        };
        private String[] crystalReportComboBoxTitle = new String[] { "Events", "Peserta", "Jadwal", "Skor Vs", "Skor Individual" };

        public Converter() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            comboBoxConvertTypeSelection.Items.AddRange(new string[] { "Excel", "PDF", "Crystal Report" });
            if (comboBoxConvertTypeSelection.Items.Count > 0) comboBoxConvertTypeSelection.SelectedIndex = 0;

            projectPathDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            comboBoxCrystalReportSelection.Visible = comboBoxConvertTypeSelection.SelectedIndex == 2;
            comboBoxCrystalReportSelection.Items.AddRange(crystalReportComboBoxTitle);
            if (comboBoxCrystalReportSelection.Items.Count > 0) comboBoxCrystalReportSelection.SelectedIndex = 0;
        }

        public void SetDataGridView(DataGridView dataGridView) {
            this.dataGridView = dataGridView;
        }

        private void buttonConvert_Click(object sender, EventArgs e) {
            if (dataGridView != null) {
                if (dataGridView.Rows.Count > 0) {
                    if (comboBoxConvertTypeSelection.SelectedIndex == 0) {

                        try {

                            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                            excel.Application.Workbooks.Add(Type.Missing);
                            // jadikan tanpa format
                            excel.Cells.NumberFormat = "@";

                            for (int i = 0; i < dataGridView.Columns.Count; i++) {
                                // pada cell yang ke pertama column seterusnya diisi oleh header
                                excel.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataGridView.Rows.Count; i++) {
                                for (int j = 0; j < dataGridView.Columns.Count; j++) {
                                    excel.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            excel.Columns.AutoFit();
                            excel.Visible = true;

                        } catch(Exception exception) {
                            Console.WriteLine(exception.Message);
                        }
                    } else if (comboBoxConvertTypeSelection.SelectedIndex == 1) {

                        PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 30;
                        pdfTable.WidthPercentage = 95;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        pdfTable.TotalWidth = 300f;

                        try {

                            for (int i = 0; i < dataGridView.Columns.Count; i++) {

                                PdfPCell pdfPCell = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText));
                                pdfPCell.BackgroundColor = new BaseColor(240, 240, 240);

                                pdfTable.AddCell(pdfPCell);

                            }

                            for (int i = 0; i < dataGridView.Rows.Count; i++) {
                                for (int j = 0; j < dataGridView.Columns.Count; j++) {
                                    PdfPCell pdfPCell = new PdfPCell(new Phrase(dataGridView.Rows[i].Cells[j].Value.ToString()));
                                    pdfPCell.BackgroundColor = new BaseColor(240, 240, 240);

                                    pdfTable.AddCell(pdfPCell);
                                }
                            }

                            FileStream stream = new FileStream("D:\\" + "pdfexported.pdf", FileMode.Create);
                            Document pdf = new Document(PageSize.TABLOID, 0f, 0f, 10f, 10f);
                            PdfWriter writer = PdfWriter.GetInstance(pdf, stream);

                            pdf.Open();
                            pdf.Add(pdfTable);
                            pdf.Close();
                            stream.Close();

                            if (File.Exists("D:\\" + "pdfexported.pdf")) {
                                MessageBox.Show("Export PDF success dan tersimpan di path D:\\\\pdfexported.pdf", "Success");
                            } else {
                                MessageBox.Show("Export PDF error", "Error");
                            }

                        } catch (Exception exception) {
                            Console.WriteLine(exception.Message);
                        }

                    } else if (comboBoxConvertTypeSelection.SelectedIndex == 2) {
                        // jika panjang combobox item lebih dari 0 dan kurang dari
                        // panjang maksimum
                        if (comboBoxCrystalReportSelection.SelectedIndex >= 0 && 
                            comboBoxCrystalReportSelection.SelectedIndex <= comboBoxCrystalReportSelection.Items.Count - 1) {

                            int index = comboBoxCrystalReportSelection.SelectedIndex;

                            CrystalReportViewer eventPageCrystalReports = new CrystalReportViewer();
                            eventPageCrystalReports.SetCrystalReportSource(projectPathDirectory + crystalReportPath[index]);
                            eventPageCrystalReports.ShowDialog(this);
                        }
                    }
                }
            }
        }

        private void comboBoxConvertTypeSelection_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxConvertTypeSelection.SelectedIndex == 2) {
                buttonConvert.Text = "Buka Form";
            } else {
                buttonConvert.Text = "Convert";
            }

            this.Size = comboBoxConvertTypeSelection.SelectedIndex == 2 ? new System.Drawing.Size(484, 123) : new System.Drawing.Size(484, 90);
            comboBoxCrystalReportSelection.Visible = comboBoxConvertTypeSelection.SelectedIndex == 2;
        }
    }
}
