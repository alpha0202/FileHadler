namespace FileHadler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }


        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cboSystemDrives.Items.Add(drive);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void cboSystemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var disk = cboSystemDrives.SelectedItem.ToString();
                DriveInfo driveInfo = new DriveInfo(disk);

                var driveDetails = $@"
                                    Drive: {disk} drive:

                                    Total size: {driveInfo.TotalSize}
                                    Free space avalible: {driveInfo.AvailableFreeSpace}
                                    Format: {driveInfo.DriveFormat}
                                    Type: {driveInfo.DriveType}
                                    ";

                txtSystemDetails.Text = driveDetails;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Please, enter the path for the directorty");

                if (!Directory.Exists(txtNewDirectory.Text))
                {
                    Directory.CreateDirectory(txtNewDirectory.Text);
                    MessageBox.Show("Directoty created");

                }
                else
                {
                    MessageBox.Show("Please, enter the full path of the new directory");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        private void btnCreateSubDirectory_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on new directory");

                if (string.IsNullOrEmpty(txtNewSubDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on new sub directory");

                var directoryPath = txtNewDirectory.Text;
                var subDirectoyInfo = new DirectoryInfo(directoryPath);
                subDirectoyInfo.CreateSubdirectory(txtNewSubDirectory.Text);
                MessageBox.Show("subdirectory has been create");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on new directory");

                var directorty = txtNewDirectory.Text;
                var directoryInfo = new DirectoryInfo(directorty);

                if (!directoryInfo.Exists)
                    throw new Exception("directory doesn't exist");

                var subDirectories = directoryInfo.GetDirectories();
                foreach (var subDir in subDirectories)
                {
                    if (!cboDirectoryFile.Items.Contains(subDir.Name))

                        cboDirectoryFile.Items.Add(subDir.Name);

                }

                var files = directoryInfo.GetFiles("*");
                foreach (var file in files)
                {
                    if (!cboDirectoryFile.Items.Contains(file.Name))

                        cboDirectoryFile.Items.Add(file.Name);

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtCDSource.Text) || string.IsNullOrEmpty(txtCDDestination.Text))
                    throw new Exception("Source and destination fields shoudld have values.");

                var sourceDirectory = new DirectoryInfo(txtCDSource.Text);
                var destiDirectory = new DirectoryInfo(txtCDDestination.Text);
                CopyDirectory(sourceDirectory, destiDirectory);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CopyDirectory(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {

            try
            {
                if (!sourceDirectory.Exists)
                    throw new Exception("Source directory doesn't exist");

                if (!destinationDirectory.Exists)
                    destinationDirectory.Create();

                var files = sourceDirectory.GetFiles();
                foreach (var file in files)
                {
                    file.CopyTo(Path.Combine(destinationDirectory.FullName, file.Name));
                }

                var directories = sourceDirectory.GetDirectories();
                foreach (var directory in directories)
                {
                    string destination = Path.Combine(destinationDirectory.FullName, directory.Name);
                    CopyDirectory(sourceDirectory, new DirectoryInfo(destination));
                }
                MessageBox.Show("Directory copied successfully");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        //create a new file 
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a path for the new File.");



                if (!File.Exists(txtNewFile.Text))
                {
                    File.Create(txtNewFile.Text);
                    MessageBox.Show("File created");
                }
                else
                {
                    MessageBox.Show("please enter the path of the new file");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }

        }


        //open file 
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSelectedFile.Text = openFileDialog1.FileName;
                    txtRenameFile.Text = openFileDialog1.FileName;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRenameFile_Click(object sender, EventArgs e)
        {
            try
            {

                string source = txtSelectedFile.Text;
                string target = txtRenameFile.Text;

                var sourceFileInfo = new FileInfo(source);

                if (sourceFileInfo.Exists)
                {
                    sourceFileInfo.MoveTo(target);
                    MessageBox.Show("the file has been Renamed");
                }
                else
                {
                    MessageBox.Show("Error, when try to rename the file. The path is incorrect.");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSelectedFile.Text))
                    throw new Exception("Make sure you selected file.");


                if (!File.Exists(txtSelectedFile.Text))
                    throw new Exception("Select file doesn't exist.");


                FileStream fs = new FileStream(txtSelectedFile.Text, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(txtWrite.Text);
                sw.Flush();
                fs.Close();
                MessageBox.Show("New content has been successfully written.");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Read
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSelectedFile.Text))
                    throw new Exception("Make sure you selected file.");


                if (!File.Exists(txtSelectedFile.Text))
                    throw new Exception("Select file doesn't exist.");


                FileStream fs = new FileStream(txtSelectedFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtRead.Text = sr.ReadToEnd();
                fs.Close() ;
 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
        //find something string
        private void btnFine_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSelectedFile.Text))
                    throw new Exception("Make sure you selected file.");


                if (!File.Exists(txtSelectedFile.Text))
                    throw new Exception("Select file doesn't exist.");


                FileStream fs = new FileStream(txtSelectedFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                
                var content = sr.ReadToEnd();

                int i = content.IndexOf(txtFind.Text.Trim(),0);

                if (i > -1)
                    MessageBox.Show("the string is present in the file.","Notice");
                else
                    MessageBox.Show("the string wasn't found in the file.");

            

                fs.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
        //update file
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSelectedFile.Text))
                    throw new Exception("Make sure you selected file.");


                if (!File.Exists(txtSelectedFile.Text))
                    throw new Exception("Select file doesn't exist.");

                var path = txtSelectedFile.Text;

                var sw = File.AppendText(path);
                sw.WriteLine(txtUpdate.Text);
                sw.Close();

                MessageBox.Show("file content appended sussccesfully.","Notice");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}