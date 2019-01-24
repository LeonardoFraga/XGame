using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest : IRequest
    {
        public string email { get; set; }

        public string senha { get; set; }
    }
}
