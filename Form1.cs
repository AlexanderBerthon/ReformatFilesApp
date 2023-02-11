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
        private String[] displayedNames;


        private void FileSelectButton_Click(object sender, EventArgs e) {
            openfiledialog1.ShowDialog();
            if(openfiledialog1.ShowDialog() == DialogResult.OK) {
                oldFileNames = openfiledialog1.FileNames.ToArray(); //possible issue here, I initialize the array when the user clicks the button. what if they click it over and over again? garbage collection? 
                newFileNames = new String[oldFileNames.Length];
                displayedNames = new string[oldFileNames.Length];

                updateDisplayedFiles(oldFileNames);
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e) {
            if(oldFileNames != null) {
                lowercaseExt();
                updateDisplayedFiles(newFileNames);
            }
        }

        void lowercaseExt() {
            //works on any file type
            for (int i = 0; i < oldFileNames.Length; i++) {
                newFileNames[i] = Path.ChangeExtension(oldFileNames[i], (oldFileNames[i].Substring(oldFileNames[i].LastIndexOf('.') + 1)).ToLower());
                //newFileNames[i] = Path.ChangeExtension(oldFileNames[i], "JPG");
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

        void updateDisplayedFiles(String[] fileNames) {
            //turn path to file into readable file name to display to the user
            for (int i = 0; i < fileNames.Length; i++) {
                displayedNames[i] = fileNames[i].Substring(fileNames[i].LastIndexOf('\\') + 1);
            }
            fileListBox.DataSource = null;
            fileListBox.DataSource = displayedNames;
        }

    }
}