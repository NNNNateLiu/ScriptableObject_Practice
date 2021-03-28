using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LocationScriptanleObject currentLocation;

    public Text locationNameText;
    public Text locationDescription;

    public Button northButton;
    public Button southButton;
    public Button eastButton;
    public Button westButton;
    public Button walkInButton;
    public Button walkOutButton;

    public Image peter;

    public List<LocationScriptanleObject> locations;

    private void Awake()
    {
        GeneratePeter();
    }
    void Start()
    {
        UpdateLocation();
    }

    public void MoveDirection(int dir)
    {
        switch(dir)
        {
            case 0:
                currentLocation = currentLocation.locationNorth;
                break;
            case 1:
                currentLocation = currentLocation.locationSouth;
                break;
            case 2:
                currentLocation = currentLocation.locationEast;
                break;
            case 3:
                currentLocation = currentLocation.locationWest;
                break;
            case 4:
                currentLocation = currentLocation.locationInside;
                break;
            case 5:
                currentLocation = currentLocation.locationOutside;
                break;
        }


        UpdateLocation();
    }

    void UpdateLocation()
    {
        locationNameText.text = currentLocation.locationName;
        locationDescription.text = currentLocation.description;

        if(currentLocation.locationNorth == null)
        {
            northButton.gameObject.SetActive(false);
        }
        else
        {
            northButton.gameObject.SetActive(true);
        }

        if (currentLocation.locationSouth == null)
        {
            southButton.gameObject.SetActive(false);
        }
        else
        {
            southButton.gameObject.SetActive(true);
        }

        if (currentLocation.locationEast == null)
        {
            eastButton.gameObject.SetActive(false);
        }
        else
        {
            eastButton.gameObject.SetActive(true);
        }

        if (currentLocation.locationWest == null)
        {
            westButton.gameObject.SetActive(false);
        }
        else
        {
            westButton.gameObject.SetActive(true);
        }

        if(currentLocation.canWalkInside == true)
        {
            walkInButton.gameObject.SetActive(true);
        }
        else
        {
            walkInButton.gameObject.SetActive(false);
        }

        if(currentLocation.canWalkOutside)
        {
            walkOutButton.gameObject.SetActive(true);
        }
        else
        {
            walkOutButton.gameObject.SetActive(false);
        }    

        if(currentLocation.isPeterHere)
        {
            peter.gameObject.SetActive(true);
        }
        else
        {
            peter.gameObject.SetActive(false);
        }

    }

    private void GeneratePeter()
    {
        for(var i = 0; i < locations.Count; i++)
        {
            locations[i].isPeterHere = false;
        }

        locations[Random.Range(0, locations.Count)].isPeterHere = true;
    }

}
