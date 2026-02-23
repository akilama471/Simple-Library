using SarasaviLibrary.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace SarasaviLibrary.Forms
{
    public partial class ReportForm : Form
    {
        private LoanRepository _loanRepository;
        private ReservationRepository _reservationRepository;

        public ReportForm()
        {
            InitializeComponent();
            _loanRepository = new LoanRepository();
            _reservationRepository = new ReservationRepository();
            InitializeReportTypes();
        }

        private void InitializeReportTypes()
        {
            cmbReportType.Items.Add("Borrowed History");
            cmbReportType.Items.Add("Member History");
            cmbReportType.Items.Add("Reservations");
            cmbReportType.SelectedIndex = 0;
            pnlMemberSearch.Visible = false;
            pnlFilters.Visible = true;
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem?.ToString();
            
            pnlMemberSearch.Visible = (selectedReport == "Member History");
            pnlFilters.Visible = (selectedReport == "Borrowed History");
            
            if (selectedReport != "Member History")
            {
                LoadReportData();
            }
            else
            {
                dgvReport.DataSource = null; // Clear until searched
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem?.ToString() == "Member History")
            {
                LoadReportData();
            }
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void dgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvReport.Columns[e.ColumnIndex].HeaderText == "Status")
                {
                    var statusValue = dgvReport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (statusValue != null && statusValue.ToString() == "Delay Return")
                    {
                        dgvReport.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void LoadReportData()
        {
            string selectedReport = cmbReportType.SelectedItem?.ToString();
            try
            {
                switch (selectedReport)
                {
                    case "Borrowed History":
                        dgvReport.DataSource = _loanRepository.GetBorrowHistoryReport(rbActiveBorrow.Checked, chkDelayedBorrow.Checked);
                        break;
                    case "Member History":
                        if (int.TryParse(txtMemberId.Text, out int memberId))
                        {
                            dgvReport.DataSource = _loanRepository.GetMemberHistoryReport(memberId);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric Member ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "Reservations":
                        dgvReport.DataSource = _reservationRepository.GetReservationReport();
                        break;
                }
                
                // Optional: Auto-resize columns
                if (dgvReport.Columns.Count > 0)
                {
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
