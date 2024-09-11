namespace Course_Work_ver2 {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
        }

        const string path = @"D:\journal.txt";
        string screen_default_text = "a+bi" + Environment.NewLine + "+" + Environment.NewLine + "a+bi" + Environment.NewLine + "çíà÷åíèå âûðàæåíèÿ";
        string symbol;
        int value_number;
        bool end_calculation; 
        Complex complex1 = new Complex();
        Complex complex2 = new Complex();
        Complex result_complex = new Complex();
        Calculator calculator;

        private void Form1_Load(object sender, EventArgs e) {

            File.Delete(path); 
            screen.Text += screen_default_text;
            symbol = "";
            value_number = 1;
            end_calculation = false; 
            exponent_warning.Visible = false;

        }

        //ÏÎËÓ×ÅÍÈÅ ÄÀÍÍÛÕ ÀÁÑÖÈÑÑÛ=============================================
        private void a_button_1_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 1); }
        private void a_button_2_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 2); }
        private void a_button_3_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 3); }
        private void a_button_4_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 4); }
        private void a_button_5_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 5); }
        private void a_button_6_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 6); }
        private void a_button_7_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 7); }
        private void a_button_8_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 8); }
        private void a_button_9_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 9); }
        private void a_button_0_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_a(ref complex1, ref complex2, 0); }
        private void a_button_comma_Click(object sender, EventArgs e) { if (end_calculation == false) set_comma_a(ref complex1, ref complex2); }
        private void a_button_minus_Click(object sender, EventArgs e) { if (end_calculation == false) set_minus_a(ref complex1, ref complex2); }
        //ÏÎËÓ×ÅÍÈÅ ÄÀÍÍÛÕ ÀÁÑÖÈÑÑÛ============================================= 


        //ÏÎËÓ×ÅÍÈÅ ÄÀÍÍÛÕ ÎÐÄÈÍÀÒÛ=============================================
        private void b_button_1_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 1); }
        private void b_button_2_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 2); }
        private void b_button_3_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 3); }
        private void b_button_4_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 4); }
        private void b_button_5_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 5); }
        private void b_button_6_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 6); }
        private void b_button_7_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 7); }
        private void b_button_8_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 8); }
        private void b_button_9_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 9); }
        private void b_button_0_Click(object sender, EventArgs e) { if (end_calculation == false) set_value_b(ref complex1, ref complex2, 0); }
        private void b_button_comma_Click(object sender, EventArgs e) { if (end_calculation == false) set_comma_b(ref complex1, ref complex2); }
        private void b_button_minus_Click(object sender, EventArgs e) { if (end_calculation == false) set_minus_b(ref complex1, ref complex2); }
        //ÏÎËÓ×ÅÍÈÅ ÄÀÍÍÛÕ ÎÐÄÈÍÀÒÛ=============================================


        //ÎÏÐÅÄÅËÅÍÈÅ ÎÏÅÐÀÖÈÈ==================================================
        private void addition_button_Click(object sender, EventArgs e) { if (end_calculation == false) set_symbol("+", false); }
        private void subtraction_button_Click(object sender, EventArgs e) { if (end_calculation == false) set_symbol("-", false); }
        private void multiplication_button_Click(object sender, EventArgs e) { if (end_calculation == false) set_symbol("*", false); }
        private void division_button_Click(object sender, EventArgs e) { if (end_calculation == false) set_symbol("/", false); }
        private void exponentiation_button_Click(object sender, EventArgs e) { if (end_calculation == false) set_symbol("^", true); }
        //ÎÏÐÅÄÅËÅÍÈÅ ÎÏÅÐÀÖÈÈ==================================================


        //ÒÐÈÃÎÍÎÌÅÒÐÈ×ÅÑÊÀß ÔÎÐÌÀ==============================================
        private void trig_form_button_Click(object sender, EventArgs e) {
  
            symbol = "trig"; 
            screen_update();
            File.AppendAllText(path, "#óñòàíîâëåíî çíà÷åíèå# :: " + complex1.string_format() + "\n");
            File.AppendAllText(path, "#óñòàíîâëåíà îïåðàöèÿ# :: " + symbol + "\n");
            exponent_warning.Visible = false;

        }
        //ÒÐÈÃÎÍÎÌÅÒÐÈ×ÅÑÊÀß ÔÎÐÌÀ==============================================


        //ÝÊÑÏÎÍÅÍÖÈÀËÜÍÀß ÔÎÐÌÀ================================================
        private void exp_form_button_Click(object sender, EventArgs e) {
            
            symbol = "exp"; 
            screen_update();
            File.AppendAllText(path, "#óñòàíîâëåíî çíà÷åíèå# :: " + complex1.string_format() + "\n");
            File.AppendAllText(path, "#óñòàíîâëåíà îïåðàöèÿ# :: " + symbol + "\n");
            exponent_warning.Visible = false; 
        
        }
        //ÝÊÑÏÎÍÅÍÖÈÀËÜÍÀß ÔÎÐÌÀ================================================


        //ÂÛÂÎÄ ÇÍÀ×ÅÍÈß========================================================
        private void calculate_button_Click(object sender, EventArgs e) {

            string error = "";
            string exponent_zero_event = "";
            string final_string = ""; 
            complex1.value_creation_a();
            complex2.value_creation_a();
            calculator = new Calculator(complex1, complex2);

            if (symbol == "+") calculator.addition(ref result_complex);
            else if (symbol == "-") calculator.subtraction(ref result_complex);
            else if (symbol == "*") calculator.multiplication(ref result_complex);
            else if (symbol == "/") calculator.division(ref result_complex, out error);
            else if (symbol == "^") calculator.exponentiation(ref result_complex, out error, out exponent_zero_event);
            else if (symbol == "trig" || symbol == "exp") calculator.trig_form(ref result_complex, out error);

            screen.Text += Environment.NewLine;

            if (error != "") {

                screen.Text += error;
                File.AppendAllText(path, "#óñòàíîâëåíî çíà÷åíèå# :: " + complex2.string_format() + "\n");
                File.AppendAllText(path, "#îáíàðóæåíà îøèáêà. Âû÷èñëåíèå ïðåðâàíî#\n");

            } else if (exponent_zero_event != "") {

                screen.Text += "1";
                File.AppendAllText(path, "#óñòàíîâëåíî çíà÷åíèå# :: 0\n");
                File.AppendAllText(path, "#âûâåäåí ðåçóëüòàò# :: 1\n"); 

            } else {

                if (symbol == "trig") {

                    final_string = result_complex.R().ToString() + "(cos" + result_complex.FI().ToString() + "+isin" + result_complex.FI().ToString() + ")";
                    screen.Text += final_string;
                    File.AppendAllText(path, "#âûâåäåí ðåçóëüòàò# :: " + final_string + "\n");

                } else if (symbol == "exp") {

                    final_string = result_complex.R().ToString() + "e^(i" + result_complex.FI().ToString() + ")";
                    screen.Text += final_string;
                    File.AppendAllText(path, "#âûâåäåí ðåçóëüòàò# :: " + final_string + "\n");

                } else {

                    if (result_complex.A() != 0 && result_complex.B() > 0) final_string = result_complex.A().ToString() + "+" + result_complex.B().ToString() + "i";
                    else if (result_complex.A() != 0 && result_complex.B() < 0) final_string = result_complex.A().ToString() + result_complex.B().ToString() + "i";
                    else if (result_complex.A() != 0 && result_complex.B() == 0) final_string = result_complex.A().ToString();
                    else if (result_complex.A() == 0 && result_complex.B() != 0) final_string = result_complex.B().ToString() + "i";
                    else final_string = "0";

                    screen.Text += final_string;
                    File.AppendAllText(path, "#óñòàíîâëåíî çíà÷åíèå# :: " + complex2.string_format() + "\n");
                    File.AppendAllText(path, "#âûâåäåí ðåçóëüòàò# :: " + final_string + "\n");

                }

            }

            end_calculation = true; 

        }
        //ÂÛÂÎÄ ÇÍÀ×ÅÍÈß========================================================


        //Î×ÈÑÒÊÀ ÏÎËß==========================================================
        private void clear_button_Click(object sender, EventArgs e) {

            complex1.delete_value();
            complex2.delete_value();
            result_complex.delete_value();
            screen.Clear();
            screen.ForeColor = Color.Gray;
            screen.Text = screen_default_text;
            value_number = 1;
            symbol = "";
            end_calculation = false;
            File.AppendAllText(path, "#ïîëå ñáðîøåíî#\n");

        }
        //Î×ÈÑÒÊÀ ÏÎËß==========================================================


        //ÂÛÂÎÄ ÆÓÐÍÀËÀ=========================================================
        private void report_button_Click(object sender, EventArgs e) { MessageBox.Show(File.ReadAllText(path)); }
        //ÂÛÂÎÄ ÆÓÐÍÀËÀ=========================================================


        //ÂÑÏÎÌÎÃÀÒÅËÜÍÛÅ ÔÓÍÊÖÈÈ===============================================
        private void screen_update() {

            screen.ForeColor = Color.Black;
            if (symbol == "^") screen.Text = complex1.string_format() + Environment.NewLine + symbol + Environment.NewLine + complex1.string_exp_format();
            else screen.Text = complex1.string_format() + Environment.NewLine + symbol + Environment.NewLine + complex2.string_format();

        }
        private void set_value_a(ref Complex obj1, ref Complex obj2, int value) {

            if (value_number == 1) obj1.add_value_a(value);
            else if (value_number == 2) {

                if (symbol == "^") obj1.add_value_exp(value);
                else obj2.add_value_a(value);

            }
            screen_update();

        }
        private void set_comma_a(ref Complex obj1, ref Complex obj2) {

            if (value_number == 1) obj1.add_comma_a();
            else if (value_number == 2) {

                if (symbol != "^") obj2.add_comma_a();

            }
            screen_update();

        }
        private void set_minus_a(ref Complex obj1, ref Complex obj2) {

            if (value_number == 1) obj1.add_minus_a();
            else if (value_number == 2) {

                if (symbol == "^") obj1.add_minus_exp();
                else obj2.add_minus_a();

            }
            screen_update();

        }
        private void set_value_b(ref Complex obj1, ref Complex obj2, int value) {

            if (value_number == 1) obj1.add_value_b(value);
            else if (value_number == 2) {

                if (symbol != "^") obj2.add_value_b(value);

            }
            screen_update();

        }
        private void set_comma_b(ref Complex obj1, ref Complex obj2) {

            if (value_number == 1) obj1.add_comma_b();
            else if (value_number == 2) {

                if (symbol != "^") obj2.add_comma_b();

            }
            screen_update();

        }
        private void set_minus_b(ref Complex obj1, ref Complex obj2) {

            if (value_number == 1) obj1.add_minus_b();
            else if (value_number == 2) {

                if (symbol != "^") obj2.add_minus_b();

            }
            screen_update();

        }
        private void set_symbol(string symb, bool exp_warn) {

            symbol = symb;
            value_number = 2;
            screen_update();
            exponent_warning.Visible = exp_warn;
            File.AppendAllText(path, "#óñòàíîâëåíî çíà÷åíèå# :: " + complex1.string_format() + "\n");
            File.AppendAllText(path, "#óñòàíîâëåíà îïåðàöèÿ# :: " + symbol + "\n"); 

        }
        private void screen_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }
        //ÂÑÏÎÌÎÃÀÒÅËÜÍÛÅ ÔÓÍÊÖÈÈ===============================================

    }

}