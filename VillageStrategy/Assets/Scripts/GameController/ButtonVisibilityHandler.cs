using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonVisibilityHandler : MonoBehaviour {

    public GameObject soilButtons;
    public GameObject commonButtons;

    private TileTypeHandler actualTileType;
    private TileProperties actualTileProperties;
    private TileBehaviourScript actualTileBehaviour;

    private GameObject activeTileObject;

	void Start () {
	}

    void Update() {

        if (Tile.getSelectedTile() == null)
        {
            soilButtons.SetActive(false);
            commonButtons.transform.Find("populate").gameObject.SetActive(false);

            return;
        }
        activeTileObject = Tile.getSelectedTile();
        actualTileType = activeTileObject.GetComponent<TileTypeHandler>();
        actualTileProperties = activeTileObject.GetComponent<TileProperties>();
        actualTileBehaviour = activeTileObject.GetComponent<TileBehaviourScript>();

        handlePopulateButton();

        if (actualTileBehaviour.populated)
        {
            switch (actualTileType.tileType)
            {
                case TileType.Soil:
                    {
                        soilButtons.SetActive(true);

                        if (actualTileBehaviour.soil.growing)
                        {
                            soilButtons.transform.Find("stopGrow").gameObject.SetActive(true);
                            soilButtons.transform.Find("startGrow").gameObject.SetActive(false);
                        }
                        else
                        {
                            soilButtons.transform.Find("stopGrow").gameObject.SetActive(false);
                            soilButtons.transform.Find("startGrow").gameObject.SetActive(true);
                        }
                        break;
                    }
                case TileType.Water:
                    {
                        soilButtons.SetActive(false);
                        break;
                    }
                case TileType.None:
                    {
                        soilButtons.SetActive(false);
                        break;
                    }
            }
        }else
        {
            disableAllButtons();
        }
	}

    #region populate button
    void handlePopulateButton()
    {
        if (actualTileBehaviour.populated)
        {
            commonButtons.transform.Find("populate").gameObject.SetActive(false);
        }
        else if(!actualTileBehaviour.populated && areTilesAroundPopulated())
        {
            commonButtons.transform.Find("populate").gameObject.SetActive(true);
        }else
        {
            commonButtons.transform.Find("populate").gameObject.SetActive(false);
        }
    }

    bool areTilesAroundPopulated()
    {
        foreach(GameObject o in Tile.getObjectsAroundSelected())
        {
            if(o.GetComponent<TileBehaviourScript>().populated)
            {
                return true;
            }
        }
        return false;
    }
    #endregion

    void disableAllButtons()
    {
        soilButtons.SetActive(false);
    }
}
