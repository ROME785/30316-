using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.rotSpeed = 50.0f;
            
            }
        if (Input.GetMouseButtonDown(1)){
            this.rotSpeed = 0;

        }
        this.rotSpeed *= 0.987f; //속도가 서서히 줄어 들음.
            transform.Rotate(0, 0, this.rotSpeed);
        }
    }