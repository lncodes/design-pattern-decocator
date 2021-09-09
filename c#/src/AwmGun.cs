namespace Lncodes.DesignPattern.Decocator
{
    public sealed class AwmGun : Gun
    {
        /// <inheritdoc cref="Gun.GetReloadSpeed"/>
        public override uint GetReloadSpeed() =>
            3;

        /// <inheritdoc cref="Gun.GetRecoilControll"/>
        public override uint GetRecoilControll() =>
            10;
        
        /// <inheritdoc cref="Gun.GetAmmountOfMagazine"/>
        public override uint GetAmmountOfMagazine() =>
            5;
    }
}
