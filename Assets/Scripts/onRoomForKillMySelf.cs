using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onRoomForKillMySelf : MonoBehaviour {
    public int myID;
    // Use this for initialization
    void Start () {
        myID = GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount;
    }
	
	// Update is called once per frame
	void Update () {
        if ((GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myRoomCount - myID) > 4)
        {Destroy(gameObject);}
    }
}
