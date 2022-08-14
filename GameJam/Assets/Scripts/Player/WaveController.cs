using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    [SerializeField] private float durationTime = 1f;
    [SerializeField] private float travelSpeed = 1f;
    [SerializeField] private Vector3 scaling = new Vector3(1.5f, 1.5f, 1f);

    private Vector3 target;
    private float duration;

    void Start()
    {
        duration = durationTime;
        target = transform.localPosition + Vector3.up;
    }

    void Update()
    {
        if (duration > 0)
        {
            duration -= Time.deltaTime;
            transform.localPosition = Vector3.MoveTowards(
                                    transform.localPosition,
                                    target,
                                    travelSpeed * Time.deltaTime);
            transform.localScale.Scale(scaling);
        }
        else
            Destroy(gameObject);
    }
}