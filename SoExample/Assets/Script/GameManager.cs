using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyMove enemy;
    public EnemyData[] levelData;

    [Range(1,5)]
    public int level;

    void Awake()
    {
        if (level > levelData.Length)
        {
            level = levelData.Length;
        }

        enemy.data = levelData[level - 1];
    }
}
