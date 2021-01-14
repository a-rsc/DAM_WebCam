using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
    Aquest projecte necessita la llibreria EmguCV que és una llibreria per a treballar amb OpenCV dins de l'entorn C# de Visual Studio
    // http://www.emgu.com/wiki/index.php/Main_Page

    Hem d'afegir les referències necessàries a les DLL d'EmguCV que contenen les eines que necessitem

    Al quadre d'eines de Visual Studio hem de fer botó dret i seleccionar <Escollir elements>. Després anem, amb el botó <Examinar> a la carpeta on tenim les llibreries d'EmguCV (carpeta bin) i seleccionem Emgu.CV.UI.dll. 
    En els components del quadre d'eines ens n'apareixeran de nous, farem servir ImageBox

    IMAGEBOX - eina d'Emgu Corporation
*/

// Llibreries d'EmguCV: ..\bin\DEBUG
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
// Llibreria per llegir QR code
using ZXing;
// Encode: create QR code image
// Decode: read an image containing one or more QR codes.

namespace DAM_WebCam
{
    public partial class FrmMain : Form
    {
        // Càmera
        private Capture kam; // Capture és una captura d'imatges o videos des de qualsevol fitxer de càmera o video: class Emgu.CV.Capture
        private string textQR = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void TmCam_Tick(object sender, EventArgs e)
        {
            GestioFotograma(sender, e);
        }

        private void GestioFotograma(object sender, EventArgs arg)
        {
            Mat frame; // Mat és un tipus matriu definit en l'estàndard OpenCV que s'associa a les imatges: class Emgu.CV.Mat
            BarcodeReader lector = new BarcodeReader { AutoRotate=true }; // BarcodeReader és un tipus definit a la referencia zxing

            try
            {
                frame = kam.QueryFrame(); // Captura del frame actual segons el timer TmCam
                ImgCam.Image = frame; // ImgCam és una eina (herramienta del formulari) allotjada a la llibreria Emgu.CV.UI.ImageBox

                // Examinador de objetos Emgu.CV.UI.Image
                // ImgCam.Image.Save(string filename); // https://docs.microsoft.com/es-es/dotnet/api/system.drawing.image.save?view=dotnet-plat-ext-5.0#System_Drawing_Image_Save_System_String_

                if(ImgCam.Image != null && lector.Decode(ImgCam.Image.Bitmap) != null)
                {
                    TbTextQR.Text=lector.Decode(ImgCam.Image.Bitmap).Text;

                    if(!TbTextQR.Text.Equals(TextQR))
                    {
                        System.Diagnostics.Process.Start(TbTextQR.Text);
                        TextQR=TbTextQR.Text;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btCam_Click(object sender, EventArgs e)
        {
            try
            {
                kam = new Capture(0); // Inicialitzem la càmara, el 0 és l'índex per si tenim més d'una càmera (Administrador de dispositius)
                BtCam.Visible = false;
                TmCam.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(kam != null)
            {
                kam.Stop();
                kam.Dispose();
            }
        }

        public string TextQR { get => textQR; set => textQR=value; }
    }
}
