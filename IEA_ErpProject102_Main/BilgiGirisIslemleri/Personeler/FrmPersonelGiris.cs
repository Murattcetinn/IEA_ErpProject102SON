﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;
using IEA_ErpProject102_Main.Properties;

namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Personeler
{
    public partial class FrmPersonelGiris : Form
    {
        private ErpProject102Entities erp = new ErpProject102Entities();
        private Numaralar n = new Numaralar();
        private int secimId = -1;
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void Listele()
        {
            
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGrupId == 4
                       select new
                       {
                           id = s.Id,
                           dkodu = s.tblCariler.CariKodu,
                           dadi = s.tblCariler.CariAdi,
                           dtel = s.tblCariler.CariTel,
                           dmail = s.tblCariler.CariMail,
                           dyetcep = s.tblCariler.YetkiliCep1,
                           dgtarih=s.IsBasiTarih,
                           dbtarih=s.IsBitisTarih
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.dkodu;
                Liste.Rows[i].Cells[3].Value = k.dadi;
                Liste.Rows[i].Cells[4].Value = k.dtel;
                Liste.Rows[i].Cells[5].Value = k.dyetcep;
                Liste.Rows[i].Cells[6].Value = k.dmail;
                Liste.Rows[i].Cells[7].Value = k.dgtarih;
                Liste.Rows[i].Cells[8].Value = k.dbtarih;
                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblHastaneKodu.Text = n.CariKoduPersonel();

        }
        private void ComboDoldur()
        {
            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));

            var dep1 = erp.tblDepartmanlar.Where(x => x.GrupId == 4).ToList();

            var seh = erp.tblSehirler.ToList();

            txtSehir.DataSource = seh;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "sehir";
            txtSehir.SelectedIndex = -1;

            txtPDept.DataSource = dep1;
            txtPDept.ValueMember = "Id";
            txtPDept.DisplayMember = "DeptAdi";
            txtPDept.SelectedIndex = -1;

        }
        private void YeniKayit()
        {
            string pkodu = n.CariKoduPersonel();
            try
            {
                if (txtPAdi.Text=="")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPAdi.Text;
                    hst.CariMail = txtPMail.Text;
                    hst.CariTel = txtPTel.Text;
                     
                    hst.YetkiliDep1 = txtPDept.Text;
                      
                    hst.YetkiliCep1 = txtPCep.Text;
                     
                    hst.Adres1 = txtPAdres1.Text;
                    hst.Adres2 = txtPAdres2.Text;
                    hst.CariGrupId = 4;
                    hst.CariTipId = 1;
                    hst.CariUnvan = txtPUnvan.Text;
                   
                    hst.VnoTcno = txtVnTc.Text;
                    if (txtSehir.SelectedValue != null)
                    {
                        hst.SehirId = (int)txtSehir.SelectedValue;
                    }
                    //txtSehir.SelectedValue!=null ? (int) txtSehir.SelectedValue:-1;
                    //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;

                    hst.SaveDate = DateTime.Now;
                    hst.SaveUserId = 1;
                    hst.CariKodu = pkodu;
                    


                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.IsBasiTarih = txtGirisT.Value;
                    pdet.CariId = erp.tblCariler.First(x => x.CariAdi == txtPAdi.Text).Id;

                    erp.tblPersonelDetay.Add(pdet);
                    erp.SaveChanges();


                    MessageBox.Show(@"Kayit Basarili");

                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show(@"Bu kayit daha once sahiplendirilmis. Kendine baska bir kayit bul...");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Guncelle()
        {
            if (secimId < 0)
            {
                return;
            }
            try
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(secimId);
                hst.tblCariler.CariAdi = txtPAdi.Text;
                hst.tblCariler.CariMail = txtPMail.Text;
                hst.tblCariler.CariTel = txtPTel.Text;

                hst.tblCariler.YetkiliDep1 = txtPDept.Text;

                hst.tblCariler.YetkiliCep1 = txtPCep.Text;

                hst.tblCariler.Adres1 = txtPAdres1.Text;
                hst.tblCariler.Adres2 = txtPAdres2.Text;
                hst.tblCariler.CariTipId = 1;
                hst.tblCariler.CariUnvan = txtPUnvan.Text;
             
                hst.tblCariler.VnoTcno = txtVnTc.Text;
                if (txtSehir.SelectedValue!=null)
                {
                    hst.tblCariler.SehirId = (int)txtSehir.SelectedValue;
                }
                
                hst.tblCariler.UpdateDate = DateTime.Now;
                hst.tblCariler.UpdateUserId = 1;
                hst.tblCariler.CariKodu = lblHastaneKodu.Text;

                if (txtDurum.Checked)
                {
                    hst.IsBitisTarih = txtBitisT.Value;
                }

                erp.SaveChanges();
                MessageBox.Show(@"Guncelleme Basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }

            secimId = -1;
            txtSehir.SelectedIndex = -1;
            txtPDept.SelectedIndex = -1;
            txtDurum.Visible = false;
            txtDurum.Checked = false;
            txtBitisT.Visible = false;
        }
        public void Ac(int i)
        {
            txtDurum.Visible = true;
            secimId = i;
            try
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(i);
                txtPAdi.Text = hst.tblCariler.CariAdi;
                txtPMail.Text = hst.tblCariler.CariMail;
                txtPTel.Text = hst.tblCariler.CariTel;

                txtPDept.Text = hst.tblCariler.YetkiliDep1;

                txtPCep.Text = hst.tblCariler.YetkiliCep1;

                txtPAdres1.Text = hst.tblCariler.Adres1;
                txtPAdres2.Text = hst.tblCariler.Adres2;
                txtPUnvan.Text = hst.tblCariler.CariUnvan;
                
                txtVnTc.Text = hst.tblCariler.VnoTcno;
                txtSehir.Text = hst.tblCariler.tblSehirler == null ? "" : hst.tblCariler.tblSehirler.sehir;
                lblHastaneKodu.Text = hst.tblCariler.CariKodu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtHKoduBul.ClientSize.Height + 0);
            btn.Location = new Point(txtHKoduBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            SendMessage(txtHKoduBul.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            txtHKoduBul.Controls.Add(btn);

            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmPersonellerListesi"] == null)
            {
                FrmPersonellerListesi frm = new FrmPersonellerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblPersonelDetay hst = erp.tblPersonelDetay.Find(secimId);
                hst.tblCariler.isActive = false;
                erp.SaveChanges();
                MessageBox.Show(@"Silme basarili");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                txtBitisT.Visible = true;

            }
            else
            {
                txtBitisT.Visible = false;
            }
        }
    }
}
