namespace module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("User", "Name", false);

            Console.WriteLine("Работа непремиум-пользователя");
            user.Action();
            Console.WriteLine("Работа премиум-пользователя");
            user.BuyPremium();
            user.Action();

        }

    }
}
