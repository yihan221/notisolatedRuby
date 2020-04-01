using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image pic;
    [SerializeField] private int num;
    void Start()
    {
        num = 0;
        pic.color = new Color(1, 1, 1, 0);
        StartCoroutine(waittime(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   IEnumerator waittime(int mytime)
    {
        yield return new WaitForSeconds(3);
        pic.color = new Color(1, 1, 1, 1);
    }
    
}
