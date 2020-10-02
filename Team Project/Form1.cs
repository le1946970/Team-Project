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

                        currentAudio.Artist = tokens[1];
                        currentAudio.BitRate = int.Parse(tokens[2]);

                        filesListBox.Items.Add(currentAudio.Artist + ", " + currentAudio.BitRate);
                    }
                    else if (tokens[0] == "EndOfAudio")
                    {
                        audioList.Add(currentAudio);
                    }
                    else if (tokens[0] == "Image")
                    {
                        currentImage = new Image();

                        currentImage.Width = decimal.Parse(tokens[1]);
                        currentImage.Height = decimal.Parse(tokens[2]);
                        currentImage.Resolution = double.Parse(tokens[2]);

                        filesListBox.Items.Add(currentImage.Width + ", " + currentImage.Height + ", " + currentImage.Resolution);
                    }
                    else if (tokens[0] == "EndOfImage")
                    {
                        imageList.Add(currentImage);
                    }
                    else if (tokens[0] == "Media")
                    {
                        currentMedia = new Media();

                        currentMedia.Title = tokens[0];
                        currentMedia.Length = double.Parse(tokens[1]);
                        currentMedia.Rating = tokens[2];

                        filesListBox.Items.Add(currentMedia.Title + ", " + currentMedia.Length + ", " + currentMedia.Rating);
                    }
                    else if (tokens[0] == "EndOfMedia")
                    {
                        mediaList.Add(currentMedia);
                    }
                    else if (tokens[0] == "Document")
                    {
                        currentDocument = new Document();

                        currentDocument.NumPages = int.Parse(tokens[1]);
                        currentDocument.NumWords = int.Parse(tokens[2]);
                        currentDocument.DocSubject = tokens[3];

                        filesListBox.Items.Add(currentDocument.NumPages + ", " + currentDocument.NumWords + ", " + currentDocument.DocSubject);
                    }
                    else if (tokens[0] == "EndOfDocument")
                    {
                        documentList.Add(currentDocument);
                    }
                    else if (tokens[0] == "Video")
                    {
                        currentVideo = new Video();

                        currentVideo.Director = tokens[1];
                        currentVideo.Producer = tokens[2];

                        filesListBox.Items.Add(currentDocument.NumPages + ", " + currentDocument.NumWords + ", " + currentDocument.DocSubject);
                    }
                    else if (tokens[0] == "EndOfDocument")
                    {
                        videoList.Add(currentVideo);
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

        }
    }
}
