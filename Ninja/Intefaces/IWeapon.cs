using System;

namespace Ninja.Intefaces
{
    public interface IWeapon
    {
        void DeliberateAttack();
        void SwiftAttack();

        // can be since since usage of this class is covered by definition of a INinja or ISuperNinja
        void SuperAttack();
    }
}