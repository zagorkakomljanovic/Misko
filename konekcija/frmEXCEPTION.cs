﻿using System;
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
    public partial class frmEXCEPTION : Form
    {
        konekcija.MojaEntities _context;
        List<Cardholder> Lista;
        List<AccessLog> Lista1;
        List<Card> Lista2;

        public int CARDHOLDERID;
        public int brojac;

        public frmEXCEPTION()
        {
            InitializeComponent();
        }       

        private void cboxCARDHOLDER_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARDHOLDERID = 0;
            if (cboxCARDHOLDER.Text == "")
            {

            }
            else
            {
                CARDHOLDERID = _context.Cardholders.Where(w => w.Name == cboxCARDHOLDER.Text).Select(s => s.CardholderID).First();

                Lista1 = _context.AccessLogs.ToList();

                Lista1 = Lista1.Where(i => ((CARDHOLDERID == 0) ? true : (i.LocalTime >= dateTimePicker1.Value.Date)
                                           && (i.LocalTime <= dateTimePicker2.Value.Date)
                                           && (i.CardholderID == CARDHOLDERID))).ToList();

                accessLogBindingSource.DataSource = Lista1;
                dgCHECKLIST.DataSource = Lista1;

            }
        }

        private void cboxCARDHOLDER_Click(object sender, EventArgs e)
        {
            if (brojac == 1)
            {

            }
            else
            {                
                brojac = 1;

                _context = new konekcija.MojaEntities();
                cboxCARDHOLDER.DataSource = _context.Cardholders.ToList();
                cboxCARDHOLDER.Text = "";

                Lista2 = _context.Cards.ToList();
                Lista1 = _context.AccessLogs.ToList();
                Lista = _context.Cardholders.ToList();
            }
            

        }

        private void frmEXCEPTION_Load(object sender, EventArgs e)
        {
          
        }
    }
}