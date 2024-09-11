using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_ver2 {
    internal class Calculator {

        public Calculator(Complex C1, Complex C2) {

            this.C1 = C1;
            this.C2 = C2;

        }
        
        Complex C1;
        Complex C2;

        public void addition(ref Complex ad_result) { ad_result = C1 + C2; }
        public void subtraction(ref Complex sub_result) { sub_result = C1 - C2; }
        public void multiplication(ref Complex mul_result) { mul_result = C1 * C2; } 
        public void division(ref Complex div_result, out string error) {

            error = ""; 

            if (C2.A() == 0 && C2.B() == 0) error = "ошибка"; //ошибка деления на ноль
            else div_result = C1 / C2;
        
        }
        public void exponentiation(ref Complex exp_result, out string error, out string exponent_zero_event) {

            error = "";
            exponent_zero_event = "";
            int exponent = C1.EXP(); 

            if (exponent < 0) {

                if (C1.A() == 0 && C1.B() == 0) error = "ошибка"; //ошибка возведения нуля в отрицательную степень 
                else {

                    exponent *= -1;
                    exp_result = C1;
                    for (int num = 0; num < exponent - 1; num++) { exp_result *= C1; }
                    exp_result = 1 / exp_result; 

                }

            } else if (exponent == 0) {

                exponent_zero_event = "1";

            } else {

                exp_result = C1;
                for (int num = 0; num < exponent - 1; num++) { exp_result *= C1; }

            }

        }
        public void trig_form(ref Complex trig_result, out string error) {

            error = ""; 
            C1.value_creation_trig(out error);
            trig_result = C1; 

        }

    }

}
