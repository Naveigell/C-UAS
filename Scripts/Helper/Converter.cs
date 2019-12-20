﻿using iTextSharp.text.pdf;
using System;
using iTextSharp.text;
using System.Windows.Forms;
using System.IO;

namespace UAS.Scripts.Helper {
    public partial class Converter : Form {

        private DataGridView dataGridView;

        public Converter() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            comboBoxConvertTypeSelection.Items.AddRange(new string[] { "Excel", "PDF" });
            if (comboBoxConvertTypeSelection.Items.Count > 0) comboBoxConvertTypeSelection.SelectedIndex = 0;
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

                            for (int i = 0; i < dataGridView.Columns.Count; i++) {
                                excel.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataGridView.Rows.Count; i++) {
                                for (int j = 0; j < dataGridView.Columns.Count; j++) {
                                    excel.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            /*excel.Columns.AutoFit();*/
                            excel.Visible = true;

                        } catch(Exception exception) {
                            Console.WriteLine(exception.Message);
                        }
                    } else if (comboBoxConvertTypeSelection.SelectedIndex == 1) {

                        PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 30;
                        pdfTable.WidthPercentage = 30;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfTable.DefaultCell.BorderWidth = 1;

                        try {

                            for (int i = 0; i < dataGridView.Columns.Count; i++) {

                                PdfPCell pdfPCell = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText));
                                pdfPCell.BackgroundColor = new BaseColor(240, 240, 240);

                                pdfTable.AddCell(pdfPCell);

                            }

                            FileStream stream = new FileStream("D:\\" + "pdfexported.pdf", FileMode.Create);
                            Document pdf = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                            PdfWriter.GetInstance(pdf, stream);

                            pdf.Open();
                            pdf.Add(pdfTable);
                            pdf.Close();
                            stream.Close();

                        } catch (Exception exception) {
                            Console.WriteLine(exception.Message);
                        }

                    }
                }
            }
        }
    }
}
