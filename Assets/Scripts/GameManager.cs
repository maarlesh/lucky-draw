
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public  bool gameEnded = false;
    public void endGame(int winner){
      if(gameEnded == false){
        Debug.Log("game ended");
        Debug.Log("Winnner: " + winner);
        gameEnded = true;
      }  
    }
}
