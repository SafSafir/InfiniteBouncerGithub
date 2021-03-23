using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    public Sprite[] spriteArr;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[PlayerPrefs.GetInt("PlayerPrefI", 0)];
    }

    private void Update()
    {
    }
}