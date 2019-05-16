using System;
using System.Collections.Generic;
using System.Text;

namespace KrediKartiProblemi1
{
    public class FactoryAmericanExpress : FactoryBase
    {
        public override IKrediKarti CreateKrediKarti()
        {
            return new AmericanExpress();
        }
    }
}
