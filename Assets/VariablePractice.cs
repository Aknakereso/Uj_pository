using System.Collections;   //törlendõ
using System.Collections.Generic;  //törlendõ
using UnityEngine;

class VariablePractice : MonoBehaviour   //public class: a 'public' törlendõ
{ 
    private void Start()
    {

        // komment perjellel: / , de kettõvel. Most ez az egész sor komment
        /*egy egy komment
         * 
         * 
         * szegmens eddig is tarthat: */
        int myFirstVariable;
        myFirstVariable = 5;

        myFirstVariable = 30;


        Debug.Log(myFirstVariable);


        myFirstVariable = 40;
        Debug.Log(myFirstVariable);

        int a = 3 + 5;
        int b = a - 4; //4
        int c = a * b; //16
        int d = a / 3; //2

        float f1 = 45.33f;   //tizedesenek
        float f2 = 3.3f, f3 = 7.2f, f4 = 5.4f, f5 = 5; //f a tizedesértéknél kell, egésznél nem      

        float sum = f1 + f2;
        float difference = f1 - f2;
        float product = f1 * f2;
        float rate = f1 / f2;

        int rateInt = 11 / 3;  //3 lesz a maradék nem lesz kiirva
        int moduloInt = 11 % 3;  //2 lesz;maradékot fogja kiirni "modulo" mûvelet"


        // kasztlás
        float fff = 5;  //Implicit kasztolás

        int iii = (int)5.5f;//explicit kasztolás

        //összeaDÁSI LEEHTÕSÉGEK:

        a = a + 1;
        a += 1;
        a++; // EGYET ADUNK HOZZÁ (akár kivonunk)

        Debug.Log(a);
             



    }


}
