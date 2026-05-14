using BlasII.Framework.UI;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace BlasII.StylePoints.UI;

/// <summary>
/// Enumeration containg the different alignment options possible for a bar.
/// </summary>
public enum BarAlignment
{
	/// <summary>
	/// Aligns the bar on the left side.
	/// </summary>
    Left,

	/// <summary>
	/// Aligns the bar in the center.
	/// </summary>
	Center,

	/// <summary>
	/// Aligns the bar on the right.
	/// </summary>
	Right
}


/// <summary>
/// Displays a bar that can change of size.
/// </summary>
public class Bar : Component
{
	/* Properties */

	/// <summary>
	/// The Position on the screen in pixels (center).
	/// </summary>
	public Vector2 Position { get; init; }

	/// <summary>
	/// The size of the bar in pixels.
	/// </summary>
	public Vector2 Size { get; init; }

	/// <summary>
	/// The color of the bar (defaults to white).
	/// </summary>
	public Color Color { get; init; }

	/// <summary>
	/// The alignment of the bar.
	/// </summary>
	public BarAlignment Alignment { get; init; }

	/* Members */

	private Image? _image;

	/* Constructors */

	/// <summary>
	/// Initializes a new bar.
	/// </summary>
	public Bar(
		string name,
		Vector2 position,
		Vector2 size,
		BarAlignment alignment = BarAlignment.Left,
		Color? color = null
	) : base(name)
	{
		Position = position;
		Size = size;
		Color = color ?? Color.white;
		Alignment = alignment;
	}

	/* Methods */

	/// <summary>
	/// Create the bar's image.
	/// </summary>
	protected override List<GameObject> Create()
	{
		List<GameObject> gameObjects = new ();

		_image = UIModder.Create(new RectCreationOptions()
		{
			Name = Name,
			Parent = UIModder.Parents.GameLogic,
			Position = Position,
			Size = Size,
		}).AddImage(new ImageCreationOptions()
		{
			Color = Color
		});
		gameObjects.Add(_image.gameObject);

		return gameObjects;
	}

	/// <summary>
	/// Updates the size of the bar from the given ratio (floating point between
	/// 0 and 1).
	/// To fill the bar at 80%, the ratio would be 8/10 or 0.8.
	/// </summary>
	public void Update(float ratio)
	{
		if (Visible && _image != null)
		{
			float width = Size.x * ratio;
			_image.rectTransform.SetSize(new Vector2(width, Size.y));

			float x = Position.x;
			float offset = (Size.x - width) / 2;
			switch (Alignment)
			{
				case BarAlignment.Left:
					x -= offset;
					break;
				case BarAlignment.Right:
					x += offset;
					break;
			}
			_image.rectTransform.SetPosition(new Vector2(x, Position.y));
		}
	}
}

