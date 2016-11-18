using UnityEngine;
using System.Collections;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	protected static T Instance;
	public static T instance {
		get {
			if (Instance == null) {
				Instance = (T)FindObjectOfType (typeof(T));

				if (Instance == null) {
					Debug.LogWarning (typeof(T) + "is nothing");
				}
			}

			return Instance;
		}
	}

	protected void Awake()
	{
		CheckInstance();
	}

	protected bool CheckInstance()
	{
		if( Instance == null)
		{
			Instance = (T)this;
			return true;
		}else if( instance == this )
		{
			return true;
		}

		Destroy(this);
		return false;
	}
}