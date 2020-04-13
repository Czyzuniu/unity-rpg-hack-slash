using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatIndicator : MonoBehaviour
{
    public float indicatorSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, Vector3.up, indicatorSpeed * Time.deltaTime);
    }
}
