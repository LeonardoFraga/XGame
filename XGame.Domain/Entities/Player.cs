using System;

namespace XGame.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Status { get; set; }
    }
}
