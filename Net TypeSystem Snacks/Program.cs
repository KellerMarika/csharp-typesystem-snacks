//See https://aka.ms/new-console-template for more information
//using System;

ISTUZIONI CONDIZIONALI
1.L’utente inserisce due numeri in successione.	Il software stampa il maggiore.

Console.WriteLine("Inserisci 2 numeri, verrà stampato il maggiore");
int[] numbers = new int[2];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i + 1}° valore: ");
    numbers[i] = Convert.ToInt16(Console.ReadLine());
}

int? biggerNumber = null;
foreach (var currentNumber in numbers)
{
    if (!biggerNumber.HasValue || currentNumber > biggerNumber.Value)
        biggerNumber = currentNumber;
}
Console.WriteLine($"il numero maggiore è {biggerNumber}");


//2. L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Inserisci 2 prole, verranno stampate in ordine di lunghezza crescente");
string[] words = new string[2];
for (int i = 0; i < words.Length; i++)
{
    Console.Write($"{i + 1}° parola: ");
    words[i] = Console.ReadLine();
}

for (int i = 0; i < words.Length; i++)
{
    if (i + 1! <= words.Length - 1)
    {
        if (words[i].Length > words[i + 1].Length)
        {
            Console.WriteLine($"{words[i + 1]}");
            Console.WriteLine($"{words[i]}");
        }

        else
        {
            Console.WriteLine($"{words[i]}");
            Console.WriteLine($"{words[i + 1]}");
        }
    }
}

//CICLO FOR
//  3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
int[] numbersToSum = new int[10];
int sum = 0;

Console.WriteLine("Inserisci 10 valori di cui otterrai la somma:");
for (int i = 0; i < numbersToSum.Length; i++)
{
    Console.Write($"{i + 1}° valore : ");
    numbersToSum[i] = Convert.ToInt16(Console.ReadLine());
    sum += numbersToSum[i];
}
Console.WriteLine(sum);

//4.Calcola la somma e la media dei numeri da 2 a 10.
sum = 0;
int numberCounter = 0;
for (int i = 2; i < 10; i++)
{
    sum += i;
    numberCounter++;
}
Console.WriteLine($"la somma dei numeri da 2 a 10 è {sum}, mentre la media è {sum / numberCounter}");

OPERATORE MODULO
5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
Console.WriteLine("Scegli un numero, se sarà pari lo ristamperò altrimenti stamperò il successivo ");
int inserNumber = Convert.ToInt16(Console.ReadLine());
if (inserNumber % 2 == 0)
    Console.WriteLine($"{inserNumber} è pari");
else
    Console.WriteLine($"{inserNumber + 1} è pari");

ARRAY
6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
string[] invitati = { "Jay Gatsby", "Nick Carraway", "Daisy Buchanan", "Tom Buchanan", "Jordan Baker", "Myrtle Wilson", "George Wilson", "Meyer Wolfsheim", "Walter Perkins" };

Console.WriteLine("Inserisci il tuo nome e ti rivelerò se ti è concesso partecipare alla festa del grande Gatsby");
string username = Console.ReadLine();
if (invitati.Contains(username))
    Console.WriteLine($"prego si aggomodi {username}");
else
    Console.WriteLine($"{username}  tu non puoi passare!!! (cit)");


7.Crea un array vuoto.Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
Console.Write("Inserisci 6 numeri");
int[] oddNumbers = new int[6];
for (int i = 0; i < 6; i++)
{
    int addedN = Convert.ToInt16(Console.ReadLine();
    if (addedN % 2 != 0)
    {
        Console.Write($"{i + 1}° valore: ");
        oddNumbers[i] = addedN;
    }
}
Console.Write("i numeri dispari da te inseriti sono: ");
foreach (int n in oddNumbers)
{
    if (n != 0)
        Console.Write($"{n}, ");
}


8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
int[] integerNumbers = { 0,1,2,3,4};
int sumOfOddNumbers = 0;
Console.Write("i numeri in posizione dispari sono: [");
for (int i = 0; i < integerNumbers.Length; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{integerNumbers[i]} ");
        sumOfOddNumbers += integerNumbers[i];
    }
}
Console.WriteLine($"] la cui somma è: {sumOfOddNumbers}");


CICLO WHILE
9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
int[] numbers_while = new int[50];
int tot = 0;
while (tot < 50)
{
    int insertedNumber = Convert.ToInt16(Console.ReadLine());
    if (insertedNumber != 0)
    {
        Console.Write("inserisci un numero: ");
        tot += insertedNumber;
    }
    else
        Console.WriteLine("inserisci un dato valido!");
}


RANDOM
10.Fai inserire un numero N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.

Console.Write("scegli quanti array di numeri casuali vuoi crare: ");
int N = Convert.ToInt16(Console.ReadLine());
int[][] bigMammaArrays= new int[N][];

for (int i = 0; i < N; i++)
{
    Console.Write($"Nell'array in posizione {i} di {N} troviamo i numeri: [");
    bigMammaArrays[i] = new int[10];
   for (int j = 0; j < 10; j++)
    {
        bigMammaArrays[i][j] = (new Random()).Next(0, 100);
        if (j != 9) Console.Write($"{bigMammaArrays[i][j]}, ");
        else Console.WriteLine($"{bigMammaArrays[i][j]}]");
    }

}