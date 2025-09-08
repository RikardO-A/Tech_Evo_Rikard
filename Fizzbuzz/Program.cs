//Fizzbuzz
// Delbart med 3. print Fizz
//Delbart med 5, print Buzz
//Om båda, fizzbuzz
//1-100
// OM x/3 = heltal, print Fizz
// OM x/5 = heltall, print Buzz
// OM x/3 && x/5 = heltal, print FizzBuzz
//For i - X


for (int x = 1; x <= 100; x++)
{
    int modulo3 = x % 3;
    int modulo5 = x % 5;

    if (modulo3 == 0 && modulo5 == 0)
        Console.WriteLine("FizzBuzz");
    else if (modulo3 == 0)
        Console.WriteLine("Fizz");
    else if (modulo5 == 0)
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(x);
}
