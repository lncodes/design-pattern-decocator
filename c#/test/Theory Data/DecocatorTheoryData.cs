using Xunit;
using System.Collections.Generic;

namespace Lncodes.DesignPattern.Decocator.Test
{
    public sealed class DecocatorTheoryData : TheoryData<GunAccessoriesDecocator, IEnumerable<uint>>
    {
        public DecocatorTheoryData()
        {
            var actualGun = new AwmGun();
            var quickDrawMagGunAccessoryDecocator = new QuickDrawMagGunAccessoryDecocator(actualGun);
            var flashHidderGunAccessoryDecocator = new FlashHidderGunAccessoryDecocator(quickDrawMagGunAccessoryDecocator);
            var extendedMagGunAccessoryDecocator = new ExtendedMagGunAccessoryDecocator(flashHidderGunAccessoryDecocator);

            Add(quickDrawMagGunAccessoryDecocator, new uint[] { 1, actualGun.GetRecoilControll(), actualGun.GetAmmountOfMagazine() });
            Add(flashHidderGunAccessoryDecocator, new uint[] { 1, 15, actualGun.GetAmmountOfMagazine() });
            Add(extendedMagGunAccessoryDecocator, new uint[] { 1, 15, 7 });
        }
    }
}
