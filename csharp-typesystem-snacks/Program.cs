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
