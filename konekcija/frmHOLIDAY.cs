using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konekcija
{
    public partial class frmHOLIDAY : Form
    {

        private konekcija.MojaEntities _context;

        int NUMBEROFDAYS;
        int CARDHOLDERID;
        int HOLIDAYID;


        public frmHOLIDAY()
        {
            InitializeComponent();
        }

        private void frmHOLIDAY_Load(object sender, EventArgs e)
        {
            _context = new konekcija.MojaEntities();

            cardholderBindingSource.DataSource = _context.Cardholders.ToList();
            cmbCARDHOLDER.Text = "";
        }

        private void btnACCEPT_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                MessageBox.Show("Invalid return date");
            }

            else
            {

                var query = from s in _context.Holidays
                            where s.CardholderID == CARDHOLDERID
                            select new { s.HolidayID };
                foreach (var item in query)
                {
                    HOLIDAYID = item.HolidayID;
                }
                if (CARDHOLDERID == 0 || dateTimePicker2.Value <= dateTimePicker1.Value)
                {
                    MessageBox.Show("Date or worker name is not valid.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    var holi = new Holiday();
                    holi.CardholderID = CARDHOLDERID;
                    holi.LeaveDate = dateTimePicker1.Value;
                    holi.ReturnDate = dateTimePicker2.Value;
                    holi.NumberOfDays = Convert.ToInt32(txtTOTAL.Text);
                    holi.NumberOfDays = NUMBEROFDAYS;
                    _context.Holidays.Add(holi);
                    _context.SaveChanges();

                    MessageBox.Show("Leave request successfully added.", "Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    CARDHOLDERID = 0;
                    cmbCARDHOLDER.Text = "";
                    HOLIDAYID = 0;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                txtTOTAL.Text = "ERROR";
                MessageBox.Show("Invalid return date");
            }
            else
            {
                double days = (dateTimePicker2.Value - dateTimePicker1.Value).TotalDays;
                NUMBEROFDAYS = Convert.ToInt32(days);
                txtTOTAL.Text = NUMBEROFDAYS.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                txtTOTAL.Text = "ERROR";
                MessageBox.Show("Invalid return date");
            }
            else
            {
                double days = (dateTimePicker2.Value - dateTimePicker1.Value).TotalDays;
                NUMBEROFDAYS = Convert.ToInt32(days);
                txtTOTAL.Text = NUMBEROFDAYS.ToString();
            }
        }

        private void cmbCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARDHOLDERID = 0;
            if (cmbCARDHOLDER.Text == "")
            {

            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cmbCARDHOLDER.Text).Select(s => s.CardholderID).First();
            }
            
        }
    }
}

