using MelonLoader;

namespace BlasII.StylePoints;

internal class Main : MelonMod
{
    public static StylePoints StylePoints { get; private set; }

    public override void OnLateInitializeMelon()
    {
        StylePoints = new StylePoints();
    }
}