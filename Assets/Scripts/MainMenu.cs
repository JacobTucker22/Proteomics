using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     public static MainMenu inst;
     //name of scene to be loaded
     public string chosenScene = null;

     //text showing which level is currently selected
     public Text selectedLevelText;
     //buttons
     public Button BuilderButton, startButton;

     private void Awake()
     {
          inst = this;
          DontDestroyOnLoad(transform.gameObject);
     }

/*     private void Start()
     {
          Cursor.lockState = CursorLockMode.None;
     }
*/

     //Protein Builder button function
     public void selectBuilder()
     {
          chosenScene = BuilderButton.GetComponentInChildren<Text>().text;
          selectedLevelText.text = chosenScene;
     }



     //start game loads currently selected level
     //FIXME add function to load desired number of entites
     public void StartGame()
     {
          if (chosenScene == "")
          {
               Debug.Log("No Level Selected");
          }
          else
          {
               //Cursor.lockState = CursorLockMode.Locked;
               SceneManager.LoadScene(chosenScene);
          }

     }
}
