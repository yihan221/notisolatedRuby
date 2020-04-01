using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playercontroller : MonoBehaviour
{
    public float moveForce = 5, AttackMultipler = 2; 
    Rigidbody2D myBody;
    // Start is called before the first frame update
    protected bool Attack;
    public void Start()
    {
        myBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"),CrossPlatformInputManager.GetAxis("Vertical"))* moveForce;
        bool isAttcking = CrossPlatformInputManager.GetButton("Attack");
        //Debug.Log(isAttcking ? AttackMultipler : 1);
        myBody.AddForce(moveVec * (isAttcking ? AttackMultipler : 1));
     /*   if(!Attack && joybutton.Pressed)
        {
            Attack = true;
            Vector3 pos = gameObject.transform.position + new Vector3(-0.6f, 0, 0);
            Instantiate(Bullet, pos, gameObject.transform.rotation);
        }
        if (!Attack && joybutton.Pressed)
        {
            Attack = false;
        }
       void OnPointerDown(PointerEventData data) 
        { 
            if(data.button==true){
                Vector3 pos = gameObject.transform.position + new Vector3(-0.6f, 0, 0);
                Instantiate(Bullet, pos, gameObject.transform.rotation);
            }
        }*/
    }
}
