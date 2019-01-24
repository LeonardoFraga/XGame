using System;
using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
    public interface IPlayerService
    {
        AuthenticatePlayerReponse AuthenticatePlayer(AuthenticatePlayerRequest request);

        AddPlayerResponse AddPlayer(AddPlayerRequest request);
    }
}
