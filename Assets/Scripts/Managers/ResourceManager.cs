using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResourceManager : Manager
{
    public static ResourceManager Instance => GameManager.Instance.ResourceManager;

    public GameObject PlayerPrefab;
    public GameObject EnemyPrefab;

    public List<SpellSO> PlayerSpells;

    public override void OnAwake()
    {
        base.OnAwake();
    }

    public List<GameObject> LoadAllResourcesGameobjects(string path)
    {
        return Resources.LoadAll<GameObject>(path).ToList();
    }

    public GameObject GetPlayerPrefab()
    {
        return PlayerPrefab;
    }

    public GameObject GetEnemyPrefab()
    {
        return EnemyPrefab;
    }
}