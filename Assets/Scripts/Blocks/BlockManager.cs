using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] List<Block> blockPrefab = new List<Block>();

    [Header("Matrix")]
    [SerializeField] Block[,] blockMatrix;
    [SerializeField] int xSize = 8, ySize = 2;
    [SerializeField] float xStartPos = -4f, yStartPos = 2f;
    [SerializeField] float xPadding = 1.05f, yPadding = 0.55f;

    private void Awake()
    {
        CreateBlocks();
    }

    void CreateBlocks()
    {        
        blockMatrix = new Block[xSize, ySize];

        float xPos = xStartPos;
        float yPos = yStartPos;
        Vector2 offset = new Vector2(xPadding, yPadding);
        
        //desp ver como elegir un numero random, y eliminarlo de la seleccion..
        //int numRandom = Random.Range(0, blockPrefab.Count);
        for (int y = 0; y < ySize; y++)
        {
            int numRandom = y;
            for (int x = 0; x < xSize; x++)
            {
                Vector3 pos = new Vector3(xPos + (offset.x * x),
                                          yPos + (offset.y * y),
                                          0f);

                Block block = Instantiate(blockPrefab[numRandom],
                                          pos,
                                          blockPrefab[numRandom].transform.rotation);

                block.Position = new Vector2(x, y);
                block.name = string.Format("Block[{0}][{1}]", x, y);
                block.transform.parent = this.transform;

                blockMatrix[x, y] = block;
            }
        }        
    }
}
