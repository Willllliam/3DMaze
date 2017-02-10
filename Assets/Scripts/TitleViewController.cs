using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleViewController : MonoBehaviour {

	public Button 
		startButton,
		deleteButton;

	void Start () {
		startButton.onClick.AddListener(PushStartButton);
		deleteButton.onClick.AddListener(PushDeleteButton);
	}
	
	private void PushStartButton () 
	{
		if (GameManager.instance.loaded) 
		{
			ViewManager.instance.ChangeView(Const.ViewType.StageSelect);
			ViewManager.instance.stageSelectView.ViewStart();
		}
	}

	private void PushDeleteButton () 
	{
		PlayerPrefs.DeleteAll();
		UnityEngine.SceneManagement.SceneManager.LoadScene("Original game");
	}
}
