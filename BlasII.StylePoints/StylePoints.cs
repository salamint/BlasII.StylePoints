using BlasII.ModdingAPI;
using BlasII.StylePoints.Combo;

namespace BlasII.StylePoints;

public class StylePoints : BlasIIMod
{
    internal StylePoints() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

	private int currentRatingIndex = 0;

	public ComboMeter ComboMeter = new ();

    protected override void OnUpdate()
    {
		ComboMeter.Update();
    }
}
