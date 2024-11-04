using UnityEngine;
using System.Collections.Generic;

public class StatBlock
{

    private Dictionary<Stat, int> baseStats;
    private int baseStatLUCK;

    public StatBlock(Dictionary<Stat, int> baseStats, int baseStatLUCK)
    {
        this.baseStats = baseStats;

        this.baseStatLUCK = baseStatLUCK;
    }

    private int GetModByCleanStat(int cleanStat)
    {
        return (cleanStat / 2) - 5;
    }

    public int GetSkillStat(Skill skill)
    {
        return 0;
    }

    public int RollSkill(Skill skill)
    {
        return Random.Range(1, 20) + GetModByCleanStat(GetSkillStat(skill));
    }

    public enum Skill
    {
        ACROBATICS,
        ANIMALHANDLING,
        ARCANA,
        ATHLETICS,
        DECEPTION,
        HISTORY,
        INSIGHT,
        INTIMIDATION,
        INVESTIGATION,
        MEDICINE,
        NATURE,
        PERCEPTION,
        PERFORMANCE,
        PERSUASION,
        RELIGION,
        SLEIGHTOFHAND,
        STEALTH,
        SURVIVAL
    }

    public enum Stat
    {
        STRENGH,
        DEXTERITY,
        CONSTITUTION,
        INTELLIGENT,
        WISDOM,
        CHARISMA
    }
}
