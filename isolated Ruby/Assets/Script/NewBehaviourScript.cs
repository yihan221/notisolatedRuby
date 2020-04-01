using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Bullet;

    public Button button;
    public Button left;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button lft = left.GetComponent<Button>();
        lft.onClick.AddListener(LeftOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(+0.1f,0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, +0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, -0.1f, 0);
        }
        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("攻擊攻擊");
            
            Vector3 pos = gameObject.transform.position + new Vector3(-0.6f, 0, 0);

            Instantiate(Bullet, pos, gameObject.transform.rotation);

        }*/
        
    }

    /*void GetMouseButtonDown(){
        Debug.Log("攻擊攻擊");
    }*/

    void TaskOnClick(){
		Debug.Log ("You have clicked the button!");

        Vector3 pos = gameObject.transform.position + new Vector3(-0.6f, 0, 0);

        Instantiate(Bullet, pos, gameObject.transform.rotation);
	}
    public void LeftOnClick(){
         gameObject.transform.position += new Vector3(-0.1f, 0, 0);
         
     }
}