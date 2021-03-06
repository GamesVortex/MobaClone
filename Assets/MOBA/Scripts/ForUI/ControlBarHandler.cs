﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBarHandler : MonoBehaviour {
//display health and power cooldowns for my player
	// Use this for initialization
	public MyPlayer myPlayer;
	public Health health;
	public PowerHandler powers;
	public PlayerInputHandler playerInput;

	public UI_PowerButton[] powerButtons;

	public BarControl healthBar;
	void Start () {
		myPlayer.playerSet += playerIsSet;
	}
	void playerIsSet()
	{
		//grab health
		//grab powers
		//set path to playerInput
		health = myPlayer.myPlayer.GetComponent<Health>();
		if ( health )
		{
			health.healthChange += updateBar;
		}
		powers = myPlayer.myPlayer.GetComponent<PowerHandler>();
		/*for(int x=0;x<powers.powers.Length;x++)
		{
			powerButtons[0].setBound( powers.powers[1] );
		}*/
		powerButtons[0].setBound( powers.powers[1] );
		playerInput = myPlayer.myPlayer.GetComponent<PlayerInputHandler>();
	}
	void updateBar(int newHealth)
	{
		healthBar.setPercent(newHealth, health.maxHealth);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
