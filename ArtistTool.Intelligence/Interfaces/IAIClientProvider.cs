namespace ArtistTool.Intelligence;

public interface IAIClientProvider
{
    IChatClient GetConversationalClient();
    IChatClient GetVisionClient();
    IImageGenerator GetImageClient();
}
