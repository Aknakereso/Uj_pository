
using UnityEngine;

class ControsStructure : MonoBehaviour
{
    // Start is called before the first frame update


    //szekvencia: parancsok egym�s ut�n.
    //El�gaz�s: If f�ggv�ny


    [SerializeField] int number;
    void Start()
    {
        bool isEven = number % 2 == 0;

        if (isEven) //ha igaz. Ez �gy funkcion�lis!
        {

            Debug.Log("p�ros");
        }
        else
        {  // de ha nem

            Debug.Log("p�ratlan");
        }
        // ------negat�v, pozit�v, nulla?

        if (number >= 1)
        {
            Debug.Log("pozit�v");
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
        while (i < number) //ez egy igaz felt�tel
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
