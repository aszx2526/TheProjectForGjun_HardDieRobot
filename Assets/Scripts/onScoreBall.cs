using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onScoreBall : MonoBehaviour {
    public bool isNeedToDie;
    public float myDieTimer;
    public AudioClip myJuWee;
	// Use this for initialization
	void Start () {
        myJuWee = GetComponent<AudioSource>().clip;

    }
	
	// Update is called once per frame
	void Update () {
        if (isNeedToDie) {
            myDieTimer += Time.deltaTime;
            if (myDieTimer >= 0.388) {
                Destroy(gameObject);
            }
        }
	}
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            GameObject.Find("myGameManager").GetComponent<onMyGameManager>().myScoreNow += 10;
            GetComponent<AudioSource>().PlayOneShot(myJuWee);
            Color mya = GetComponent<MeshRenderer>().material.color;
            mya.a = 0;
            GetComponent<MeshRenderer>().material.color = mya;
            isNeedToDie = true;
        }
    }
}
