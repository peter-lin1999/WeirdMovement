using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructibleObjectState : MonoBehaviour
{
    public Sprite[] sprites;
    //public Image imgColor;
    public Image imgObject;
    private BoxCollider2D collider2D;

    public int iNum = 10;
    bool isP1Touch;
    bool isP2Touch;
    // Start is called before the first frame update
    void Start()
    {
        //imgColor = gameObject.GetComponent<Image>();
        imgObject = gameObject.GetComponent<Image>();
        collider2D = gameObject.transform.parent.GetComponent<BoxCollider2D>();
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            if (collision.name.Equals("Player1"))
            {
                isP1Touch = true;
            }
            if (collision.name.Equals("Player2"))
            {
                isP2Touch = true;
            }
            if (isP1Touch && isP2Touch)
            {
                Debug.Log("接觸到兩個Player");
                if (/*collision.name.Equals("Player1") && */GameManagerScript.instance.eClick == EClick.P1Click)
                {
                    iNum = GameManagerScript.instance.iP1HitNum;
                    GameManagerScript.instance.iP2HitNum = iNum;
                }
                if (/*collision.name.Equals("Player2") && */GameManagerScript.instance.eClick == EClick.P2Click)
                {
                    iNum = GameManagerScript.instance.iP2HitNum;
                    GameManagerScript.instance.iP1HitNum = iNum;
                }
            }
            else
            {
                if (collision.name.Equals("Player1") && GameManagerScript.instance.eClick == EClick.P1Click)
                {
                    iNum = GameManagerScript.instance.iP1HitNum;
                }
                if (collision.name.Equals("Player2") && GameManagerScript.instance.eClick == EClick.P2Click)
                {
                    iNum = GameManagerScript.instance.iP2HitNum;
                }
            }
            if (iNum<6)
            {
                //imgColor.color = Color.red;
            }
            if (iNum<1)
            {
                //imgColor.color = Color.black;
                imgObject.sprite = sprites[0];
                collider2D.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals("Player1"))
        {
            isP1Touch = false;
        }
        if (collision.name.Equals("Player2"))
        {
            isP2Touch = false;
        }
    }
}
