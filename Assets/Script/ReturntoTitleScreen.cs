using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoTitleScreen : MonoBehaviour{

    public void TitleScreen()
    {
       SceneManager.LoadScene("OpenGame");
     }
}
