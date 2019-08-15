using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeModel : MonoBehaviour
{

    private Image img;
  
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>() as Image;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Drag actorSprite = other.GetComponent<Drag>();
        string pathToImage = "Sprites/Characters/Hexie Kiss/" + actorSprite.objectName;
        Object gObject = Resources.Load<Sprite>(pathToImage);
        img.sprite = (Sprite)gObject;
    }
}
