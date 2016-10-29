using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onRoom3 : MonoBehaviour {
    public GameObject[] myRoomCreaterList;
    public GameObject myScoreBall;
	// Use this for initialization
	void Start () {
        for (int a = 0; a < myRoomCreaterList.Length; a++) {
            myRoomCreaterList[a].gameObject.GetComponent<onMyNextRoomCreater>().isRoomBeCreate = false;
        }
        GameObject myScoreBalla = Instantiate(myScoreBall, transform.position, transform.rotation)as GameObject;
        myScoreBalla.transform.parent = GameObject.Find("myScoreBallManager").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
