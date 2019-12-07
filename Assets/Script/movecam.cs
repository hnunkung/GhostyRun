using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movecam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        disableAnimatorCam();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, GM.vertVel, 3);
    }

    IEnumerable disableAnimatorCam() {
        yield return new WaitForSeconds(.2f);
        GetComponent<Animator>().enabled = false;
    }

    //private void moveCame() {

    //}
}
