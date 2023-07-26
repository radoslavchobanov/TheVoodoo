using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private List<Manager> _managers = new();

    public MapManager MapManager;
    public EventManager EventManager;
    public PlayerManager PlayerManager;
    public ResourceManager ResourceManager;
    public EnemyManager EnemyManager;
    public SpellManager SpellManager;

    private void AddManagers()
    {
        _managers.Add(MapManager);
        _managers.Add(EventManager);
        _managers.Add(PlayerManager);
        _managers.Add(ResourceManager);
        _managers.Add(EnemyManager);
        _managers.Add(SpellManager);
    }

    private void Awake()
    {
        if (Instance == null) Instance = this;
        DontDestroyOnLoad(Instance);

        AddManagers();

        _managers.ForEach(manager => manager.OnAwake());
    }

    private void Start()
    {
        _managers.ForEach(manager => manager.OnStart());

        // temporary OnEnterGame is called here
        _managers.ForEach(manager => manager.OnEnterGame());
    }

    private void Update()
    {
        _managers.ForEach(manager => manager.OnLogicalUpdate());
    }

    private void FixedUpdate()
    {
        _managers.ForEach(manager => manager.OnPhysicalUpdate());
    }

    private void LateUpdate()
    {
        _managers.ForEach(manager => manager.OnAnimationUpdate());
    }
}
