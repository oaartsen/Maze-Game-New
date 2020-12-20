using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndsceneRestart : MonoBehaviour
{
    float exitInput = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        exitInput = Input.GetAxis("Submit");
        ChangeScene();
    }
    private void ChangeScene()
    {
        if (exitInput != 0)
        {
            exitInput = 0f;
            SceneManager.LoadScene(0);
        }
    }
    
}
