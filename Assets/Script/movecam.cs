using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class movecam : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(disableAnimator());
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, GM.vertVel, 3);
    }

    IEnumerator disableAnimator() {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(1.1f);
        GetComponent<Animator>().enabled = false;
        Debug.Log("Remove Animator Propert");
    }

    //private void moveCame() {

    //}
}
