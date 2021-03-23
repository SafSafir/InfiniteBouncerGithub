using UnityEngine;

public class ChangeTransparency : MonoBehaviour
{
    private SpriteRenderer rend;
    private int transparency;
    private float loadDuration = 1.5f;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Color textureColor = rend.material.color;
        textureColor.a = Mathf.PingPong(Time.time, loadDuration) / loadDuration;
        rend.material.color = textureColor;
    }
}