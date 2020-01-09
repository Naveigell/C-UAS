using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS.Scripts.Helper {
    public partial class CrystalReportViewer : Form {
        public CrystalReportViewer() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {

        }

        public void SetCrystalReportSource(String path) {
            crystalReportViewer.ReportSource = path;
        }
    }
}
