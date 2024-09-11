using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ClientInterface {
    public partial class Form1 : Form {
        private string directory = "";
        private string oldstring = "";
        private string newstring = "";

        WebClient client = new WebClient();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        //TextBox area=====================================================================
        private void DirectoryTextBox_TextChanged(object sender, EventArgs e) {
            directory = DirectoryTextBox.Text;
        }

        private void OldStringTextBox_TextChanged(object sender, EventArgs e) {
            oldstring = OldStringTextBox.Text;
        }

        private void NewStringTextBox_TextChanged(object sender, EventArgs e) {
            newstring = NewStringTextBox.Text;
        }
        //TextBox area=====================================================================

        //Button area======================================================================
        private void DirectoryClearButton_Click(object sender, EventArgs e) {
            DirectoryTextBox.Text = "";
        }

        private void OldStringClearButton_Click(object sender, EventArgs e) {
            OldStringTextBox.Text = "";
        }

        private void NewStringClearButton_Click(object sender, EventArgs e) {
            NewStringTextBox.Text = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            if (DirectoryTextBox.Text == "") {
                DirectoryEmptyLabel.Visible = true;
            } else {
                DirectoryEmptyLabel.Visible = false;
            }

            if (OldStringTextBox.Text == "") {
                OldStringEmptyLabel.Visible = true;
            } else {
                OldStringEmptyLabel.Visible = false;
            }

            if (NewStringTextBox.Text == "") {
                NewStringEmptyLabel.Visible = true;
            } else {
                NewStringEmptyLabel.Visible = false;
            }

            if (DirectoryTextBox.Text != "" && OldStringTextBox.Text != "" && NewStringTextBox.Text != "") {
                const string path = @"\xampp\htdocs\dashboard\report.txt";
                using (FileStream file = File.Create(path)) { }

                NameValueCollection InputInfo = new NameValueCollection();
                InputInfo.Add("directory", directory);
                InputInfo.Add("old_string", oldstring);
                InputInfo.Add("new_string", newstring);
                byte[] ChangeStrings = client.UploadValues("http://localhost/dashboard/KDZ/AlterFiles.php", "POST", InputInfo);

                string text = "";
                using (StreamReader read = File.OpenText(path)) {
                    text = read.ReadToEnd();
                }

                if (MessageBox.Show(text, "Info") == DialogResult.OK) {
                    File.Delete(path);
                }
            }
        }
        //Button area======================================================================
    }
}
