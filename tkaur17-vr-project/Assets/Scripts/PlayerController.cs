using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
public Rigidbody rigid;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W))
        { rigid.MovePosition(Transform.position + this.transform.forward * speed * Time.deltaTime); }
        else if (Input.GetKey(KeyCode.S))
        { rigid.MovePosition(Transform.position + -this.transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        { rigid.MovePosition(Transform.position + -Transform.right * speed * Time.deltaTime); }
        else if (Input.GetKey(KeyCode.D))
        {
            rigid.MovePosition(Transform.position + Transform.right * speed * Time.deltaTIme);
        }
            }
        }