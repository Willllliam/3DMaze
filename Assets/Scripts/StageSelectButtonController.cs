using UnityEngine;
using System.Collections;

public class StageSelectButtonController : MonoBehaviour {

	public int stageNum;
	private CanvasGroup canvasGroup;
	
	public void ButtonAvailable () {
		if (canvasGroup == null) {
			canvasGroup = GetComponent<CanvasGroup> ();
		}
		canvasGroup.alpha = 1.0f;
	}

	public void ButtonUnavailable () {
		if (canvasGroup == null) {
			canvasGroup = GetComponent<CanvasGroup> ();
		}
		canvasGroup.alpha = 0.4f;
	}

	public void PushButton () {
		GameManager.instance.currentSelectStage = stageNum;
	}

}
