using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{


    public KeyCode moveLeft;
    public KeyCode moveRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveLeft))
         GetComponent<Rigidbody>() .velocity = new Vector3 (-3,0,0);
            
         if (Input.GetKey(moveRight))
           GetComponent<Rigidbody>() .velocity = new Vector3 (3,0,0);



    }



    //  if (mxVal != 0){
      //      transform.Translate(mxVal, 0f, 0f);
      //      print("Mouse X movement selected:" + mxVal);
      //  bool isKeyDown = Input.GetKeyDown (KeyCode.L);

    //    if(Input.GetKeyDown (KeyCode.L))
       //     lightComponent.enabled = !lightComponent.enabled;
}
