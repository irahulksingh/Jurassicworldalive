using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace iFaceRecognition
{
    public partial class frmiFace : Form
    {
        Image<Bgr, Byte> currentFrame;
        Capture SnapShot;
        HaarCascade face;
        //HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        //private void btnRecognize_Click(object sender, EventArgs e)
        //{
          
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void iFace_Load(object sender, EventArgs e)
        {
            //Thread t = new Thread(new ThreadStart(startForm));
            //t.Start();
            //Thread.Sleep(5000);
            //InitializeComponent();
            //t.Abort();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VideoGrabber_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveFaces_Click_1(object sender, EventArgs e)
        {

            try
            {
                ContTrain = ContTrain + 1;
                gray = SnapShot.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                    labels.Add(txtName.Text);
                    imageBox1.Image = TrainedFace;
                    File.WriteAllText(Application.StartupPath + "/SavedFaces/SavedFaces.txt", trainingImages.ToArray().Length.ToString() + "%");
                    for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                    {
                        trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/SavedFaces/face" + i + ".bmp");
                        File.AppendAllText(Application.StartupPath + "/SavedFaces/SavedFaces.txt", labels.ToArray()[i - 1] + "%");
                    }

                    MessageBox.Show(txtName.Text + "´s face detected and added :)", "Face Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Face Detection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        

        }

        public frmiFace()
        {
            StartCam(); 
            InitializeComponent();
           face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/SavedFaces/SavedFaces.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/SavedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
               MessageBox.Show("No faces found in the database.","No Data Found" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

       void FrameGrabber(object sender, EventArgs e)
        {
            lblFacesFound.Text = "0";
            NamePersons.Add("");


           currentFrame = SnapShot.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

           gray = currentFrame.Convert<Gray, Byte>();

          MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
               currentFrame.Draw(f.rect, new Bgr(Color.DeepSkyBlue), 2);


                if (trainingImages.ToArray().Length != 0 )
                {
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);

                    currentFrame.Draw(name, ref font, new Point(f.rect.X - (-14), f.rect.Y - 3), new Bgr(Color.Yellow));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");

                lblFacesFound.Text = facesDetected[0].Length.ToString();

                           }
            t = 0;

            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            VideoGrabber.Image = currentFrame;
            lblFaceNames.Text = names;
            names = "";
            NamePersons.Clear();


        }
        public void StartCam()
        {
            SnapShot = new Capture();
            SnapShot.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);

        }

    }
     
   
}
