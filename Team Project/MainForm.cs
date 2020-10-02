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
        List<Audio> audioList = new List<Audio>();
        List<Image> imageList = new List<Image>();
        List<Media> mediaList = new List<Media>();
        List<Document> documentList = new List<Document>();
        List<Video> videoList = new List<Video>();

        Audio currentAudio = new Audio();
        Image currentImage = new Image();
        Media currentMedia = new Media();
        Document currentDocument = new Document();
        Video currentVideo = new Video();
        int numAudio = 0;
        int numImage = 0;
        int numMedia = 0;
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
                        currentAudio.Size = decimal.Parse(tokens[3]);
                        currentAudio.LastModification = int.Parse(tokens[4]);
                        currentAudio.Artist = tokens[5];
                        currentAudio.BitRate = int.Parse(tokens[6]);

                        numAudio += 1;

                        //  Add field to created list
                        audioList.Add(currentAudio);

                        //  Send the following fields to the targeted ListBox
                        filesListBox.Items.Add(currentAudio.Name + ", " + currentAudio.Type + ", " + currentAudio.Size + ", " + currentAudio.LastModification);
                    }
                    //  Check if the first tokenized string contains "Image"
                    else if (tokens[0] == "Image")
                    {
                        currentImage = new Image();

                        //  Tokenized variables are numbered and parsed
                        currentImage.Name = tokens[1];
                        currentImage.Type = tokens[2];
                        currentImage.Size = decimal.Parse(tokens[3]);
                        currentImage.LastModification = int.Parse(tokens[4]);
                        currentImage.Width = decimal.Parse(tokens[5]);
                        currentImage.Height = decimal.Parse(tokens[6]);
                        currentImage.Resolution = double.Parse(tokens[7]);

                        numImage += 1;

                        //  Add field to created list
                        imageList.Add(currentImage);

                        //  Send the following fields to the targeted ListBox
                        filesListBox.Items.Add(currentImage.Name + ", " + currentImage.Type + ", " + currentImage.Size + ", " + currentImage.LastModification);
                    }

                    //  Check if the first tokenized string contains "Media"
                    else if (tokens[0] == "Media")
                    {
                        currentMedia = new Media();

                        //  Tokenized variables are numbered and parsed
                        currentMedia.Name = tokens[1];
                        currentMedia.Type = tokens[2];
                        currentMedia.Size = decimal.Parse(tokens[3]);
                        currentMedia.LastModification = int.Parse(tokens[4]);
                        currentMedia.Title = tokens[5];
                        currentMedia.Length = double.Parse(tokens[6]);
                        currentMedia.Rating = tokens[7];

                        numMedia += 1;

                        //  Add field to created list
                        mediaList.Add(currentMedia);

                        //  Send the following fields to the targeted ListBox
                        filesListBox.Items.Add(currentMedia.Name + ", " + currentMedia.Type + ", " + currentMedia.Size + ", " + currentMedia.LastModification);
                    }

                    //  Check if the first tokenized string contains "Media"
                    else if (tokens[0] == "Document")
                    {
                        currentDocument = new Document();

                        //  Tokenized variables are numbered and parsed
                        currentDocument.Name = tokens[1];
                        currentDocument.Type = tokens[2];
                        currentDocument.Size = decimal.Parse(tokens[3]);
                        currentDocument.LastModification = int.Parse(tokens[4]);
                        currentDocument.NumPages = int.Parse(tokens[5]);
                        currentDocument.NumWords = int.Parse(tokens[6]);
                        currentDocument.DocSubject = tokens[7];

                        numDocument += 1;

                        //  Add field to created list
                        documentList.Add(currentDocument);

                        //  Send the following fields to the targeted ListBox
                        filesListBox.Items.Add(currentDocument.Name + ", " + currentDocument.Type + ", " + currentDocument.Size + ", " + currentDocument.LastModification);
                    }

                    //  Check if the first tokenized string contains "Video"
                    else if (tokens[0] == "Video")
                    {
                        currentVideo = new Video();

                        //  Tokenized variables are numbered and parsed
                        currentVideo.Name = tokens[1];
                        currentVideo.Type = tokens[2];
                        currentVideo.Size = decimal.Parse(tokens[3]);
                        currentVideo.LastModification = int.Parse(tokens[4]);
                        currentVideo.Director = tokens[5];
                        currentVideo.Producer = tokens[6];

                        numVideo += 1;

                        //  Add field to created list
                        videoList.Add(currentVideo);

                        //  Send the following fields to the targeted ListBox
                        filesListBox.Items.Add(currentVideo.Name + ", " + currentVideo.Type + ", " + currentVideo.Size + ", " + currentVideo.LastModification);
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

            //  Field numFIles is equivalent to its many attributes
            numFiles = (numAudio + numImage + numMedia + numDocument + numVideo);

            //  Declare TextBox location for the field numFiles
            numberFilesTextBox.Text = numFiles.ToString();

            //  Add ListBox items for the following string and its field
            numberFilesTypeListBox.Items.Add("Audio: " + numAudio);
            numberFilesTypeListBox.Items.Add("Image: " + numImage);
            numberFilesTypeListBox.Items.Add("Media: " + numMedia);
            numberFilesTypeListBox.Items.Add("Document: " + numDocument);
            numberFilesTypeListBox.Items.Add("Video: " + numVideo);
        }
    }
}
