using BlasII.StylePoints.UI;
using Il2CppTMPro;
using UnityEngine;

namespace BlasII.StylePoints.Combo;

/// <summary>
/// A class that manages the current consecutive streak of attack hits that the
/// player has, and displays it at the bottom of the screen.
/// </summary>
public class ComboStreak
{
	/// <summary>
	/// The combo counter, is incremented when the player hits an enemy and is
	/// reset when the player is hit or doesn't hit anything for too long.
	/// </summary>
	public int Streak { get; private set; } = 0;

	private TextShadow _text = new ()
	{
		Name = "ComboMeterRect",
		Position = new Vector2(768, -416),
		Size = new Vector2(128, 128),
		Text = "",
		TextAlignment = TextAlignmentOptions.Left,
		TextColor = Color.white,
		TextSize = 48,
		ShadowOffset = 3,
	};

	/// <summary>
	/// Increments the combo counter.
	/// Makes the counter visible on the screen if that was not previously the
	/// case.
	/// </summary>
	public void Increment()
	{
		Streak++;
		if (Streak == 1)
		{
			_text.Visible = true;
		}
		_text.SetText($"Combo x{Streak}");
	}

	/// <summary>
	/// Resets the combo counter to 0, and stop displaying it on the screen.
	/// </summary>
	public void Reset()
	{
		Streak = 0;
		_text.Visible = false;
	}
}

