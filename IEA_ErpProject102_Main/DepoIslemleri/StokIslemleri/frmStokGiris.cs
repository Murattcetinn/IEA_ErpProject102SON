using IEA_ErpProject102_Main.Dal;
using IEA_ErpProject102_Main.Entitiy;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IEA_ErpProject102_Main.Properties;

namespace IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGiris : baglanti
    {
        public string[] MyArray { get; set; }
        public frmStokGiris()
        {
            InitializeComponent();
        }

        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            txtGenelNo.Text = _n.StokGenelKodu();
        }

        #region Form Yuklenme Islemleri
        private void ComboDoldur()
        {
            txtUrnCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var srg = _erp.tblUrunler.Where(x => x.isActive == true).Select(x => x.UrunKodu).Distinct();

            foreach (string urun in srg)
            {
                veri.Add(urun);
                txtUrnCombo.Items.Add(urun);
            }

            txtUrnCombo.AutoCompleteCustomSource = veri;

            int dgv;
            dgv = txtUrnCombo.Items.Count;
            MyArray = new string[dgv];

            for (int p = 0; p < dgv; p++)
            {
                MyArray[p] = txtUrnCombo.Items[p].ToString();
            }


            txtCariGrup.DataSource = _erp.tblCariGruplari.ToList();
            txtCariGrup.ValueMember = "Id";
            txtCariGrup.DisplayMember = "GrupAdi";
            txtCariGrup.SelectedIndex = -1;
        }

        private void Temizle()
        {

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Kayit Islemleri


        private void YeniKayit()
        {
            if (txtCariGrup.Text == "" || txtCariAdi.Text == "")
            {
                MessageBox.Show("Cari Grup veya Cari Adi secmediniz.Lutfen secim yapin.");
                return;
            }

            if (txtGirisTipi.Text == "")
            {
                MessageBox.Show("Giris Tipini secmediniz.Lutfen secim yapin.");
                return;
            }

            Liste.AllowUserToAddRows = false;
            try
            {
                tblStokGirisUst ust = new tblStokGirisUst
                {
                    GenelNo = int.Parse(txtGenelNo.Text),
                    CariGrupId = (int)txtCariGrup.SelectedValue,
                    CariAdiId = _erp.tblCariler.First(x => x.CariAdi == txtCariAdi.Text).Id,
                    GirisTipi = txtGirisTipi.SelectedIndex + 1,
                    FaturaNo = txtFaturaNo.Text,
                    FaturaTarih = txtGirisTarih.Value,
                    Aciklama = txtAciklama.Text,
                    isActive = true,
                    SaveDate = DateTime.Now,
                    SaveUserId = 1
                };
                _erp.tblStokGirisUst.Add(ust);
                _erp.SaveChanges();

                tblStokDurum[] drm = new tblStokDurum[Liste.RowCount];
                tblStokGirisAlt[] alt = new tblStokGirisAlt[Liste.RowCount];

                for (int i = 0; i < Liste.RowCount; i++)
                {
                    string bar = Liste.Rows[i].Cells[2].Value.ToString() + "/" +
                                 Liste.Rows[i].Cells[3].Value.ToString();

                    //AR-1001  12345 = AR-1001/12345
                    //AR-1001  23456 = AR-1001/23456

                    drm[i] = new tblStokDurum();
                    var srg = (from s in _erp.tblStokDurum
                               where s.Barkod == bar
                               select new
                               {
                                   sadet = s.StokAdet,
                                   sraf = s.RafAdet
                               }).ToList();

                    if (srg.Count == 0)
                    {
                        drm[i].StokKodu = "1";
                        drm[i].Barkod = bar;
                        drm[i].Urun = Liste.Rows[i].Cells[2].Value.ToString();
                        drm[i].Lot = Liste.Rows[i].Cells[3].Value.ToString();
                        drm[i].StokAdet = Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        drm[i].RafAdet = Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        drm[i].SubeAdet = 0;
                        drm[i].KonsinyeAdet = 0;
                        drm[i].UT = Convert.ToDateTime(Liste.Rows[i].Cells[6].Value);
                        drm[i].SKT = Convert.ToDateTime(Liste.Rows[i].Cells[7].Value);

                        _erp.tblStokDurum.Add(drm[i]);
                        //_erp.SaveChanges();

                    }
                    else
                    {
                        tblStokDurum sdurum = _erp.tblStokDurum.First(x => x.Barkod == bar);
                        sdurum.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        sdurum.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                        _erp.SaveChanges();
                    }

                    alt[i] = new tblStokGirisAlt();
                    alt[i].GenelNo = int.Parse(txtGenelNo.Text);
                    alt[i].SiraNo = i + 1;
                    alt[i].Barkod = bar;
                    alt[i].UrunKodu = Liste.Rows[i].Cells[2].Value.ToString();
                    alt[i].LotSeriNo = Liste.Rows[i].Cells[3].Value.ToString();
                    alt[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                    alt[i].Not = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].UT = Convert.ToDateTime(Liste.Rows[i].Cells[6].Value);
                    alt[i].SKT = Convert.ToDateTime(Liste.Rows[i].Cells[7].Value);
                    alt[i].AlisFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[8].Value);

                    //Her bir satir icin tek tek kayit alir
                    //_erp.tblStokGirisAlt.Add(alt[i]);
                    //_erp.SaveChanges();
                }



                //Butun satirlar alt toplandiktan sonra kayit alir.
                _erp.tblStokGirisAlt.AddRange(alt);
                _erp.SaveChanges();

                MessageBox.Show("Kayit basarili!!!");

            }
            catch (Exception e)
            {
                MessageBox.Show("100   :" + e.Message);
            }



        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
        #endregion

        #region Guncelleme ve Silme Islemleri

        private void KayitAC()
        {

        }

        private void Guncelle()
        {

        }

        private void Sil()
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        #endregion

        #region Sanal Button Islemleri
        protected override void OnLoad(EventArgs e)
        {
            var btnUrunBul = new Button();
            btnUrunBul.Size = new Size(25, txtGenelNo.ClientSize.Height + 2);
            btnUrunBul.Location = new Point(txtGenelNo.ClientSize.Width - btnUrunBul.Width, -1);
            btnUrunBul.Cursor = Cursors.Default;
            btnUrunBul.Image = Resources.arrow_1176;
            txtGenelNo.Controls.Add(btnUrunBul);
            btnUrunBul.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnYer = new Button();
            btnYer.Size = new Size(25, txtCariAdi.ClientSize.Height + 2);
            btnYer.Location = new Point(txtCariAdi.ClientSize.Width - btnYer.Width, -1);
            btnYer.Cursor = Cursors.Default;
            btnYer.Image = Resources.arrow_1176;
            txtCariAdi.Controls.Add(btnYer);
            btnYer.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);
            btnUrunBul.Click += btnUrunBul_Click;
            btnYer.Click += btnYer_Click;
        }

        private void btnYer_Click(object sender, EventArgs e)
        {
            if (txtCariGrup.Text == "Hastane")
            {
                int id = f.HastaneListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
            if (txtCariGrup.Text == "Doktor")
            {
                int id = f.DoktorListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
            if (txtCariGrup.Text == "Firma")
            {
                int id = f.FirmaListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
            if (txtCariGrup.Text == "Personel")
            {
                int id = f.PersonelListesi(true);
                if (id > 0)
                {
                    Ac(id);
                }

                Home.Aktarma = -1;
            }
        }

        private void Ac(int id)
        {

            tblCariler bulId = _erp.tblCariler.Find(id);

            if (txtCariGrup.Text == "Personel")
            {
                bulId = _erp.tblPersonelDetay.First(x => x.Id == id).tblCariler;
            }
            try
            {
                tblCariler hst = bulId;
                txtCariAdi.Text = hst.CariAdi;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            int id = f.StokGirisListesi(true);
            if (id > 0)
            {
                FormAc(id);
            }

            Home.Aktarma = -1;
        }

        private void FormAc(int id)
        {
            int i = 0;
            var kayitBul = _erp.tblStokGirisUst.Find(id);
            //var kayitBul1 = _erp.vwStokGiris.First(x=>x.Id==id);
            tblStokGirisUst ust = kayitBul;
            txtGenelNo.Text = ust.GenelNo.ToString();
            txtCariGrup.Text = ust.tblCariGruplari.GrupAdi;
            txtAciklama.Text = ust.Aciklama;
            txtFaturaNo.Text = ust.FaturaNo;
            txtCariAdi.Text = ust.tblCariler.CariAdi;
            if (ust.FaturaTarih != null)
            {
                txtGirisTarih.Value = (DateTime)ust.FaturaTarih;
            }
            if (ust.GirisTipi != null) txtGirisTipi.SelectedIndex = ust.GirisTipi.Value;

            var alt = _erp.tblStokGirisAlt.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            Liste.Rows.Clear();
            //var alt1 = _erp.vwStokGiris.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            foreach (var k in alt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.SiraNo;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[4].Value = k.Adet;
                Liste.Rows[i].Cells[5].Value = k.Not;
                //DateTime a = Convert.ToDateTime(k.UT);
                Liste.Rows[i].Cells[6].Value = k.UT;
                Liste.Rows[i].Cells[7].Value = k.SKT;
                Liste.Rows[i].Cells[8].Value = k.AlisFiyat;
                Liste.Rows[i].Cells[9].Value = k.Id;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
        }

        #endregion

        #region DataGridView Duzenlemeleri
        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox txt = e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex == 2 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(MyArray);
                }
                else if (Liste.CurrentCell.ColumnIndex != 2 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }
                TextBox tekst = e.Control as TextBox;
                tekst.CharacterCasing = CharacterCasing.Upper;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    foreach (DataGridViewCell cell in Liste.SelectedCells)
                    {
                        int i = 0;
                        if (cell.Value != null)
                        {
                            if (Liste.CurrentCell != null)
                            {
                                string a = Liste.CurrentRow.Cells[2].Value.ToString();
                            }
                            try
                            {
                                string a = Liste.CurrentRow.Cells[2].Value.ToString();
                                var lst = (from s in _erp.tblUrunler
                                           where s.UrunKodu == a
                                           select s).First();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Urun kodu bos olmamali!!!");
                            if (Liste.CurrentRow != null)
                            {
                                Liste.CurrentRow.Cells[2].Value = "";
                            }
                        }
                        i++;
                    }
                }

                if (e.ColumnIndex == 6)
                {
                    if (Liste.CurrentRow.Cells[6].Value != null)
                    {
                        string urn = Liste.CurrentRow.Cells[2].Value.ToString();
                        var lst = (from s in _erp.tblUrunler
                                   where s.UrunKodu == urn
                                   select s).FirstOrDefault();
                        int ayy = Convert.ToInt32(lst.KullanimSuresiAy.Value);

                        DateTime ay = Convert.ToDateTime(Liste.CurrentRow.Cells[6].Value);
                        Liste.CurrentRow.Cells[7].Value = ay.AddMonths(ayy).ToShortDateString();
                    }
                }


            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }



        #endregion

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void KayitIdBul()
        {
            _secimId = (int)Liste.CurrentRow.Cells[9].Value;
            if (_secimId > 0)
            {
                Home.Aktarma = _secimId;
                f.StokGirisGuncelle();
            }

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = Liste.CurrentRow.Cells[2].Value.ToString();
            MessageBox.Show(a);
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitIdBul();
            Listele();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Listele()
        
        {
            ErpProject102Entities db = new ErpProject102Entities();
            int i = 0;
        var alt = db.tblStokGirisAlt.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
        Liste.Rows.Clear();
            //var alt1 = _erp.vwStokGiris.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
            foreach (var k in alt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.SiraNo;
                Liste.Rows[i].Cells[1].Value = k.Barkod;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
                Liste.Rows[i].Cells[4].Value = k.Adet;
                Liste.Rows[i].Cells[5].Value = k.Not;
                //DateTime a = Convert.ToDateTime(k.UT);
                Liste.Rows[i].Cells[6].Value = k.UT;
                Liste.Rows[i].Cells[7].Value = k.SKT;
                Liste.Rows[i].Cells[8].Value = k.AlisFiyat;
                Liste.Rows[i].Cells[9].Value = k.Id;
                i++;
            }

    Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;}
    }
}
