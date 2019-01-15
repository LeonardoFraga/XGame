using System;

namespace XGame.Domain.Entities
{
    public class MyGame
    {
        public Guid Id { get; set; }

        public GamePlatform GamePlatform { get; set; }

        public bool IsDesired { get; set; }

        public DateTime DateDesired { get; set; }

        public bool IsExchangeable { get; set; }

        public bool OnSale { get; set; }
    }
}
