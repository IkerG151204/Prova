// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Exercici 1

int primer, segon;

Console.WriteLine("Quin és el primer valor? ");
primer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Quin és el segon valor? ");
segon = Convert.ToInt32(Console.ReadLine());

if (segon != 0)
{
    Console.WriteLine("El valor de la divisió es: " + primer / segon);
}
else
{
    Console.WriteLine("El valor de la multiplicació es: " + primer * segon);
}
// Exercici 2

int tercero;
Console.WriteLine("Quin és el primer valor enter? ");
tercero = Convert.ToInt32(Console.ReadLine());
if (tercero % 2 == 0 && tercero % 3 == 0)
if (tercero%2 == 0) 
{
    Console.WriteLine("El teu número es multiple de 2 :) ");
}


else
{
    Console.WriteLine("El teu número no es multiple de 2 :( ");
}

if (tercero % 3 == 0)
    Console.WriteLine("El teu número es multiple de 3 :) ");
else
{
    Console.WriteLine("El teu número no es multiple de 3 :( ");
}

// Exercici 3
char caracter;
int CaracterEscojido;

Console.WriteLine("Posa un caracter: ");
CaracterEscojido = Convert.ToInt32(Console.ReadLine());


switch (CaracterEscojido)
{
    case int n when (n < 48):
        Console.WriteLine("És un símbol ");
        break;
    case int n when (n >= 48 && n < 58):
        Console.WriteLine("És un número ");
        break;
    default:
        Console.WriteLine("És un altre caracter ");
        break;
}

int i = 0;
while (i < 10) 
{
    Console.WriteLine(i);
    i++;
}


int passWord = 0;
while (passWord != 1111) 
{
    Console.WriteLine("Posa el password per entrar: ");
    passWord = Convert.ToInt32(Console.ReadLine());
    
}
Console.WriteLine("Password CORRECTE!!");




for (int proba = 2; proba <= 16; proba = proba +2 ) 
{
    Console.WriteLine(proba);
}

Console.WriteLine("OTRO EJERCICIO DIFERENTE ");

for (int mult5 = 5; mult5 <= 50; mult5 = mult5 +5)
{
    Console.WriteLine(mult5);
}

int files, columnes;
Console.WriteLine("Nombre de files? ");
files = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nombre de columnes? ");
columnes = Convert.ToInt32(Console.ReadLine());

for (int x = 0; x < files; x++)
{
    for (int y = 0; y < columnes; y++)
    {
        Console.Write("x");
    }
    Console.Write("\n");
}