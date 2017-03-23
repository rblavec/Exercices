using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution
{
    class Program
    {
        static void Main(string[] args)
        {
         
                13          string[] tabEssai = { "Vert", "Bleu", "Rouge", "Jaune" };
                14          AfficherTableau(tabEssai);
                15          string[] tabTrié = TrierTableau(tabEssai);
                16          AfficherTableau(tabTrié);
                17


18          Console.ReadKey();
                19      }
            20


21      static void AfficherTableau(string[] tab) 
22      {
                23          for (int i = 0; i < tab.Length; i++)
                    24          {
                    25              Console.Write(tab[i] + ", ");
                    26          }
                27          Console.WriteLine();
                28      }
            29


30      static string[] TrierTableau(string[] tabEntrée) 
31      {
                32          string[] tab = new string[tabEntrée.Length];
                33


34          for (int i = 0; i < tabEntrée.Length; i++)
                    35          {
                    36              tab[i] = tabEntrée[i];
                    37          }
                38


39          bool auMoinsUnePermut = true;
                40


41          while (auMoinsUnePermut == true)
                    42          {
                    43              auMoinsUnePermut = false;
                    44              for (int i = 0; i < tab.Length; i++)
                        45              {
                        46                  if (i == 0) continue;
                        47
                        

48                  int resComp = tab[i - 1].CompareTo(tab[i]);
                        49                  if (resComp > 0)
                            50                  {
                            51                      string temp = tab[i];
                            52                      tab[i] = tab[i - 1];
                            53                      tab[i - 1] = temp;
                            54                      auMoinsUnePermut = true;
                            55                  }
                        56              }
                    57          }
                58


59          return tab;
                60      }
            61  } 
62 }

}
    }
}
