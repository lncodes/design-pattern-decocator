namespace Lncodes.DesignPattern.Decocator
{
    public sealed class FlashHidderGunAccessoryDecocator : GunAccessoriesDecocator
    {
        public FlashHidderGunAccessoryDecocator(Gun BaseGunObject) : base(BaseGunObject) { }
       
        /// <inheritdoc cref="Gun.GetReloadSpeed"/>
        public override uint GetReloadSpeed() =>
            DecoratedGun.GetReloadSpeed();

        /// <inheritdoc cref="Gun.GetRecoilControll"/>
        public override uint GetRecoilControll() =>
            DecoratedGun.GetRecoilControll() + 5;

        /// <inheritdoc cref="Gun.GetAmmountOfMagazine"/>
        public override uint GetAmmountOfMagazine() =>
            DecoratedGun.GetAmmountOfMagazine();
    }
}
