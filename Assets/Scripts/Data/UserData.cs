using UnityEngine;
using System;
using System.Collections.Generic;

[SerializableAttribute]
public class UserData {

	[SerializeField] private string name;
	[SerializeField] private List<UserStageData> userStageData 
									= new List<UserStageData>();

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public List<UserStageData> Stage
	{
		get { return userStageData; }
		set { userStageData = value; }
	}

}
