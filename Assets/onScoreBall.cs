using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onScoreBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myScoreNow += 10;
            Destroy(gameObject);
        }
    }
}
