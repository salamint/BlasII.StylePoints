using BlasII.StylePoints.Utils;
using UnityEngine;

namespace BlasII.StylePoints.Ratings;

/// <summary>
/// Implements the Manager abstract class to store Ratings.
/// </summary>
public class RatingsManager : Manager<RatingID, Rating>
{
	/* Methods */

	/// <summary>
	/// Adds a new rating constructed from the given parameters to the managed
	/// values.
	/// </summary>
	public Rating Add(RatingID id, string name, Color color)
	{
		Rating rating = new ()
		{
			Id = id,
			Text = new (name, color),
		};
		this[id] = rating;
		return rating;
	}

	/// <summary>
	/// Fills the static data.
	/// </summary>
	protected override void Fill()
	{
		Add(RatingID.SSS, "Blasphemous II", Color.red);
		Add(RatingID.SS, "Blasphemous", Color.red);
		Add(RatingID.S, "Sacreligious", Color.red);
		Add(RatingID.A, "Apostate", new Color(0.5f, 0.5f, 0f, 1f));
		Add(RatingID.B, "Blasphem", Color.yellow);
		Add(RatingID.C, "Corrupt", Color.green);
		Add(RatingID.D, "Desecrator", Color.cyan);
	}
}

