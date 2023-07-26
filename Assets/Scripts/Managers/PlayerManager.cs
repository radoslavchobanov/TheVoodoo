using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Manager
{
    public static PlayerManager Instance => GameManager.Instance.PlayerManager;

    public PlayerController Player { get; private set; }


    public CharacterSO PickedCharacter; // temporary until a picking system

    public override void OnEnterGame()
    {
        base.OnEnterGame();

        InstantiatePlayer();
    }

    private void InstantiatePlayer()
    {
        var middleMapPos = MapManager.Instance.GetMiddleTile().transform.position;
        var playerObj = Instantiate(ResourceManager.Instance.GetPlayerPrefab(), middleMapPos, Quaternion.identity);

        Player = playerObj.GetComponent<PlayerController>();

        Player.Init(PickedCharacter);
    }
}
