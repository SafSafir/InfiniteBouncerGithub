using System.Collections;
using UnityEngine;

public class StickGenerate : MonoBehaviour
{
    public float gap;
    public float generateY;
    public GameObject stick;
    static public float range = 8.448f;

    private void Start()
    {
        StartCoroutine(StickWave());
    }

    private void Update()
    {
    }

    private void CubukGenerateYukaridan()
    {
        GameObject obj0, obj1, obj2;
        obj0 = Instantiate(stick) as GameObject;
        obj0.transform.position = new Vector3(GameControl.randomValue, generateY, 0);
        obj1 = Instantiate(stick) as GameObject;
        obj1.transform.position = new Vector3(GameControl.randomValue - range, generateY, 0);
        obj2 = Instantiate(stick) as GameObject;
        obj2.transform.position = new Vector3(GameControl.randomValue + range, generateY, 0);
    }

    private IEnumerator StickWave()
    {
        while (true)
        {
            float deger = 1f / StickMovement.fallSpeed;
            yield return new WaitForSeconds(deger * gap);
            CubukGenerateYukaridan();
        }
    }
}