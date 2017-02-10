using UnityEngine;
using System;
using System.Collections.Generic;

[SerializableAttribute]
public class UserData {

	[SerializeField] private string name;
	[SerializeField] private List<UserStageData> userStagesData;

	public string Name
	{
		get { return name; }
	}

	public List<UserStageData> Stages
	{
		get { return userStagesData; }
	}

	public void CreateNewData ()
	{
		userStagesData = new List<UserStageData>();
		for (int i=1; i<10; i++) 
		{
			bool opened = (i == 1) ? true : false;
			var stageData = new UserStageData(i, opened);
			userStagesData.Add(stageData);
		}
	}

	public UserStageData Stage(int id)
	{
		return userStagesData.Find(s => s.Id == id);
	}

}
