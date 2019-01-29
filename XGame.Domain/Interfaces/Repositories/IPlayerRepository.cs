using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        AuthenticatePlayerReponse AuthenticatePlayer(Player request);

        Guid AddPlayer(AddPlayerRequest request);
    }
}
