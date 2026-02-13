using System.Data;
using UnityEngine;

public class TestSCript : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(0f, 0f, 20f * Time.deltaTime);
        //on collision with anything activate audio source
    }
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
