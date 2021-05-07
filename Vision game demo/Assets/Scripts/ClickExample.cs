
using UnityEngine.SceneManagement; 

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickExample : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Debug.Log("You have clicked the button!");
	}
}
