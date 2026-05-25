using System;
class Program
{
    static void Main(string[] args)
    {
        //Bool som håller programmet igång
        bool körProgram = true;
        //While loop som fortsätter tills användaren avslutar programmet
        while (körProgram)
        {
            //Skriver ut huvudmenyn
            Console.WriteLine(" HUVUDMENY ");
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Sällskap");
            Console.WriteLine("3. Upprepa tio gånger");
            Console.WriteLine("4. Det tredje ordet");
            Console.WriteLine("0. Avsluta");
            // Läser användarens menyval
            string val = Console.ReadLine();
            // Switch sats som kontrollerar användarens val
            switch (val)
            {
               // Menyval 1,Kontrollera biljettpris för en person
                case "1":
                    Console.WriteLine("Ange din ålder:");

                    // Läser användarens input
                    string ålderInput = Console.ReadLine();

                    // Validerar input med TryParse 
                    // Programmet kontrollerar om användaren skrivit ett nummer
                    bool giltigÅlder = int.TryParse(ålderInput, out int ålder);

                    // Om användaren inte skriver ett giltigt nummer
                    if (!giltigÅlder)
                    {
                        Console.WriteLine("Fel input. Du måste skriva ett nummer.");
                    }
                    else
                    {
                        if (ålder < 20)
                        {
                            Console.WriteLine("Ungdomspris: 80kr");
                        }
                        else
                        {
                        // Nästlad if-sats som kontrollerar pensionär
                            if (ålder > 64)
                            {
                                Console.WriteLine("Pensionärspris: 90kr");
                            }
                            else
                            {
                                Console.WriteLine("Standardpris: 120kr");
                            }
                        }
                    }

                    break;

                // Menyval 2 Räkna pris för ett helt sällskap
                case "2":

                    Console.WriteLine("Hur många personer är ni?");
                    // Läser antal personer
                    string antalInput = Console.ReadLine();

                    int antalPersoner = int.Parse(antalInput);

                    int totalPris = 0;
                    // For loop som körs en gång för varje person
                    for (int i = 1; i <= antalPersoner; i++)
                    {
                        Console.WriteLine("Ange ålder för person " + i + ":");

                        string personÅlderInput = Console.ReadLine();

                        int personÅlder = int.Parse(personÅlderInput);

                        if (personÅlder < 20)
                        {
                            totalPris += 80;
                        }
                        else if (personÅlder > 64)
                        {
                            totalPris += 90;
                        }
                        else
                        {
                            totalPris += 120;
                        }
                    }
                    // Skriver ut antal personer
                    Console.WriteLine("Antal personer: " + antalPersoner);
                    // Skriver ut totalkostnad
                    Console.WriteLine("Totalkostnad: " + totalPris + "kr");

                    break;

                // Menyval 3 Upprepa text tio gånger
                case "3":
                    Console.WriteLine("Skriv en text:");

                    string input = Console.ReadLine();

                    // For loop som upprepar texten tio gånger
                    for (int i = 1; i <= 10; i++)
                    {
                       // Skriver ut text utan radbrott
                        Console.Write(i + ". " + input + " ");
                    }
                    // Skapar ny rad efter loopen
                    Console.WriteLine();

                    break;

                // Menyval 4 Visa tredje ordet
                case "4":

                    Console.WriteLine("Skriv en mening med minst tre ord:");

                    var mening = Console.ReadLine();
                    // Delar upp meningen vid varje mellanslag
                    var ord = mening.Split(' ');
                    // Skriver ut det tredje ordet
                    Console.WriteLine("Det tredje ordet är: " + ord[2]);

                    break;

                // Menyval 0 Avsluta programmet
                case "0":
                    // Stoppar while loopen
                    körProgram = false;
                    Console.WriteLine("Programmet avslutas.");
                    break;

                // Om användaren skriver fel input
                default:
                    Console.WriteLine("Felaktig input.");
                    break;
            }

            Console.WriteLine();
        }

    }
}