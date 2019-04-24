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
    public partial class frmLOGEXCEPTION : Form
    {
        konekcija.MojaEntities _context;
        //List<Cardholder> Lista;
        //List<AccessLog> Lista1;
        //List<Card> Lista2;
        List<LogException> Lista3;


        public int CARDHOLDERID;
        public int brojac;

        public frmLOGEXCEPTION()
        {
            InitializeComponent();
        }       

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARDHOLDERID = 0;
            if (cboxCARDHOLDER.Text == "")
            {
                Lista3 = _context.LogExceptions.ToList();

                Lista3 = Lista3.Where(w => w.Date >= dateTimePicker1.Value && w.Date <= dateTimePicker2.Value).ToList();
                logExceptionBindingSource.DataSource = Lista3;
                dgLOGEXCEPTION.DataSource = Lista3;
            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();

                Lista3 = _context.LogExceptions.ToList();

                Lista3 = Lista3.Where(i => ((CARDHOLDERID == 0) ? true : (i.Date >= dateTimePicker1.Value.Date)
                                           && (i.Date <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                logExceptionBindingSource.DataSource = Lista3;
                dgLOGEXCEPTION.DataSource = Lista3;
            }
                  
        }         

        private void frmEXCEPTION_Load(object sender, EventArgs e)
        {
            _context = new konekcija.MojaEntities();
            cboxCARDHOLDER.DataSource = _context.Cardholders.ToList();
            cboxCARDHOLDER.Text = "";

            Lista3 = _context.LogExceptions.ToList();
           // Lista2 = _context.Cards.ToList();
           // Lista1 = _context.AccessLogs.ToList();
           // Lista = _context.Cardholders.ToList();
        }        

        private void dgLOGEXCEPTION_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (cboxCARDHOLDER.Text != "")
            {
                var dgridView = (DataGridView)sender;
                foreach (DataGridViewRow row in dgridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var card = (konekcija.LogException)(row.DataBoundItem);
                        var imer = card.Cardholder;

                         row.Cells[gvCARDHOLDER.Index].Value = imer.Name;
                    }
                }
            }
        }
        private void CreateQuery(object sender, EventArgs e)
        {            

                Lista3 = _context.LogExceptions.ToList();

                Lista3 = Lista3.Where(i => ((CARDHOLDERID == 0) ? true : (i.Date >= dateTimePicker1.Value.Date)
                                           && (i.Date <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                logExceptionBindingSource.DataSource = Lista3;
                dgLOGEXCEPTION.DataSource = Lista3;
        }
    }
    
}
