using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public GameObject goPlayer1;
    public GameObject goPlayer2;

    public float fSpeed = 25;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(goPlayer1, 1);
        MovePlayer(goPlayer2, 2);


    }

    /// <summary>
    /// 玩家移動及範圍限制
    /// </summary>
    /// <param name="goPlayer"></param>
    /// <param name="iPlayerNum"></param>
    private void MovePlayer(GameObject goPlayer, int iPlayerNum)
    {
        switch (iPlayerNum)
        {
            case 1:
                if (Input.GetKey(KeyCode.A))
                {
                    goPlayer.transform.Translate(Vector2.left * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    goPlayer.transform.Translate(Vector2.right * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    goPlayer.transform.Translate(Vector2.up * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    goPlayer.transform.Translate(Vector2.down * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.E))
                {

                }
                break;
            case 2:
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    goPlayer.transform.Translate(Vector2.left * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    goPlayer.transform.Translate(Vector2.right * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    goPlayer.transform.Translate(Vector2.up * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    goPlayer.transform.Translate(Vector2.down * fSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.Slash))
                {

                }
                break;
            default:
                break;
        }
        if (goPlayer.transform.localPosition.x < -600)
        {
            goPlayer.transform.localPosition = new Vector2(-600, goPlayer.transform.localPosition.y);
        }
        if (goPlayer.transform.localPosition.x > 600)
        {
            goPlayer.transform.localPosition = new Vector2(600, goPlayer.transform.localPosition.y);
        }
        if (goPlayer.transform.localPosition.y < -320)
        {
            goPlayer.transform.localPosition = new Vector2(goPlayer.transform.localPosition.x, -320);
        }
        if (goPlayer.transform.localPosition.y > 320)
        {
            goPlayer.transform.localPosition = new Vector2(goPlayer.transform.localPosition.x, 320);
        }
    }

}