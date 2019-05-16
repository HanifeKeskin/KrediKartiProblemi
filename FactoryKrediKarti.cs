using System;
using System.Collections.Generic;
using System.Text;

namespace KrediKartiProblemi1
{
    public class FactoryKrediKarti
    {
        public static FactoryBase GetFactoryKrediKarti(string KrediKartiTuru)
        {
            if (KrediKartiTuru.ToUpper() == "MASTERCARD")
            {
                return new FactoryMasterCard();
            }
            else if (KrediKartiTuru.ToUpper() == "VİSA")
            {
                return new FactoryVisa();
            }
            else if (KrediKartiTuru.ToUpper() == "AMERİCANEXPRESS")
            {
                return new FactoryAmericanExpress();
            }
            else
            {
                throw new NotSupportedException("Desteklenmeyen Kredi Kartı Türü..");
            }

        }
    }
}
