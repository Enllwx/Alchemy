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

public class GameManager : MonoBehaviour
{
    
    const float BLOCL_ROW = 0.5f;
    const float BLOCK_COL = 0.25f;
    public List<GameObject> blockPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector2 getPostion(int row, int col){
        Vector2 position = Vector2.zero;
        position -= row * BLOCK_ROW * Vector2.UnitX;
        position -= row * BlOCK_COl * Vector2.UnitY;
        position += row * BLOCK_ROW * Vector2.UnitX;
        position -= row * BlOCK_COl * Vector2.UnitY;
    
    }

    void SelfGenerateArea(int rows, int cols){
        
    }

}
