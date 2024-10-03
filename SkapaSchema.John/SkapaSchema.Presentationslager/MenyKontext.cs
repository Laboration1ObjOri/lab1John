using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkapaSchema.Affärslager;
using SkapaSchema.Presentationslager;
using SkapaSchema.Presentationslager.Menyer;

namespace SkapaSchema.Presentationslager
{
    public class MenyKontext
    {
        public SchemaKontroller SchemaKontroller { get; private set; }

        private Meny meny = null;

        public MenyKontext()
        {
            SchemaKontroller = new SchemaKontroller();
        }
        public void SättMeny(Meny meny)
        {
            this.meny = meny;
        }
        public void VisaMeny()
        {
            meny.VisaMeny(this);
        }
    }
}
