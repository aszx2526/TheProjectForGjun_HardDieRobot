using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBattery : MonoBehaviour {
    public float myRollspeed;
    public GameObject myChild;
    //public Quaternion myQuaternion;
    public Vector3 myEulangle;
    public int myMod;
    // Use this for initialization
    void Start()
    {
        myChild = transform.GetChild(0).gameObject;
        //myQuaternion = myChild.transform.rotation;
        myEulangle = myChild.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (myEulangle.y > 360 || myEulangle.y < -360) { myEulangle.y = 0; }
        else { myEulangle.y += 1 * myRollspeed; }
        myChild.transform.eulerAngles = myEulangle;
    }
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            other.GetComponent<onMyPlayerForSomeControll>().myTargetEnergy += 20;
            Destroy(gameObject);
        }
    }
}

//in update

/*Quaternion a = transform.rotation;
  a.w += Time.deltaTime;
  transform.rotation = a;
  */

//transform.Rotate(eulerAngles Time.deltaTime*myRollspeed, 0, 0);

/*Vector3 a = transform.eulerAngles;

if (a.x > 90) { a.x = 0;  }
else { a.x += 1; }
/*print("a.x = "+ a.x);
print("transform.rotation = "+transform.rotation);
transform.eulerAngles = a;//= new Vector3(0, myRollspeed, 0);*/

//a.x += 1;
/*
if (myMod == 1)
{
    transform.rotation = myQuaternion;
}
else if (myMod == 2)
{
    if (myEulangle.x > 360 || myEulangle.x < -360) { myEulangle.x = 0; }
    else { myEulangle.x += 1 * myRollspeed; }
    transform.eulerAngles = myEulangle;
}
else { }*/
