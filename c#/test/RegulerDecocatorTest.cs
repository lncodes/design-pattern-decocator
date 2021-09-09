using Xunit;
using System.Collections.Generic;

namespace Lncodes.DesignPattern.Decocator.Test
{
    public sealed class RegulerDecocatorTest
    {
        [Theory]
        [ClassData(typeof(DecocatorTheoryData))]
        public void Gun_Stat_ShouldEqual(GunAccessoriesDecocator decocator, IEnumerable<uint> expected)
        {
            var actual = new uint[] { decocator.GetReloadSpeed(), decocator.GetRecoilControll(), decocator.GetAmmountOfMagazine() };

            Assert.Equal(expected, actual);
        }
    }
}
