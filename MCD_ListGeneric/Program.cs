using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList Generic versiyonu

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            //<T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek.

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);
            listeGeneric.Add(3);

            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Ali Mert");
            isimler.Add("Esra");
            isimler.Add("Hakan");

            foreach (string item in isimler)
            {
                Console.WriteLine(item);
            }

            List<Musteri> musteriListe = new List<Musteri>();
            musteriListe.Add(new Musteri()
            {
                id = 1,
                isim = "faik",
                soyisim = "turan"
            });
            musteriListe.Add(new Musteri()
            {
                id = 2,
                isim = "yeşim",
                soyisim = "salkım"
            });
            musteriListe.Add(new Musteri()
            {
                id = 5,
                isim = "hakan",
                soyisim = "taşıyan"
            });

            foreach (Musteri item in musteriListe)
            {
                Console.WriteLine(item.id + "\t" + item.isim + "\t" + item.soyisim);
            }
        }
    }
}
