namespace Lncodes.DesignPattern.Decocator
{
    public abstract class Gun
    {
        /// <summary>
        /// Method to get reload speed
        /// </summary>
        /// <returns cref="uint"></returns>
        public abstract uint GetReloadSpeed();

        /// <summary>
        /// Method to get recoil controll
        /// </summary>
        /// <returns cref="uint"></returns>
        public abstract uint GetRecoilControll();

        /// <summary>
        /// Method to get ammount of magizine
        /// </summary>
        /// <returns cref="uint"></returns>
        public abstract uint GetAmmountOfMagazine();
    }
}
