using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame(){
       SceneManager.LoadScene(0);
   }
   public void QuiteGame(){
       Application.Quit();
   }
}
