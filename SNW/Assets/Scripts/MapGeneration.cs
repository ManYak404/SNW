using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [SerializeField]
    private int rows = 5;
    [SerializeField]
    private int cols = 5;
    [SerializeField]
    private float tileSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        ArrayOfCells();
    }

    private void ArrayOfCells()
    {
        Sprite[] mvpterrainSprites = Resources.LoadAll<Sprite>("mvpterrain");
        GameObject[] mvpterrainGameObjects = new GameObject[mvpterrainSprites.Length];
        for (int i = 0; i < mvpterrainSprites.Length; i++)
        {
            GameObject mvpterrainObject = new GameObject("new temporary GameObject with the sprite of mvpterrainsprites[i]");
            SpriteRenderer renderer = mvpterrainObject.AddComponent<SpriteRenderer>();
            renderer.sprite = mvpterrainSprites[i];
            mvpterrainGameObjects[i] = mvpterrainObject;
        }
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int terrainPick = Random.Range(0, mvpterrainGameObjects.Length);

                GameObject terrain = (GameObject)Instantiate(mvpterrainGameObjects[terrainPick], transform);

                float posX = c * tileSize;
                float posY = r * -tileSize;

                terrain.transform.position = new Vector2(posX, posY);
            }
        }
        //deletes all the temp objects in mvpterrain array
        for (int i = 0; i < mvpterrainSprites.Length; i++)
        {
            //Destroy(mvpterrainGameObjects[i].gameObject);
        }

        float gridWidth = cols * tileSize;
        float gridHeight = rows * tileSize;
        transform.position = new Vector2(-gridWidth / 2 + tileSize / 2, gridHeight / 2 - tileSize / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
