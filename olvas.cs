using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D241007_13B_Vinklárik_Péter_CS3
{
    internal class olvas
    {
        public string Nev { get; set; }
        public int SzulEv { get; set; }
        public int Rajtszam { get; set; }
        public string FvN {  get; set; }
        public string Eletkor { get; set; }
        public Dictionary <string, DateTime> Idoeredmeny { get; set; }

        public override string ToString()
        {
            return $"\tNev: {Nev}\n" +
                $"\tSzulEv: {SzulEv}" +
                $"\tRajtszam: {Rajtszam}" +
                $"\tFérfi vagy Nő: {FvN}" +
                $"\tÉletkor: {Eletkor}" +
                $"\tIdoeredmények: "+
                $"a: {Idoeredmeny["úszás ideje"]}"+
                $"b: {Idoeredmeny["első depóba töltött idő"]}"+
                $"c: {Idoeredmeny["kerékpározás ideje"]}"+
                $"d: {Idoeredmeny["második depóba töltött idő"]}"+
                $"e: {Idoeredmeny["futás ideje"]}";
        }
        public olvas(string row) 
        {
            var v = row.Split(';');
             Nev = v[0];
            SzulEv = int.Parse(v[1]);
            Rajtszam = int.Parse(v[2]);
            FvN = v[3];
            Eletkor = v[4];
            Idoeredmeny = new()
            {
                { "úszás ideje", DateTime.Parse(v[5])},
                { "első depóba töltött idő", DateTime.Parse(v[6])},
                { "kerékpározás ideje", DateTime.Parse (v[7])},
                {"második depóban töltött idő", DateTime.Parse(v[8])},
                {"futás ideje", DateTime.Parse(v[9])},
            };
        }
    }
}
