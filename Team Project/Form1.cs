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
    public partial class Form1 : Form
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

        public Form1()
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

                //Open the PhoneList file
                inputFile = File.OpenText("Files.txt");

                //Read the lines from the file
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    if (tokens[0] == "Audio")
                    {
                        currentAudio = new Audio();

                        currentAudio.Name = tokens[1];
                        currentAudio.Type = tokens[2];
                        currentAudio.Size = decimal.Parse(tokens[3]);
                        currentAudio.LastModification = int.Parse(tokens[4]);
                        currentAudio.Artist = tokens[5];
                        currentAudio.BitRate = int.Parse(tokens[6]);

                        numAudio += 1;
                        audioList.Add(currentAudio);
                        filesListBox.Items.Add(currentAudio.Name + ", " + currentAudio.Type + ", " + currentAudio.Size + ", " + currentAudio.LastModification);
                    }
                    else if (tokens[0] == "Image")
                    {
                        currentImage = new Image();

                        currentImage.Name = tokens[1];
                        currentImage.Type = tokens[2];
                        currentImage.Size = decimal.Parse(tokens[3]);
                        currentImage.LastModification = int.Parse(tokens[4]);
                        currentImage.Width = decimal.Parse(tokens[5]);
                        currentImage.Height = decimal.Parse(tokens[6]);
                        currentImage.Resolution = double.Parse(tokens[7]);

                        numImage += 1;
                        imageList.Add(currentImage);
                        filesListBox.Items.Add(currentImage.Name + ", " + currentImage.Type + ", " + currentImage.Size + ", " + currentImage.LastModification);
                    }
                    else if (tokens[0] == "Media")
                    {
                        currentMedia = new Media();

                        currentMedia.Name = tokens[1];
                        currentMedia.Type = tokens[2];
                        currentMedia.Size = decimal.Parse(tokens[3]);
                        currentMedia.LastModification = int.Parse(tokens[4]);
                        currentMedia.Title = tokens[5];
                        currentMedia.Length = double.Parse(tokens[6]);
                        currentMedia.Rating = tokens[7];

                        numMedia += 1;
                        mediaList.Add(currentMedia);
                        filesListBox.Items.Add(currentMedia.Name + ", " + currentMedia.Type + ", " + currentMedia.Size + ", " + currentMedia.LastModification);
                    }
                    else if (tokens[0] == "Document")
                    {
                        currentDocument = new Document();

                        currentDocument.Name = tokens[1];
                        currentDocument.Type = tokens[2];
                        currentDocument.Size = decimal.Parse(tokens[3]);
                        currentDocument.LastModification = int.Parse(tokens[4]);
                        currentDocument.NumPages = int.Parse(tokens[5]);
                        currentDocument.NumWords = int.Parse(tokens[6]);
                        currentDocument.DocSubject = tokens[7];

                        numDocument += 1;
                        documentList.Add(currentDocument);
                        filesListBox.Items.Add(currentDocument.Name + ", " + currentDocument.Type + ", " + currentDocument.Size + ", " + currentDocument.LastModification);
                    }
                    else if (tokens[0] == "Video")
                    {
                        currentVideo = new Video();

                        currentVideo.Name = tokens[1];
                        currentVideo.Type = tokens[2];
                        currentVideo.Size = decimal.Parse(tokens[3]);
                        currentVideo.LastModification = int.Parse(tokens[4]);
                        currentVideo.Director = tokens[5];
                        currentVideo.Producer = tokens[6];

                        numVideo += 1;
                        videoList.Add(currentVideo);
                        filesListBox.Items.Add(currentVideo.Name + ", " + currentVideo.Type + ", " + currentVideo.Size + ", " + currentVideo.LastModification);
                    }
                }

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
            ReadFile();

            numFiles = (numAudio + numImage + numMedia + numDocument + numVideo);
            numberFilesTextBox.Text = numFiles.ToString();

            numberFilesTypeListBox.Items.Add(numAudio + "\t" + numImage + "\t" + numMedia + "\t" + numDocument + "\t" + numVideo);
        }
    }
}
