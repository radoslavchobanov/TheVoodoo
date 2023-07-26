using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EnemyManager : Manager
{
    public static EnemyManager Instance => GameManager.Instance.EnemyManager;

    public List<EnemyController> Enemies { get; private set; }

    public List<CharacterSO> EnemyCharacters;

    private bool shouldSpawnEnemies = false;
    private float spawnTimer = 0;

    public override void OnEnterGame()
    {
        base.OnEnterGame();

        Enemies = new();
        StartSpawning();
    }

    public override void OnLogicalUpdate()
    {
        base.OnLogicalUpdate();
        if (shouldSpawnEnemies == false) return;

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= Constants.ENEMY_SPAWN_RATE)
        {
            SpawnEnemy();
            spawnTimer = 0;
        }
    }

    private void SpawnEnemy()
    {
        var enemyObj = Instantiate(ResourceManager.Instance.EnemyPrefab, GetSpawningPosition(), Quaternion.identity);
        var enemy = enemyObj.GetComponent<EnemyController>();
        enemy.Init(GetRandomCharacter());
        Enemies.Add(enemy);
    }

    // Getting point outside of the Viewport (screen) area
    private Vector2 GetSpawningPosition()
    {
        float randomPosX = 0;
        float randomPosY = 0;

        int x = Random.Range(0, 2);
        if (x == 0)
        {
            randomPosX = Random.Range(-0.2f, 1.2f);
            var random = Random.Range(0, 2);
            if (random == 0) randomPosY = 1.2f;
            else if (random == 1) randomPosY = -0.2f;
        }
        else if (x == 1)
        {
            randomPosY = Random.Range(-0.2f, 1.2f);
            var random = Random.Range(0, 2);
            if (random == 0) randomPosX = 1.2f;
            else if (random == 1) randomPosX = -0.2f;
        }

        return Camera.main.ViewportToWorldPoint(new Vector3(randomPosX, randomPosY));
    }

    private CharacterSO GetRandomCharacter()
    {
        return EnemyCharacters[Random.Range(0, EnemyCharacters.Count)];
    }

    public void StartSpawning()
    {
        shouldSpawnEnemies = true;
    }

    public void StopSpawning()
    {
        shouldSpawnEnemies = false;
    }
}
