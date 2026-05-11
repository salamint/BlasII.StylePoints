using BlasII.ModdingAPI.Helpers;
using System.Collections.Generic;
using UnityEngine;

namespace BlasII.StylePoints.Bonuses;

/// <summary>
/// Queue storing the 5 latest bonus acquired and displaying them in a corner of
/// the screen.
/// Pushing a new bonus when the limit was already reached will remove the
/// oldest bonus text in the queue.
/// </summary>
public class BonusQueue
{
	/* Constants */

	/// <summary>
	/// The maximum number of bonuses displayed at the same time.
	/// Adding a new bonus when this limit is reached will remove a bonus at the
	/// other end of the queue.
	/// </summary>
	public static readonly int SIZE = 5;

	/* Members */

	private Queue<BonusText> _texts = new ();

	/* Methods */

	/// <summary>
	/// Adds a new bonus to the queue.
	/// Checks of the limit has been reached. If that is the case, removes the
	/// oldest bonus text and increments the index of every other bonus text to
	/// leave a spot for the new bonus text.
	/// </summary>
	public void Add(Bonus bonus)
	{
		if (_texts.Count == SIZE)
			PopHead();

		foreach (BonusText text in _texts)
			text.Index++;

		_texts.Enqueue(new (bonus));
	}

	/// <summary>
	/// Fetches the value at the head of the queue without popping it, or null
	/// is the queue is empty.
	/// </summary>
	public BonusText? GetHead()
	{
		if (_texts.Count == 0)
			return null;
		return _texts.Peek();
	}

	/// <summary>
	/// Removes and returns the value at the head of the queue, and also sets
	/// its visibility to false.
	/// </summary>
	public BonusText? PopHead()
	{
		BonusText? bonusTimestamp = GetHead();
		if (bonusTimestamp == null)
			return null;

		_texts.Dequeue();
		bonusTimestamp.Text.Visible = false;
		return bonusTimestamp;
	}

	/// <summary>
	/// Updates the queue, updating the time left of every bonus text still
	/// present, and removing the bonus texts which are expired.
	/// </summary>
	public void Update()
	{
		foreach (BonusText text in _texts)
		{
			text.TimeLeft -= Time.deltaTime;
		}

		if (SceneHelper.GameSceneLoaded)
		{
			for (int i = 0; i < _texts.Count; i++)
			{
				BonusText text = _texts.Peek();
				if (text.TimeLeft <= 0)
				{
					PopHead();
				}
			}
		}
	}
}

