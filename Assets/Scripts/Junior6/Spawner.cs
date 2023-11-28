using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private EnemyMove[] _enemies;
    [SerializeField] private TargetMover[] _targets;

    private Transform[] _points;

    private void Awake()
    {
        _points = new Transform[_point.childCount];

        for (int i = 0; i < _point.childCount; i++)
        {
            _points[i] = _point.GetChild(i);
        }
    }

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        float seconds = 2;
        var waitSeconds = new WaitForSeconds(seconds);
        int countEnemy = 0;
        int maxEnemy = 20;
        int indexEnemy = 0;
        int indexTarget = 0;

        while (countEnemy <= maxEnemy)
        {
            for (int i = 0; i < _points.Length; i++)
            {
                if (indexEnemy < _enemies.Length)
                {
                    var enemy = Instantiate(_enemies[indexEnemy], _points[i].position, Quaternion.identity);

                    if (indexTarget < _targets.Length)
                    {
                        enemy.Init(_targets[indexTarget].transform.position);
                        indexTarget++;
                    }
                    else
                    {
                        indexTarget = 0;
                        enemy.Init(_targets[indexTarget].transform.position);
                    }

                    indexEnemy++;
                }
                else
                {
                    indexEnemy = 0;
                }

                countEnemy++;

                yield return waitSeconds;
            }
        }
    }



    private Vector3 RandomDirection()
    {
        float maxAxis = 2;
        float minAxis = -1;
        float randomAxisX = Random.Range(minAxis, maxAxis);
        float randomAxisY = Random.Range(minAxis, maxAxis);

        if (randomAxisX == 0 && randomAxisY == 0)
        {
            randomAxisX = 1;
        }

        Vector3 direction = new Vector3(randomAxisX, randomAxisY, 0);
        return direction;
    }
}
