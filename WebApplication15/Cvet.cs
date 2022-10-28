using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication15
{
    public class Cvet
    {
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Dobavljac { get; set; }
        public string imageURL { get; set; }

        public Cvet(string line)
        {
            string[] podaci = line.Split('|');
            Naziv = podaci[0];
            Vrsta = podaci[1];
            Dobavljac = podaci[2];
            imageURL = podaci[3];
        }

        public Cvet()
        { }

        public static List<Cvet> PreuzmiSve()
        {
            List<Cvet> cvetovi = new List<Cvet>();

            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~/cvecara.txt")))
            {
                try
                {
                    string line = sr.ReadLine();
                    while (!string.IsNullOrEmpty(line))
                    {
                        Cvet cvet = new Cvet(line);
                        cvetovi.Add(cvet);
                        line = sr.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return cvetovi;
        }
        public static void DodajNovi(string line)
        {
            using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath("~/cvecara.txt"), true))
            {
                try
                {
                    sw.WriteLine(line);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}