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
	/* Properties */

	/// <summary>
	/// Position of the text's rect.
	/// </summary>
	public Vector2 Position
	{
		get => _position;
		set
		{
			if (_textImage != null && _shadowImage != null)
			{
				_textImage.rectTransform.SetPosition(value);
				Vector2 shadowPosition = new Vector2()
				{
					x = value.x,
					y = value.y - ShadowOffset,
				};
				_shadowImage.rectTransform.SetPosition(shadowPosition);
			}
			_position = value;
		}
	}

	/// <summary>
	/// Size of the text's rect.
	/// </summary>
	public Vector2 Size
	{
		get => _size;
		set
		{
			if (_textImage != null && _shadowImage != null)
			{
				_textImage.rectTransform.SetSize(value);
				_shadowImage.rectTransform.SetSize(value);
			}
			_size = value;
		}
	}

	/// <summary>
	/// Content of the text to display.
	/// </summary>
	public string Text
	{
		get => _text;
		set
		{
			if (_textImage != null && _shadowImage != null)
			{
				_textImage.text = value;
				_shadowImage.text = value;
			}
			_text = value;
		}
	}

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
	public Color ShadowColor { get; init; }

	/// <summary>
	/// Offset of the text's shadow (in pixels).
	/// </summary>
	public int ShadowOffset { get; init; }

	/* Members */

	private Vector2 _position;
	private Vector2 _size;
	private string _text;

	private TextMeshProUGUI? _textImage;
	private TextMeshProUGUI? _shadowImage;

	/* Constructors */

	/// <summary>
	/// Initializes a new text shadow.
	/// </summary>
	public TextShadow(
		string name,
		Vector2 position,
		Vector2 size,
		string text,
		int textSize,
		int shadowOffset,
		TextAlignmentOptions textAlignment = TextAlignmentOptions.Left,
		Color? textColor = null,
		Color? shadowColor = null
	) : base(name)
	{
		_position = position;
		_size = size;
		_text = text;
		TextSize = textSize;
		ShadowOffset = shadowOffset;
		TextAlignment = textAlignment;
		TextColor = textColor ?? Color.white;
		ShadowColor = shadowColor ?? Color.black;
	}

	/* Methods */

	/// <summary>
	/// Create the text and its shadow to be rendered.
	/// </summary>
	protected override List<GameObject> Create()
	{
		List<GameObject> gameObjects = new ();

		_shadowImage = UIModder.Create(new RectCreationOptions()
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
		gameObjects.Add(_shadowImage.gameObject);

		_textImage = UIModder.Create(new RectCreationOptions()
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
		gameObjects.Add(_textImage.gameObject);

		return gameObjects;
	}
}

