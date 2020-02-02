using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GoundType {ROCK, WATER, GRASS, SAND};
public class Grid : MonoBehaviour
{   
   //public enum GoundType {ROCK, WATER, GRASS, SAND};
   public GoundType goundType;

   public int row;
   public int col;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setUpGrid(int rolnum, int colnum){
    }
}
