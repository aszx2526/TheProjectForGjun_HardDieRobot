using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class onMyPlayerForSomeControll : MonoBehaviour {
    public float myMoveSpeed = 10.0F;
    public float myRotationSpeed = 100.0F;
    public float myJumpHeigh;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //float rotation = Input.GetAxis("Horizontal") * myRotationSpeed;
        //float translation = Input.GetAxis("Vertical") * myMoveSpeed;
        float h = CrossPlatformInputManager.GetAxis("Horizontal")* myRotationSpeed;
        float v = CrossPlatformInputManager.GetAxis("Vertical")* myMoveSpeed;
        h *= Time.deltaTime;
        v *= Time.deltaTime;
        transform.Rotate(0, h, 0);
        transform.Translate(0, 0, v);

        if (Input.GetKeyDown(KeyCode.Space)) {
            myJumpFN();
        }
    }
    public void myJumpFN() {
        if (GetComponent<Rigidbody>().velocity.y == 0) {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, myJumpHeigh, 0));
        }
    }
}
