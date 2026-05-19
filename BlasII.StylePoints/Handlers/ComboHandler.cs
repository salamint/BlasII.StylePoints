using BlasII.Framework.WeaponEvents.Events;
using Il2CppTGK.Game.Components.Attack.Data;

namespace BlasII.StylePoints.Handlers;

/// <summary>
/// Weapon handler to update the combo meter.
/// </summary>
public class ComboHandler : WeaponHandler
{
	/// <summary>
	/// Increments the combo meter when hitting an enemy.
	/// </summary>
    public override void OnAttackHit(AttackInfo info)
    {
		Main.StylePoints.ComboMeter.Increment();
    }

	/// <summary>
	/// Resetting the combo meter when resting at a Prie Dieu.
	/// </summary>
    public override void OnRestAtPrieDieu()
    {
		Main.StylePoints.ComboMeter.Reset();
		Main.StylePoints.RatingScore.Reset();
    }
}

