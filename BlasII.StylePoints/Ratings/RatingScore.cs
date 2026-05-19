using BlasII.StylePoints.Bonuses;
using System;
using UnityEngine;

namespace BlasII.StylePoints.Ratings;

/// <summary>
/// Stores and updates the current style score of the player and evaluates the
/// style rating.
/// </summary>
public class RatingScore
{
	/* Constants */

	/// <summary>
	/// Number of style points lost per second.
	/// </summary>
	public static readonly int POINTS_LOST_PER_SECOND = 5;

	/* Properties */

	/// <summary>
	/// The current style rating of the player.
	/// When set, hides the previous rating and shows the new one (if not null).
	/// </summary>
	public Rating? CurrentRating
	{
		get => currentRating;
		private set
		{
			string? text = value == null ? null : value.Text.Text;
			if (currentRating != null)
			{
				Visible = false;
			}
			currentRating = value;
			if (currentRating != null)
			{
				Visible = true;
			}
		}
	}

	/// <summary>
	/// The current score of the player in style points.
	/// </summary>
	public float Score { get; private set; } = 0;

	/// <summary>
	/// The visibility status of the current rating's text. If there is no
	/// current rating, the getter returns false, and the setter is a NO-OP.
	/// </summary>
	public bool Visible
	{
		get => CurrentRating != null ? CurrentRating.Text.Visible : false;
		set
		{
			if (CurrentRating != null)
				CurrentRating.Text.Visible = value;
		}
	}

	/* Members */

	private Rating? currentRating = null;

	/* Methods */

	/// <summary>
	/// Adds the given bonus' points to the global score, and increase the
	/// rating if a points goal is reached.
	/// </summary>
	public void Add(Bonus bonus)
	{
		Score += bonus.Points;
		if (CurrentRating == null)
		{
			Next();
			return;
		}

		Rating? nextRating = CurrentRating.NextRating;
		if (nextRating != null && Score >= nextRating.MinimumStyle)
			Next();
	}

	/// <summary>
	/// Sets the current rating to the next available rating.
	/// If the current rating is already the highest available rating, this has
	/// no effects.
	/// </summary>
	public void Next()
	{
		if (CurrentRating == null)
		{
			CurrentRating = Main.StylePoints.RatingsManager[RatingID.D];
			return;
		}

		if (CurrentRating.NextRating != null)
			CurrentRating = CurrentRating.NextRating;
	}

	/// <summary>
	/// Sets the current rating to the previous avilable rating.
	/// If the current rating is the lowest available rating, this sets the
	/// current rating to <c>null</c>.
	/// </summary>
	public void Previous()
	{
		if (CurrentRating == null)
			return;

		CurrentRating = CurrentRating.PreviousRating;
	}

	/// <summary>
	/// Resets the global score and sets the current rating to <c>null</c>.
	/// </summary>
	public void Reset()
	{
		CurrentRating = null;
		Score = 0;
	}

	/// <summary>
	/// Updates the current score by decreasing the value.
	/// </summary>
	public void Update()
	{
		float pointsLost = POINTS_LOST_PER_SECOND * Time.deltaTime;
		Score = Math.Max(Score - pointsLost, 0);

		if (CurrentRating != null && Score < CurrentRating.MinimumStyle)
			Previous();
	}
}

