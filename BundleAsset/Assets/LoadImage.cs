using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
   
    
    public void NewImage()
    {
        original.sprite = newSprite;
    }

    
}
