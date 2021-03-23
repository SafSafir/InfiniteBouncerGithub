using UnityEngine;

public class RandomCoinGenerate : MonoBehaviour
{
    private float randomX;
    private float randomY;
    static public int coinOnScreen;
    public GameObject coin;

    private void Start()
    {
        coinOnScreen = 0;
    }

    private void Update()
    {
        Invoke("GenerateCoin", 4.0f);
    }

    private void GenerateCoin()
    {
        if (coinOnScreen < 1)
        {
            coinOnScreen++;
            randomX = Random.Range(-2f, 2f);
            randomY = Random.Range(-0f, 4f);
            Instantiate(coin, new Vector3(randomX, randomY, 0), Quaternion.identity);
        }
        new WaitForSeconds(1f);
    }
}