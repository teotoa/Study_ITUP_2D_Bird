using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float gravity = 10f;
    public float accel = 10f;
    float v;

    public AudioClip upSound;
    public AudioClip downSound;

    void Start()
    {
        v = 0f;
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<AudioSource>().PlayOneShot(upSound);
        }

        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<AudioSource>().PlayOneShot(downSound);
        }

        if (Input.GetButton("Jump"))
        {
            v -= accel * Time.deltaTime;
        }

        else
        {
            v += gravity * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.down * v * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            float score = GameManager.instance.score;

            PlayerPrefs.SetInt("Score", (int)score);
            PlayerPrefs.Save();

            SceneManager.LoadScene("GameOver");
        }
    }
}

