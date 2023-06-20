using System;
using System.Collections.Immutable;

namespace SchoolAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1. DemonstreerStudenten uitvoeren");
                Console.WriteLine("2. DemonstreerCursussen uitvoeren");
                Console.WriteLine("3. DemonstreerStudentUitTekstFormaat uitvoeren");
                Console.WriteLine("4. DemonstreerStudieProgramma uitvoeren");
                Console.WriteLine("5. DemonstreerAdministratiefPersoneel uitvoeren");
                Console.WriteLine("6. DemonstreerLectoren uitvoeren");
                Console.WriteLine("7. Student toevoegen");
                Console.WriteLine("8. Cursus toevoegen");
                Console.WriteLine("9. VakInschrijving toevoegen");
                Console.WriteLine("10. Inschrijvingsgegevens tonen");
                Console.WriteLine("11. Studenten tonen");
                Console.WriteLine("12. Cursussen tonen");
                Console.WriteLine("13. Exporteer alles");
                int keuze = Convert.ToInt32(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        Student.DemonstreerStudenten();
                        break;
                    case 2:
                        Cursus.DemonstreerCursussen();
                        break;
                    case 3:
                        Student.DemonstreerStudentUitTekstFormaat();
                        break;
                    case 4:
                        StudieProgramma.DemonstreerStudieProgramma();
                        break;
                    case 5:
                        AdministratiefPersoneel.DemonstreerAdministratiefPersoneel();
                        break;
                    case 6:
                        Lector.DemonstreerLectoren();
                        break;
                    case 7:
                        Student.LeesVanafCommandLine();
                        break;
                    case 8:
                        Cursus.LeesVanafCommandLine();
                        break;
                    case 9:
                        VakInschrijving.LeesVanafCommandLine();
                        break;
                    case 10:
                        VakInschrijving.ToonInschrijvingsGegevens();
                        break;
                    case 11:
                        Student.ToonStudenten();
                        break;
                    case 12:
                        Cursus.ToonCursussen();
                        break;
                    case 13:
                        ExporteerAlles();
                        break;

                    default:
                        break;

                }
            }

        }
        private static void ExporteerAlles()
        {
            ImmutableList<ICSVSerializable> alles = ImmutableList<ICSVSerializable>.Empty;
            alles = alles.AddRange(Cursus.AlleCursussen);
            alles = alles.AddRange(Persoon.AllePersonen);
            foreach (var item in alles)
            {
                Console.WriteLine(item.ToCSV());
            }
        }

    }
}
