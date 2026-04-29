using BlasII.Framework.UI;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace BlasII.StylePoints.UI;


/// <summary>
/// Displays a bar that can change of size.
/// </summary>
public class Bar : Component
{
	/// <summary>
	/// The name of Unity component.
	/// </summary>
	public string Name { get; init; }

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
	public Color Color { get; init; } = Color.white;

	private Image _image;

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
		if (Visible)
		{
			_image.rectTransform.SetSize(new Vector2(Size.x * ratio, Size.y));
		}
	}
}

