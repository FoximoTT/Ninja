using Ninja.Intefaces;
using Ninja.Model.Weapon;

namespace Ninja.Model
{
    public class Ninja : INinja
    {
        public IWeapon currentWeapon;

        public Ninja()
        {
            //Better. Might add some validation logic latter, like weight limits...
            ChangeWeapon(new EmptyHands());
        }

        public void ChangeWeapon(IWeapon weapon)
        {
            currentWeapon = weapon;
        }

        public void DeliberateAttack()
        {
            currentWeapon.DeliberateAttack();
        }

        public void SwiftAttack()
        {
            currentWeapon.SwiftAttack();
        }
    }
}