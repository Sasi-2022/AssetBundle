using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCatImage : MonoBehaviour
{
    [SerializeField]
    private GameObject cat;

    private bool catIsEnabled;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        catIsEnabled = true;
        cat.SetActive(catIsEnabled);
    }


    private void TurnOnAndOff()
    {
        catIsEnabled ^= true;
        cat.SetActive(catIsEnabled);
    }
}
