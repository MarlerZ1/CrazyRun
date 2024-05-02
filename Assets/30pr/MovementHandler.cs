using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class MovementHandler : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 curDeltaPos = touch.deltaPosition * speed;
            Physics.gravity = new Vector3(curDeltaPos.x, Physics.gravity.y, curDeltaPos.y);
        }
    }
}
