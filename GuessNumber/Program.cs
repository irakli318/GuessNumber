Console.WriteLine("Gamoicani ricxvi");
Random rnd = new Random();
var ranNumber = rnd.Next(10,20);
var maxAttemps = 1;
bool Guess = false;
while(Guess != true)
{
    Console.WriteLine("Shemoikvanet ricxvi");
    {
        var Number = int.Parse(Console.ReadLine());
        if(Number < ranNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Guess = false;
            maxAttemps++;
            Console.WriteLine("Meti");
            Console.ResetColor();
        }
        else if (Number > ranNumber)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Guess = false;
            maxAttemps++;
            Console.WriteLine("Naklebi");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Guess = true;
            maxAttemps++;
            Console.WriteLine($"Gilocavt tqven gamoicanit chafiqrebuli ricxvi \n {maxAttemps}- mcdelobashi");
            Console.ResetColor();
        }
    }
}