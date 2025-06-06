﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr=new FrmHastaGiris();
            fr.Show();
            this.Hide(); //Üstünde çalıştığım formu bana gizle
        }

        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr=new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            FrmSekreter fr = new FrmSekreter();
            fr.Show();
            this.Hide();
        }
    }
}
