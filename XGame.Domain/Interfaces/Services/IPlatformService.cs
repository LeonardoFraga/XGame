using XGame.Domain.Arguments.Platform;

namespace XGame.Domain.Interfaces.Services
{
    public interface IPlatformService
    {
        AddPlatformReponse AddPlatform(AddPlatformRequest request);
    }
}
