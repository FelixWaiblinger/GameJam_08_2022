using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillNumber : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI number;
    [SerializeField] private Vector3 move = new Vector3(1, 1, 0);
    [SerializeField] private float timer = 1f;

    public void Setup(int num, Color32 color)
    {
        number.color = color;
        number.SetText("+" + num.ToString());
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0.5f)
            number.transform.position += move;

        if (timer < 0.2f)
            number.alpha -= 40;

        if (timer < 0)
            Destroy(gameObject);
    }
}