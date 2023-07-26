using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : Manager
{
    public static SpellManager Instance => GameManager.Instance.SpellManager;

    private List<SpellSO> _performingSpells = new();
    public List<SpellSO> PerformingSpells => _performingSpells;

    private bool enabledd = false;

    public override void OnEnterGame()
    {
        base.OnEnterGame();

        AddSpell(ResourceManager.Instance.PlayerSpells[0]);
        AddSpell(ResourceManager.Instance.PlayerSpells[1]);
        AddSpell(ResourceManager.Instance.PlayerSpells[2]);

        foreach (var spell in _performingSpells)
        {
            spell.Init(PlayerManager.Instance.Player.gameObject);
        }

        enabledd = true;
    }

    public override void OnExitGame()
    {
        base.OnExitGame();

        enabledd = false;
    }

    public override void OnLogicalUpdate()
    {
        base.OnLogicalUpdate();

        if (enabledd == false) return;

        foreach (var spell in _performingSpells)
        {
            spell.Tick();
        }
    }

    public void AddSpell(SpellSO spellToAdd)
    {
        _performingSpells.Add(spellToAdd);
    }

    public void RemoveSpell(SpellSO spellToRemove)
    {
        if (_performingSpells.Contains(spellToRemove) == false)
        {
            Debug.Log("No such spell in performing spell: " + spellToRemove);
            return;
        }

        _performingSpells.Remove(spellToRemove);
    }
}
