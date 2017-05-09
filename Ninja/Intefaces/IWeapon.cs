using System;

namespace Ninja.Intefaces
{
    /// <summary>
    /// Implements IAdvancedCombat interface since all weapons can execute all kinds of attacks
    /// which are restriced just by character class executing it (i.e. ninja or masterninja)
    /// </summary>
    public interface IWeapon : IAdvancedCombat
    {
    }
}