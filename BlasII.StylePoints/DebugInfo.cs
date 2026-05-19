using BlasII.ModdingAPI.Input;
using BlasII.StylePoints.UI;
using System.Collections.Generic;
using UnityEngine;

namespace BlasII.StylePoints;

public class DebugInfo
{
	/* Constants */

	private static readonly string TOGGLE_INFO_KEYBIND = "ToggleStylePointsInfo";

	/* Properties */

	public StylePoints StylePoints { get; init; }

	public InputHandler InputHandler { get => StylePoints.InputHandler; }

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

	public DebugInfo(StylePoints stylePoints)
	{
		StylePoints = stylePoints;
	}

	/* Methods */

	public void Init()
	{
		InputHandler.RegisterDefaultKeybindings(new Dictionary<string, KeyCode>()
		{
			{ TOGGLE_INFO_KEYBIND, KeyCode.F8 },
		});
	}

	public void Update()
	{
		if (InputHandler.GetKeyDown(TOGGLE_INFO_KEYBIND))
		{
			Visible = !Visible;
		}

		scoreText.Text = $"Score: {StylePoints.RatingScore.Score:F2}";
	}
}

