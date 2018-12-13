using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            decimal Mil = 10;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING
            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex); //CONVERT: "M"

            //1.2 CHAR to BOOL
            //bool place1 = place;                                        //IMPLICIT: NOT COMPILING
            //bool place1 = (bool)place                                   //EXPLICIT: NOT COMPILING   
            //bool place1 = Convert.ToBoolean(place);                     //InvalidCastException

            //1.3 CHAR to DECIMAL
            decimal placeToDecimal = place;
            decimal placeToDecimal1 = (decimal) place;
            decimal placeToDecimal2 = Convert.ToDecimal(place);
            //1.4 CHAR to INT
            int placeToInt = place;
            int placeToInt1 = (int)place;
            int placeToInt2 = Convert.ToInt32(place);
            //2. STRING CONVERSION

            //2.1 STRING to CHAR
            //char nameToString = name;                                    //IMPLICIT: NOT COMPILING
            //char nametoString1 = (char)name;                              //EXPLICIT: NOT COMPILING
            char nameToString2 = Convert.ToChar(name);

            //2.2 STRING to BOOL
            //bool hasPhotoToBool = hasPhoto;
            //bool hasPhotoToBool = (bool)hasPhoto;
            bool hasPhotoToBool = Convert.ToBoolean(hasPhoto);

            //2.3 STRING to DECIMAL
            //decimal flatNumberToDecimal = flatNumber;
            //decimal flatNumberToDecimal = (decimal)flatNumber;
            decimal flatNumberToDecimal = Convert.ToDecimal(flatNumber);

            //2.4 STRING to INT
            //int flatNumberToInt = flatNumber;
            //int flatNumberToInt = (int)flatNumber;
            int flatNumberToInt1 = Convert.ToInt32(flatNumber);

            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR
            //char hasFree2PagesToChar = hasFree2Pages;
            //char hasFree2PagesToChar = (char)hasFree2Pages;
            char hasFree2PagesToChar = Convert.ToChar(hasFree2Pages);

            //3.2 BOOL to STRING
            //string hasFree2PagesToChar1 = hasFree2Pages;
            //string hasFree2PagesToChar1 = (string)hasFree2Pages;
            string hasFree2PagesToChar1 = Convert.ToString(hasFree2Pages);

            //3.3 BOOL to DECIMAL

            //3.4 BOOL to INT

            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR
            //char MilToChar = Mil;
            //char MilToChar = (char)Mil;
            char MilToChar = Convert.ToChar(Mil);

            //4.2 DECIMAL to BOOL
            bool MilToBool = Convert.ToBoolean(Mil);

            //4.3 DECIMAL to STRING
            //string MilToString = Mil;
            //string MilToString = (string)Mil;
            string MilToString = Convert.ToString(Mil);
            //4.4 DECIMAL to INT
            //int MilToInt = Mil;
            int MilToInt = (int)Mil;
            //5. INT CONVERSION         

            //5.1 INT to CHAR
            //char birthYearToChar = birthYear;
            char birthYearToChar = (char)birthYear;
            char birthYearToChar1 = Convert.ToChar(birthYear);
            //5.2 INT to BOOL
            //bool birthYearToInt = birthYear;
            //bool birthYearToInt = (bool)birthYear;
            bool birthYearToInt = Convert.ToBoolean(birthYear);
            //5.3 INT to DECIMAL
            decimal birthYearToDecimal = birthYear;
            //5.4 INT to STRING
            //string birthYearToString = birthYear;
            //string birthYearToString = (string)birthYear;
            string birthYearToString = Convert.ToString(birthYear);
        }
    }

}
