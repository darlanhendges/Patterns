using Patterns.ChainResponsability.Abstraction;
using Patterns.ChainResponsability.Request;

namespace Patterns.ChainResponsability.ConcreteHandlers
{
    public class OnlyAdultValidationHandler : Handler<User>, IHandler<User>
    {
        public override void Handle(User request)
        {
            if (request.BirthDate.Year > DateTime.Now.Year - 18)
            {
                throw new Exception("Age under 18 is not allowed.");
            }

            base.Handle(request);
        }
    }
}
