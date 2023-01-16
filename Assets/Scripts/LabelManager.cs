using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LabelManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    void Start()
    {
        _text.text = gameObject.name;
    }

    void Update()
    {
        
    }
}
