using BlasII.Framework.UI;
using Il2CppTMPro;
using UnityEngine;
using System.Collections.Generic;

namespace BlasII.StylePoints.UI;

/// <summary>
/// Displays a text and renders a shadow under the text.
/// </summary>
public class TextShadow : Component
{
	/// <summary>
	/// Name of the Unity component.
	/// </summary>
	public string Name { get; init; }

	/// <summary>
	/// Position of the text's rect.
	/// </summary>
	public Vector2 Position { get; init; }

	/// <summary>
	/// Size of the text's rect.
	/// </summary>
	public Vector2 Size { get; init; }

	/// <summary>
	/// Content of the text to display.
	/// </summary>
	public string Text { get; init; }

	/// <summary>
	/// Alignment option of the text (left, center or right).
	/// </summary>
	public TextAlignmentOptions TextAlignment { get; init; }

	/// <summary>
	/// Color of the text to display.
	/// </summary>
	public Color TextColor { get; init; }

	/// <summary>
	/// Size of the text to display (in pixels).
	/// </summary>
	public int TextSize { get; init; }

	/// <summary>
	/// Color of the text's shaodw (defaults to black).
	/// </summary>
	public Color ShadowColor { get; init; } = Color.black;

	/// <summary>
	/// Offset of the text's shadow (in pixels).
	/// </summary>
	public int ShadowOffset { get; init; }

	private TextMeshProUGUI _text;
	private TextMeshProUGUI _textShadow;

	/// <summary>
	/// Create the text and its shadow to be rendered.
	/// </summary>
	protected override List<GameObject> Create()
	{
		List<GameObject> gameObjects = new ();

		_textShadow = UIModder.Create(new RectCreationOptions()
		{
			Name = $"{Name}Shadow",
			Parent = UIModder.Parents.GameLogic,
			Position = new Vector2()
			{
				x = Position.x,
				y = Position.y - ShadowOffset,
			},
			Size = Size,
		}).AddText(new TextCreationOptions()
		{
			Alignment = TextAlignment,
			Contents = Text,
			Color = ShadowColor,
			FontSize = TextSize
		});
		gameObjects.Add(_textShadow.gameObject);

		_text = UIModder.Create(new RectCreationOptions()
		{
			Name = Name,
			Parent = UIModder.Parents.GameLogic,
			Position = Position,
			Size = Size,
		}).AddText(new TextCreationOptions()
		{
			Alignment = TextAlignment,
			Contents = Text,
			Color = TextColor,
			FontSize = TextSize
		});
		gameObjects.Add(_text.gameObject);

		return gameObjects;
	}

	/// <summary>
	/// Sets the content of the text to display to a new value.
	/// </summary>
	public void SetText(string text)
	{
		if (_text != null)
		{
			_text.text = text;
			_textShadow.text = text;
		}
	}
}

