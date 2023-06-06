using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject ugunsdzeseji;
	public GameObject b2;
	public GameObject e46;
	public GameObject e61;
	public GameObject ekskavators;
	public GameObject policija;
	public GameObject traktors;
	public GameObject traktors2;



	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 ugunsKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 eksKoord;
    [HideInInspector]
    public Vector2 polKoord;
    [HideInInspector]
    public Vector2 tKoord;
    [HideInInspector]
    public Vector2 t2Koord;

    public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;

        ugunsKoord =
            ugunsdzeseji.GetComponent<RectTransform>().localPosition;

        b2Koord = 
			b2.GetComponent<RectTransform>().localPosition;

        e46Koord =
            e46.GetComponent<RectTransform>().localPosition;

        e61Koord =
            e61.GetComponent<RectTransform>().localPosition;

        eksKoord =
            ekskavators.GetComponent<RectTransform>().localPosition;

        polKoord =
            policija.GetComponent<RectTransform>().localPosition;

        tKoord =
            traktors.GetComponent<RectTransform>().localPosition;

        t2Koord =
            traktors2.GetComponent<RectTransform>().localPosition;
    }
}
