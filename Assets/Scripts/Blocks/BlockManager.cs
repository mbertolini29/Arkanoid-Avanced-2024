using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [Header("Prefab")]
    [SerializeField] List<Block> blockPrefab = new List<Block>();

    [Header("Matrix")]
    [SerializeField] Block[,] blockMatrix;
    [SerializeField] int xSize, ySize;
    [SerializeField] float xStartPos = -3f, yStartPos = 2.5f;
    [SerializeField] float xPadding = 0.5f, yPadding = 0.5f;

    private void Awake()
    {
        Vector2 offset = new Vector2(1f + xPadding, 1f + yPadding);
        CreateBlocks(offset);
    }

    void CreateBlocks(Vector2 offset)
    {
        blockMatrix = new Block[xSize, ySize];

        float xPos = xStartPos;
        float yPos = yStartPos;
        
        //desp ver como elegir un numero random, y eliminarlo de la seleccion..
        //int numRandom = Random.Range(0, blockPrefab.Count);

        for (int x = 0; x < xSize; x++)
        {
            int numRandom = x;
            for (int y = 0; y < ySize; y++)
            {
                Vector3 pos = new Vector3(xPos + (offset.x * x),
                                          yPos + (offset.y * y),
                                          0f);

                Block block = Instantiate(blockPrefab[numRandom],
                                          pos,
                                          blockPrefab[numRandom].transform.rotation);

                block.Position = new Vector2(x, y);
                block.name = string.Format("Invader[{0}][{1}]", x, y);
                block.transform.parent = this.transform;

                blockMatrix[x, y] = block;
            }

        }
        
    }
}
