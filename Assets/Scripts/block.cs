using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    level level;
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<level>();
        level.countBreakableBlock();
        gameStatus = FindObjectOfType<GameStatus>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyedBlock();
    }

    private void DestroyedBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.blockDestroyed();
        gameStatus.AddToScore();
    }
}
