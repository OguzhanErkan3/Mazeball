using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartButtonn : MonoBehaviour
{
  

    public void restartGame(){

       
        SceneManager.LoadScene("Game");
        
   }

}
