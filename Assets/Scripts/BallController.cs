using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;
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

        rb.linearVelocity = new Vector3(speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
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
