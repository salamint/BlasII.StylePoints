using BlasII.Framework.WeaponEvents.Constants;
using BlasII.Framework.WeaponEvents.Events;
using BlasII.StylePoints.Bonuses;
using Il2CppTGK.Game.Components.Attack.Data;

namespace BlasII.StylePoints.Handlers;

public class RapierStyleHandler : RapierHandler
{
    public override void OnNormalThrustHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_LUNGE);
    }

    public override void OnElectricThrustHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_SILVER_LUNGE);
    }

    public override void OnDashCounterAttackHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_PIERCING_RETRIBUTION);
    }

    public override void OnIndicator1()
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_VERDADERA_DESTREZA_I);
    }

    public override void OnIndicator2()
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_VERDADERA_DESTREZA_II);
    }

    public override void OnIndicator3()
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_VERDADERA_DESTREZA_III);
    }

    public override void OnAirCrossHit(RapierAttackID attack, AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_SILVER_CROSS);
    }

    public override void OnElectricAirCrossHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_CROSS_OF_THE_TEMPEST);
    }

    public override void OnWeakStormOfThrustsHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_SILVER_STORM);
    }

    public override void OnPowerfulStormOfThrustsHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_SILVER_LIGHTNING);
    }

    public override void OnThrustHit(RapierAttackID attack, AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.RAPIER_SILVER_NAIL);
    }
}

