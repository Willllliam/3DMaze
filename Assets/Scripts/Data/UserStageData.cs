using UnityEngine;
using System;
using System.Collections.Generic;

[SerializableAttribute]
public class UserStageData {

	[SerializeField] private int id;
	[SerializeField] private float clearTime;
	[SerializeField] private Const.StageState stageState;

	public int Id { get{ return id; } }
	public float ClearTime { get{ return clearTime; } }
	public Const.StageState StageState { get{ return stageState; } }

	public UserStageData (int identifier, bool opened = false) 
	{
		id = identifier;
		clearTime = 0f;
		stageState = opened ? Const.StageState.Opened : Const.StageState.Locked;
	}

	public void SetScore (float time)
	{
		stageState = Const.StageState.Cleared;
		clearTime = (time < clearTime) ? time : clearTime;
	}

	public void Open ()
	{
		if (stageState != Const.StageState.Cleared) 
			stageState = Const.StageState.Opened;
	}

}
