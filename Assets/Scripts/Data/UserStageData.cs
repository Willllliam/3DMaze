using UnityEngine;
using System;
using System.Collections.Generic;

[SerializableAttribute]
public class UserStageData {

	[SerializeField] private string name;
	[SerializeField] private int id;
	[SerializeField] private float clearTime;
	[SerializeField] private Const.StageState stageState;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public int Id
	{
		get { return id; }
		set { id = value; }
	}

	public float clearTime
	{
		get { return clearTime; }
		set { clearTime = value; }
	}

}
