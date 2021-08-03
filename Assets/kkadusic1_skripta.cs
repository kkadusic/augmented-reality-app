using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class kkadusic1_skripta : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject plane;
    public GameObject tekst;
    public GameObject audio;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            bool aktivanTekst = tekst.activeInHierarchy;
            bool aktivanVideo = plane.activeInHierarchy;
            bool aktivnaMuzika = audio.activeInHierarchy;


            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "kkadusic1_Brodic")
                {
                    if (!aktivanVideo)
                    {
                        tekst.SetActive(false);
                        audio.SetActive(false);
                        plane.SetActive(true);
                    }
                    else
                        plane.SetActive(false);
                }
                else if (hit.collider.gameObject.name == "kkadusic1_Zastava")
                {
                    if (!aktivnaMuzika)
                    {
                        plane.SetActive(false);
                        tekst.SetActive(false);
                        audio.SetActive(true);
                    }
                    else
                        audio.SetActive(false);
                }
                else if (hit.collider.gameObject.name == "kkadusic1_Govornica")
                {
                    if (!aktivanTekst)
                    {
                        audio.SetActive(false);
                        plane.SetActive(false);
                        tekst.SetActive(true);
                    }
                    else
                        tekst.SetActive(false);
                }
            }
        }
    }
}