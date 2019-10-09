using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            int auswahl;
            string wiederolung;


            Console.WriteLine("1:Dezimal zu Binär");
            Console.WriteLine("2: Binär zu Dezimal");
            Console.WriteLine("3: Aktion 3");
            do
            {
                Console.WriteLine("Aktion auswählen");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                     //Umwandlung Dezimal zu Binär    
                    string eingabe, ausgabe="";
                    int dez, quotient =1, rest;

                    Console.WriteLine("Dezimahl eingabe :");
                    eingabe = Console.ReadLine();
                    dez = Convert.ToInt32(eingabe);

                    while (quotient != 0)

                    {
                        quotient = dez / 2;
                        rest = dez % 2;
                        ausgabe += Convert.ToInt32(rest);
                        dez = quotient;
                    }
                    //Ausgabe spiegeln
                    string ausgabe_R = "";
                    for (int i = ausgabe.Length - 1; i >=0; i--)
                    {
                    }
                    Console.WriteLine(eingabe + "in binär:" +ausgabe);
                }
                else if (auswahl == 2)
                {
                    string eingabe;
                    double dez = 0;
                    
                    Console.WriteLine("Binär eingabe:" );
                    eingabe = Console.ReadLine();
                    //dez = Convert.ToInt32(eingabe);

                    for(int i=0; i<eingabe.Length; i++)
                    {
                        double faktor = Convert.ToDouble(Convert.ToString(eingabe[i]));
                        double exponent = Convert.ToDouble(Convert.ToString(eingabe.Length-1-i));
                        dez += faktor * Math.Pow(2, exponent);
                    }
                    Console.WriteLine(eingabe + " in dezimal " + dez);

                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Hi");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
                Console.WriteLine("Neu Aktion wählen? (j/n)");
                wiederolung = Console.ReadLine();
            } while (wiederolung == "j");

        }

    }

    }
