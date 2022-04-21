using Patterns.Decorator.Abstraction;
using System.Diagnostics;

namespace Patterns.Decorator.Concrete
{
    public class AccountServiceLoggingDecorator : IAccountService
    {
        private readonly AccountService _accountService;

        public AccountServiceLoggingDecorator(AccountService accountService)
        {
            _accountService = accountService;
        }

        public void DecreaseQuantity()
        {
            // you can implement something here before to call the target action
            Stopwatch stopwatch = Stopwatch.StartNew();

            _accountService.DecreaseQuantity();

            stopwatch.Stop();
        }
    }
}
