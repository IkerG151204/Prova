// See https://aka.ms/new-console-template for more information

Console.WriteLine("Posa un numero del 1 al 4:");
int exercici1 = Convert.ToInt32(Console.ReadLine());
switch (exercici1)
{
    case 1:
        Console.WriteLine("Posa la teva edat: ");
        int Edat = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Posa el teu pes: ");
        int pes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Posa la teva alçada: ");
        int alçada = Convert.ToInt32(Console.ReadLine());

        int alçada2 = alçada + alçada;
        int IMC = pes / alçada2;

        if (IMC < 22.0)
        {
            if (Edat < 45)
            {
                Console.WriteLine("BAJO");
            }
            else
            {
                Console.WriteLine("MEDIO");
            }
        }
        else
        {
            if (IMC > 22.0)
            {
                if (Edat > 45)
                {
                    Console.WriteLine("MEDIO");
                }
                else
                {
                    Console.WriteLine("ALTO");

                }
            }
        }
        break;

    case 2:
        Console.WriteLine("Posa el teu nom: ");
        string Nom = Console.ReadLine();
        Console.WriteLine("Posa el teu pes en KG: ");
        int Pes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Posa la teva alçada: ");
        int Alçada3 = Convert.ToInt32(Console.ReadLine());

        double Pesenlliure = Pes / 0.453559237;

        double Peu = Alçada3 / 30;
        double Polçades = Peu * 30;
        double Polçades2 = Alçada3 - Polçades;
        double Polçades3 = Math.Round(Polçades2 / 2.54);
        double Total = Peu + Polçades3;
      
        Console.WriteLine("El teu pes en lliures serà: " + Pesenlliure + " Lbs");
        Console.WriteLine("La teva alçada en peus serà: " + Peu);
        Console.WriteLine("La teva alçada en polçades serà: " + Polçades3);
        Console.WriteLine("EL teu pes és: " + Peu + "," + Polçades3);

        break;
    case 3:

        break;
}









