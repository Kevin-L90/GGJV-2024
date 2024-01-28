using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour
{

    private GameObject player;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");

        float direction = transform.position.x - player.transform.position.x;

        if (direction < 0) {
            if (GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))
                GetComponent<Rigidbody2D>().velocity = new Vector2(3, 3);
        } else {
            if (GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))
                GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 3);
        }
    }
}
