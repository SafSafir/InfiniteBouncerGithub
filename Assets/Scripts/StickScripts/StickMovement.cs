using UnityEngine;

public class StickMovement : MonoBehaviour
{
    //Values

    #region

    public float stickSpeedHorizontal;
    private Touch theThouch;
    static public float fallSpeed = 4.428453f;

    #endregion

    private void Start()
    {
    }

    private void Update()
    {
        MoveStick();
        StickFall();
    }

    private void MoveStick()
    {
        //HorizontalMovement
        if (Input.touchCount > 0)
        {
            theThouch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(theThouch.position);
            Vector3 pivot = Input.GetTouch(0).deltaPosition;
            transform.Translate((pivot.x * stickSpeedHorizontal * Time.deltaTime) / 2, 0, 0);
        }
    }

    private void StickFall()
    {
        //VerticalMovement
        transform.position = transform.position + new Vector3(0, -fallSpeed * Time.deltaTime, 0);
    }
}