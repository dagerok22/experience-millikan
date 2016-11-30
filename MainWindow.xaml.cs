using SharpGL;
using SharpGL.SceneGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFOpengl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGLControl_OpenGLInitialized(object sender, OpenGLEventArgs args)
        {
            var gl = args.OpenGL;
            gl.ClearColor(0.3f, 0.3f, 0.3f, 0.3f);
        }

        private void OpenGLControl_OpenGLDraw(object sender, OpenGLEventArgs args)
        {
            var gl = args.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(0f, 1f, 0f);
            gl.Vertex(-1f, -1f);
            gl.Vertex(0f, 1f);
            gl.Vertex(1f, -1f);
            gl.End();
        }

        private void OpenGLControl_Resized(object sender, OpenGLEventArgs args)
        {
        }
    }

}
