using UnityEngine;
using System.Collections;

public class GameManager 
: SingletonMonoBehaviour<GameManager> {

	public int currentSelectStage;
	public int currentOpenNum;

	const string userDataSaveKey = "UserData";
	private UserData userData = new UserData();
	public UserData UserData 
	{
		get { return userData; }
		set { userData = value; }
	}

	public void ClearStage() 
	{
		
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
	}


}
