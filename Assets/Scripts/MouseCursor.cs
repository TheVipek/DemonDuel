using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;
    public static Vector3 mouse_position;
    private void Start()
    {
        
    }
    private void Update()
    {
        Vector3 mousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        mouse_position = mousePosition;
        transform.position = mousePosition;
    }
}
