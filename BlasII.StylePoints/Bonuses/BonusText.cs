using BlasII.StylePoints.UI;
using UnityEngine;

namespace BlasII.StylePoints.Bonuses;

/// <summary>
/// Text displaying a bonus flavor text for a given duration.
/// </summary>
public class BonusText
{
	/* Constants */

	/// <summary>
	/// The duration in seconds for which a bonus flavor text is displayed.
	/// </summary>
	public static readonly float BONUS_DISPLAY_TIME = 3f;

	/// <summary>
	/// The offset between each bonus text in pixels.
	/// </summary>
	public static readonly int OFFSET = 48;

	/* Members */

	/// <summary>
	/// Stores the current index of the bonus text.
	/// </summary>
	private int _index = 0;

	/* Properties */

	/// <summary>
	/// Current index of the bonus text.
	/// Changing the index of the bonus text also changes its position.
	/// </summary>
	public int Index
	{
		get => _index;
		set
		{
			int diff = value - _index;
			Vector2 newPosition = new Vector2()
			{
				x = Text.Position.x,
				y = Text.Position.y + (diff * OFFSET),
			};
			Text.Position = newPosition;
			_index = value;
		}
	}

	/// <summary>
	/// The bonus ddisplayed.
	/// </summary>
	public Bonus Bonus { get; init; }

	/// <summary>
	/// The time left before the bonus text expires.
	/// </summary>
	public float TimeLeft { get; set; }

	/// <summary>
	/// The graphical component displaying the text on the screen.
	/// </summary>
	public TextShadow Text { get; init; }

	/* Constructors */

	/// <summary>
	/// Initializes a new bonus text to be displayed.
	/// The default index is 0 and the time left is set to the maximum.
	/// </summary>
	public BonusText(Bonus bonus)
	{
		Bonus = bonus;
        TimeLeft = BONUS_DISPLAY_TIME;
		Text = new (
			name: $"BonusText{Index}",
			position: new Vector2(-800, -468),
			size: new Vector2(128, 128),
			text: $"+ {Bonus.Name}",
			textColor: Bonus.Color,
			textSize: 32,
			shadowOffset: 2
		);
		Text.Visible = true;
	}
}

