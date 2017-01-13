using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleViewController : MonoBehaviour {

	public Button startButton;

	// Use this for initialization
	void Start () {
		startButton.onClick.AddListener(PushStartButton);
	}
	
	// Update is called once per frame
	private void PushStartButton () {
		ViewManager.instance.ChangeView(Const.ViewType.StageSelect);
	}
}
