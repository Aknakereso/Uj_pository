
using UnityEngine;

class StringPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        string myString = "Faragó";
        string s1 = "Balázs";
        string s2 = $"Nevem {s1}, aki itt van{name}";  // a $ jel mûködésre bírja a { } bnelüli dolgokat 
        Debug.Log(s2);

        int myAge = 30;  //a halványkékre lesznek utalások a parancsban
        float myHeight = 1.80f;

        string introduction = $"Nevem {s1}, {myHeight} magassággal és {myAge} korral";
        Debug.Log(introduction);

        //szám és szöveg összefûzés(konfatenálás)
        string aaa = "cukor";
        string ddd = aaa + myAge;
        Debug.Log(ddd);


        string s6 = myAge.ToString(); //szöveg lesz az értékbõl. Nem számolunk vele
        string s7 = 44.55f.ToString();





    }
}
