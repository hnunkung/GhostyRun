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
        	GM.score = (player.position.z)*4;
        	scoreText.text = (GM.score+GM.coinTotal).ToString("0");
        	
        }
        
        
        // Debug.Log(player.position.z);
    }
}
