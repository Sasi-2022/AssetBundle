using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDogImage : MonoBehaviour
{
    [SerializeField]
    private GameObject dog;

    private bool dogIsEnabled;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        dogIsEnabled = true;
        dog.SetActive(dogIsEnabled);
    }

   
    private void TurnOnAndOff()
    {
        dogIsEnabled ^= true;
        dog.SetActive(dogIsEnabled);
    }
}
