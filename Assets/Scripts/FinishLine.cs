using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private float loadDelay = 0.5f;

    [SerializeField]
    private ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
