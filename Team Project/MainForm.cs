using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Team_Project
{
    public partial class MainForm : Form
    {
        const int LOWER_RATING = 1;
        const int UPPER_RATING = 5;

        //  Declare Lists for each of the following: audio, image, document, video
        List<GenericFile> fileList = new List<GenericFile>();

        //  Affiliate class with variable
        AudioFile currentAudio = new AudioFile();
        ImageFile currentImage = new ImageFile();
        DocumentFile currentDocument = new DocumentFile();
        VideoFile currentVideo = new VideoFile();

        //  Declare int variables as 0
        int numAudio = 0;
        int numImage = 0;
        int numDocument = 0;
        int numVideo = 0;
        int numFiles = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile; //To read the file
                string line;            //To hold a line from the file

                //Create a delimiter array
                char[] delim = { ',' };

                //Open the Files.txt file
                inputFile = File.OpenText("Files.txt");

                //Read the lines from the file
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    //  Check if the first tokenized string contains "Media"
                    if (tokens[0] == "Media")
                    {
                        //  Check if the first tokenized string contains "Audio"
                        if (tokens[1] == "Audio")
                        {
                            if (tokens[3] == "MP3" || tokens[3] == "AAC")
                            {
                                currentAudio = new AudioFile();

                                //  Tokenized variables are numbered and parsed
                                currentAudio.Name = tokens[2];
                                currentAudio.Type = tokens[3];
                                currentAudio.Size = tokens[4];
                                currentAudio.LastModification = int.Parse(tokens[5]);
                                currentAudio.Title = tokens[6];
                                currentAudio.Length = int.Parse(tokens[7]);
                                currentAudio.Rating = int.Parse(tokens[8]);
                                currentAudio.Artist = tokens[9];
                                currentAudio.BitRate = int.Parse(tokens[10]);

                                //Add one to the count of the amount of audio files
                                numAudio += 1;
                                //  Add field to created list
                                fileList.Add(currentAudio);
                                //  Send the following fields to the targeted ListBox
                                filesListBox.Items.Add(currentAudio.Name + "\t" + currentAudio.Type + "\t" + currentAudio.Size + "\t" + currentAudio.LastModification);
                            }
                            else
                            {
                                //Display an error message
                                MessageBox.Show("This Audio type is not supported");
                            }
                        }
                        //  Check if the first tokenized string contains "Video"
                        else if (tokens[1] == "Video")
                        {
                            if  (checkIfIntervalOK(int.Parse(tokens[8]), LOWER_RATING, UPPER_RATING))
                            {
                                if (tokens[3] == "MP4" || tokens[3] == "AVI" || tokens[3] == "MKV")
                                {
                                    currentVideo = new VideoFile();

                                    //  Tokenized variables are numbered and parsed
                                    currentVideo.Name = tokens[2];
                                    currentVideo.Type = tokens[3];
                                    currentVideo.Size = tokens[4];
                                    currentVideo.LastModification = int.Parse(tokens[5]);
                                    currentVideo.Title = tokens[6];
                                    currentVideo.Length = int.Parse(tokens[7]);
                                    currentVideo.Rating = int.Parse(tokens[8]);
                                    currentVideo.Director = tokens[9];
                                    currentVideo.Producer = tokens[10];

                                    //Add one to the count of the amount of audio files
                                    numVideo += 1;
                                    //  Add field to created list
                                    fileList.Add(currentVideo);
                                    //  Send the following fields to the targeted ListBox
                                    filesListBox.Items.Add(currentVideo.Name + "\t" + currentVideo.Type + "\t" + currentVideo.Size + "\t" + currentVideo.LastModification);
                                }
                                else
                                {
                                    //Display an error message
                                    MessageBox.Show("This Video type is not supported");
                                }
                            }
                        }
                    }
                    //  Check if the first tokenized string contains "Image"
                    else if (tokens[0] == "Image")
                    {
                        if (tokens[2] == "PNG" || tokens[2] == "JPG" || tokens[2] == "BMP")
                        {
                            currentImage = new ImageFile();

                            //  Tokenized variables are numbered and parsed
                            currentImage.Name = tokens[1];
                            currentImage.Type = tokens[2];
                            currentImage.Size = tokens[3];
                            currentImage.LastModification = int.Parse(tokens[4]);
                            currentImage.Width = decimal.Parse(tokens[5]);
                            currentImage.Height = decimal.Parse(tokens[6]);
                            currentImage.Resolution = tokens[7];

                            //Add one to the count of the amount of audio files
                            numImage += 1;
                            //  Add field to created list
                            fileList.Add(currentImage);
                            //  Send the following fields to the targeted ListBox
                            filesListBox.Items.Add(currentImage.Name + "\t" + currentImage.Type + "\t" + currentImage.Size + "\t" + currentImage.LastModification);
                        }
                        else
                        {
                            //Display an error message
                            MessageBox.Show("This Image type is not supported");
                        }
                    }
                    //  Check if the first tokenized string contains "Document"
                    else if (tokens[0] == "Document")
                    {
                        if (tokens[2] == "PDF" || tokens[2] == "DOCX" || tokens[2] == "TXT")
                        {
                            currentDocument = new DocumentFile();

                            //  Tokenized variables are numbered and parsed
                            currentDocument.Name = tokens[1];
                            currentDocument.Type = tokens[2];
                            currentDocument.Size = tokens[3];
                            currentDocument.LastModification = int.Parse(tokens[4]);
                            currentDocument.NumPages = int.Parse(tokens[5]);
                            currentDocument.NumWords = int.Parse(tokens[6]);
                            currentDocument.DocSubject = tokens[7];

                            //Add one to the count of the amount of audio files
                            numDocument += 1;
                            //  Add field to created list
                            fileList.Add(currentDocument);
                            filesListBox.Items.Add(currentDocument.Name + "\t" + currentDocument.Type + "\t" + currentDocument.Size + "\t" + currentDocument.LastModification);
                        }
                        else
                        {
                            //Display an error message
                            MessageBox.Show("This Document type is not supported");
                        }
                    }
                }
                //  Close file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //  Call method ReadFile when the form loads
            ReadFile();

            //  Field numFiles is equivalent to its many attributes
            numFiles = (numAudio + numImage + numDocument + numVideo);
            //  Declare TextBox location for the field numFiles
            numberFilesTextBox.Text = numFiles.ToString();

            //  Add ListBox items for the following string and its field
            numberFilesTypeListBox.Items.Add("Audio: " + numAudio);
            numberFilesTypeListBox.Items.Add("Image: " + numImage);
            numberFilesTypeListBox.Items.Add("Document: " + numDocument);
            numberFilesTypeListBox.Items.Add("Video: " + numVideo);
        }

        private void ReorganizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  if the ComboBox text selected is "File Name" then organize in alphabetical order
            if (reorganizeComboBox.Text == "File Name")
            {
                var qry = from currentFile in fileList
                          orderby currentFile.Name
                          select currentFile;
                filesListBox.Items.Clear();
                Array.ForEach<GenericFile>(qry.ToArray<GenericFile>(), currentFile => filesListBox.Items.Add(currentFile.Name + ", " + currentFile.Type + ", " + currentFile.Size + ", " + currentFile.LastModification));
            }
            else if (reorganizeComboBox.Text == "File Type")
            {
                var qry = from currentFile in fileList
                          orderby currentFile.Type
                          select currentFile;
                filesListBox.Items.Clear();
                Array.ForEach<GenericFile>(qry.ToArray<GenericFile>(), currentFile => filesListBox.Items.Add(currentFile.Name + ", " + currentFile.Type + ", " + currentFile.Size + ", " + currentFile.LastModification));
            }
            else if (reorganizeComboBox.Text == "File Size")
            {
                var qry = from currentFile in fileList
                          orderby currentFile.Size
                          select currentFile;
                filesListBox.Items.Clear();
                Array.ForEach<GenericFile>(qry.ToArray<GenericFile>(), currentFile => filesListBox.Items.Add(currentFile.Name + ", " + currentFile.Type + ", " + currentFile.Size + ", " + currentFile.LastModification));
            }
            else if (reorganizeComboBox.Text == "Last Modification Date")
            {
                var qry = from currentFile in fileList
                          orderby currentFile.LastModification
                          select currentFile;
                filesListBox.Items.Clear();
                Array.ForEach<GenericFile>(qry.ToArray<GenericFile>(), currentFile => filesListBox.Items.Add(currentFile.Name + ", " + currentFile.Type + ", " + currentFile.Size + ", " + currentFile.LastModification));
            }
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filesListBox.SelectedIndex != -1)
            {
                int selected = filesListBox.SelectedIndex;
                AudioFile anAudioFile;
                VideoFile aVideoFile;
                ImageFile anImageFile;
                DocumentFile aDocumentFile;

                if (fileList[selected] is AudioFile)
                {
                    anAudioFile = (AudioFile)fileList[selected];
                    MessageBox.Show("Title: " + anAudioFile.Title + ", Length: " + anAudioFile.Length + "minutes" + ", Rating: " + anAudioFile.Rating + "Artist: " + anAudioFile.Artist + ", BitRate: " + anAudioFile.BitRate);
                }
                else if (fileList[selected] is VideoFile)
                {
                    aVideoFile = (VideoFile)fileList[selected];
                    MessageBox.Show("Title: " + aVideoFile.Title + ", Length: " + aVideoFile.Length + " minutes" + ", Rating: " + aVideoFile.Rating + ", Director: " + aVideoFile.Director + ", Producer: " + aVideoFile.Producer);
                }
                else if (fileList[selected] is ImageFile)
                {
                    anImageFile = (ImageFile)fileList[selected];
                    MessageBox.Show("Width: " + anImageFile.Width + ", Height: " + anImageFile.Height + ", Resolution: " + anImageFile.Resolution);
                }
                else if (fileList[selected] is DocumentFile)
                {
                    aDocumentFile = (DocumentFile)fileList[selected];
                    MessageBox.Show("Number of pages: " + aDocumentFile.NumPages + ", Number of words: " + aDocumentFile.NumWords + ", Document's subject: " + aDocumentFile.DocSubject);
                }
            }
        }
        private bool checkIfIntervalOK(int value, int lowerLimit, int upperLimit)
        {
            if (value <= upperLimit && value >= lowerLimit)
            {
                return true;
            }
            else
            {
                MessageBox.Show("The rating should be between 1 and 5");
                return false;
            }
        }
    }
}
