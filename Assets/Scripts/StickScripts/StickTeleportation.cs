using UnityEngine;

public class StickTeleportation : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        TeleportSticks();
    }

    private void TeleportSticks()
    {
        if (transform.position.x >= StickGenerate.range * 2)
        {
            transform.position = new Vector3(-StickGenerate.range, transform.position.y, 0);
        }
        if (transform.position.x <= -StickGenerate.range * 2)
        {
            transform.position = new Vector3(StickGenerate.range, transform.position.y, 0);
        }
    }
}