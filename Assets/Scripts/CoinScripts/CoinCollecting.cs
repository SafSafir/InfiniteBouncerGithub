using UnityEngine;

public class CoinCollecting : MonoBehaviour
{
    public Vector3 ballPosition;

    private void Start()
    {
    }

    private void Update()
    {
        if (GameControl.isInGameScene)
            ballPosition = GameObject.FindGameObjectWithTag("ball").transform.position;
        if (Mathf.Sqrt(Mathf.Pow((ballPosition.x - transform.position.x), 2) + Mathf.Pow((ballPosition.y - transform.position.y), 2)) <= 0.5130112f)
        {
            GameControl.SCORE += 50;
            GameControl.coinCounter++;
            RandomCoinGenerate.coinOnScreen--;
            Destroy(transform.root.gameObject);
        }
    }
}