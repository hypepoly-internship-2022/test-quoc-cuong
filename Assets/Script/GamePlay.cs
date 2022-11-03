using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public List<GameObject>imageList;
    public int rowCurBlank;
    public int colCurBlank;
    public GameObject curTarget;

    TouchMove touchMove;


    GameObject[,] imageListArr = new GameObject[3, 3];

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        createArr();
    }

    void createArr(){
        for(int r = 0; r < 3; r++){
            for(int c = 0; c < 3; c++){
                imageListArr[r, c] = imageList[count];
                count++;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        curTarget = imageListArr[rowCurBlank, colCurBlank];
        Debug.Log(imageListArr[rowCurBlank, colCurBlank]);
    }
}
