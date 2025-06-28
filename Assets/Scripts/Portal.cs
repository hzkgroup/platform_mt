using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portalMenuCanvas; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            portalMenuCanvas.SetActive(true); 
            Time.timeScale = 0f;
        }
    }
}