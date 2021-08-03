using System;
using UnityEngine;
using UnityEngine.UI;

public class kkadusic1_interfejs : MonoBehaviour
{
    public Text infoTekst;
    public Text pomocTekst;

    private bool prikazaneInfo = false;
    private bool prikazanaPomoc = false;

    public string url;
    

    public void izlaz()
    {
        Application.Quit();
    }

    public void informacije()
    {
        if (prikazaneInfo == false)
        {
            if (prikazanaPomoc)
            {
                pomocTekst.text = "";
                prikazanaPomoc = false;
            }
            infoTekst.text = "TOWER BRIDGE AUGUMENTED REALITY" + Environment.NewLine +
                        "Elektrotehnički fakultet Sarajevo" + Environment.NewLine +
                        "Računarska grafika" + Environment.NewLine +
                        "Kerim Kadušić" + Environment.NewLine +
                        "Sarajevo, januar 2020.";
            prikazaneInfo = true;
        }
        else
        {
            infoTekst.text = "";
            prikazaneInfo = false;
        }
    }

    public void pomoc()
    {
        if (prikazanaPomoc == false)
        {
            if (prikazaneInfo)
            {
                infoTekst.text = "";
                prikazaneInfo = false;
            }
            pomocTekst.text = "UPUTE ZA RAD NAD APLIKACIJOM" + Environment.NewLine +
                              "- Za prikaz videa pritisnuti na brod" + Environment.NewLine +
                              "- Za prikaz osnovih informacija o mostu" + Environment.NewLine +
                              "  pritisnuti na zastavu Velike Britanije" + Environment.NewLine +
                              "- Za slusanje himne Velike Britanije" + Environment.NewLine +
                              "  pritisnuti na crvenu telefonsku govorincu" + Environment.NewLine +
                              " (Za zatvaranje neke od prethodnih stavki" + Environment.NewLine +
                              " pritisnuti opet na neki od objekata)";
            prikazanaPomoc = true;
        }
        else
        {
            pomocTekst.text = "";
            prikazanaPomoc = false;
        }
    }

    public void otvoriUrl()
    {
        Application.OpenURL(url);
    }

}