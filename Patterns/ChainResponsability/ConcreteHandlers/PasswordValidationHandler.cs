using Patterns.ChainResponsability.Abstraction;
using Patterns.ChainResponsability.Request;

namespace Patterns.ChainResponsability.ConcreteHandlers
{
    public class PasswordValidationHandler : Handler<User>, IHandler<User>
    {
        public override void Handle(User request)
        {
            if (request.Password == String.Empty || request.Password.Length < 10)
            {
                throw new Exception("Password is invalid.");
            }

            base.Handle(request);
        }
    }
}
