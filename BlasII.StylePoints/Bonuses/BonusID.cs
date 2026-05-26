namespace BlasII.StylePoints.Bonuses;

/// <summary>
/// Uniquely identifies every style bonus.
/// </summary>
public enum BonusID
{
	/* Common */

	/// <summary>When killing a normal enemy</summary>
	KILL,
	/// <summary>When killing a big enemy</summary>
	BIG_KILL,
	/// <summary>
	/// When inflicting a remarkable amount of damage to an enemy with low
	/// health.
	/// </summary>
	OVER_KILL,
	/// <summary>When executing a normal enemy</summary>
	EXECUTION,
	/// <summary>When executing a big enemy</summary>
	BIG_EXECUTION,

	/* Ruego al Alba attacks */

	/// <summary>Default parry</summary>
	BLADE_ROSARY_WARD,
	/// <summary>Upgraded parry</summary>
	BLADE_RETRIBUTION,

	/// <summary>Default ground slam</summary>
	BLADE_WEIGTH_OF_SIN,
	/// <summary>Upgraded ground slam</summary>
	BLADE_WEIGTH_OF_JUSTICE,

	/// <summary>Ascending 3rd combo</summary>
	BLADE_CRIMSON_ASCENSION,
	/// <summary>Cyclone 3rd combo</summary>
	BLADE_CRIMSON_CYCLONE,

	/// <summary>4th combo</summary>
	BLADE_CRIMSON_CLEAVER,
	/// <summary>Upgraded 4th combo</summary>
	BLADE_CRIMSON_GLAIVE,

	/// <summary>Blood pact activation</summary>
	BLADE_BLOOD_PACT,
	/// <summary>Blood pact special attack</summary>
	BLADE_REAPER_ROSARY,

	/* Veredicto attacks */

	/// <summary>Charged smash</summary>
	CENSER_THUNDER_OF_MERCY,
	/// <summary>Air spin charged attack</summary>
	CENSER_AZURE_TYPHOON,
	/// <summary>Charged attack shockwave</summary>
	CENSER_AND_THE_EARTH_SHATTERED,
	/// <summary>Upgraded charged attack shockwave</summary>
	CENSER_SOUL_COMBUSTION,

	/// <summary>Veredicto activation</summary>
	CENSER_EMBERS_OF_FAITH,
	/// <summary>Upgraded Veredicto activation</summary>
	CENSER_EXPLOSIVE_EMBERS,

	/// <summary>Activation combo</summary>
	CENSER_IGNITION_STRIKE,
	/// <summary>Activation mid-air</summary>
	CENSER_AERIAL_IGNITION,
	/// <summary>Loop combo</summary>
	CENSER_ENDLESS_FLAME,

	/* Sarmiento y Centella attacks */

	/// <summary>Dash attack</summary>
	RAPIER_LUNGE,
	/// <summary>Upgraded dash attack</summary>
	RAPIER_SILVER_LUNGE,

	/// <summary>Default parry</summary>
	RAPIER_CROSS_GUARD,
	/// <summary>Upgraded parry</summary>
	RAPIER_PIERCING_RETRIBUTION,

	/// <summary>1st indicator</summary>
	RAPIER_VERDADERA_DESTREZA_I,
	/// <summary>2nd indicator</summary>
	RAPIER_VERDADERA_DESTREZA_II,
	/// <summary>3rd indicator</summary>
	RAPIER_VERDADERA_DESTREZA_III,

	/// <summary>Mid-air special attack</summary>
	RAPIER_SILVER_CROSS,
	/// <summary>Upgraded mid-air special attack</summary>
	RAPIER_CROSS_OF_THE_TEMPEST,

	/// <summary>Barrage of thrusts</summary>
	RAPIER_SILVER_STORM,
	/// <summary>Upgraded barrage of thrusts</summary>
	RAPIER_SILVER_LIGHTNING,

	/// <summary>Charged hit combo</summary>
	RAPIER_SILVER_NAIL,

	/* Mea Culpa attacks */

	/// <summary>Dash attack</summary>
	MEA_CULPA_SACRED_ONSLAUGHT,

	/// <summary>Default parry</summary>
	MEA_CULPA_THORN_GUARD,
	/// <summary>Upgraded parry</summary>
	MEA_CULPA_FERVOROUS_RETRIBUTION,

	/// <summary>Projectile</summary>
	MEA_CULPA_PERCEPTOR_PULSE,
	/// <summary>Projectile piercing</summary>
	MEA_CULPA_PATH_OF_DESTRUCTION,
	/// <summary>Projectile explosion</summary>
	MEA_CULPA_END_OF_LINE,

	/// <summary>Default charged attack</summary>
	MEA_CULPA_HOLY_WRATH,
	/// <summary>Upgraded charged attack</summary>
	MEA_CULPA_WRATH_OF_THE_TWISTED_ONE,

	/// <summary>Default ground slam</summary>
	MEA_CULPA_WEIGHT_OF_JUSTICE,
	/// <summary>Upgraded ground slam</summary>
	MEA_CULPA_CONSECRATION,

	/// <summary>3rd combo ascension</summary>
	MEA_CULPA_FERVOROUS_ASCENSION,
	/// <summary>3rd combo cyclone</summary>
	MEA_CULPA_FERVOROUS_CYCLONE,
	/// <summary>4th combo</summary>
	MEA_CULPA_LAST_WORDS,

	/// <summary>Activation</summary>
	MEA_CULPA_INCARNATE_REMORSE,
}

