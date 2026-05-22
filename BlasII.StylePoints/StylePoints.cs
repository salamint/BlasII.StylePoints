using BlasII.ModdingAPI;
using BlasII.StylePoints.Bonuses;
using BlasII.StylePoints.Combo;
using BlasII.StylePoints.Ratings;

namespace BlasII.StylePoints;

/// <summary>
/// Class managing the Miracle May Cry mod, also called Style Points mod.
/// It adds a style system to the game, as well as ratings and bonuses, to
/// encourage the player to have a more varied and "stylish" playstyle.
/// </summary>
public class StylePoints : BlasIIMod
{
	/* Properties */

	/// <summary>
	/// The combo meter keeps track of the combo of the player.
	/// In other words, the number of hits the player inflicted to enemies
	/// in a streak, without taking damage and before it expires.
	/// </summary>
	public ComboMeter ComboMeter { get; } = new ();

	/// <summary>
	/// The bonuses manager initializes the bonuses at a later stage once all of
	/// the other components are initialized.
	/// </summary>
	public BonusesManager BonusesManager { get; } = new ();

	/// <summary>
	/// The bonus queue displays the last 5 bonus gained by the player during
	/// their gameplay.
	/// </summary>
	public BonusQueue BonusQueue { get; } = new ();

	/// <summary>
	/// The ratings manager initializes the ratings at a later stage once all of
	/// the other components are initialized.
	/// </summary>
	public RatingsManager RatingsManager { get; } = new ();

	/// <summary>
	/// The rating score keeps track of the global amount of style points
	/// gained, decrease them with the time, and updates the current rating
	/// depending on the current amount of style points.
	/// </summary>
	public RatingScore RatingScore { get; } = new ();

	/// <summary>
	/// Displays debug information on a key press to help troubleshoot problems
	/// or testing.
	/// </summary>
	public DebugInfo DebugInfo { get; init; }

	/* Constructors */

    internal StylePoints()
		: base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION)
	{
		DebugInfo = new (this);
	}

	/* Methods */

	/// <summary>
	/// Adds a bonus to the bonus queue and rating score, increasing the global
	/// style score and being displayed at the bottom left of the screen.
	/// </summary>
	public void AddBonus(BonusID id)
	{
		Bonus bonus = BonusesManager[id];
		BonusQueue.Add(bonus);
		RatingScore.Add(bonus);
	}

	/// <summary>
	/// Initializes the mod at a late stage, once all mods are loaded by the mod
	/// loader.
	/// </summary>
    protected override void OnInitialize()
    {
		DebugInfo.Init();
		BonusesManager.Init();
		RatingsManager.Init();
    }

	/// <summary>
	/// Called whenever the player is entering a room.
	/// Shows the user interface.
	/// </summary>
    protected override void OnSceneLoaded(string sceneName)
    {
		RatingScore.Visible = true;
    }

	/// <summary>
	/// Called whenever the player is leaving a room.
	/// Hides the user interface.
	/// </summary>
    protected override void OnSceneUnloaded(string sceneName)
    {
		RatingScore.Visible = false;
    }

	/// <summary>
	/// When an update is called, once per frame in the game loop.
	/// Updates the bonus queue, combo meter and rating score.
	/// </summary>
    protected override void OnUpdate()
    {
		DebugInfo.Update();
		BonusQueue.Update();
		ComboMeter.Update();
		RatingScore.Update();
    }
}
