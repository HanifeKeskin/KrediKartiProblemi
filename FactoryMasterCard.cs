using System;
using System.Collections.Generic;
using System.Text;

namespace KrediKartiProblemi1
{
    public class FactoryMasterCard : FactoryBase
    {
        public override IKrediKarti CreateKrediKarti()
        {
            return new MasterCard();
        }
    }
}
