using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdController : MonoBehaviour
{
    public float jumpForce = 10f;
    public GameManager gameManager;
    public AudioClip jumpSound;
    public AudioClip hitSound;
    public AudioClip pointSound;
    private AudioSource jumpAudioSource;
    private AudioSource hitAudioSourse;
    private AudioSource pointAudioSource;
    private Rigidbody2D birdRigidBody;
    private bool hasHitPipe = false;

    void Start()
    {
        jumpAudioSource = GetComponent<AudioSource>();
        hitAudioSourse = GetComponent<AudioSource>();
        pointAudioSource = GetComponent<AudioSource>();
        birdRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasHitPipe)
        {
            birdRigidBody.velocity = Vector2.up * jumpForce;
            JumpSoundPlay();
        }
    }

    private void JumpSoundPlay()
    {
        jumpAudioSource.PlayOneShot(jumpSound);
    }

    private void HitSoundPlay()
    {
        hitAudioSourse.PlayOneShot(hitSound);
    }

    public void PointSoundPlay()
    {
        pointAudioSource.PlayOneShot(pointSound);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasHitPipe = true;
        HitSoundPlay();
        gameManager.GameOver();
    }
}
