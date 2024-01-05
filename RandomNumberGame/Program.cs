namespace RandomNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int randomnumber = rndm.Next(1, 100);
            int chosennumber = 0;
            int noofguesses = 0;
            bool cont = true;
            while (cont)
            {
                if(noofguesses == 5)
                {
                    Console.WriteLine("Incorrect, you have used all 5 guesses, you lose! {0}", randomnumber);
                    cont = false;
                    break;
                } else
                {
                    noofguesses++;
                    Console.WriteLine("Guest Number: {0}", noofguesses);
                    Console.Write("Guess a number between 1 and 99: ");
                    chosennumber = Convert.ToInt32(Console.ReadLine());
                    if (chosennumber == randomnumber)
                    {
                        Console.WriteLine("Congratulations, you guessed the right number");
                        cont = false;
                        break;
                    } else if (chosennumber < randomnumber)
                    {
                        Console.WriteLine("The number is bigger");
                    } else
                    {
                        Console.WriteLine("The number is smaller");
                    }
                }
            }
        }
    }
}
