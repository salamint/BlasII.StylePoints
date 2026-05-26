using BlasII.Framework.WeaponEvents.Events;
using BlasII.StylePoints.Bonuses;
using Il2CppTGK.Game.Components.Attack.Data;

namespace BlasII.StylePoints.Handlers;

public class MeaCulpaStyleHandler : MeaCulpaHandler
{
    public override void OnThrustAttackHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_SACRED_ONSLAUGHT);
    }

    public override void OnNormalRetributionHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_THORN_GUARD);
    }

    public override void OnPerfectRetributionHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_FERVOROUS_RETRIBUTION);
    }

    public override void OnPhantomProjectileHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_PERCEPTOR_PULSE);
    }

    public override void OnChargedAttackHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_WRATH_OF_THE_TWISTED_ONE);
    }

    public override void OnLowerPlungingStrikeHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_WEIGHT_OF_JUSTICE);
    }

    public override void OnHighPlungingStrikeHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_CONSECRATION);
    }

    public override void OnCombo3AscendingHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_FERVOROUS_ASCENSION);
    }

    public override void OnCombo3SpinHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_FERVOROUS_CYCLONE);
    }

    public override void OnCombo4Hit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_LAST_WORDS);
    }

    public override void OnRemorseStartHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.MEA_CULPA_INCARNATE_REMORSE);
    }
}

