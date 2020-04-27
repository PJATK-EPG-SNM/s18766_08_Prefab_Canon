using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public float period = 1; 
    private float lastBallTime;

    public Canonball prefab;
    public Transform startTransform;

    public float rotationSpeed = 50;
    public float direction = -1;

    void Start()
    { lastBallTime = 0;
          }

    
    void Update()
    { lastBallTime += Time.deltaTime;

    if(lastBallTime > period) { 
    lastBallTime = 0;
    //tworzenie z prefabu
    Instantiate(prefab, startTransform.position, startTransform.rotation);}

    if(lastBallTime > period/2) { 
    float rotationValue = rotationSpeed * direction * Time.deltaTime;
    Vector3 rotateVector = new Vector3 (0, 0, rotationValue);
    startTransform.Rotate(rotateVector);
    
    if(startTransform.rotation.z < -0.999 || startTransform.rotation.z>0){
        direction *= -1;
    }

    }
}}
