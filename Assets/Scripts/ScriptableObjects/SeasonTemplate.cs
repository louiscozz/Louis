﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SeasonParts;
[CreateAssetMenu(fileName = "newSeasonTemp", menuName = "SeasonTemplate")]
public class SeasonTemplate : ScriptableObject
{
    public string nameSeason;
    public List<Team> Tribes;    
    public float mergeAt;
    public float jury;
    public float final;
    public List<Episode> Episodes;
    public string Tiebreaker;
    public string ReturningPlayers;
    public Color MergeTribeColor;
    public string MergeTribeName;
    public List<TribeSwap> swaps;
    public bool ExileIslandd;
    public bool RedemptionIsland;
    public bool EdgeOfExtinction;
    public bool Outcasts;
    public bool MedallionOfPower;
    public int MOPExpire;
    public Twist Twists;
    public List<OneTimeEvent> oneTimeEvents;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}