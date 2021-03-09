using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;

    public void countBreakableBlock()
    {
        breakableBlocks++;

    }

}
