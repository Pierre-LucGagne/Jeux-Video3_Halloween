using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private float nbTemps = 180;
    [SerializeField] private TMP_Text champTexteTemps;
    public UnityEvent auChangementDuTemps;
    public UnityEvent aLaFinDuTemps;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if(nbTemps > 0){
                //On décrémente le temps
                nbTemps -= Time.fixedDeltaTime;

                //On envoie l'événement
                auChangementDuTemps.Invoke();
            }

            else{
                nbTemps = 0;

                //On envoie l'événement
                aLaFinDuTemps.Invoke();
            }
    }

    public void AfficherTemps(){
        if(nbTemps < 0) nbTemps = 0;

        //Convertir le temps en secondes
        TimeSpan ts = TimeSpan.FromSeconds(nbTemps);

        champTexteTemps.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
    }
}
