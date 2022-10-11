using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCowImage : MonoBehaviour
{
    [SerializeField]
    private GameObject Cow;

    private bool CowIsEnabled;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        CowIsEnabled = true;
        Cow.SetActive(CowIsEnabled);
    }


    private void TurnOnAndOff()
    {
        CowIsEnabled ^= true;
        Cow.SetActive(CowIsEnabled);
    }
}
