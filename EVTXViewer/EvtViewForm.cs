using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace EVTXViewer
{
    public partial class EvtViewForm : RadForm
    {
        public EvtViewForm() { InitializeComponent(); }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {Multiselect = false, Filter = "EVTX Files|*.evtx"};
            openFileDialog.FileOk += openFileDialog_FileOk;
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var selectedFileNames = ((OpenFileDialog) sender).FileNames;
            txtFilePath.Text = string.Join(",", selectedFileNames);
        }

        private void btnFileImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Dosya seçiniz");
                return;
            }
            grdEvtxData.DataSource = LogRecordCollection(txtFilePath.Text);
        }

        private static IEnumerable<EventLogRecord> LogRecordCollection(string filename, string xpathquery = "*")
        {
            var eventLogQuery = new EventLogQuery(filename, PathType.FilePath, xpathquery);
            using (var eventLogReader = new EventLogReader(eventLogQuery))
            {
                EventLogRecord eventLogRecord;
                while ((eventLogRecord = (EventLogRecord) eventLogReader.ReadEvent()) != null)
                    yield return eventLogRecord;
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (grdEvtxData.DataSource == null)
            {
                MessageBox.Show("Önce dosya seçip Import ediniz.");
                return;
            }

            var r = MessageBox.Show("Bu işlem çoook uzun sürmekte devam etmek istiyor musunuz? :)", "", MessageBoxButtons.OKCancel);
            if (r != DialogResult.OK)
                return;
            var exporter = new ExportToCSV(grdEvtxData)
                           {
                               HiddenColumnOption = HiddenOption.DoNotExport,
                               SummariesExportOption = SummariesOption.DoNotExport
                           };
            var saveFileDialog = new SaveFileDialog();
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                exporter.RunExport(saveFileDialog.FileName);
                MessageBox.Show("Excel aktarımı tamamlandı");
            }
        }
    }
}