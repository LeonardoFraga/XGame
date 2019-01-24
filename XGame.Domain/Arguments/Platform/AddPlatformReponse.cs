using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Platform
{
    public class AddPlatformReponse :  IResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }
    }
}
