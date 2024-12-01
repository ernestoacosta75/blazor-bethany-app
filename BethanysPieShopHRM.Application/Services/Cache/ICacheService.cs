namespace BethanysPieShopHRM.Application.Services.Cache
{
    public interface ICacheService
    {
        void Set<T>(string key, T value, TimeSpan expiration);
        bool TryGet<T>(string key, out T value);
        void Remove(string key);
    }
}
