using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_ver2 {
    internal class Complex {

        public Complex() {

            a = 0;
            b = 0;
            r = 0; 
            exponent = 1; 
            sign_a = 1;
            sign_b = 1;
            sign_exp = 1; 
            int_part_length_a = 0;
            int_part_length_b = 0;
            comma_a = false; 
            comma_b = false;

        }

        List<int> Ai = new List<int>(0); //хранилище символов вещественных чисел по отдельности 
        List<int> Bi = new List<int>(0);
        List<int> EXPi = new List<int>(0); 
        
        private double a; //абсцисса
        private double b; //ордината
        private double r; //модуль
        private double fi; //аргумент

        private int exponent; //степень

        private int sign_a; //знак 
        private int sign_b;
        private int sign_exp; 

        private int int_part_length_a; //длина целой части 
        private int int_part_length_b;

        private bool comma_a; //индикатор наличия запятой 
        private bool comma_b; 

        public double A() { return a; }
        public double B() { return b; }
        public double R() { return r; } 
        public double FI() { return fi; }
        public int EXP() { return exponent; } 
        public void add_value_a(int value) { add_value(ref Ai, value, comma_a); }
        public void add_value_b(int value) { add_value(ref Bi, value, comma_b); }
        public void add_value_exp(int value) { add_value(ref EXPi, value); }
        public void add_comma_a() { add_comma(ref Ai, ref int_part_length_a, ref comma_a); }
        public void add_comma_b() { add_comma(ref Bi, ref int_part_length_b, ref comma_b); }
        public void add_minus_a() { add_minus(ref sign_a); }
        public void add_minus_b() { add_minus(ref sign_b); }
        public void add_minus_exp() { add_minus(ref sign_exp); }
        public void value_creation_a() { value_creation(ref Ai, ref a, int_part_length_a, sign_a); }
        public void value_creation_b() { value_creation(ref Bi, ref b, int_part_length_b, sign_b); }
        public void value_creation_exp() { value_creation(ref EXPi, ref exponent, sign_exp); }
        public void value_creation_trig(out string error) {

            error = "";
            if (a == 0 && b == 0) error = "ошибка";
            else {

                r = Math.Round(Math.Sqrt(a * a + b * b), 2); 
                fi = Math.Round(Math.Acos(a / r) * 180 / Math.PI, 2);

            } 
        
        }
        public void delete_value() { 
            
            Ai.Clear(); 
            Bi.Clear(); 
            EXPi.Clear();
            a = 0;
            b = 0;
            r = 0;
            fi = 0; 
            exponent = 0;
            sign_a = 1; 
            sign_b = 1;
            sign_exp = 1;
            int_part_length_a = 0;
            int_part_length_b = 0;
            comma_a = false;
            comma_b = false;

        }
        public string string_format() {

            value_creation_a();
            value_creation_b();

                 if (a != 0 && b > 0) return a.ToString() + "+" + b.ToString() + "i"; 
            else if (a != 0 && b < 0) return a.ToString() + b.ToString() + "i"; 
            else if (a != 0 && b == 0) return a.ToString(); 
            else if (a == 0 && b != 0) return b.ToString() + "i"; 
            else return "0"; 
 
        }
        public string string_exp_format() {

            value_creation_exp();
            return EXP().ToString(); 

        }

        private void add_value(ref List<int> list, int value, bool comma_cond = false) {

            if (list.Count < 10) {

                if (list.Count == 0) list.Add(value); //проверка нулевой строки 
                else {

                    if (value == 0) {

                        if (list[0] == 0 && comma_cond == true || list[0] != 0) list.Add(value); //условия введения нуля

                    } else {

                        if (list[0] == 0 && comma_cond == false) list[0] = value; //условия введения ненулевого значения
                        else list.Add(value);

                    }

                }

            }

        }
        private void add_comma(ref List<int> list, ref int integer_lenght, ref bool comma_cond) {
            
            if (list.Count != 0 && comma_cond == false) {

                comma_cond = true;
                integer_lenght = list.Count();

            }

        }
        private void add_minus(ref int coef) { if (coef != -1) coef = -1; }
        private void value_creation(ref List<int> list, ref double value, int integer_length, int coef) {

            value = 0; 
            if (integer_length == 0) integer_length = list.Count();
            int exponent = integer_length - 1;
            for (int num = 0; num < integer_length; num++) {

                value += list[num] * Math.Pow(10, exponent);
                exponent -= 1;

            }

            for (int num = integer_length; num < list.Count(); num++) {

                int symbols = num - integer_length + 1; 
                value += list[num] * Math.Pow(10, exponent);
                value = Math.Round(value, symbols); 
                exponent -= 1;

            }

            value *= coef;

        }
        private void value_creation(ref List<int> list, ref int value, int coef) {

            value = 0;
            int exponent = list.Count() - 1;
            for (int num = 0; num < list.Count(); num++) {

                value += list[num] * (int)Math.Pow(10, exponent);
                exponent -= 1;

            }

            value *= coef;

        }

        public static Complex operator +(Complex complex1, Complex complex2) {

            Complex result = new Complex(); 
            result.a = complex1.a + complex2.a; 
            result.b = complex1.b + complex2.b; 
            return result; 

        }
        public static Complex operator -(Complex complex1, Complex complex2) {

            Complex result = new Complex();
            result.a = complex1.a - complex2.a;
            result.b = complex1.b - complex2.b;
            return result;

        }
        public static Complex operator *(Complex complex1, Complex complex2) {

            Complex result = new Complex();
            result.a = complex1.a * complex2.a - complex1.b * complex2.b; 
            result.b = complex1.a * complex2.b + complex1.b * complex2.a;
            return result;

        }
        public static Complex operator /(Complex complex1, Complex complex2) {

            Complex result = new Complex();
            result.a = (complex1.a * complex2.a + complex1.b * complex2.b) / (complex2.a * complex2.a + complex2.b * complex2.b);
            result.b = (complex2.a * complex1.b - complex2.b * complex1.a) / (complex2.a * complex2.a + complex2.b * complex2.b);
            return result;

        }
        public static Complex operator /(int value, Complex complex) {

            Complex result = new Complex();
            result.a = complex.a / (complex.a * complex.a + complex.b * complex.b); 
            result.b = -1 * complex.b / (complex.a * complex.a + complex.b * complex.b);
            return result;

        }

    }

}
