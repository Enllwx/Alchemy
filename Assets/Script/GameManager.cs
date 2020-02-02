using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // goundType[0]: this is the gameboard base 
    public List<GameObject> goundType;
    public GameObject[,] goundBase;
    // public GameObject goundBaseEmpty;

    // Start is called before the first frame update
    void Start() 
    {
        Time.timeScale = 1f;
        setUpBase(9,12);
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    void setUpBase(int row, int col) {
        goundBase = new GameObject[row, col];
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                GameObject go = Instantiate(goundType[0], new Vector3(j, i, 0), Quaternion.identity);
                go.layer = LayerMask.NameToLayer("Gound");
                go.transform.parent = GameObject.Find("GoundBase").transform;
                goundBase[i,j] = go;
            }
        }
    }
}
