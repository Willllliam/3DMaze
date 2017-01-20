using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameViewController : MonoBehaviour {

	public Text timeLabel;
	float time;
	bool isStart = false;

	public Transform stageRoot;

	public void ShowStage () {
		int selected = GameManager.instance.currentSelectStage;
		GameObject obj = (GameObject)Instantiate (Resources.Load("Stage/" + selected.ToString()));
		obj.transform.SetParent (stageRoot);
		obj.transform.localPosition = Vector3.zero;
		isStart = true;
	}

	void Update () {
		if (isStart == true) {
			time += Time.deltaTime;
			timeLabel.text = time.ToString ("F2") + "s";
		}
	}
	
}
