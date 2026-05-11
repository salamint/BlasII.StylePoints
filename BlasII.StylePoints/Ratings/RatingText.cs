using BlasII.ModdingAPI.Helpers;
using Il2CppTMPro;
using UnityEngine;

using BlasII.StylePoints.UI;

namespace BlasII.StylePoints.Ratings;

/// <summary>
/// Class used to display the text for a rating.
/// The content is split in two parts:
/// <list type="number">
///		<item>
///			<term>The first letter</term>
///			<description>
///				It is capitalized and bigger than the rest of the text.
///			</description>
///		</item>
///		<item>
///			<term>The rest of the word</term>
///			<description>Is smaller than the first letter.</description>
///		</item>
/// </list>
/// </summary>
public class RatingText
{
	/* Constants */

	/// <summary>
	/// How many times is the first (capital) letter bigger than the rest of the
	/// word.
	/// </summary>
	public static readonly int LETTER_SIZE_FACTOR = 4;

	/// <summary>
	/// By how many pixels is the shadow of the text offsetted by for the normal
	/// text.
	/// For the capital letter, this value is multiplied by the size factor.
	/// </summary>
	public static readonly int TEXT_SHADOW_OFFSET = 4;

	/// <summary>
	/// The size of the normal text for the rest of the word.
	/// The size of the first (capital) letter is computed using this value
	/// multiplied by the size factor.
	/// </summary>
	public static readonly int TEXT_SIZE = 64;

	/// <summary>
	/// The offset of the shadow for the first (capital) letter.
	/// Is computed using the shadow offset and the size factor.
	/// </summary>
	public static readonly int LETTER_SHADOW_OFFSET = TEXT_SHADOW_OFFSET * LETTER_SIZE_FACTOR;

	/// <summary>
	/// The size of the first (capital) letter, is computed using the text size
	/// and the size factor.
	/// </summary>
	public static readonly int LETTER_SIZE = TEXT_SIZE * LETTER_SIZE_FACTOR;

	/// <summary>
	/// The size of the rectangle containing either part of the content.
	/// </summary>
	public static readonly Vector2 RECT_SIZE = new Vector2(128, 128);

	/* Properties */

	/// <summary>
	/// The content of the rating text.
	/// Multiple words work, but a single word is recommended.
	/// </summary>
	public string Text { get; init; }

	/// <summary>
	/// The color to use to display the text.
	/// </summary>
	public Color Color { get; init; }

	/// <summary>
	/// Gets and sets the visibility of both parts of the text.
	/// </summary>
	public bool Visible
	{
		get => LetterText.Visible && WordText.Visible;
		set {
			if (SceneHelper.GameSceneLoaded)
			{
				LetterText.Visible = value;
				WordText.Visible = value;
			}
		}
	}

	/* Members */

	private TextShadow LetterText;
	private TextShadow WordText;

	/* Constructors */

	/// <summary>
	/// Initializes a new RatingText object.
	/// Generates the TextShadow objects for both parts of the text.
	/// </summary>
	public RatingText(string text, Color color)
	{
		Text = text;
		Color = color;

		LetterText = new ()
		{
			Name = "LetterRect",
			Position = new Vector2(336, 416),
			Size = RECT_SIZE,
			Text = Text.Substring(0, 1),
			TextAlignment = TextAlignmentOptions.Right,
			TextColor = Color,
			TextSize = LETTER_SIZE,
			ShadowOffset = LETTER_SHADOW_OFFSET,
		};

		WordText = new ()
		{
			Name = "WordRect",
			Position = new Vector2(464, 400),
			Size = RECT_SIZE,
			Text = Text.Substring(1),
			TextAlignment = TextAlignmentOptions.Left,
			TextColor = Color,
			TextSize = TEXT_SIZE,
			ShadowOffset = TEXT_SHADOW_OFFSET,
		};
	}
}

