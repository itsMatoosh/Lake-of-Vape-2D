﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/// <summary>
/// Represents a single game.
/// </summary>
public class Game {
	/// <summary>
	/// Levels played during this game.
	/// </summary>
	public List<string> playedLevels;
	/// <summary>
	/// Settings of this game.
	/// </summary>
	public GameSettings settings;


	/// <summary>
	/// Initializes a new instance of the <see cref="Game"/> class.
	/// </summary>
	public Game (GameSettings settings) {
		this.settings = settings;

		initGame ();
	}

	/// <summary>
	/// Inits the game.
	/// </summary>
	private void initGame() {
		Network
	}
}
