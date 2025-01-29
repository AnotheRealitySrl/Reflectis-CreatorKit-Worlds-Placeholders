namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public interface INetworkPlaceholder
    {
        bool IsNetworked { get; set; }
        int InitializationId { get; set; }
    }
}
