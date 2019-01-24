using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class PlayerService : IPlayerService
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
                throw new ArgumentNullException("AuthenticatePlayerRequest is mandatory.");
            }

            if (string.IsNullOrEmpty(request.senha))
            {
                throw new ArgumentException($"The field {nameof(request.senha)} is required.");
            }

            if (request.senha.Length <= 6)
            {
                throw new ArgumentException($"The field {nameof(request.senha)} must have six characters or more.");
            }

            if (string.IsNullOrEmpty(request.email))
            {
                throw new ArgumentException($"The field {nameof(request.email)} is required.");
            }

            if (IsEmail(request.email))
            {
                throw new ArgumentException($"The field {nameof(request.email)} isn't a valid e-mail");
            }

            var response = _playerService.AuthenticatePlayer(request);

            return response;

        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
