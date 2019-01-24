using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Platform
{
    public class AddPlatformRequest : IRequest
    {
        public string Name { get; set; }
    }
}
