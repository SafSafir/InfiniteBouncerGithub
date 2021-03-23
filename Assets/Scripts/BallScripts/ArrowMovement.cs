using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public GameObject ball;
    public Sprite Arrow;

    private void Start()
    {
    }

    private void Update()
    {
        if (ball.transform.position.y >= 7.5f)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Arrow;
            gameObject.transform.position = new Vector3(ball.transform.position.x, 7.38f, 0);
        }
        else if (ball.transform.position.y < 7.5f)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}