using UnityEngine;
using System.Collections;

public class GameManager 
: SingletonMonoBehaviour<GameManager> {

	public bool loaded = false;
	public int currentSelectStage;
	public int currentOpenNum;

	const string userDataSaveKey = "UserData";
	[SerializeField]
	private UserData userData = new UserData();
	public UserData UserData 
	{
		get { return userData; }
	}

	private void Start()
	{
		LoadUserData();
		loaded = true;
	}

	public void ClearStage(int id, float clearTime) 
	{
		userData.Stage(id).SetScore(clearTime);
		var nextStage = userData.Stage(id+1);
		if (nextStage.StageState == Const.StageState.Locked) 
		{
			nextStage.Open();
		}
		SaveUserData();
	}

	public void SaveUserData()
	{
		PlayerPrefs.SetString(
			userDataSaveKey, 
			JsonUtility.ToJson(userData));
	}

	public void LoadUserData()
	{
		if (PlayerPrefs.HasKey(userDataSaveKey))
		{
			userData = JsonUtility.FromJson<UserData>(
				PlayerPrefs.GetString(userDataSaveKey));
		}
		else 
		{
			userData.CreateNewData();
			SaveUserData();
		}
	}


}
