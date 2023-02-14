namespace ReformatFilesApp {

    public partial class Form1 : Form {

        private OpenFileDialog openfiledialog1;
        private string[] oldFileNames;
        private string[] newFileNames;

        public Form1() {
            InitializeComponent();
            openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Multiselect = true;
        }

        private void FileSelectButton_Click(object sender, EventArgs e) {
            if(openfiledialog1.ShowDialog() == DialogResult.OK) {
                oldFileNames = openfiledialog1.FileNames.ToArray();
                newFileNames = new string[oldFileNames.Length];
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

        void updateDisplayedFiles(string[] fileNames) {
            //turn path to the file(s) into readable file name to display to the user
            string[] displayedNames = new string[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++) {
                displayedNames[i] = fileNames[i].Substring(fileNames[i].LastIndexOf('\\') + 1);
            }

            fileListBox.DataSource = null;
            fileListBox.DataSource = displayedNames;
        }

    }
}