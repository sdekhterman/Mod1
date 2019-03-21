using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public Vector2 fireRate;
    public float delay;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
        InvokeRepeating("Fire", delay, Random.Range(fireRate.x, fireRate.y));
    }

    void Fire()
    {
        Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.Play();
    }
}