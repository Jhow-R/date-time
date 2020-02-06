using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime:
             * Representa um INSTANTE;
             * É um tipo valor (struct).
             */

            RepresentandoDataHora();
            Propriedades();
            Formatacao();
            Operacoes();
            DT_Kind();
            PadraoISO8601();

            Console.ReadLine();
        }

        private static void PadraoISO8601()
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            // "Z" indica que a data/hora está em Utc, então ele transforma para local DateTime (d2.Kind)
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); 

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            // Antes de imprimir a data no formato ISO8601, é necessário garantir que ela esteja no formato universal primeiro
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); 
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
             
        }

        private static void DT_Kind()
        {
            /* DateTimeKind:  Tipo enumerado especial que define três valores possíveis para a localidade da data:
             * Local [fuso horário do sistema. Exemplo: São Paulo = GMT-3]
             * Utc [fuso horário GMT(Greenwich Mean Time)]
             * Unspecified
             */

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
        }

        private static void Operacoes()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);                   
            Console.WriteLine(d);

            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d2);

            DateTime d3 = d.AddMinutes(3);
            Console.WriteLine(d3);

            DateTime d4 = d.AddDays(7);
            Console.WriteLine(d4);

            TimeSpan t = new DateTime(2000, 10, 18).Subtract(new DateTime(2000, 10, 15));
            Console.WriteLine(t);

        }

        private static void Formatacao()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }

        private static void Propriedades()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
        }

        private static void RepresentandoDataHora()
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2020, 02, 05);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2020, 02, 05, 11, 12, 30);
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2020, 02, 05, 11, 12, 30, 500);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }
    }
}
