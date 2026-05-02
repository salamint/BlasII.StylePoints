using System.Collections.Generic;
using UnityEngine;

namespace BlasII.StylePoints.UI;

/// <summary>
/// A graphical component, capable of initializing itself late enough to be able
/// to be displayed on the game window.
/// </summary>
public abstract class Component
{
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

	private bool _created = false;
	private bool _visible = false;

	/// <summary>
	/// </summary>
	protected List<GameObject> gameObjects = new ();

	/// <summary>
	/// </summary>
	protected abstract List<GameObject> Create();
}

