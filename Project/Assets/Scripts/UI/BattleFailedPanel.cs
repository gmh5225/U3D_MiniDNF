﻿using UnityEngine;
using System.Collections;

public class BattleFailedPanel : UIPanelBase
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnOkBtnClicked()
	{
		GameMain.EnterMainMenuScene();
	}
}
