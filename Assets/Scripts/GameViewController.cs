using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameViewController : MonoBehaviour {

	public Text timeLabel;
	float time;
	bool isStart = false;

	private GameObject currentStageObj;
	public Transform stageRoot;

	int currentStageId;

	public void ShowStage () {
		int selected = GameManager.instance.currentSelectStage;
		currentStageId = selected;
		currentStageObj = (GameObject)Instantiate (Resources.Load("Stage/" + selected.ToString()));
		currentStageObj.transform.SetParent (stageRoot);
		currentStageObj.transform.localPosition = Vector3.zero;
		isStart = true;
	}

	void Update () {
		if (isStart == true) {
			time += Time.deltaTime;
			timeLabel.text = time.ToString ("F2") + "s";
		}
	}

	public void Goal()
	{
		isStart = false;
		Invoke("ToResult", 3.0f);
	}

	private void ToResult()
	{
		ViewManager.instance.ChangeView(Const.ViewType.Result);
		ViewManager.instance.resultView.UpdateValue(currentStageId, time);
		Destroy(currentStageObj, 1.0f);
	}
	
}
