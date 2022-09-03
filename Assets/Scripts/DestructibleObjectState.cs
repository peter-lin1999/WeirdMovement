using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructibleObjectState : MonoBehaviour
{
    public Sprite[] sprites;
    public Image imgColor;


    public int iNum = 10;
    // Start is called before the first frame update
    void Start()
    {
        imgColor = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("±µÄ²¨ìPlayer");
            iNum = GameManagerScript.instance.iHitNum;
            switch (iNum)
            {
                case 5:
                    imgColor.color = Color.red;
                    break;
                case 0:
                    imgColor.color = Color.black;
                    break;
                default:
                    break;
            }
        }
    }
}
