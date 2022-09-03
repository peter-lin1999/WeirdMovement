using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public EPlayer ePlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("DestructibleObject"))
        {
            Debug.Log("接觸可破壞物件");
            switch (ePlayer)
            {
                case EPlayer.player1:
                    GameManagerScript.instance.isP1TouchObject = true;
                    Debug.Log($"P1 isP1TouchObject:{GameManagerScript.instance.isP1TouchObject}");
                    GameManagerScript.instance.goCurrentObject = collision.gameObject;
                    GameManagerScript.instance.iP1HitNum = collision.gameObject.GetComponent<DestructibleObjectState>().iNum;
                    break;
                case EPlayer.player2:
                    GameManagerScript.instance.isP2TouchObject = true;
                    Debug.Log($"P2 isP2TouchObject:{GameManagerScript.instance.isP2TouchObject}");
                    GameManagerScript.instance.goCurrentObject = collision.gameObject;
                    GameManagerScript.instance.iP2HitNum = collision.gameObject.GetComponent<DestructibleObjectState>().iNum;
                    break;
                default:
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("DestructibleObject"))
        {
            Debug.Log("離開可破壞物件");
            switch (ePlayer)
            {
                case EPlayer.player1:
                    GameManagerScript.instance.isP1TouchObject = false;
                    Debug.Log($"P1 isP1TouchObject:{GameManagerScript.instance.isP1TouchObject}");
                    break;
                case EPlayer.player2:
                    GameManagerScript.instance.isP2TouchObject = false;
                    Debug.Log($"P2 isP2TouchObject:{GameManagerScript.instance.isP2TouchObject}");
                    break;
                default:
                    break;
            }
        }
    }
}
