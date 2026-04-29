using BlasII.ModdingAPI.Helpers;
using BlasII.StylePoints.UI;
using UnityEngine;

namespace BlasII.StylePoints.Combo;

/// <summary>
/// Manages the duration of the combo, reducing it over time until it reaches 0,
/// but increasing it on every attack hit until it reaches the maximum amount.
/// </summary>
public class ComboTimer
{
    /// <summary>
    /// The maximum amount of time left to the combo before being reset when
    /// the player doesn't attack an enemy (in seconds).
    /// </summary>
    public static float MAXIMUM_TIME_REMAINING = 15f;

    /// <summary>
    /// The amount of time left to the combo that is added to the current time
	/// left for every attack hit (in seconds).
    /// </summary>
    public static float TIME_ADDED_PER_HIT = 3f;

    /// <summary>
	/// Whether the timer is running or not.
    /// </summary>
    public bool Running { get; private set; } = false;

    /// <summary>
	/// The current amount of time remaining before the end of the combo (in
	/// seconds).
    /// </summary>
    public float TimeRemaining { get; private set; } = 0f;

    /// <summary>
	/// If the timer is finished or not.
	/// The timer is not considered finished when it is not running.
    /// </summary>
    public bool Finished { get => Running && TimeRemaining <= 0; }

	private Bar _bar = new ()
	{
		Name = "ComboTimerBar",
		Position = new Vector2(782, -448),
		Size = new Vector2(150, 10),
	};

	/// <summary>
	/// Shows the time bar if it wasn't already visible, starts the timer if it
	/// wasn't started, and adds time to the timer.
	/// </summary>
	public void Increment()
	{
		if (!Running)
			Running = true;

		TimeRemaining += TIME_ADDED_PER_HIT;
		if (TimeRemaining > MAXIMUM_TIME_REMAINING)
			TimeRemaining = MAXIMUM_TIME_REMAINING;

		if (!_bar.Visible)
		{
			_bar.Visible = true;
		}
	}

	/// <summary>
	/// Updates the size of the bar to idicate the amount of time left, and
	/// decrease the time remaining.
	/// </summary>
	public void Update()
	{
		if (TimeRemaining > 0 && SceneHelper.GameSceneLoaded)
		{
			_bar.Update(TimeRemaining / MAXIMUM_TIME_REMAINING);
			TimeRemaining -= Time.deltaTime;
		}
	}

	/// <summary>
	/// Resets the timer and hides the time bar.
	/// </summary>
	public void Reset()
	{
		TimeRemaining = 0f;
		Running = false;
		_bar.Visible = false;
	}
}
