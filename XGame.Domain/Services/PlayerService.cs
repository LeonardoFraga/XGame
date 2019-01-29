using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;

namespace XGame.Domain.Services
{
    public class PlayerService : Notifiable, IPlayerService
    {
        private readonly IPlayerRepository _playerService;

        public PlayerService(IPlayerRepository playerService)
        {
            _playerService = playerService;
        }

        public AddPlayerResponse AddPlayer(AddPlayerRequest request)
        {
            Guid id = _playerService.AddPlayer(request);

            return new AddPlayerResponse { Id = id, Message = "Success" };
        }

        public AuthenticatePlayerReponse AuthenticatePlayer(AuthenticatePlayerRequest request)
        {
            if (request == null)
            {
                AddNotification("AuthenticatePlayerRequest", 
                    string.Format(NotificationMessages.X0_IS_MANDATORY, nameof(AuthenticatePlayerRequest)));
            }

            var response = _playerService.AuthenticatePlayer(request);
            //AddNotifications(Player)

            return response;

        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
