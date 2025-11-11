using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private bool started;
    private bool gameOver;
    public InputAction directionChange;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        directionChange.Enable();
    }

    void OnDisable()
    {
        directionChange.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        started = false;
        gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (directionChange.triggered)
            {
                rb.linearVelocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }

        if(! Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            //rb.linearVelocity=new Vector3(0f, -25f, 0f);
            Camera.main.GetComponent<CameraFollow>().gameOver = true;

            Debug.Log("Game Over");
        }
        
        if(directionChange.triggered)
        {
            SwitchDirection();
        }
        

    }
    
    void SwitchDirection()
    {
        if (rb.linearVelocity.z > 0)
        {
            rb.linearVelocity = new Vector3(speed, 0, 0);
        }
        else if (rb.linearVelocity.x > 0)
        {
            rb.linearVelocity = new Vector3(0, 0, speed);
        }
    }
}
