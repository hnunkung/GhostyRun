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
        	scoreText.text = ((player.position.z)*4).ToString("0");
        	GM.score = (player.position.z)*4;
        }
        
        
        // Debug.Log(player.position.z);
    }
}
