namespace BlasII.StylePoints.Ratings;

/// <summary>
/// Represents a rating uniquely identified by its RatingID.
/// A rating is represented with a text displayed at the top of the screen with
/// a specific color.
///
/// A rating also has a style goal which must be rached in order to not lose it.
/// A rating also adds small buffs to the player to reward them.
/// </summary>
public class Rating
{
	/* Properties */

	/// <summary>
	/// The unique identifier of this rating.
	/// </summary>
	public RatingID Id { get; init; }

	/// <summary>
	/// The text of the rating to display at the top of the screen.
	/// </summary>
	public RatingText Text { get; init; }
}

