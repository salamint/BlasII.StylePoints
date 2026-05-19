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

	/// <summary>
	/// The minimum amount of style points required for this rating.
	/// </summary>
	public int MinimumStyle { get; init; }

	/// <summary>
	/// The ID of the previous rating of this rating (nullable).
	/// </summary>
	public RatingID? PreviousRatingID { get; init; }

	/// <summary>
	/// The previous rating of this rating (nullable).
	/// </summary>
	public Rating? PreviousRating
    {
        get => PreviousRatingID == null ? null :
			Main.StylePoints.RatingsManager.Get((RatingID) PreviousRatingID);
    }

	/// <summary>
	/// The ID of the next rating of this rating (nullable).
	/// </summary>
	public RatingID? NextRatingID { get; init; }

	/// <summary>
	/// The next rating of this rating (nullable).
	/// </summary>
	public Rating? NextRating
    {
        get => NextRatingID == null ? null :
			Main.StylePoints.RatingsManager.Get((RatingID) NextRatingID);
    }

    /* Constructors */

    /// <summary>
    /// Initializes a new rating from a unique identifier and a text.
    /// </summary>
    public Rating(
		RatingID id,
		RatingText text,
		int minimumStyle,
		RatingID? previousRatingID,
		RatingID? nextRatingID
	)
	{
		Id = id;
		Text = text;
		MinimumStyle = minimumStyle;
		PreviousRatingID = previousRatingID;
		NextRatingID = nextRatingID;
	}
}

