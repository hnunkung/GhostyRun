using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;
    public KeyCode moveU;
    public KeyCode moveD;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel,GM.vertVel,3);
        if((Input.GetKeyDown(moveL)) && (laneNum>1) &&(controlLocked =="n")) {
        	horizVel = -2;
        	StartCoroutine (stopSlide());
        	laneNum -=1;
        	controlLocked ="y";
        }
        if((Input.GetKeyDown(moveR)) && (laneNum<3) &&(controlLocked =="n")) {
        	horizVel = 2;
        	StartCoroutine (stopSlide());
        	laneNum +=1;
        	controlLocked ="y";
        }
        if(Input.GetKeyDown(moveU)) {
        	transform.position = new Vector3(transform.position.x, -1.35f, transform.position.z);
            StartCoroutine (stopUp());
        
        }

        if(Input.GetKeyDown(moveD)) {
        	transform.position = new Vector3(transform.position.x, -2.65f, transform.position.z);
            StartCoroutine (stopDown());
        
        }
        
    }
    //เวลาเราชนกับobjectอะไรสักอย่าง
    void OnCollisionEnter(Collision other){
    	//ชนอุปสรรค objectจะหาย ก็คือเราตายนั่นแหละ
    	if(other.gameObject.tag == "lethal"){
    		Destroy (gameObject);
    		SceneManager.LoadScene("gameover");
    	}
    	//เหมือนเก็บ item 	เก็บแล้วitemหายไป แต่เราไม่ตาย
    }
    void OnTriggerEnter(Collider other){
    	if(other.gameObject.name == "coin"){
    		Destroy (other.gameObject);
    		GM.coinTotal+=10;
    	}
    }

    IEnumerator stopSlide(){
    	yield return new WaitForSeconds(.5f);
    	horizVel = 0;
    	controlLocked ="n";
    }
    IEnumerator stopUp(){
    	yield return new WaitForSeconds(.7f);
    	transform.position = new Vector3(transform.position.x, -2.00f, transform.position.z);
    	controlLocked ="n";
    }
    IEnumerator stopDown(){
    	yield return new WaitForSeconds(.7f);
    	transform.position = new Vector3(transform.position.x, -2.00f, transform.position.z);
    	controlLocked ="n";
    }

}
