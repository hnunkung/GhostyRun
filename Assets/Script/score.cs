using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{


    public Transform player;
    public float player1;
    public Text scoreText;
    void Update()
    {
        if(player){
        	scoreText.text = player.position.z.ToString("0");
        	GM.score = player.position.z;
        }
        
        
        // Debug.Log(player.position.z);
    }
}
