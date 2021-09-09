namespace Lncodes.DesignPattern.Decocator
{
    public abstract class GunAccessoriesDecocator : Gun
    {
        protected readonly Gun DecoratedGun;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="baseGun"></param>
        protected GunAccessoriesDecocator(Gun baseGun) =>
            DecoratedGun = baseGun;
    }
}