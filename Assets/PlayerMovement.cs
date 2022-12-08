using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(1, 100)]
    float speed;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right) && transform.position.x < 4.72)
        {
            // den här koden flyttar spelaren till den position som beffiner sig i x.
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("!");
        }
        if (Input.GetKey(left) && transform.position.x > -4.72)
        {
            // Den här koden startar en animation när spelarens position är mot x och hastighet över noll.

            // den här koden flyttar spelaren till den position som beffiner sig i -x.
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            print("!");
        }
        if (Input.GetKey(up) && transform.position.y < 4.6)
        {
            // den här koden flyttar spelaren till den position som beffiner sig i x.
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            print("!");
        }
        if (Input.GetKey(down) && transform.position.y > -4.6)
        {
            // Den här koden startar en animation när spelarens position är mot x och hastighet över noll.

            // den här koden flyttar spelaren till den position som beffiner sig i -x.
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            print("!");
        }
    }
}
