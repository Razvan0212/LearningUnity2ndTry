using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!FindObjectOfType<GameManager>().GetState()) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (player.position.y <= 0.9)
                FindObjectOfType<GameManager>().EndGame();
        }
    }
}
