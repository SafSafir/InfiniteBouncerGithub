using UnityEngine;

public class MainMenuBall : MonoBehaviour
{
    public Sprite[] spriteArr;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "middle")
        {
            gameObject.GetComponentInChildren<Rigidbody2D>().velocity = new Vector2(0, 5);
            spriteRenderer.sprite = spriteArr[Random.Range(0, spriteArr.Length)];
        }
    }
}