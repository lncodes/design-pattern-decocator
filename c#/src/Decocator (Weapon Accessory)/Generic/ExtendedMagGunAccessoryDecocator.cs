namespace Lncodes.DesignPattern.Decocator
{
    public sealed class ExtendedMagGunAccessoryDecocator<T> : GunAccessoriesDecocator<T> where T : Gun, new()
    {
        /// <inheritdoc cref="Gun.GetReloadSpeed"/>
        public override uint GetReloadSpeed() =>
            DecoratedGun.GetReloadSpeed();

        /// <inheritdoc cref="Gun.GetRecoilControll"/>
        public override uint GetRecoilControll() =>
            DecoratedGun.GetRecoilControll();

        /// <inheritdoc cref="Gun.GetAmmountOfMagazine"/>
        public override uint GetAmmountOfMagazine() =>
            DecoratedGun.GetAmmountOfMagazine() + 10;
    }
}