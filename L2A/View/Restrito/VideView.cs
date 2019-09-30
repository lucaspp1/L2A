using L2A.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2A.View.Restrito
{
    public partial class VideView : MetroFramework.Forms.MetroForm
    {
        Video video;
        public VideView()
        {
            video = new Video();
            //video.URL = "http://www.youtube.com/embed/5B0H-5cLkEo";
            video.URL = "https://www.youtube.com/watch?v=5B0H-5cLkEo";
            InitializeComponent();

            var embed = @"<html>

<head>
    <meta http-equiv='X-UA-Compatible' content='IE=Edge' />
</head>

<body width='100%' style='background-color: rgb(255,200,150)'>
    <iframe src='http://www.youtube.com/embed/5B0H-5cLkEo' style='overflow: hidden; height: 400px; width: 100%;' frameborder='0' allow='autoplay; encrypted-media' allowfullscreen></iframe>
</body>

</html>";
            var url = "http://www.youtube.com/embed/5B0H-5cLkEo";
            wbVideo.DocumentText = embed;
            //wbVideo.DocumentText = $"<html> <head></head> <body> <iframe width='100%' height='100%' src={video.URL}> </ifram> </body> </html>";
        }

        private void VideView_Load(object sender, EventArgs e)
        {

        }
    }
}
