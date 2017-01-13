using UnityEngine;
using System.Collections;

public class GameViewController : MonoBehaviour {

	public void ShowStage () {
		print(GameManager.instance.currentSelectStage);
	}
	
}
