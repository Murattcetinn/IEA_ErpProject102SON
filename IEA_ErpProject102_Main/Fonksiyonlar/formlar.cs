using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Firmalar;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject102_Main.BilgiGirisIslemleri.Personeler;
using IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri;

namespace IEA_ErpProject102_Main.Fonksiyonlar
{
    class formlar
    {
        public int HastaneListesi(bool secim = false)
        {
            frmHastanelerListesi frm = new frmHastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int DoktorListesi(bool secim = false)
        {
            frmDoktorlarListesi frm = new frmDoktorlarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int FirmaListesi(bool secim = false)
        {
            frmFirmalarListesi frm = new frmFirmalarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int PersonelListesi(bool secim = false)
        {
            FrmPersonellerListesi frm = new FrmPersonellerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }
        public int StokGirisListesi(bool secim = false)
        {
            frmStokListesi frm = new frmStokListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }

            return Home.Aktarma;
        }

        public void StokGirisGuncelle()
        {
            frmStokGirisGuncelleme frm = new frmStokGirisGuncelleme();
            frm.ShowDialog();

        }
    }
}
