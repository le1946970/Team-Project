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
        //  Declare Lists for each of the following: audio, image, document, video
        List<Audio> audioList = new List<Audio>();
        List<Image> imageList = new List<Image>();
        List<Document> documentList = new List<Document>();
        List<Video> videoList = new List<Video>();

        //  Affiliate class with variable
        Audio currentAudio = new Audio();
        Image currentImage = new Image();
        Document currentDocument = new Document();
        Video currentVideo = new Video();

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

                    //  Check if the first tokenized string contains "Audio"
                    if (tokens[0] == "Audio")
                    {
                        currentAudio = new Audio();

                        //  Tokenized variables are numbered and parsed
                        currentAudio.Name = tokens[1];
                        currentAudio.Type = tokens[2];
                        currentAudio.Size = tokens[3];
                        currentAudio.LastModification = int.Parse(tokens[4]);
                        currentAudio.Artist = tokens[5];
                        currentAudio.BitRate = int.Parse(tokens[6]);

                        //Add one to the count of the amount of audio files
                        numAudio += 1;
                        //  Add field to created list
                        audioList.Add(currentAudio);
                        //  Send the following fields to the targeted ListBox
                        filesListBox.Items.Add(currentAudio.Name + ", " + currentAudio.Type + ", " + currentAudio.Size + ", " + currentAudio.LastModification);
                    }
                    //  Check if the first tokenized string contains "Media"
                    else if (tokens[0] == "Media")
                    {
                        //  Check if the first tokenized string contains "Video"
                        if (tokens[1] == "Video")
                        {
                            currentVideo = new Video();

                            //  Tokenized variables are numbered and parsed
                            currentVideo.Name = tokens[2];
                            currentVideo.Type = tokens[3];
                            currentVideo.Size = tokens[4];
                            currentVideo.LastModification = int.Parse(tokens[5]);
                            currentVideo.Director = tokens[6];
                            currentVideo.Producer = tokens[7];

                            //Add one to the count of the amount of audio files
                            numVideo += 1;
                            //  Add field to created list
                            videoList.Add(currentVideo);
                            //  Send the following fields to the targeted ListBox
                            filesListBox.Items.Add(currentVideo.Name + ", " + currentVideo.Type + ", " + currentVideo.Size + ", " + currentVideo.LastModification);
                        }
                        //  Check if the first tokenized string contains "Image"
                        else if (tokens[1] == "Image")
                        {
                            currentImage = new Image();

                            //  Tokenized variables are numbered and parsed
                            currentImage.Name = tokens[2];
                            currentImage.Type = tokens[3];
                            currentImage.Size = tokens[4];
                            currentImage.LastModification = int.Parse(tokens[5]);
                            currentImage.Width = decimal.Parse(tokens[6]);
                            currentImage.Height = decimal.Parse(tokens[7]);
                            currentImage.Resolution = tokens[8];

                            //Add one to the count of the amount of audio files
                            numImage += 1;
                            //  Add field to created list
                            imageList.Add(currentImage);
                            //  Send the following fields to the targeted ListBox
                            filesListBox.Items.Add(currentImage.Name + ", " + currentImage.Type + ", " + currentImage.Size + ", " + currentImage.LastModification);
                        }
                    }
                    //  Check if the first tokenized string contains "Document"
                    else if (tokens[0] == "Document")
                    {
                        currentDocument = new Document();

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
                        documentList.Add(currentDocument);
                        filesListBox.Items.Add(currentDocument.Name + ", " + currentDocument.Type + ", " + currentDocument.Size + ", " + currentDocument.LastModification);
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
    }
}
