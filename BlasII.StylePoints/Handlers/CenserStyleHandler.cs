using BlasII.Framework.WeaponEvents.Events;
using BlasII.StylePoints.Bonuses;
using Il2CppTGK.Game.Components.Attack.Data;

namespace BlasII.StylePoints.Handlers;

public class CenserStyleHandler : CenserHandler
{
    public override void OnChargedAttackHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.CENSER_THUNDER_OF_MERCY);
    }

    public override void OnWhirlwindHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.CENSER_AZURE_TYPHOON);
    }

    public override void OnIgnitionAreaHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.CENSER_EXPLOSIVE_EMBERS);
    }

    public override void OnIgnitionStrikeHit(AttackInfo info, int hit)
    {
		Main.StylePoints.AddBonus(BonusID.CENSER_IGNITION_STRIKE);
    }

    public override void OnMidairIgnitionHit(AttackInfo info)
    {
		Main.StylePoints.AddBonus(BonusID.CENSER_AERIAL_IGNITION);
    }

    public override void OnIgnitionOrTemperStrikeHit(AttackInfo info, int hit)
    {
		Main.StylePoints.AddBonus(BonusID.CENSER_ENDLESS_FLAME);
    }
}
