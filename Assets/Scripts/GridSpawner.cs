using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject cellPrefab;
    public int numOfRows;
    public int numOfCols;
    public List<List<GameObject>> cells = new List<List<GameObject>>();
    private int counter = 0;
    private int horizontalSpace = 1;
    private int verticalSpace = 1;
    void Start()
    {

        InstantiateGrid();
    }

    void Update()
    {

    }

    public void InstantiateGrid()
    {
        for (int i = 0; i < numOfRows; i++)
        {
            cells.Add(new List<GameObject>());
            for (int j = 0; j < numOfCols; j++)
            {
                CellsPosition();
                GameObject cell = Instantiate(cellPrefab, new Vector2(verticalSpace, horizontalSpace), transform.rotation);
                cells[i].Add(cell);
                counter++;
            }
        }
    }

    public void CellsPosition()
    {
        if (counter == numOfRows)
        {
            verticalSpace += 2;
            counter = 0;
            horizontalSpace = 3;
        }
        else
        {
            horizontalSpace += 2;
        }
    }




}
