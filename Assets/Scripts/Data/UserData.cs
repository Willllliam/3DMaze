using UnityEngine;
using System;
using System.Collections.Generic;

[SerializableAttribute]
public class UserData {

	[SerializeField]
	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

}
