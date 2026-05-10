using UnityEngine;

public class LevelNameExiting : MonoBehaviour
{

    public GameObject levelname;

    private void OnTriggerEnter(Collider collision)
    {
        levelname.SetActive(false);
        
    }
}
