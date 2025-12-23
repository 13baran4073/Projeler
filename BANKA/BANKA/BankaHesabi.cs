using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKA
{
        internal class BankaHesabi
        {
            private int bakiye;

            // Parametresiz yapıcı metot → bakiye 0 başlar
            public BankaHesabi()
            {
                bakiye = 0;
            }

            // İstersen başlangıç bakiyesiyle de açılabilsin
            public BankaHesabi(int ilkBakiye)
            {
                if (ilkBakiye < 0)
                    bakiye = 0;
                else
                    bakiye = ilkBakiye;
            }

            public bool HarcamaYap(int miktar)
            {
                if (miktar <= bakiye)
                {
                    bakiye -= miktar;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void ParaEkle(int miktar)
            {
                bakiye += miktar;
            }

            public int GetBakiye()
            {
                return bakiye;
            }
        }
}
