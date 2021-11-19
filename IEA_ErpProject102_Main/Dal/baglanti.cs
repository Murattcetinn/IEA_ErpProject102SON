using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject102_Main.Entitiy;
using IEA_ErpProject102_Main.Fonksiyonlar;

namespace IEA_ErpProject102_Main.Dal
{
    public class baglanti:Form
    {
        protected ErpProject102Entities _erp = new ErpProject102Entities();
        protected ErpProject102Entities erp = new ErpProject102Entities();
        internal Numaralar _n = new Numaralar();
        protected int _secimId = -1;
        internal formlar f = new formlar();
    }
}
