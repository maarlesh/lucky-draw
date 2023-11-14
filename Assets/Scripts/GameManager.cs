
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public void endGame(){
      if(gameEnded == false){
        Debug.Log("game ended");
        
        gameEnded = true;
      }  
    }
}
