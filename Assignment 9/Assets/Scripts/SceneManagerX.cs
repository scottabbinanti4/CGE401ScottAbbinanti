//Scott Abbinanti

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerX : MonoBehaviour
{
    public void LoadThisScene(int sceneID)
    {
        Debug.Log("Pressed button");
        SceneManager.LoadScene(sceneID);
    }
}
