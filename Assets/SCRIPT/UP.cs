using UnityEngine;

public class UP : MonoBehaviour
{
    public PLYBEHAVE player;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.ActivatePowerUp();

            gameObject.SetActive(false);
        }
    }

    public void ResetPowerUp()
    {
        transform.position = startPosition;
        gameObject.SetActive(true);
    }
}
