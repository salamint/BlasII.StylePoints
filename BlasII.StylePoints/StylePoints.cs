using System.Collections.Generic;
using BlasII.ModdingAPI;
using BlasII.StylePoints.Combo;
using BlasII.StylePoints.Ratings;
using UnityEngine;

namespace BlasII.StylePoints;

public class StylePoints : BlasIIMod
{
    internal StylePoints() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

	private RatingsManager RatingsManager { get; } = new ();
	private List<RatingID> Ratings { get; } = new ()
	{
		RatingID.D,
		RatingID.C,
		RatingID.B,
		RatingID.A,
		RatingID.S,
		RatingID.SS,
		RatingID.SSS,
	};

	private int currentRatingIndex = 0;

	public Rating CurrentRating { get => RatingsManager[Ratings[currentRatingIndex]]; }

	public ComboMeter ComboMeter { get; } = new ();

	private static string SwitchKeybinding = "SwitchStyleMeter";

    protected override void OnInitialize()
    {
        // Perform initialization here
		InputHandler.RegisterDefaultKeybindings(new Dictionary<string, KeyCode>()
		{
			{ SwitchKeybinding, KeyCode.F8 },
		});

		RatingsManager.Init();
    }

    protected override void OnSceneLoaded(string sceneName)
    {
		CurrentRating.Text.Visible = true;
    }

    protected override void OnSceneUnloaded(string sceneName)
    {
		CurrentRating.Text.Visible = false;
    }

    protected override void OnUpdate()
    {
        if (InputHandler.GetKeyDown(SwitchKeybinding))
		{
			bool visible = CurrentRating.Text.Visible;
			CurrentRating.Text.Visible = false;

			currentRatingIndex++;
			if (currentRatingIndex >= Ratings.Count)
			{
				currentRatingIndex = 0;
			}

			CurrentRating.Text.Visible = visible;
		}

		ComboMeter.Update();
    }
}
