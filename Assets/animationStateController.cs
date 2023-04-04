using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
public float speed=5;
public float turnSpeed=90;

Animator animator;
int isWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
      animator = GetComponent<Animator>();  
      isWalkingHash= Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {   bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed= Input.GetKey("w");
        // bool backwardPressed= Input.GetKey("s");
          //bool leftPressed= Input.GetKey("a");
           //bool rightPressed= Input.GetKey("d");




       if(!isWalking && forwardPressed) 
       {

 animator.SetBool(isWalkingHash, true);
       }

 if(isWalking && !forwardPressed) 
       {

 animator.SetBool(isWalkingHash, false);
       }


/*if(!isWalking && backwardPressed) 
       {

 animator.SetBool(isWalkingHash, true);
       }

 if(isWalking && !backwardPressed) 
       {

 animator.SetBool(isWalkingHash, false);
       }


       if(!isWalking && leftPressed) 
       {

 animator.SetBool(isWalkingHash, true);
       }

 if(isWalking && !leftPressed) 
       {

 animator.SetBool(isWalkingHash, false);
       }



 if(!isWalking && rightPressed) 
       {

 animator.SetBool(isWalkingHash, true);
       }

 if(isWalking && !rightPressed) 
       {

 animator.SetBool(isWalkingHash, false);
       }*/

  transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime);







    }
}
