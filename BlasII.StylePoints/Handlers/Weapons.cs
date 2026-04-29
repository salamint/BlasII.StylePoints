using BlasII.Framework.WeaponEvents.Events;
using Il2CppTGK.Game.Components.Attack.Data;

namespace BlasII.StylePoints.Handlers;

public class GeneralHandler : WeaponHandler
{
    public override void OnAttackHit(AttackInfo info)
    {
		Main.StylePoints.ComboMeter.Increment();
    }

    public override void OnRestAtPrieDieu()
    {
		Main.StylePoints.ComboMeter.Reset();
    }
}

