
using UnityEngine;

class BoolGyakorlas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        bool myFirstBool = true;

        myFirstBool = false;


        int a = 22, b = 66;

        bool b1 = a < b;  //true

        bool b2 = a > b;  //false

         
        bool b3 = a >= b;
        bool b4 = a <= b;

        bool b5 = b == 66; //true    ==egyezik e
        bool b6 = b != -66; //true    !=nemegyen�?

        // LOGIKAI '�S' &&  m�veletre p�lda:
        int ammo = 44;
        bool haveAmmo = ammo > 0;
        bool coolDown = true;
        bool canIShoot = haveAmmo && coolDown; //kisz�moljuk, hogy tudunk e l�ni. && �s m�velet

        //vagylagoss�g || alt gr +w


        bool isOnGround = false;
        int airJumpCount = 1;
        bool canAirJump = airJumpCount < 1;

        bool canJump = isOnGround || (airJumpCount < 1); // nem tudunk ugrani


        //-----------! neg�l igazb�l negat�vat csin�l vagy ford�tva. !+n�v

        bool canNotJump = !canJump; //canJUmp igazz� v�lt (elvileg)


        //random
        var i = 5;  //integer
        var g = 4.4f; //float
        var br = "fe"; //string
        var t = true; // bool
         //var egy szimpla v�ltoz�.












    }
}
