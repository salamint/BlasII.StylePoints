using BlasII.StylePoints.Utils;
using UnityEngine;

namespace BlasII.StylePoints.Bonuses;

/// <summary>
/// Implements the Manager abstract class to store Bonuses.
/// </summary>
public class BonusesManager : Manager<BonusID, Bonus>
{
	/* Methods */

	/// <summary>
	/// Adds a new bonuses constructed from the given parameters, to the managed
	/// values.
	/// </summary>
	public Bonus Add(BonusID id, string name, int points, Color? color = null)
	{
		Bonus bonus = new (id, name, points, color);
		this[id] = bonus;
		return bonus;
	}

	/// <summary>
	/// Fills the static data.
	/// </summary>
	protected override void Fill()
	{
	}
}

