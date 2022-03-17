using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_10._1_Lukujen_summa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tehtävä 10 vaihe 1");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Anna kokonaislukuja, niin lasken summan realiajassa.");            
           int i = 0;//Lisätään muuttujat
           int luku = 0;//Käyttäjälle
           int summa = 0;// Eli Summa on 10 + Anna 2. luku?10 sit onkin luku 30:ä

            while (luku < 100)//luku kun on 100 loppuu
            {
             i = i + 1;//0 lisätty 1:si
             Console.Write("Anna " + i + ". luku? ");// +i+ nappaa ja vaihtaa 1 2:si eli Anna 1.luku ja Anna 2.luku              
             summa = int.Parse(Console.ReadLine());// Käyttäjä syöttämä luku Anna 1. luku? vaikka 10 eli summa +
             luku += summa;//Tässä kohtaan luvulle(luku) lisätään käyttäjän syöttämä luku  
             Console.WriteLine("Summa on nyt" + " " +luku );//Jotta summa tulisi olee viakka 20.Nyt jo laskee käyttäjän
                                                            //syöttämän kokonaisluvun ja summa on nyt yhteensä
            }           
            Console.WriteLine( "Raja on saavutettu!");//Kun 100 on täyttynyt ja luuppi pysähtyy, ilmestyy tuo teksti
        }
    }
}
