using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// set the top block as (0,0), first block created 
// up-left   : x - 0.5, y + 0.25
// up-right  : x + 0.5, y + 0.25
// down-left : x - 0.5, y - 0.25
// down-rigth: x + 0.5, y - 0.25
// down      :          y - 0.25 
// up        :          y + 0.25


// the row start from 0, and from toppest block to down-left
// the row start from 0, and from toppest block to down-left

public class theGameManager : MonoBehaviour
{
    
    const float BLOCK_ROW_SIZE = 0.53f;
    const float BLOCK_COL_SIZE = 0.28f;
    public GameObject blockPrefabs;
    public List<GameObject> TestGameBoard;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        selfGenerateArea(6,6);

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 getPostion(int row, int col){
        Vector3 position = Vector3.zero;
        int y_position = row;
        if (col > row) y_position = col;

        position = position + (col - row) * BLOCK_ROW_SIZE * Vector3.right;
        position = position - (row + col) * BLOCK_COL_SIZE * Vector3.up;
        return position;
    }

    void selfGenerateArea(int rows, int cols){
        if (rows < 0 || cols < 0) {
            Debug.Log("invalid row/col number");
        }

        TestGameBoard = new List<GameObject>();

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                GameObject go = (GameObject)Instantiate(blockPrefabs, getPostion(i,j), Quaternion.identity);
                go.transform.parent = GameObject.Find("GameBoard").transform;
                go.layer = LayerMask.NameToLayer("Gound");
                TestGameBoard.Add(go);
                
            }
        }
    }




}
