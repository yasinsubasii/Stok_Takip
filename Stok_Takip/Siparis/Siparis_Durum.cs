﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip.Siparis
{
    public partial class Siparis_Durum : Form
    {
        public Siparis_Durum()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            siparisTableAdapter1.Fill(mayaStokDataSet11.Siparis);
        }
        Modul_Sttok.MayaStokEntities db;
        Modul_Sttok.Siparis spr;
        private void Siparis_Durum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mayaStokDataSet1.Siparis' table. You can move, or remove it, as needed.
            this.siparisTableAdapter.Fill(this.mayaStokDataSet1.Siparis);
            // TODO: This line of code loads data into the 'mayaStokDataSet.Urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.mayaStokDataSet.Urunler);
            db = new Modul_Sttok.MayaStokEntities();
            spr = new Modul_Sttok.Siparis();

         

        }
    }
}
