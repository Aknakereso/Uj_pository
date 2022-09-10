
using UnityEngine;

 class OnValidatePractice : MonoBehaviour
{
    //�j Unity f�ggv�ny

    [SerializeField, Min(0)] int intField;            //ezek itt a Unity panelj�ben, az
    [SerializeField] float floatField;        // objektum jellemz�i n�l
                                              // tal�lhat� attrib�tumokn�l l�that� a jelent�s�ge
    [SerializeField] string stringField;      //attrib�tum menut csi�lhatunk (inspector felulet)
    [SerializeField] bool boolField;

    [Space]
    [SerializeField] int number;
    [SerializeField] bool IsNumberEven;




    void OnValidate()
    {
        IsNumberEven = number % 2 == 0;

        Debug.Log(intField);
    }

}
