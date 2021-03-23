using UnityEngine;

public class BallMovement : MonoBehaviour
{
    static public float thrustY = 17.5f;
    static public float Delay = 0.6700001f;
    private float thrustX;
    private Rigidbody2D phy;
    private Collider2D coll;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        thrustX = 3.5f;
        phy = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        MoveBall(other);
    }

    private void MoveBall(Collision2D other)
    {
        if (other.gameObject.tag == "middle")
        {
            phy.velocity = new Vector3(0, thrustY, 0);
            coll.enabled = false;
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        else if (other.gameObject.tag == "right")
        {
            phy.velocity = new Vector3(thrustX, thrustY, 0);
            coll.enabled = false;
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        else if (other.gameObject.tag == "left")
        {
            phy.velocity = new Vector3(-thrustX, thrustY, 0);
            coll.enabled = false;
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        Invoke("TrueYap", Delay);
    }

    private void TrueYap()
    {
        coll.enabled = true;
    }
}