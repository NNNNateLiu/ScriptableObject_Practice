using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Location",
    menuName = "ScriptableObject/Location", order = 0)]

public class LocationScriptanleObject : ScriptableObject
{
    public string locationName = "New Place";
    public string description = "Default Description";
    public bool canWalkInside = false;
    public bool canWalkOutside = false;

    public bool isPeterHere = false;

    public LocationScriptanleObject locationNorth;
    public LocationScriptanleObject locationSouth;
    public LocationScriptanleObject locationWest;
    public LocationScriptanleObject locationEast;

    public LocationScriptanleObject locationInside;
    public LocationScriptanleObject locationOutside;
}
