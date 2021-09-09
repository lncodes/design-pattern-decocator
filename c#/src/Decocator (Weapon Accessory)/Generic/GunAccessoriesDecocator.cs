namespace Lncodes.DesignPattern.Decocator
{
    public abstract class GunAccessoriesDecocator<T> : Gun where T : Gun, new()
    {
        protected readonly T DecoratedGun = new T();
    }
}