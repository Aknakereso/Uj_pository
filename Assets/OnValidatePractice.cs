
using UnityEngine;

 class OnValidatePractice : MonoBehaviour
{
    //Új Unity függvény

    [SerializeField, Min(0)] int intField;            //ezek itt a Unity paneljében, az
    [SerializeField] float floatField;        // objektum jellemzõi nél
                                              // található attribútumoknál látható a jelentõsége
    [SerializeField] string stringField;      //attribútum menut csiálhatunk (inspector felulet)
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
