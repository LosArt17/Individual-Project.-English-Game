using UnityEngine;
using UnityEngine.SceneManagement;

public class LastTrigger1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        string tag = collision.gameObject.tag;

        if (tag.StartsWith("LastTrig"))
        {
            string number = tag.Substring(8); // длина "LastTrig"
            SceneManager.LoadScene("CongratsScene " + number);
        }
        else if (tag.StartsWith("WrongAns"))
        {
            string number = tag.Substring(8); // длина "WrongAns" тоже 8
            SceneManager.LoadScene("LoseScene " + number);
        }
    }
}