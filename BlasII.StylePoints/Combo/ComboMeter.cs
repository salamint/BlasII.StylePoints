
namespace BlasII.StylePoints.Combo;

/// <summary>
/// </summary>
public class ComboMeter
{
	/// <summary>
	/// </summary>
	public ComboStreak Streak { get; } = new ();

	/// <summary>
	/// </summary>
	public ComboTimer Timer { get; } = new ();

	/// <summary>
	/// </summary>
	public void Increment()
	{
		Streak.Increment();
		Timer.Increment();
	}

	/// <summary>
	/// </summary>
	public void Update()
	{
		Timer.Update();
		if (Timer.Finished)
			Reset();
	}

	/// <summary>
	/// </summary>
	public void Reset()
	{
		Streak.Reset();
		Timer.Reset();
	}
}

