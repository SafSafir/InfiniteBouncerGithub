using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed;

    private void Start()
    {
    }

    private void Update()
    {
        RotateCoin();
    }

    private void RotateCoin()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0));
    }
}