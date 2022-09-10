
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
        bool b6 = b != -66; //true    !=nemegyenõ?

        // LOGIKAI 'ÉS' &&  mûveletre példa:
        int ammo = 44;
        bool haveAmmo = ammo > 0;
        bool coolDown = true;
        bool canIShoot = haveAmmo && coolDown; //kiszámoljuk, hogy tudunk e lõni. && és mûvelet

        //vagylagosság || alt gr +w


        bool isOnGround = false;
        int airJumpCount = 1;
        bool canAirJump = airJumpCount < 1;

        bool canJump = isOnGround || (airJumpCount < 1); // nem tudunk ugrani


        //-----------! negál igazból negatívat csinál vagy fordítva. !+név

        bool canNotJump = !canJump; //canJUmp igazzá vált (elvileg)


        //random
        var i = 5;  //integer
        var g = 4.4f; //float
        var br = "fe"; //string
        var t = true; // bool
         //var egy szimpla változó.












    }
}
