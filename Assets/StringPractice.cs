
using UnityEngine;

class StringPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        string myString = "Farag�";
        string s1 = "Bal�zs";
        string s2 = $"Nevem {s1}, aki itt van{name}";  // a $ jel m�k�d�sre b�rja a { } bnel�li dolgokat 
        Debug.Log(s2);

        int myAge = 30;  //a halv�nyk�kre lesznek utal�sok a parancsban
        float myHeight = 1.80f;

        string introduction = $"Nevem {s1}, {myHeight} magass�ggal �s {myAge} korral";
        Debug.Log(introduction);

        //sz�m �s sz�veg �sszef�z�s(konfaten�l�s)
        string aaa = "cukor";
        string ddd = aaa + myAge;
        Debug.Log(ddd);


        string s6 = myAge.ToString(); //sz�veg lesz az �rt�kb�l. Nem sz�molunk vele
        string s7 = 44.55f.ToString();





    }
}
