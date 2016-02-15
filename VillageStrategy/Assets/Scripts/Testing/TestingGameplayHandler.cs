using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestingGameplayHandler : MonoBehaviour {

    public KeyCode restartGame = KeyCode.R;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(restartGame))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
