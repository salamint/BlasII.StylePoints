using BlasII.ModdingAPI.Input;
using BlasII.StylePoints.UI;
using System.Collections.Generic;
using UnityEngine;

namespace BlasII.StylePoints;

/// <summary>
/// Displays debug information for the style points mod on top of the game's
/// canvas.
/// Can be toggled on and off by pressing F8.
/// </summary>
public class DebugInfo
{
	/* Constants */

	/// <summary>
	/// The toggle keybing name. Default to F8.
	/// </summary>
	public static readonly string TOGGLE_INFO_KEYBIND = "ToggleStylePointsInfo";

	/* Properties */

	/// <summary>
	/// The style points mod instance. Used to access the input handler and
	/// current score.
	/// </summary>
	public StylePoints StylePoints { get; init; }

	/// <summary>
	/// The input handler
	/// </summary>
	public InputHandler InputHandler { get => StylePoints.InputHandler; }

	/// <summary>
	/// Makes the debug information vissible or invisible.
	/// Internally makes visible or invisible every component.
	/// </summary>
	public bool Visible
	{
		get => scoreText.Visible;
		set => scoreText.Visible = value;
	}

	/* Members */

	private TextShadow scoreText = new (
		"ScoreText",
		position: new Vector2(-872, 0),
		size: new Vector2(128, 128),
		text: "",
		textSize: 48,
		shadowOffset: 3
	);

	/* Constructors */

	/// <summary>
	/// Initializes a new debug information from an instance of the mod.
	/// </summary>
	public DebugInfo(StylePoints stylePoints)
	{
		StylePoints = stylePoints;
	}

	/* Methods */

	/// <summary>
	/// Initializes late the parts of the debug information screen that need to
	/// be initialized after the mod has been properly initialized, such as
	/// registering the keybindings.
	/// </summary>
	public void Init()
	{
		InputHandler.RegisterDefaultKeybindings(new Dictionary<string, KeyCode>()
		{
			{ TOGGLE_INFO_KEYBIND, KeyCode.F8 },
		});
	}

	/// <summary>
	/// Checks for user input to know when to be toggled on/off and update the
	/// text of the debug information displayed.
	/// </summary>
	public void Update()
	{
		if (InputHandler.GetKeyDown(TOGGLE_INFO_KEYBIND))
		{
			Visible = !Visible;
		}

		scoreText.Text = $"Score: {StylePoints.RatingScore.Score:F2}";
	}
}

