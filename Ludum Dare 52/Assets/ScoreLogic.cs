using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLogic : MonoBehaviour
{

    
    private SpriteRenderer spriteRenderer;
    private Sprite newSprite;

    public Player player;
    public Sprite[] spriteArray;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }

	void ChangeSprite()
	{
        switch (player.score)
		{
            case 0:
                newSprite = spriteArray[0];
                break;
            case 1:
                newSprite = spriteArray[1];
                break;
            case 2:
                newSprite = spriteArray[2];
                break;
            case 3:
                newSprite = spriteArray[3];
                break;
            case 4:
                newSprite = spriteArray[4];
                break;
            case 5:
                newSprite = spriteArray[5];
                break;
            case 6:
                newSprite = spriteArray[6];
                break;
            case 7:
                newSprite = spriteArray[7];
                break;
            case 8:
                newSprite = spriteArray[8];
                break;
            case 9:
                newSprite = spriteArray[9];
                break;
        }
        spriteRenderer.sprite = newSprite;
	}
}
