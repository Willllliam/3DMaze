using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageSelectViewController : MonoBehaviour {

	public StageSelectButtonController[] stageSelectButtons;

	void Start () {
		for (int i = 0; i < stageSelectButtons.Length; i++) {
			if (i < GameManager.instance.currentOpenNum) {
				stageSelectButtons [i].ButtonAvailable ();
			} else {
				stageSelectButtons [i].ButtonUnavailable ();
			}
		}
	}

	public void ViewStart () {
		var userData = GameManager.instance.UserData;
		for (int i=1; i<10; i++) 
		{
			stageSelectButtons[i-1].SetStageData(userData.Stage(i));
		}
	}
}
