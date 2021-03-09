using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    level level;

    private void Start()
    {
        level = FindObjectOfType<level>();
        level.countBreakableBlock();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
