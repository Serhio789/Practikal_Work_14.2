using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    public GameObject effects;
    public float time_Deafh = 4;
    public GameObject player;
    public GameObject button_restart_game;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeafTrigger"))
        {
            effects.SetActive(true);
            player.SetActive(false);
            button_restart_game.SetActive(true);
        }
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}