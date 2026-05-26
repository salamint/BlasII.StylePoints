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
		/* Common */

		Add(BonusID.KILL, "Kill", 10);
		Add(BonusID.BIG_KILL, "Big Kill", 50);
		Add(BonusID.OVER_KILL, "Over Kill", 50);
		Add(BonusID.EXECUTION, "Execution", 100);
		Add(BonusID.BIG_EXECUTION, "Big Execution", 200);

		/* Blade */

		Add(BonusID.BLADE_ROSARY_WARD, "Rosary Ward", 20);
		Add(BonusID.BLADE_RETRIBUTION, "Retribution", 30, Color.red);

		Add(BonusID.BLADE_WEIGTH_OF_SIN, "Weight of Sin", 20);
		Add(BonusID.BLADE_WEIGTH_OF_JUSTICE, "Weight of Justice", 30, Color.red);

		Add(BonusID.BLADE_CRIMSON_ASCENSION, "Crimson Ascension", 20, Color.red);
		Add(BonusID.BLADE_CRIMSON_CYCLONE, "Crimson Cyclone", 20, Color.red);

		Add(BonusID.BLADE_CRIMSON_CLEAVER, "Crimson Cleaver", 100);
		Add(BonusID.BLADE_CRIMSON_GLAIVE, "Crimson Glave", 150, Color.red);

		Add(BonusID.BLADE_BLOOD_PACT, "Blood Pact", 10, Color.red);
		Add(BonusID.BLADE_REAPER_ROSARY, "Reaper Rosary", 15, Color.red);

		/* Censer */

		Color orange = new (100, 50, 0);

		Add(BonusID.CENSER_THUNDER_OF_MERCY, "Thunder of Mercy", 30);
		Add(BonusID.CENSER_AZURE_TYPHOON, "Azure Typhoon", 30);
		Add(BonusID.CENSER_AND_THE_EARTH_SHATTERED, "And the Earth Shattered", 40, orange);
		Add(BonusID.CENSER_SOUL_COMBUSTION, "Soul Combustion", 50, orange);

		Add(BonusID.CENSER_EMBERS_OF_FAITH, "Embers of Faith", 10, orange);
		Add(BonusID.CENSER_EXPLOSIVE_EMBERS, "Explosive Embers", 15, orange);

		Add(BonusID.CENSER_IGNITION_STRIKE, "Ignition Strike", 15, orange);
		Add(BonusID.CENSER_AERIAL_IGNITION, "Aerial Ignition", 15, orange);
		Add(BonusID.CENSER_ENDLESS_FLAME, "Endless Flame", 15, orange);

		/* Sarmiento y Centella */

		Add(BonusID.RAPIER_LUNGE, "Lunge", 10);
		Add(BonusID.RAPIER_SILVER_LUNGE, "Silver Lunge", 10, Color.cyan);

		Add(BonusID.RAPIER_CROSS_GUARD, "Cross Guard", 10);
		Add(BonusID.RAPIER_PIERCING_RETRIBUTION, "Piercing Retribution", 10, Color.cyan);

		Add(BonusID.RAPIER_VERDADERA_DESTREZA_I, "Verdadera Destreza I", 10, Color.cyan);
		Add(BonusID.RAPIER_VERDADERA_DESTREZA_II, "Verdadera Destreza II", 20, Color.cyan);
		Add(BonusID.RAPIER_VERDADERA_DESTREZA_III, "Verdadera Destreza III", 30, Color.cyan);

		Add(BonusID.RAPIER_SILVER_CROSS, "Silver Cross", 10);
		Add(BonusID.RAPIER_CROSS_OF_THE_TEMPEST, "Cross of the Tempest", 20, Color.cyan);

		Add(BonusID.RAPIER_SILVER_STORM, "Silver Storm", 10);
		Add(BonusID.RAPIER_SILVER_LIGHTNING, "Silver Lightning", 20, Color.cyan);

		Add(BonusID.RAPIER_SILVER_NAIL, "Silver Nail", 15);

		/* Mea Culpa */

		Color thorns = Color.magenta;

		Add(BonusID.MEA_CULPA_SACRED_ONSLAUGHT, "Sacred Onslaught", 15);

		Add(BonusID.MEA_CULPA_THORN_GUARD, "Thorn Guard", 10);
		Add(BonusID.MEA_CULPA_FERVOROUS_RETRIBUTION, "Fervorous Retribution", 20, thorns);

		Add(BonusID.MEA_CULPA_PERCEPTOR_PULSE, "Perceptor Pulse", 10, thorns);
		Add(BonusID.MEA_CULPA_PATH_OF_DESTRUCTION, "Path of Destruction", 15, thorns);
		Add(BonusID.MEA_CULPA_END_OF_LINE, "End of Line", 15, thorns);

		Add(BonusID.MEA_CULPA_HOLY_WRATH, "Holy Wrath", 20);
		Add(BonusID.MEA_CULPA_WRATH_OF_THE_TWISTED_ONE, "Wrath of The Twisted One", 30, thorns);

		Add(BonusID.MEA_CULPA_WEIGHT_OF_JUSTICE, "Weight of Justice", 15);
		Add(BonusID.MEA_CULPA_CONSECRATION, "Consecration", 20, thorns);

		Add(BonusID.MEA_CULPA_FERVOROUS_ASCENSION, "Fervorous Ascension", 10, thorns);
		Add(BonusID.MEA_CULPA_FERVOROUS_CYCLONE, "Fervorous Cyclone", 10, thorns);
		Add(BonusID.MEA_CULPA_LAST_WORDS, "Last Words", 20, thorns);

		Add(BonusID.MEA_CULPA_INCARNATE_REMORSE, "Incarnate Remorse", 30, thorns);
	}
}

