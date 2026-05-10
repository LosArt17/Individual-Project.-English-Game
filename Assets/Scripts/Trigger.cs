using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject txt;
    public GameObject sound;
    public GameObject left;
    public GameObject right;
    
    private void OnTriggerEnter(Collider collision)
    {
        txt.SetActive(true);
        sound.SetActive(true);
        left.SetActive(true);
        right.SetActive(true);
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
