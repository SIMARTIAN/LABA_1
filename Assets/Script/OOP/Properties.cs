using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private int experience;

    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}

public class Properties : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player();

        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
