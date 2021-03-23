using System.Collections;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    static public int SCORE;
    static public float G = -41.2f;
    static public float randomValue;
    static public int coinCounter = 0;
    static public bool isInGameScene = true;
    public float maxFallSpeed;
    public float fallSpeedRatio;
    public float gRatio;
    public float delayRatio;
    public float thrustRatio;

    private void Start()
    {
        isInGameScene = true;

        Physics2D.gravity = new Vector3(0, G, 0);
        randomValue = Random.Range(3.268f, -3.268f);
        StartCoroutine(Doit());
    }

    private void Update()
    {
        randomValue = Random.Range(3.268f, -3.268f);
        if (!DestroySticks.isDead && MainMenuButtonManager.isPressedMenu == false)
        {
        }
    }

    private void OptimizationByTime()
    {
        if (StickMovement.fallSpeed <= maxFallSpeed)
        {
            StickMovement.fallSpeed *= fallSpeedRatio;
            G = -StickMovement.fallSpeed * gRatio;
            BallMovement.Delay -= delayRatio;
            BallMovement.thrustY += thrustRatio;
            Physics2D.gravity = new Vector3(0, G, 0);
        }
    }

    private IEnumerator Doit()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            OptimizationByTime();
        }
    }
}