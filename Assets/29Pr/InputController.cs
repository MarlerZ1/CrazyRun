using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private float _startX;
    private float _startY;

    private float _initialDistance;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                _startX = touch.position.x;
                _startY = touch.position.y;
               // print("Start pos: " + _startX + " " + _startY);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
               // print("End pos: " + touch.position.x + " " + touch.position.y);
                if (touch.position.x - _startX >= 100 && Mathf.Abs(touch.position.y - _startY) <= 50)
                    print("Right Swipe");
            }
        }



        if (Input.touchCount == 1)
        {
            Touch touchFirst = Input.GetTouch(0);
            //Unity remote didn`t work, simulated second point
            Vector2 secondTouchPos = new Vector2(150, 150);

            if (touchFirst.phase == TouchPhase.Began)
                _initialDistance = Vector2.Distance(touchFirst.position, secondTouchPos);
            else if (touchFirst.phase == TouchPhase.Ended)
            {
                if (Vector2.Distance(touchFirst.position, secondTouchPos) > _initialDistance)
                    print("Zoom gesture");
            }
            
        }

    }
}
