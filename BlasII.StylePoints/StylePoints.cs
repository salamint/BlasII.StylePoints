using BlasII.ModdingAPI;
using BlasII.StylePoints.Bonuses;
using BlasII.StylePoints.Combo;
using BlasII.StylePoints.Ratings;

namespace BlasII.StylePoints;

public class StylePoints : BlasIIMod
{
    internal StylePoints() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

	public ComboMeter ComboMeter { get; } = new ();

	public BonusesManager BonusesManager { get; } = new ();
	public BonusQueue BonusQueue { get; } = new ();

	public RatingsManager RatingsManager { get; } = new ();
	public RatingScore RatingScore { get; } = new ();

	public void AddBonus(BonusID id)
	{
		Bonus bonus = BonusesManager[id];
		BonusQueue.Add(bonus);
		RatingScore.Add(bonus);
	}

    protected override void OnInitialize()
    {
        // Perform initialization here
		RatingsManager.Init();
		BonusesManager.Init();
    }

    protected override void OnSceneLoaded(string sceneName)
    {
		RatingScore.Visible = true;
    }

    protected override void OnSceneUnloaded(string sceneName)
    {
		RatingScore.Visible = false;
    }

    protected override void OnUpdate()
    {
		BonusQueue.Update();
		ComboMeter.Update();
    }
}
