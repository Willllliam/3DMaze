using UnityEngine;
using System.Collections;

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
		
	}
}
