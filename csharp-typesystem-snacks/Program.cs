//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
//snack7();
//snack8();
//snack9();
//snack10();
//snack11();
//snack12();

//snack 1
void snack1()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    int sum = num1 - num2;

    if (num1 == num2)
    {
        Console.WriteLine("Numbers are equal");
    }
    else
    {
        Console.WriteLine(sum);
    }
}


//snack 2

void snack2()
{
    string str1 = Console.ReadLine() ?? "";
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length > str2.Length)
    {
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
    else
    {
        Console.WriteLine(str2);
        Console.WriteLine(str1);
    }
}


//sack 3
void snack3()
{
    int somma = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Inserisci il numero {i + 1}: ");
        int numero = int.Parse(Console.ReadLine());
        somma += numero;
    }
    Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");
}



//snack 4

void snack4()
{
    int sum = 0;
    double average = 0;

    for (int i = 2; i <= 10; i++)
    {
        sum += i;
    }
    average = (double)sum / 9;
    Console.WriteLine($"la somma dei numeri da 2 a 10 e': {sum}");
    Console.WriteLine($"la media dei numeri da 2 a 10 e': {average}");
}

//snack 5

void snack5()
{
    Console.Write("Scrivi un numero: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine($"OK il numero: {num} e' pari ");
    }
    else
    {
        Console.WriteLine($"il numero: {num} e' dispari, il numero pari successivo e': {num + 1}");
    }
}



//snack 6

void snack6()
{
    string[] nomi = { "Franco", "Giulio", "Maria", "Alessio" };
    Console.Write("Inserisci un nome: ");
    string nomeDaCercare = Console.ReadLine();
    bool trovato = false;
    for (int i = 0; i < nomi.Length; i++)
    {
        if (nomi[i] == nomeDaCercare)
        {
            trovato = true;
            break;
        }
    }

    if (trovato)
    {
        Console.WriteLine("OK, sei nella lista puoi entreare");
    }
    else
    {
        Console.WriteLine("NO, non sei nella lista non puoi entrare");
    }
}



//snack 7

void snack7()
{
    int[] numeriDispari = new int[0];

    for (int i = 0; i < 6; i++)
    {
        Console.Write("Inserisci un numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 != 0)
        {
            Array.Resize(ref numeriDispari, numeriDispari.Length + 1);
            numeriDispari[numeriDispari.Length - 1] = numero;
        }
    }
    Console.Write("Numeri dispari inseriti nell'array: ");
    for (int i = 0; i < numeriDispari.Length; i++)
    {
        Console.Write(numeriDispari[i] + " ");
    }
}



//snack 8

void snack8()
{
    int[] numeri = { 3, 7, 9, 2, 5, 8, 4, 6, 1 };
    int somma = 0;

    for (int i = 1; i < numeri.Length; i += 2)
    {
        somma += numeri[i];
    }
    Console.WriteLine("La somma dei numeri in posizione dispari è: " + somma);
}

//snack 9

void snack9()
{
    int[] numeri = new int[0];
    int somma = 0;

    while (somma < 50)
    {
        Console.Write("Inserisci un numero: ");
        int numero = int.Parse(Console.ReadLine());

        Array.Resize(ref numeri, numeri.Length + 1);
        numeri[numeri.Length - 1] = numero;
        somma += numero;
    }

    Console.WriteLine("Hai inserito i seguenti numeri:");
    for (int i = 0; i < numeri.Length; i++)
    {
        Console.Write(numeri[i] + " ");
    }
    Console.WriteLine();
}


//snack 10


void snack10()
{
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num}; ");
        }

        Console.WriteLine();
    }
}


//snack 11

void snack11()
{
    Console.Write("Inserisci la prima parola: ");
    string primaParola = Console.ReadLine();

    Console.Write("Inserisci la seconda parola: ");
    string secondaParola = Console.ReadLine();

    if (HannoLaStessaLunghezza(primaParola, secondaParola))
    {
        Console.WriteLine($"Le due parole inserite ({primaParola} e {secondaParola}) SI, hanno la stessa lunghezza.");
        Console.WriteLine($"Le parole inserite sono: {primaParola}, {secondaParola}");
    }
    else
    {
        string parolaPiuLunga = TrovaParolaPiuLunga(primaParola, secondaParola);
        Console.WriteLine($"Le parole inserite ({primaParola} e {secondaParola}) NO, non hanno la stessa lunghezza.");
        Console.WriteLine($"La parola più lunga è: {parolaPiuLunga}");
    }
}

static bool HannoLaStessaLunghezza(string primaParola, string secondaParola)
{
    return primaParola.Length == secondaParola.Length;
}

static string TrovaParolaPiuLunga(string primaParola, string secondaParola)
{
    if (primaParola.Length >= secondaParola.Length)
    {
        return primaParola;
    }
    else
    {
        return secondaParola;
    }
}


//snack 12

void snack12()
{
    Console.Write("Inserisci un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Il numero è pari");
    }
    else
    {
        Console.WriteLine("Il numero è dispari");
    }
}