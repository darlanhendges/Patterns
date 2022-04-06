using Patterns.ChainResponsability.Abstraction;
using Patterns.ChainResponsability.Request;

namespace Patterns.ChainResponsability.ConcreteHandlers
{
    public class UsernameValidationHandler : Handler<User>, IHandler<User>
    {
        public override void Handle(User request)
        {
            if (string.IsNullOrEmpty(request.Username) || request.Username.Trim().Length == 0)
            {
                throw new Exception("Username is invalid.");
            }

            base.Handle(request);
        }
    }
}
