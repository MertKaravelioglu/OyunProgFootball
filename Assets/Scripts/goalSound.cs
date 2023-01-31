using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalSound : MonoBehaviour
{
    public player1 player1;
    public player2 player2;
    public Top top;
    public AudioClip triggersound;

    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggersound != null && other.gameObject.CompareTag("top"))
        {
            top.transform.position = new Vector3(-0.26f, 1.12f, 0.13f);
            top.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ScoreScript.scoreValue += 1;
            ScoreScript2.scoreValue += 1;
            audiosource.PlayOneShot(triggersound, 0.7f);
        }
    }
}

