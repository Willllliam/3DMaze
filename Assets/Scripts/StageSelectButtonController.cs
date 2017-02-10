using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageSelectButtonController : MonoBehaviour {

	public int stageNum;
	private bool avairable;
	private CanvasGroup canvasGroup;
	private Button button;
	[SerializeField]
	private UserStageData stageData;

	private void Start () {
		button = GetComponent<Button>();
		button.onClick.AddListener(PushButton);
	}

	public void SetStageData (UserStageData data)
	{
		stageData = data;
		if (data.StageState == Const.StageState.Locked) 
		{
			ButtonUnavailable();
		}
		else ButtonAvailable();
	}
	
	public void ButtonAvailable () 
	{
		if (canvasGroup == null) 
		{
			canvasGroup = GetComponent<CanvasGroup> ();
		}
		canvasGroup.alpha = 1.0f;
		avairable = true;
	}

	public void ButtonUnavailable () {
		if (canvasGroup == null) 
		{
			canvasGroup = GetComponent<CanvasGroup> ();
		}
		canvasGroup.alpha = 0.4f;
		avairable = false;
	}

	public void PushButton () 
	{
		if (avairable) 
		{
			GameManager.instance.currentSelectStage = stageNum;
			ViewManager.instance.ChangeView(Const.ViewType.Game);
			ViewManager.instance.gameView.ShowStage();
		}
	}

}
