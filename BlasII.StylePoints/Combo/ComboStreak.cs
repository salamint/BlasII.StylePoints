using BlasII.StylePoints.UI;
using UnityEngine;

namespace BlasII.StylePoints.Combo;

/// <summary>
/// A class that manages the current consecutive streak of attack hits that the
/// player has, and displays it at the bottom of the screen.
/// </summary>
public class ComboStreak
{
	/* Properties */

	/// <summary>
	/// The combo counter, is incremented when the player hits an enemy and is
	/// reset when the player is hit or doesn't hit anything for too long.
	/// </summary>
	public int Streak { get; private set; } = 0;

	/* Members */

	private TextShadow _text = new (
		"ComboMeterRect",
		position: new Vector2(768, -416),
		size: new Vector2(128, 128),
		text: "",
		textSize: 48,
		shadowOffset: 3
	);

	/* Methods */

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
		_text.Text = $"Combo x{Streak}";
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

