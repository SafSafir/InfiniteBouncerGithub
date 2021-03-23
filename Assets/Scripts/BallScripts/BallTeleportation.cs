using UnityEngine;

public class BallTeleportation : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        TeleportTheBall();
    }

    private void TeleportTheBall()
    {
        if (transform.position.x < -StickGenerate.range / 2)
        {
            transform.position = new Vector3(StickGenerate.range / 2, transform.position.y, transform.position.z);
        }
        if (transform.position.x > StickGenerate.range / 2)
        {
            transform.position = new Vector3(-StickGenerate.range / 2, transform.position.y, transform.position.z);
        }
    }
}