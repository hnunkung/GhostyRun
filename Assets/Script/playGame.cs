using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    public void startGame () {
        //SceneManager.LoadScene(SceneManager.GetActiveScene());
        StartCoroutine(switchScene());
        Debug.Log("Startgame");
    }

    public void quitGame() {
        Application.Quit();
    }

    IEnumerator switchScene() {
        yield return new WaitForSeconds(.25f);
        SceneManager.LoadScene("Main");
    }
}
