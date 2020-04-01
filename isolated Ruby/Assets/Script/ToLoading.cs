using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLoading : MonoBehaviour
{
    // Start is called before the first frame update
    int currentScene;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        // Debug.Log(currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void startScene()
    {
        SceneManager.LoadScene(0);
    }
}
