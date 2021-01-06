//Can be used for start menu/screen
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour{

  public int levelNum;
  public string levelName;

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player")){
      SceneManager.LoadScene(levelNum);
      SceneManager.LoadScene(levelName);
    }   
  }
}