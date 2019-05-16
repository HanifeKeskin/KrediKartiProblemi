using System;
using System.Collections.Generic;
using System.Text;

namespace KrediKartiProblemi1
{
    public class FactoryVisa : FactoryBase
    {
        public override IKrediKarti CreateKrediKarti()
        {
            return new Visa();
        }
    }
}
