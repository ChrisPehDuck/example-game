using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //only executed if condition is met
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
