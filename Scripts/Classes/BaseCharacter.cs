using UnityEngine;
using System.Collections;
using System;

public class BaseCharacter {

    //PLAYER ATTRIBUTES
    private string charName;
    private string race;
    private string gender;
    private int level;
    private int freeExp;
    private int weight;
    //PRIMARY STATS
    private int strength;
    private int intellect;
    private int dexterity;
    private int armourGrade;
    //ACTIVE STATS
    private float stamina;
    private float health;
    private float mana;
    //HIDDEN STATS
    private int blessing;
    private int luck;

    public string CharName
    {
        get { return charName; }
        set { charName = value; }
    }

    public int Level
    {
        get { return level; }
        set { level = value; }
    }

    public int FreeExp
    {
        get { return freeExp; }
        set { freeExp = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }
    public int ArmourGrade
    {
        get { return armourGrade; }
        set { armourGrade = value; }
    }
    public float Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public float Health
    {
        get { return health; }
        set { health = value; }

    }
    public float Mana {
        get { return mana; }
        set { mana = value; }
    }
    public int Blessing
    {
        get { return blessing; }
        set { blessing = value; }
    }
    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }
}
