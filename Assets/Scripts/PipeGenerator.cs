using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{

    public GameObject pipe; // Qual item ele vai gerar
    public float minHeight; // Altura minima dos canos
    public float maxHeight; // Altura máxima dos canos
    public float maxTime = 1f; // Tempo de intervalo entre um cano e outro

    private float timer = 0f; // Timer para gerar os canos

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            Destroy(newPipe, 10f);
            timer = 0f;
        }

        timer += Time.deltaTime;
    }
}
