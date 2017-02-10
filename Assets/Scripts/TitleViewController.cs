using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleViewController : MonoBehaviour {

	public Button startButton;

	void Start () {
		startButton.onClick.AddListener(PushStartButton);
	}
	
	private void PushStartButton () {
		if (GameManager.instance.loaded) 
		{
			ViewManager.instance.ChangeView(Const.ViewType.StageSelect);
			ViewManager.instance.stageSelectView.ViewStart();
		}
	}
}
