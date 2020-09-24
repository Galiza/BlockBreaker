using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration Parameters
    [SerializeField] float screenWidthInUnits;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(LimitPaddlePosition(), transform.position.y);
        transform.position = paddlePos;
    }

    private float GetMousePositionInUnits()
    {
        return Input.mousePosition.x / Screen.width * screenWidthInUnits;
    }

    private float LimitPaddlePosition()
    {
        return Mathf.Clamp(GetMousePositionInUnits(), minX, maxX);
    }
}
