using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerSpell")]
public class SpellSO : ScriptableObject
{
    [SerializeField]
    private SpellID _id;

    [SerializeField]
    private Spell _spell;

    [SerializeField]
    private float _damage;

    [SerializeField]
    private float _movementSpeed;

    [SerializeField]
    private float _cooldown;

    private GameObject _performer;

    public SpellID Id { get => _id; }
    public Spell Spell { get => _spell; }
    public float Damage { get => _damage; }
    public float MovementSpeed { get => _movementSpeed; }
    public float Cooldown { get => _cooldown; }
    public GameObject Performer { get => _performer; set => _performer = value; }


    private float timer = 0f;

    private void Perform()
    {
        Debug.Log(this + " Perform");
        Spell.Perform();
    }

    public void Tick()
    {
        timer += Time.deltaTime;
        if (timer >= Cooldown)
        {
            Perform();
            timer = 0;
        }
    }

    public void Init(GameObject performer)
    {
        this._performer = performer;
    }
}
