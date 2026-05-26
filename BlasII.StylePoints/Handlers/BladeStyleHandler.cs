using BlasII.Framework.WeaponEvents.Constants;
using BlasII.Framework.WeaponEvents.Events;
using BlasII.StylePoints.Bonuses;
using Il2CppTGK.Game.Components.Attack.Data;

namespace BlasII.StylePoints.Handlers;

public class BladeStyleHandler : BladeHandler
{
    public override void OnNormalRetributionHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.BLADE_ROSARY_WARD);
    }

    public override void OnPerfectRetributionHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_RETRIBUTION);
	}

    public override void OnMiddlePlungingStrikeHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_WEIGTH_OF_SIN);
	}

    public override void OnHighPlungingStrikeHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_WEIGTH_OF_JUSTICE);
	}

    public override void OnCombo3AscendingHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_CRIMSON_ASCENSION);
	}

    public override void OnCombo3SpinHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_CRIMSON_CYCLONE);
	}

    public override void OnCombo4NormalHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_CRIMSON_CLEAVER);
	}

    public override void OnCombo4UpgradedHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.BLADE_CRIMSON_GLAIVE);
    }

    public override void OnBloodPactStartHit(AttackInfo info)
	{
		Main.StylePoints.AddBonus(BonusID.BLADE_BLOOD_PACT);
	}

    public override void OnBloodPactSpecialAttackHit(BladeAttackID attack, AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.BLADE_REAPER_ROSARY);
    }
}

