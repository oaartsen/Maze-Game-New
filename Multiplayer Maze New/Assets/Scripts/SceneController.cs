using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void LoadMainGamelScene() {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene() {
        SceneManager.LoadScene(0);
    }

    public void LoadTutorialScene() {
        SceneManager.LoadScene(3);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
