using System;

namespace Ninja.Intefaces
{
    public interface INinja
    {
        IWeapon CurrentWeapon { get; set; }

        void ChangeWeapon(IWeapon weapon);
        void DeliberateAttack();
        void SwiftAttack();

        void Rest();
        void Wake();
    }
}