using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onRoom2 : MonoBehaviour {
    public GameObject[] myRoomCreaterList;
    // Use this for initialization
    void Start()
    {
        for (int a = 0; a < myRoomCreaterList.Length; a++)
        {
            myRoomCreaterList[a].gameObject.GetComponent<onMyNextRoomCreater>().isRoomBeCreate = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
