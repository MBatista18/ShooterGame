using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    private float speed = 3f;
    private float amplitude = 1.5f;
    private float frequency = 1f;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);

        float horizontalMovement = Mathf.Sin((Time.time - startTime) * frequency) * amplitude;
        transform.Translate(new Vector3(horizontalMovement, 0, 0) * Time.deltaTime);

        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}