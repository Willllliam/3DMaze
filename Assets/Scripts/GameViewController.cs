using UnityEngine;
using System.Collections;

public class GameViewController : MonoBehaviour {

	public Transform stageRoot;

	public void ShowStage () {
		int selected = GameManager.instance.currentSelectStage;
		GameObject obj = (GameObject)Instantiate (Resources.Load("Stage/" + selected.ToString()));
		obj.transform.SetParent (stageRoot);
		obj.transform.localPosition = Vector3.zero;
	}
	
}
