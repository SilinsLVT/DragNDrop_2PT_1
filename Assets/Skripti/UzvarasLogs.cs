using UnityEngine;
using UnityEngine.SceneManagement;

public class UzvarasLogs : MonoBehaviour
{
    public NomesanasVieta nomesanasVietaScript;

    private float sakas;

    void Start()
    {
        sakas = Time.time;
    }

    void Update(){
        if (visiIr()){
            float laiks = Time.time - sakas;
            int zvaigznes = cikzvaigznes(laiks);
            uzvara(zvaigznes);
        }
    }

    bool visiIr()
    {
       bool[] vietā = nomesanasVietaScript.vieta;

        for (int i = 0; i < vietā.Length; i++){
            if (!vietā[i])
            {
                return false;
            }
        }
        return true;
    }

    int cikzvaigznes(float laiks)
    {
        if (laiks <= 120f){
            return 3;
        }
        else if (laiks <= 180f){
            return 2;
        }
        else{
            return 1;
        }
    }

    void uzvara(int zvaigznes)
    {
        switch (zvaigznes)
        {
            case 3:
                SceneManager.LoadScene("3", LoadSceneMode.Single);
                break;

            case 2:
                SceneManager.LoadScene("2", LoadSceneMode.Single);
                break;

            case 1:
                SceneManager.LoadScene("1", LoadSceneMode.Single);
                break;
        }
        Time.timeScale = 0f;
    }
}