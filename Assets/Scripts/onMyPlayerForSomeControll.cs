using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
public class onMyPlayerForSomeControll : MonoBehaviour {
    public float myMoveSpeed = 10.0F;
    public float myRotationSpeed = 100.0F;
    public float myJumpHeigh;
    public float myFullEnergy;
    public float myTargetEnergy;
    public float myEnergy;
    public Image myEnergyBar_Image;
    public Image myTargetEnergyBar_Image;

    public float myEnergyUpdateSpeed;
    // Use this for initialization
    void Start () {
        print("hehehaha");
        myEnergy = myFullEnergy;
        myTargetEnergy = myFullEnergy;
    }
	
	// Update is called once per frame
	void Update () {


        if (myTargetEnergy > myEnergy) { myEnergy += Time.deltaTime * myEnergyUpdateSpeed; }
        else if (myTargetEnergy < myEnergy) { myEnergy -= Time.deltaTime * myEnergyUpdateSpeed; }
        else { myEnergy = myTargetEnergy; }

        myTargetEnergyBar_Image.fillAmount = myTargetEnergy / myFullEnergy;
        myEnergyBar_Image.fillAmount = myEnergy / myFullEnergy;
        //float rotation = Input.GetAxis("Horizontal") * myRotationSpeed;
        //float translation = Input.GetAxis("Vertical") * myMoveSpeed;
        /*  float h = CrossPlatformInputManager.GetAxis("Horizontal")* myRotationSpeed;
          float v = CrossPlatformInputManager.GetAxis("Vertical")* myMoveSpeed;
          h *= Time.deltaTime;
          v *= Time.deltaTime;
          transform.Rotate(0, h, 0);
          transform.Translate(0, 0, v);

          if (Input.GetKeyDown(KeyCode.Space)) {
              myJumpFN();
          }*/
    }
    /*
    public void myJumpFN() {
        if (GetComponent<Rigidbody>().velocity.y == 0) {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, myJumpHeigh, 0));
        }
    }*/
}
