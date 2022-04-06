using Patterns.ChainResponsability.ConcreteHandlers;
using Patterns.ChainResponsability.Request;

namespace Patterns.ChainResponsability
{
    public class ChainRegistrationProcessor
    {
        public void Register(User user)
        {
            var handler = new UsernameValidationHandler()
                        .SetNext(new PasswordValidationHandler())
                        .SetNext(new OnlyAdultValidationHandler());

            handler.Handle(user);
        }
    }
}
