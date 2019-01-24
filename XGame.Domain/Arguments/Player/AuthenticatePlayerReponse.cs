using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerReponse : IResponse
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
