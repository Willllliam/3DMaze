using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageSelectButtonController : MonoBehaviour {

	public int stageNum;
	private CanvasGroup canvasGroup;
	private Button button;

	private void Start () {
		button = GetComponent<Button>();
		button.onClick.AddListener(PushButton);
	}
	
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
		print(stageNum);
		GameManager.instance.currentSelectStage = stageNum;
	}

}
