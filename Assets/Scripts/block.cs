using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparks;
    [SerializeField] int maxHits = 2;
    [SerializeField] int timesHits;
    level level;
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<level>();
        if (tag == "Breakable")
        {
            level.countBreakableBlock();
        }
        gameStatus = FindObjectOfType<GameStatus>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            timesHits++;
            if (timesHits >= maxHits)
            {
                DestroyedBlock();
            }
        }

    }

    private void DestroyedBlock()
    {
        PlayBlockDestroy();
        level.blockDestroyed();
        gameStatus.AddToScore();
        TriggerSparkle();
    }

    private void PlayBlockDestroy()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
    }

    private void TriggerSparkle()
    {
        GameObject sparks = Instantiate(blockSparks, transform.position, transform.rotation);
        Destroy(sparks, 1f);
    }
}
