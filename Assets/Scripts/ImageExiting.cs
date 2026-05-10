using UnityEngine;

public class ImageExiting : MonoBehaviour
{

    public GameObject left;
    public GameObject right;
    public GameObject wall;
    public GameObject wrong;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Player"){
            left.SetActive(false);
            right.SetActive(false);
            wall.SetActive(true);
            wrong.SetActive(false);
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
