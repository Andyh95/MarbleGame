using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void StartButton()
	{
		Application.LoadLevel (1);
	}
	public void ExitButton()
	{
		Application.Quit ();
	}
}
