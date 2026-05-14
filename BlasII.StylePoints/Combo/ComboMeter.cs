
namespace BlasII.StylePoints.Combo;

/// <summary>
/// Keeps track of the combo streak of the player while keeping track of the
/// time before it expires with a timer.
/// </summary>
public class ComboMeter
{
	/* Properties */

	/// <summary>
	/// The combo streak which keeps track of how many hits the player has
	/// without taking any damage or before expiration.
	/// </summary>
	public ComboStreak Streak { get; } = new ();

	/// <summary>
	/// The combo timer which keeps track of the time left before the combo
	/// expires.
	/// </summary>
	public ComboTimer Timer { get; } = new ();

	/* Methods */

	/// <summary>
	/// Increments the combo streak and increases the time left to the timer.
	/// </summary>
	public void Increment()
	{
		Streak.Increment();
		Timer.Increment();
	}

	/// <summary>
	/// Updates the timer of the combo meter, and resets the streak if the timer
	/// finishes.
	/// </summary>
	public void Update()
	{
		Timer.Update();
		if (Timer.Finished)
			Reset();
	}

	/// <summary>
	/// Resets both the timer and streak of the combo meter.
	/// </summary>
	public void Reset()
	{
		Streak.Reset();
		Timer.Reset();
	}
}

