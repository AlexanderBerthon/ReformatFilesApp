namespace ReformatFilesApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Multiselect = true;
        }

        private OpenFileDialog openfiledialog1;
        private String[] oldFileNames;
        private String[] newFileNames;

        private void FileSelectButton_Click(object sender, EventArgs e) {
            openfiledialog1.ShowDialog();
            if(openfiledialog1.ShowDialog() == DialogResult.OK) {
                oldFileNames = openfiledialog1.FileNames.ToArray(); //possible issue here, I initialize the array when the user clicks the button. what if they click it over and over again? garbage collection? 
                newFileNames = new String[oldFileNames.Length];

                PathTextbox.Text = oldFileNames[0].Substring(oldFileNames[0].LastIndexOf('\\') + 1);
                for (int i = 1; i<oldFileNames.Length; i++) {
                    PathTextbox.Text += "\n" + oldFileNames[i].Substring(oldFileNames[i].LastIndexOf('\\') + 1);
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e) {
            if(oldFileNames != null) {
                lowercaseExt();
            }
        }

        void lowercaseExt() {
            //works on any file type
            for (int i = 0; i < oldFileNames.Length; i++) {
                newFileNames[i] = Path.ChangeExtension(oldFileNames[i], (oldFileNames[i].Substring(oldFileNames[i].LastIndexOf('.') + 1)).ToUpper());
            }
            applyChanges();
        }

        void applyChanges() {
            //apply the changes to the directory
            if (newFileNames.Length == oldFileNames.Length) {
                for (int i = 0; i < newFileNames.Length; i++) {
                    try {
                        File.Move(oldFileNames[i], newFileNames[i]);
                    }
                    catch (System.IO.IOException e) {
                        File.Delete(oldFileNames[i]);
                    }
                }
            }
        }

    }
}