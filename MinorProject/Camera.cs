using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace MinorProject
{
    public partial class Camera : Form
    {
     
        
        private Capture capture;
        Image<Bgr,byte> Frames;
        Image<Gray, byte> GrayFrame;
        //Bitmap ExtractedFace;
        Image<Gray, byte> ExtractedFace=null,result;
        HaarCascade face;
        //Bitmap[] ExtractedFaces;
        List<Image<Gray, byte>> ExtractedFaces = new List<Image<Gray, byte>>();
        int faceNo=0;
        int flag = 0;
        //Database Connection String
        String connectionString = ConfigurationManager.ConnectionStrings["MinorProject.Properties.Settings.FaceDatabaseConnectionString"].ConnectionString;
        
        public Camera()
        {
            
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
            nextButton.Enabled = false;
            prevButton.Enabled = false;
            add2DbButton.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                if (button1.Text == "Detect Face")
                { 
                    button1.Text = "Resume Live Video";
                    Application.Idle -= ProcessFrame;
                    ExtractedFaces.Clear();
                    faceNo = 0;
                    face_detect();
                }
                else
                {
                    button1.Text = "Detect Face";
                    Application.Idle += ProcessFrame;
                }
            }
        }


        private void ProcessFrame(object sender, EventArgs arg)
        {
            Frames = capture.QueryFrame().Resize(500, 375, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);//capture a frame from camera
            cameraViewBox.Image = Frames;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cameraViewBox.ClearOperation();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog.FileName);
                Frames = new Image<Bgr, byte>(new Bitmap(InputImg));
                cameraViewBox.Image = Frames;
                ExtractedFaces.Clear();
                faceNo = 0;
                face_detect();
            }
        }
        private void face_detect()
        {
            GrayFrame = Frames.Convert<Gray, byte>();
            
            var facesDetected = GrayFrame.DetectHaarCascade(
            face,
            1.1,
            3,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20))[0];

            if (facesDetected.Length > 0)
            {
                MessageBox.Show("Total Faces Detected: " + facesDetected.Length.ToString());
                int i = 0;
                //ExtractedFaces = new Bitmap[facesDetected.Length];

                //Bitmap BmpInput = GrayFrame.ToBitmap();
                //Graphics FaceCanvas;

                foreach (var f in facesDetected)
                {
                    result = Frames.Copy(f.rect).Convert<Gray,byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);;
                    ExtractedFace = result;
                    ExtractedFaces.Add(ExtractedFace);
                    Frames.Draw(f.rect, new Bgr(Color.Green), 2);

                    /*ExtractedFace = new Bitmap(f.rect.Width, f.rect.Height);
                    FaceCanvas = Graphics.FromImage(ExtractedFace);
                    FaceCanvas.DrawImage(BmpInput, 0, 0, f.rect, GraphicsUnit.Pixel);
                    //ExtractedFace.Save("E:\\Minor Project\\FaceDatabase\\" + textBox2.Text + ".jpg");
                    ExtractedFaces[i] = ExtractedFace;*/

                    i++;

                }
                cameraViewBox.Image = Frames;
                extractedFaceBox.Image = ExtractedFaces.ToArray()[0];

                add2DbButton.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;

                if (facesDetected.Length>1)
                {
                    prevButton.Enabled = true;
                    nextButton.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("Try Again :(");
            }
        }

        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (faceNo < ExtractedFaces.Count - 1)
            {
                faceNo++;
                extractedFaceBox.Image = ExtractedFaces.ToArray()[faceNo];
                add2DbButton.Enabled = true;
            }
            else
                MessageBox.Show("This is the LAST image!");
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (faceNo > 0)
            {
                faceNo--;
                extractedFaceBox.Image = ExtractedFaces.ToArray()[faceNo];
                add2DbButton.Enabled = true;
            }
            else
                MessageBox.Show("This is the FIRST image!");
        }

        private void add2DbButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String SQLQuery1 = "SELECT ImageAddr FROM StudentDetails";
            String SQLQuery2 = "INSERT INTO StudentDetails(Name,ImageAddr) VALUES(@Name,@ImageAddr)";
            using (SqlCommand cmd1 = new SqlCommand(SQLQuery1, connection))
            { 
                using(SqlDataReader Reader1 = cmd1.ExecuteReader())
                {
                    while(Reader1.Read())
                    {
                        if(Reader1["ImageAddr"].ToString()==textBox2.Text)
                        {
                            MessageBox.Show(textBox2.Text + " already exists in Database");
                            flag = 0;
                        }
                        else
                        {
                            flag = 1;
                        }
                    }
                }
            }

            if(flag==1)
            {
                using (SqlCommand cmd2 = new SqlCommand(SQLQuery2, connection))
                {
                    cmd2.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@ImageAddr", textBox2.Text);
                    cmd2.ExecuteNonQuery();
                }
                //ExtractedFaces[faceNo] = new Bitmap(ExtractedFaces[faceNo],new Size(250,250));

                //Imp Comment
                //ExtractedFaces.ToArray()[faceNo] = ExtractedFaces.ToArray()[faceNo].Resize(200,200,Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                
                //ExtractedFaces.ToArray()[faceNo].Save(Application.StartupPath + textBox2.Text + ".jpg");
                
                ExtractedFaces.ToArray()[faceNo].Save("E:\\Minor Project\\FaceDatabase\\" + textBox2.Text + ".bmp");
                connection.Close();
                MessageBox.Show(textBox1.Text + "'s Face added in Database");
                add2DbButton.Enabled = false;
            }
        }
    }
}