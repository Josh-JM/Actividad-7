
static double Uno = 0;
double Dos = 0;
double Tres = 0;
double Cuatro = 0;
double Cinco = 0;
double Resultado = 0;

static void IngresarNumeros()
{
    Console.WriteLine("Ingresa el Primer Número");
    Uno = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el Segundo Número");
    Dos = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el Tercer Número");
    Tres = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el Cuarto Número");
    Cuatro = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el Quinto Número");
    Cinco = Convert.ToDouble(Console.ReadLine());
}

static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("...::MENÚ::...");
    Console.WriteLine("1. Pedir Números");
    Console.WriteLine("2. Media");
    Console.WriteLine("3. Mediana");
    Console.WriteLine("4. Desviación Estándar");
    Console.WriteLine("5. Salir");

}

static double Media(double Uno, double Dos, double Tres, double Cuatro, double Cinco)
{
    return (Uno + Dos + Tres + Cuatro + Cinco) / 5;
}

bool ContinuarMenu = true;

while (ContinuarMenu)
{
    MostrarMenu();
    int Opcion = int.Parse(Console.ReadLine());

    switch (Opcion)
    {
        case 1:
            Console.Clear();
            IngresarNumeros();
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Resultado = Media(Uno, Dos, Tres, Cuatro, Cinco);
            Console.WriteLine(Resultado);
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.ReadKey();
            break;
        case 4:
            Console.Clear();
            Console.ReadKey();
            break;
    }
}