using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    bool respawn = Player.restart;
    public void NextLevel(int scenNumber)
    {
        SceneManager.LoadScene(scenNumber);
    }
}
