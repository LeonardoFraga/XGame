using System;
using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        AuthenticatePlayerReponse AuthenticatePlayer(AuthenticatePlayerRequest request);

        Guid AddPlayer(AddPlayerRequest request);
    }
}
