using BlasII.StylePoints.Bonuses;
using System.Collections.Generic;

namespace BlasII.StylePoints.Ratings;

public class RatingScore
{
	/* Properties */

	private List<RatingID> Ratings { get; } = new ()
	{
		RatingID.D,
		RatingID.C,
		RatingID.B,
		RatingID.A,
		RatingID.S,
		RatingID.SS,
		RatingID.SSS,
	};

	public Rating CurrentRating
	{
		get => Main.StylePoints.RatingsManager[Ratings[currentRatingIndex]];
	}

	public int Score { get; private set; } = 0;

	public bool Visible
	{
		get => CurrentRating.Text.Visible;
		set => CurrentRating.Text.Visible = value;
	}

	/* Members */

	private int currentRatingIndex = 0;

	/* Methods */

	public void Add(Bonus bonus)
	{
		Score += bonus.Points;
	}

	public void Next()
	{
		if (currentRatingIndex + 1 >= Ratings.Count)
			return;

		bool visible = Visible;
		Visible = false;
		currentRatingIndex++;
		Visible = visible;
	}

	public void Previous()
	{
		if (currentRatingIndex + 1 >= Ratings.Count)
			return;

		bool visible = Visible;
		Visible = false;
		currentRatingIndex++;
		Visible = visible;
	}
}

