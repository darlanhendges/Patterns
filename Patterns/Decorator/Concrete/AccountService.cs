using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
    public class AccountService : IAccountService
    {
        public int QuantityAvailable { get; set; }

        public AccountService(int quantity)
        {
            QuantityAvailable = quantity;
        }

        public void DecreaseQuantity()
        {
            Thread.Sleep(2000);

            if (QuantityAvailable > 0)
                QuantityAvailable -= 1;
            else
                throw new Exception("Invalid quantity to decrease.");

            Console.WriteLine($"Quantity Available: {QuantityAvailable}");
        }
    }
}
