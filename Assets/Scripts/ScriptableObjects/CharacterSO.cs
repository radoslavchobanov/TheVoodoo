using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/Character")]
public class CharacterSO : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private CharacterType _type;

    [SerializeField]
    private GameObject _prefab;

    [SerializeField]
    private BasicStats _basicStats;


    public string Name { get => _name; }
    public CharacterType Type { get => _type; }
    public GameObject Prefab { get => _prefab; }
    public BasicStats BasicStats { get => _basicStats; }
}