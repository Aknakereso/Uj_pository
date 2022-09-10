
using UnityEngine;

class ControsStructure : MonoBehaviour
{
    // Start is called before the first frame update


    //szekvencia: parancsok egymás után.
    //Elágazás: If függvény


    [SerializeField] int number;
    void Start()
    {
        bool isEven = number % 2 == 0;

        if (isEven) //ha igaz. Ez így funkcionális!
        {

            Debug.Log("páros");
        }
        else
        {  // de ha nem

            Debug.Log("páratlan");
        }
        // ------negatív, pozitív, nulla?

        if (number >= 1)
        {
            Debug.Log("pozitív");
        }
        else if (number <= -1)
        {
            Debug.Log("negative");


        }
        else
        {
            Debug.Log("zero");
        }




        //Loopok, Ciklusok, hurkok

        int i = 1;
        while (i < number) //ez egy igaz feltétel
        {

            Debug.Log(i);
            i++; //i+1
        }

        for (int j = 0; j < number; j++)
        {
            Debug.Log(j); //ctrl + k+d
        }

    }


}
