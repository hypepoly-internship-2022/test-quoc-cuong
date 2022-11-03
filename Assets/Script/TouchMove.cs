using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TouchMove : MonoBehaviour
{
    public int row, col;

    GamePlay gamePlay;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameMgr = GameObject.Find("GamePlay");
        gamePlay = gameMgr.GetComponent<GamePlay>();
    }
    
    void OnMouseDown()
    {
        if(checkSuffer(row, col) == true){
            Sprite tempPos = gamePlay.curTarget.GetComponent<SpriteRenderer>().sprite;
            gamePlay.curTarget.GetComponent<SpriteRenderer>().sprite = this.GetComponent<SpriteRenderer>().sprite;
            this.GetComponent<SpriteRenderer>().sprite = tempPos;
            gamePlay.rowCurBlank = row;
            gamePlay.colCurBlank = col;
            // Debug.Log("Touch: " + row + " " + col);
        }
    }
    bool checkSuffer(int r, int c){
        int rBlank = gamePlay.rowCurBlank;
        int cBlank = gamePlay.colCurBlank;
        if(rBlank != r && cBlank == c){
            if(Math.Abs(r - rBlank) ==1){
                return true;
            }
        } else if(rBlank == r && cBlank != c){
            if(Math.Abs(c - cBlank) == 1){
                return true;
            }
        }

        return false;
    }

    // Update is called once per frame
    void Update()
    {
    }


}
