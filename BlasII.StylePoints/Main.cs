using MelonLoader;

namespace BlasII.StylePoints;

internal class Main : MelonMod
{
#nullable disable
    public static StylePoints StylePoints { get; private set; }
#nullable enable

    public override void OnLateInitializeMelon()
    {
        StylePoints = new StylePoints();
    }
}
