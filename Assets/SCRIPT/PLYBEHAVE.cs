using UnityEngine;
using UnityEngine.InputSystem;
public class PLYBEHAVE : MonoBehaviour
{
    InputAction upButton;
    InputAction dwButton;
    InputAction LButton;
    InputAction RButton;
    AudioSource CDplayer;
    public Transform startPoint;
    public int normalspd = 2;
    public int spdup = 5;
    public int currentspd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        upButton = InputSystem.actions.FindAction("UP");
        dwButton = InputSystem.actions.FindAction("DOWN");
        LButton = InputSystem.actions.FindAction("LEFT");
        RButton = InputSystem.actions.FindAction("RIGHT");
        CDplayer = GetComponent<AudioSource>();
    }

    public void ResetPlayer()
    {
        transform.localPosition = startPoint.position;

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 playerposiotion = transform.position;
        if(playerposiotion.x<-10.75)
        {
            playerposiotion.x = (float)-10.75;
        }
        if(playerposiotion.x > 11.5)
        {
            playerposiotion.x = (float)11.5;
        }
        if (playerposiotion.y > 7.3)
        {
            playerposiotion.y = (float)7.3;
        }
        if (playerposiotion.y < -5)
        {
            playerposiotion.y = (float)-5;
        }
        if (upButton .IsPressed())
        {
            playerposiotion.y += currentspd * Time.deltaTime;
            Debug.Log("GO UP");
        }
        if (dwButton.IsPressed())
        {
            playerposiotion.y -= currentspd * Time.deltaTime;
            Debug.Log("GO DW");
        }
        if (LButton.IsPressed())
        {
            playerposiotion.x -= currentspd * Time.deltaTime;
            Debug.Log("GO UP");
        }
        if (RButton.IsPressed())
        {
            playerposiotion.x += currentspd * Time.deltaTime;
            Debug.Log("GO DW");
        }
        transform.position = playerposiotion;
    }

    void OnTriggerEnter(Collider other)
    {
        CDplayer.Play();
    }

    public void ActivatePowerUp()
    {
        currentspd = spdup;
    }

    public void RemovePowerUp()
    {
        currentspd = normalspd;
    }
}
