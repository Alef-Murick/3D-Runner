using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;

    Vector3 offset;
    [SerializeField] float smoothRate;

    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;
        Vector3 newPos = player.position - offset;

        transform.position = Vector3.Lerp(currentPos, newPos, smoothRate);
    }
}
