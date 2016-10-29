using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMyNextRoomCreater : MonoBehaviour {
    public GameObject[] myRoomList;
    public GameObject myRoomCreatePoint;
    public int myRoomCreaterMod;
    public bool isRoomBeCreate;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            if (!isRoomBeCreate) {
                switch (myRoomCreaterMod) {
                    case 0:
                        isRoomBeCreate = true;
                        GameObject myRoom1 =  Instantiate(myRoomList[0].gameObject, myRoomCreatePoint.transform.position, myRoomCreatePoint.transform.rotation)as GameObject;
                        GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount++;
                        myRoom1.name = GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount.ToString();
                        myRoom1.transform.parent = GameObject.Find("myRoomManager").gameObject.transform;
                        
                        break;
                    case 1:
                        isRoomBeCreate = true;
                        GameObject myRoom2 = Instantiate(myRoomList[0].gameObject, myRoomCreatePoint.transform.position, myRoomCreatePoint.transform.rotation) as GameObject;
                        GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount++;
                        myRoom2.name = GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount.ToString();
                        myRoom2.transform.parent = GameObject.Find("myRoomManager").gameObject.transform;
                        break;
                    case 2:
                        isRoomBeCreate = true;
                        GameObject myRoom3 = Instantiate(myRoomList[0].gameObject, myRoomCreatePoint.transform.position, myRoomCreatePoint.transform.rotation) as GameObject;
                        GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount++;
                        myRoom3.name = GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount.ToString();
                        myRoom3.transform.parent = GameObject.Find("myRoomManager").gameObject.transform;
                        break;
                }
            }
        }
    }
}
