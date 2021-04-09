using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyo_Olli_Rautiainen
{

    public struct OtteluTilasto
    {
        public string aika;
        public string Aika { get { return aika; } }
        public string joukkue;
        public string Joukkue { get { return joukkue; } }
        public string maali;
        public string Maali { get { return maali; } }
        //maalintekijä
        public string etunimi;
        public string Etunimi { get { return etunimi; } }
        public string sukunimi;
        public string Sukunimi { get { return sukunimi; } }
        public string numero;
        public string Numero { get { return numero; } }
        //syöttäjä 1
        public string syottaja1;
        public string Syottaja1 { get { return syottaja1; } }
        public string s1etunimi;
        public string EtunimiS1 { get { return s1etunimi; } }
        public string s1sukunimi;
        public string SukunimiS1 { get { return s1sukunimi; } }
        public string s1numero;
        public string NumeroS1 { get { return s1numero; } }
        //syöttäjä 2
        public string syottaja2;
        public string Syottaja2 { get { return syottaja2; } }
        public string s2etunimi;
        public string EtunimiS2 { get { return s2etunimi; } }
        public string s2sukunimi;
        public string SukunimiS2 { get { return s2sukunimi; } }
        public string s2numero;
        public string NumeroS2 { get { return s2numero; } }

        public string alkuaika;
        public string PeliAlkanut { get { return alkuaika; } }

        public string loppuaika;
        public string PeliPäättynyt { get { return loppuaika; } }

    }

    public struct JoukkueTilasto
    {
        public string laji;
        public string Laji { get { return laji; } }
        public string joukkue;
        public string Joukkue { get { return joukkue; } }
        public string tulos;
        public string Tulos { get { return tulos; } }
        public string maalit;
        public string Maalit { get { return maalit; } }
        public string syotot;
        public string Syotot { get { return syotot; } }
        public string aika;
        public string Aloitusaika { get { return aika; } }
    }


}
