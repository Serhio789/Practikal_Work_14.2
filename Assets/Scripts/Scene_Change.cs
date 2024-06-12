using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    public int namber_Scene_New;

    public void Next_Scene_Clik()
    {
        SceneManager.LoadScene(namber_Scene_New + 1);
    }
}
