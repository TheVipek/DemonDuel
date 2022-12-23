using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastBeam : MonoBehaviour
{
    private float cast_time = 2f;
    void Start()
    {
        StartCoroutine(castRay());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, new Vector2(transform.right.x * 20f, transform.position.y), Color.red);

    }

    IEnumerator castRay()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("CAST DONE");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Destroying");
        Destroy(gameObject);
        yield return null;
        
    }
}
