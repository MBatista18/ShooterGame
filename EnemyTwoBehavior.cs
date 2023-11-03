using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal movement from left to right
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 3);

        // Adjust the following condition based on your scene's boundaries
        if (transform.position.x > 8f)
        {
            Destroy(this.gameObject);
        }
    }
}