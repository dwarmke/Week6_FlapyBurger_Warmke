using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReStart : MonoBehaviour

{
    // Start is called before the first frame update

public void OnRestartButtonPressed()
{
    SceneManager.LoadScene(0);
}
}
