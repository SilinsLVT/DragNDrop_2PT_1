﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;
    public bool[] vieta = new bool[12];

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null)
		{
            if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

                    switch (eventData.pointerDrag.tag) {
                        case "atkritumi":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[1]);
                            vieta[0] = true;
                            break;

                        case "atrie":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[2]);
                            vieta[1] = true;
                            break;

                        case "buss":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[3]);
                            vieta[2] = true;
                            break;

                        case "uguns":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[4]);
                            vieta[3] = true;
                            break;

                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[5]);
                            vieta[4] = true;
                            break;

                        case "b2":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[6]);
                            vieta[5] = true;
                            break;

                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[7]);
                            vieta[6] = true;
                            break;

                        case "e61":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[8]);
                            vieta[7] = true;
                            break;

                        case "eksk":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[9]);
                            vieta[8] = true;
                            break;

                        case "poli":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[10]);
                            vieta[9] = true;
                            break;

                        case "tr1":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[11]);
                            vieta[10] = true;
                            break;

                        case "tr2":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[12]);
                            vieta[11] = true;
                            break;

                        default:
							Debug.Log("Tags nav definēts!");
							break;
					}
				}

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord;
                        break;

                    case "atrie":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atrPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.bussKoord;
                        break;


					case "uguns":
                        objektuSkripts.ugunsdzeseji.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.ugunsKoord;
                        break;


                    case "cements":
                        objektuSkripts.cementamasina.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.cementaKoord;
                        break;


                    case "b2":
                        objektuSkripts.b2.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.b2Koord;
                        break;


                    case "e46":
                        objektuSkripts.e46.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.e46Koord;
                        break;


                    case "e61":
                        objektuSkripts.e61.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.e61Koord;
                        break;


                    case "eksk":
                        objektuSkripts.ekskavators.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.eksKoord;
                        break;


                    case "poli":
                        objektuSkripts.policija.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.polKoord;
                        break;


                    case "tr1":
                        objektuSkripts.traktors.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.tKoord;
                        break;


                    case "tr2":
                        objektuSkripts.traktors2.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.t2Koord;
                        break;


                    default:
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}

    bool visiIr()
    {
        for (int i = 0; i < vieta.Length; i++)
        {
            if (!vieta[i])
            {
                Debug.Log("Visi vietā!");
                return false;
            }
        }
        return true;
    }

}
