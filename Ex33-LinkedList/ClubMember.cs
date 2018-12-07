using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_LinkedList
{
    public class ClubMember
    {
        private int nr;
        private string fnavn;
        private string lnavn;
        private int alder;

        public int Nr { get { return nr; } set { nr = value; } }
        public string FNavn { get { return fnavn; } set { fnavn = value; } }
        public string LNavn { get { return lnavn; } set { lnavn = value; } }
        public int Alder { get { return alder; } set { alder = value; } }


        public ClubMember(int Nr, string FNavn, string LNavn, int Alder)
        {
            nr = Nr;
            fnavn = FNavn;
            lnavn = LNavn;
            alder = Alder;
        }


        public override string ToString()
        {
            return $"{Nr} {FNavn} {LNavn} {Alder}";
        }
    }
}
