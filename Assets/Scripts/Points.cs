using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    private int nbPoint = 0;

    [SerializeField] private TMP_Text champPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        champPoint.text = nbPoint.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "grab"){
            nbPoint++;
            other.gameObject.SetActive(false);
        }
    }
}
