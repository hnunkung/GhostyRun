using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{
    public GameObject coin;
    //public bool activeme;
    // Start is called before the first frame update
    void Start()
    {
        coin.GetComponent<MeshRenderer>().enabled = false;
        coin.GetComponent<CapsuleCollider>().enabled = false;
        Debug.Log("Remove");
        StartCoroutine(setDisactiveObj());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "coin")
        {
            transform.Rotate(0, 0, 5);
        }
    }

    IEnumerator setDisactiveObj() {
        yield return new WaitForSeconds(4.5f);
        //coin.SetActive(true);
        coin.GetComponent<MeshRenderer>().enabled = true;
        coin.GetComponent<CapsuleCollider>().enabled = true;
        Debug.Log("Back to Active");
    }
}
