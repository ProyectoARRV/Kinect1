using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Kinect;

namespace Kinect1
{
    public partial class frmPrincipal : Form
    {

        public List<Vector> Vectores { get; set; }
        KinectSensor Sensor { get; set; }
        //Aqui crear las propiedades para cualquier llamado en el codigo que use this.Propiedad

        public frmPrincipal()
        {
            Vectores = new List<Vector>();
            InitializeComponent();
        }

        private void KinectStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Console.WriteLine("El Kinect cambio su status");
            if (args.Sensor == null)
            {
                return;
            }

            if (Sensor != null)
            {
                Sensor.SkeletonFrameReady -= KinectSkeletonFrameReady;
            }

            Console.WriteLine(args.Sensor.Status);
            Sensor = args.Sensor;

            if (args.Sensor.Status.ToString() == "Connected")
            {
                Sensor.Start();
                Sensor.SkeletonStream.Enable();
                Sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;// cambiar a default para probar el kinect parado
                Sensor.SkeletonFrameReady += KinectSkeletonFrameReady;

                //Aqui this.speechRecognizer + SpeechRecognizer.Create
                //this.speechRecognies +=  SpeechRecognized 
            }
        }

        //Aqui private void SpeechRecognized
        //en la linea de PlayVideo mandar a llamar Calcular();


        private void KinectSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs args)
        {
            var skeleton = new Skeleton[0];
            
            using (var skeletonFrame = args.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeleton = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeleton);
                }
            }

            if (skeleton.Length == 0)
            {
                return;
            }

            var skel = skeleton.FirstOrDefault(x => x.TrackingState == SkeletonTrackingState.Tracked);
            if(skel == null)
            {
                return;
            }

            var manoDerecha = skel.Joints[JointType.HandRight];
            var manoIzquierda = skel.Joints[JointType.HandLeft];

            var escala = float.Parse(TxtEscala.Text);



            TxtDerechaX.Text = (manoDerecha.Position.X * escala).ToString();
            TxtDerechaY.Text = (manoDerecha.Position.Y * escala).ToString();
           
            TxtIzquierdaX.Text = (manoIzquierda.Position.X * escala).ToString();
            TxtIzquierdaY.Text = (manoIzquierda.Position.Y * escala).ToString();

            pnVectorContenedor.Invalidate();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            KinectSensor.KinectSensors.StatusChanged += KinectStatusChanged;
            


            pnVectorContenedor.BackColor = Color.White;
            TxtIzquierdaX.Text = "0";
            TxtIzquierdaY.Text = "0";
            TxtDerechaX.Text = "0";
            TxtDerechaY.Text = "0";
        }

        private void pnVectorContenedor_Paint(object sender, PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.Blue, 1);

            Graphics graphics = pnVectorContenedor.CreateGraphics();

            //Dibuja las lines azules en el contenedor
            var anchoContenedor = float.Parse(pnVectorContenedor.Width.ToString());
            var altoContendor = float.Parse(pnVectorContenedor.Height.ToString());
            graphics.DrawLine(bluePen, 0, altoContendor / 2, anchoContenedor, altoContendor / 2);
            graphics.DrawLine(bluePen, anchoContenedor / 2, 0, anchoContenedor / 2, altoContendor);

            //Dibuja los vectores guardados en memoria
            foreach (var vector in Vectores)
            {
                DibujaVector(vector, graphics);
            }

            //Dibuja el vector actual
            DibujarVectorActual(graphics);
        }

        private void DibujarVectorActual(Graphics graphics)
        {
            DibujaVector(ObtenerVectorActual(), graphics);
        }

        public Vector ObtenerVectorActual()
        {
            var escala = float.Parse(TxtEscala.Text);
            var punto1 = new CoordenadaDeVector(float.Parse(TxtIzquierdaX.Text)/escala, float.Parse(TxtIzquierdaY.Text)/escala);
            var punto2 = new CoordenadaDeVector(float.Parse(TxtDerechaX.Text)/escala, float.Parse(TxtDerechaY.Text)/escala);
            return new Vector(punto1, punto2);
        }

        private void DibujaVector(Vector vector, Graphics graphics)
        {
            Pen redPen = new Pen(Color.Red, 1);

            var x1 = ObtenerValorEnX(vector.Punto1.X);
            var y1 = ObtenerValorEnY(vector.Punto1.Y);

            var x2 = ObtenerValorEnX(vector.Punto2.X);
            var y2 = ObtenerValorEnY(vector.Punto2.Y);

            graphics.DrawLine(redPen, x1, y1, x2, y2);
        }

        private float ObtenerValorEnX(float valor)
        {
            var anchoContenedor = float.Parse(pnVectorContenedor.Width.ToString());
            var mitadDelAnchoDelContenedor = anchoContenedor / 2;
            //var valorAEscalaDelContenedor = valor * anchoContenedor;

            float valorEscalaContendor = 0;
            if (valor > 0)
            {
                valorEscalaContendor = valor * mitadDelAnchoDelContenedor;
            }
            else
            {
                valorEscalaContendor = valor * mitadDelAnchoDelContenedor;
            }

            return mitadDelAnchoDelContenedor + valorEscalaContendor;
        }

        private float ObtenerValorEnY(float valor)
        {
            var altoContenedor = float.Parse(pnVectorContenedor.Height.ToString());
            var mitadAltoContenedor = altoContenedor / 2;

            float valorEscalaContendor = 0;
            if (valor > 0)
            {
                valorEscalaContendor = valor * mitadAltoContenedor;
                //return mitadAltoContenedor - valorEscalaContendor;
            }
            else
            {
                valorEscalaContendor = valor * mitadAltoContenedor;
            }

            return mitadAltoContenedor - valorEscalaContendor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            Vectores.Add(ObtenerVectorActual());
            if (Sensor != null)
            {
                Sensor.SkeletonFrameReady -= KinectSkeletonFrameReady;
                //this.speechRecognizer.SpeechRecognized -=  SpeechRecognized;
            }


            var izqX = float.Parse(TxtIzquierdaX.Text);//Magnitud = raiz de (x2-x1)al cuadrado + (y2-y1)al cuadrado
            var izqy = float.Parse(TxtIzquierdaY.Text);//Direccion = Contangente (y2-y1)/(x2-x1)
            var derx = float.Parse(TxtDerechaX.Text);
            var dery = float.Parse(TxtDerechaY.Text);
            //Magnitud
            var x = Math.Pow(2, derx - izqX);
            var y = Math.Pow(2, dery - izqy);
            var magnitud = Math.Sqrt(x + y);
            txtMagnitud.Text = magnitud.ToString();
            //Direccion
            var x1 = derx - izqX;
            var y1 = dery - izqy;
            var direccion = Math.Atan(y1 / x1) * 180 / Math.PI;
            txtDireccion.Text = direccion.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vectores = new List<Vector>();
            TxtIzquierdaX.Text = "0";
            TxtIzquierdaY.Text = "0";
            TxtDerechaX.Text = "0";
            TxtDerechaY.Text = "0";
            txtDireccion.Text = "0";
            txtMagnitud.Text = "0";
            if(Sensor != null)
            {
                Sensor.SkeletonFrameReady += KinectSkeletonFrameReady;
                //this.speechRecognizer.SpeechRecognized +=  SpeechRecognized;
            }
        }
    }
}
