using UnityEngine;

namespace BlasII.StylePoints.Bonuses;

/// <summary>
/// Represents a bonus displayed in the corner of the screen, which increases
/// the overall score by a set amount of points.
/// </summary>
public class Bonus
{
	/* Properties */

	/// <summary>
	/// The unique identifier of the bonus
	/// </summary>
	public BonusID Id { get; init; }

	/// <summary>
	/// The (display) name of the bonus which will be displayed.
	/// </summary>
	public string Name { get; init; }

	/// <summary>
	/// The amount of style points gained from this bonus.
	/// </summary>
	public int Points { get; init; }

	/// <summary>
	/// The color to use for the display name of the bonus.
	/// </summary>
	public Color Color { get; init; }

	/* Constructors */

	/// <summary>
	/// Initializes a new instance of the Bonus class.
	/// Requires a name and an amount of point.
	/// The default color is white.
	/// </summary>
	public Bonus(BonusID id, string name, int points, Color? color = null)
	{
		Id = id;
		Name = name;
		Points = points;
		if (color == null)
			Color = Color.white;
		else
			Color = (Color) color;
	}
}

