using System.Collections.Generic;
using UnityEngine;

namespace BlasII.StylePoints.UI;

/// <summary>
/// A graphical component, capable of initializing itself late enough to be able
/// to be displayed on the game window.
/// </summary>
public abstract class Component
{
	/* Properties */

	/// <summary>
	/// The name of Unity component.
	/// </summary>
	public string Name { get; init; }

	/// <summary>
	/// Makes the component visible or hides it.
	/// When called for the first time, initializes the game objects to display.
	/// </summary>
	public bool Visible
	{
		get => _visible;
		set {
			if (!_created)
			{
				gameObjects.AddRange(Create());
				_created = true;
			}

			foreach (GameObject gameObject in gameObjects)
			{
				gameObject.SetActive(value);
			}

			_visible = value;
		}
	}

	/* Members */

	private bool _created = false;
	private bool _visible = false;

	/// <summary>
	/// Contains the the game objects which compose the component.
	/// </summary>
	protected List<GameObject> gameObjects = new ();

	/* Constructors */

	/// <summary>
	/// Initializes a new component (requires at least a name).
	/// </summary>
	public Component(string name)
	{
		Name = name;
	}

	/* Abstract methods */

	/// <summary>
	/// Initializes the graphical objects which compose the component at a later
	/// stage.
	/// </summary>
	protected abstract List<GameObject> Create();
}

