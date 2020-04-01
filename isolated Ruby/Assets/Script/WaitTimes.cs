using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaitTimes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waittime(3));      // 執行 Ienumerator
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waittime(int mytime)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
