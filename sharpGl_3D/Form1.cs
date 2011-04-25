using SharpGL;
using SharpGL.SceneGraph.Assets;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpGl_3D
{
    public partial class form3D : Form
    {
        //struct of ask
        public struct Point3D
        {
            public int _X;
            public int _Y;
            public int _Z;
            
        }
        public class Camera
        {
            public double eyex, eyey, eyez;

            public Camera()
            {
                eyex = 10;eyey = 9;eyez = 10;
            }
            public void lookNear(int dis)
            {
                //Nhan phim  Z
                if (eyex!=0 && eyey != 0 && eyez != 0)
                {
                    eyex -= dis;
                    eyey -= dis;
                    eyez -= dis;
                }
            }
            public void lookFar(int dis)
            {
                //nhan X
                eyex += dis;
                eyey += dis;
                eyez += dis;
            }
            public void turnLeft(int dis)
            {
                eyey -= dis;
            }
            public void turnRight(int dis)
            {
                eyey += dis;
            }
            public void turnDown(int dis)
            {
                eyex -= dis;
                eyey -= dis;
                eyez += dis;
            }
            public void turnUp(int dis)
            {
                eyex -= dis;
                eyey += dis;
                eyez -= dis;
            }
        }

        //There are object: abstract object, cube, pyramid, prism
        public abstract class image3DObject
        {
            public Point3D center;
            public int R;
            public Color color;

            public image3DObject()
            {
                center._X = center._Y = center._Z =  0;
                R = 2;
                color = Color.Red;
            }
            public void set(Point3D pt, int bankinh)
            {
                center = pt;
                R = bankinh;
            }
            public virtual void setInformation(Point3D pt, Point3D ptRotate)
            {
                center = pt;
            }
            public void setcolor(Color border)
            {
                color = border;
            }
            public virtual void viewFrame(OpenGL gl) { }
            public virtual void draw3DObject(OpenGL gl) { }
            public virtual void changePicture(string _fileName) { }
        } 
        public class cube: image3DObject
        {
            public Point3D A, B, C, D;
            public Point3D _A, _B, _C, _D;
            public cube(): base()
            {
                color = Color.Pink;
            }
            public void setPoint()
            {
                A._X = center._X + R; A._Y = center._Y + R; A._Z = center._Z + 2 * R;
                B._X = center._X + R; B._Y = center._Y - R; B._Z = center._Z + 2 * R;
                C._X = center._X - R; C._Y = center._Y - R; C._Z = center._Z + 2 * R;
                D._X = center._X - R; D._Y = center._Y + R; D._Z = center._Z + 2 * R;

                _A._X = center._X + R; _A._Y = center._Y + R; _A._Z = center._Z;
                _B._X = center._X + R; _B._Y = center._Y - R; _B._Z = center._Z;
                _C._X = center._X - R; _C._Y = center._Y - R; _C._Z = center._Z;
                _D._X = center._X - R; _D._Y = center._Y + R; _D._Z = center._Z;
            }
            public override void setInformation(Point3D pt, Point3D ptRotate)
            {
                base.setInformation(pt, ptRotate);
                A._X += center._X;
                A._Y += center._Y;
                A._Z += center._Z;
                B._X += center._X;
                B._Y += center._Y;
                B._Z += center._Z;
                C._X += center._X;
                C._Y += center._Y;
                C._Z += center._Z;
                D._X += center._X;
                D._Y += center._Y;
                D._Z += center._Z;

                _A._X += center._X;
                _A._Y += center._Y;
                _A._Z += center._Z;
                _B._X += center._X;
                _B._Y += center._Y;
                _B._Z += center._Z;
                _C._X += center._X;
                _C._Y += center._Y;
                _C._Z += center._Z;
                _D._X += center._X;
                _D._Y += center._Y;
                _D._Z += center._Z;

                _A._X *= ptRotate._X;_A._Y *= ptRotate._X;_A._Z *= ptRotate._Z;
            }
            public override void draw3DObject(OpenGL gl)
            {
                setPoint();
                //top
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 255.0, color.G / 255.0, color.B / 255.0, 1.0);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.End();

                //bottom
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 265.0, color.G / 265.0, color.B / 265.0, 1.0);
                gl.Vertex(_A._X, _A._Y, _A._Z);
                gl.Vertex(_B._X, _B._Y, _B._Z);
                gl.Vertex(_C._X, _C._Y, _C._Z);
                gl.Vertex(_D._X, _D._Y, _D._Z);
                gl.End();

                //front
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 275.0, color.G / 275.0, color.B / 275.0, 1.0);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(_B._X, _B._Y, _B._Z);
                gl.Vertex(_A._X, _A._Y, _A._Z);
                gl.End();

                //back
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 285.0, color.G / 285.0, color.B / 285.0, 1.0);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(_C._X, _C._Y, _C._Z);
                gl.Vertex(_D._X, _D._Y, _D._Z);
                gl.End();

                //left
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 295.0, color.G / 295.0, color.B / 295.0, 1.0);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X,B._Y, B._Z);
                gl.Vertex(_C._X, _C._Y, _C._Z);
                gl.Vertex(_B._X, _B._Y, _B._Z);
                gl.End();

                //right
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 305.0, color.G / 305.0, color.B / 305.0, 1.0);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(_D._X, _D._Y, _D._Z);
                gl.Vertex(_A._X, _A._Y, _A._Z);
                gl.End();
            }
            public override void viewFrame(OpenGL gl)
            {
                gl.Color(frame.R / 255.0, frame.G / 255.0, frame.B / 255.0, 1.0);
                gl.LineWidth(5.0f);

                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.End();

                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(_A._X, _A._Y, _A._Z);
                gl.Vertex(_B._X, _B._Y, _B._Z);
                gl.Vertex(_C._X, _C._Y, _C._Z);
                gl.Vertex(_D._X, _D._Y, _D._Z);
                gl.End();

                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(_B._X, _B._Y, _B._Z);
                gl.Vertex(_A._X, _A._Y, _A._Z);
                gl.End();

                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(_C._X, _C._Y, _C._Z);
                gl.Vertex(_D._X, _D._Y, _D._Z);
                gl.End();

                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, B._Y, B._Z);
                gl.Vertex(_C._X, _C._Y, _C._Z);
                gl.Vertex(_B._X, _B._Y, _B._Z);
                gl.End();

                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(_D._X, _D._Y, _D._Z);
                gl.Vertex(_A._X, _A._Y, _A._Z);
                gl.End();
            }
        }
        public class Pyramid: image3DObject
        {
            public Point3D O, A, B, C, D;
            public Pyramid() : base()
            {
                color = Color.Green;
            }
            public void setPoint()
            {
                A._X = center._X + R; A._Y = center._Y + R; A._Z = center._Z;
                B._X = center._X + R; B._Y = center._Y - R; B._Z = center._Z;
                C._X = center._X - R; C._Y = center._Y - R; C._Z = center._Z;
                D._X = center._X - R; D._Y = center._Y + R; D._Z = center._Z;

                O._X = center._X; O._Y = center._Y; O._Z = center._Z + 2 * R;
            }
            public override void draw3DObject(OpenGL gl)
            {
                setPoint();
                //bottom
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 255.0, color.G / 255.0, color.B / 255.0, 1.0);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.End();

                //front
                gl.Begin(OpenGL.GL_POLYGON);
                gl.Color(color.R / 265.0, color.G / 265.0, color.B / 265.0, 1.0);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();

                //back
                gl.Begin(OpenGL.GL_POLYGON);
                gl.Color(color.R / 275.0, color.G / 275.0, color.B / 275.0, 1.0);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();

                //left
                gl.Begin(OpenGL.GL_POLYGON);
                gl.Color(color.R / 285.0, color.G / 285.0, color.B / 285.0, 1.0);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();

                //right
                gl.Begin(OpenGL.GL_POLYGON);
                gl.Color(color.R / 295.0, color.G / 295.0, color.B / 295.0, 1.0);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();
            }
            public override void viewFrame(OpenGL gl)
            {
                gl.Color(frame.R / 255.0, frame.G / 255.0, frame.B / 255.0, 1.0);
                gl.LineWidth(5.0f);
                //bottom
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.End();

                //front
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();

                //back
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();

                //left
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(B._X, B._Y, B._Z);
                gl.Vertex(C._X, C._Y, C._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();

                //right
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(D._X, D._Y, D._Z);
                gl.Vertex(A._X, A._Y, A._Z);
                gl.Vertex(O._X, O._Y, O._Z);
                gl.End();
            }
            //public override void setInformation(Point3D pt, Point3D ptRotate)
            //{
            //    base.setInformation(pt, ptRotate);
            //    A._X += center._X;
            //    A._Y += center._Y;
            //    A._Z += center._Z;
            //    B._X += center._X;
            //    B._Y += center._Y;
            //    B._Z += center._Z;
            //    C._X += center._X;
            //    C._Y += center._Y;
            //    C._Z += center._Z;
            //    D._X += center._X;
            //    D._Y += center._Y;
            //    D._Z += center._Z;
            //    O._X += center._X;
            //    O._Y += center._Y;
            //    O._Z += center._Z;

            //    float tmp = (float)Math.Sin(pt._X * 10);
            //    A._X = (int)(tmp * A._X);
            //    B._X = (int)(tmp * B._X);
            //    C._X = (int)(tmp * C._X);
            //    D._X = (int)(tmp * D._X);
            //    O._X = (int)(tmp * O._X);
            //}
        }
        public class Prism: image3DObject
        {
            public Prism() : base()
            {
                center._X = center._Y = center._Z = 0;
                color = Color.Brown;
            }
            public override void draw3DObject(OpenGL gl)
            {
                //top
                gl.Begin(OpenGL.GL_POLYGON);
                gl.Color(color.R / 255.0, color.G / 255.0, color.B / 255.0, 1.0);
                gl.Vertex(center._X + R, center._Y, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z + 2 * R);
                gl.End();

                //bottom
                gl.Begin(OpenGL.GL_POLYGON);
                gl.Color(color.R / 265.0, color.G / 265.0, color.B / 265.0, 1.0);
                gl.Vertex(center._X + R, center._Y, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z);
                gl.End();

                //left
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 275.0, color.G / 275.0, color.B / 275.0, 1.0);
                gl.Vertex(center._X + R, center._Y, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X + R, center._Y, center._Z + 2*R);
                gl.End();

                //back
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 285.0, color.G / 285.0, color.B / 285.0, 1.0);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z);
                gl.End();

                //right
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(color.R / 295.0, color.G / 295.0, color.B / 295.0, 1.0);
                gl.Vertex(center._X + R, center._Y, center._Z);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X + R, center._Y, center._Z + 2 * R);
                gl.End();
            }
            public override void viewFrame(OpenGL gl)
            {
                gl.Color(frame.R / 255.0, frame.G / 255.0, frame.B / 255.0, 1.0);
                gl.LineWidth(5.0f);

                //top
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(center._X + R, center._Y, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z + 2 * R);
                gl.End();

                //bottom
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(center._X + R, center._Y, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z);
                gl.End();

                //left
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(center._X + R, center._Y, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X + R, center._Y, center._Z + 2 * R);
                gl.End();

                //back
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y - 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z);
                gl.End();

                //right
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(center._X + R, center._Y, center._Z);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z);
                gl.Vertex(center._X - R / 2, center._Y + 0.866 * R, center._Z + 2 * R);
                gl.Vertex(center._X + R, center._Y, center._Z + 2 * R);
                gl.End();
            }
        }
        public class cubeWithTex:image3DObject
        {
            Texture texture;
            public string fileName;

            public cubeWithTex(OpenGL gl) : base()
            {
                fileName = "Crate.bmp";
                texture = new Texture();
                texture.Create(gl, fileName);
            }
            public override void draw3DObject(OpenGL gl)
            {
                gl.Enable(OpenGL.GL_TEXTURE_2D);
                texture.Bind(gl);

                //top
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(1.0, 1.0, 1.0, 0.0);
                gl.TexCoord(0, 0); gl.Vertex(center._X + R, center._Y + R, center._Z + 2 * R);
                gl.TexCoord(1, 0); gl.Vertex(center._X + R, center._Y - R, center._Z + 2 * R);
                gl.TexCoord(1, 1); gl.Vertex(center._X - R, center._Y - R, center._Z + 2 * R);
                gl.TexCoord(0, 1); gl.Vertex(center._X - R, center._Y + R, center._Z + 2 * R);
                //gl.End();

                //bottom
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(1.0, 1.0, 1.0, 0.0);
                gl.TexCoord(1, 0); gl.Vertex(center._X + R, center._Y + R, center._Z);
                gl.TexCoord(1, 1); gl.Vertex(center._X + R, center._Y - R, center._Z);
                gl.TexCoord(0, 1); gl.Vertex(center._X - R, center._Y - R, center._Z);
                gl.TexCoord(0, 0); gl.Vertex(center._X - R, center._Y + R, center._Z);
                gl.End();

                //front
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(1.0, 1.0, 1.0, 0.0);
                gl.TexCoord(0, 1); gl.Vertex(center._X + R, center._Y - R, center._Z + 2 * R);
                gl.TexCoord(0, 0); gl.Vertex(center._X + R, center._Y + R, center._Z + 2 * R);
                gl.TexCoord(1, 0); gl.Vertex(center._X + R, center._Y + R, center._Z);
                gl.TexCoord(1, 1); gl.Vertex(center._X + R, center._Y - R, center._Z);
                gl.End();

                //back
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(1.0, 1.0, 1.0, 0.0);
                gl.TexCoord(1, 1); gl.Vertex(center._X - R, center._Y - R, center._Z + 2 * R);
                gl.TexCoord(0, 1); gl.Vertex(center._X - R, center._Y + R, center._Z + 2 * R);
                gl.TexCoord(0, 0); gl.Vertex(center._X - R, center._Y + R, center._Z);
                gl.TexCoord(1, 0); gl.Vertex(center._X - R, center._Y - R, center._Z);
                gl.End();

                //left
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(1.0, 1.0, 1.0, 0.0);
                gl.TexCoord(1, 0); gl.Vertex(center._X - R, center._Y - R, center._Z + 2 * R);
                gl.TexCoord(1, 1); gl.Vertex(center._X + R, center._Y - R, center._Z + 2 * R);
                gl.TexCoord(0, 1); gl.Vertex(center._X + R, center._Y - R, center._Z);
                gl.TexCoord(0, 0); gl.Vertex(center._X - R, center._Y - R, center._Z);
                gl.End();

                //right
                gl.Begin(OpenGL.GL_QUADS);
                gl.Color(1.0, 1.0, 1.0, 0.0);
                gl.TexCoord(0, 0); gl.Vertex(center._X - R, center._Y + R, center._Z + 2 * R);
                gl.TexCoord(1, 0); gl.Vertex(center._X + R, center._Y + R, center._Z + 2 * R);
                gl.TexCoord(1, 1); gl.Vertex(center._X + R, center._Y + R, center._Z);
                gl.TexCoord(0, 1); gl.Vertex(center._X - R, center._Y + R, center._Z);
                gl.End();

                //texture.Destroy(gl);
                texture.Create(gl, fileName);
                gl.Disable(OpenGL.GL_TEXTURE_2D);
                //gl.Flush();
            }
            public override void changePicture(string _fileName)
            {
                fileName = _fileName;
            }
        }

        //variable static to control program
        private static Color frame = Color.Orange;
        private Camera camera = new Camera();
        private Point3D ptControl, ptControlTranform, ptControlRotate;
        private int BanKinh = 2;
        Stopwatch st = new Stopwatch();

        private int shShape;
        private int numOfObject = 0, idview = -1;

        //Array of image object
        image3DObject[] object3D = new image3DObject[100];

        //program init
        public form3D()
        {
            InitializeComponent();
            shShape = 1;
        }

        //SharpGL init
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.ClearColor(0, 0, 0, 0);
        }
        //SharpGl resized
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            //set ma tran viewport
            gl.Viewport(
                0, 0,
                openGLControl.Width,
                openGLControl.Height);

            //set ma tran phep chieu
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(-10000.0,
            openGLControl.Width / openGLControl.Height,
                1.0, 10000.0);

            //set ma tran model view
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LookAt(
                camera.eyex, camera.eyey, camera.eyez,
                0, 0, 0,
                0, 0, 1);
        }
        //Sharogl draw
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            if (cb_rotateObject.Checked == false)
            {
                // Set the projection matrix.
                gl.MatrixMode(OpenGL.GL_MODELVIEW);
                // Load the identity.
                gl.LoadIdentity();
                // Create a perspective transformation.
                gl.LookAt(camera.eyex, camera.eyey, camera.eyez, 0, 0, 0, 0, 0, 1);
            }

            // Draw a image
            switch (shShape)
            {
                case 1: object3D[numOfObject] = new cube(); break;
                case 2: object3D[numOfObject] = new Pyramid(); break;
                case 3: object3D[numOfObject] = new Prism(); break;
                case 4: object3D[numOfObject] = new cubeWithTex(gl);break;
                default: break;
            }

            //  cai dat thong tin truoc khi ve doi tuong
            object3D[numOfObject].set(ptControl, BanKinh);

            //draw space and rotate
            if (cb_space.Checked == true)
                drawSpace(gl, Convert.ToInt16(tb_BanKinh.Text));

            if (cb_rotateObject.Checked == true)
            {
                //drawTextureCube(gl);
                int x = 0, y = 0, z = 0;
                if (tb_rotateX.Text != "")
                {
                    x = Convert.ToInt32(tb_rotateX.Text);
                }

                if (tb_rotateY.Text != "")
                {
                    y = Convert.ToInt32(tb_rotateY.Text);
                }

                if (tb_rotateZ.Text != "")
                {
                    z = Convert.ToInt32(tb_rotateZ.Text);
                }
                gl.Rotate(x, y, z);
            }

            //draw and caculate times
            st.Reset();
            st.Start();
            if (numOfObject > 0)
                for (int i = 1; i <= numOfObject; i++)
                {
                    object3D[i].draw3DObject(gl);
                }
            st.Stop();
            lb_Time.Text = "Time to draw image is: " + st.Elapsed.ToString();

            //view frame
            if (idview > 0)
                object3D[idview].viewFrame(gl);

            gl.Flush();
        }

        //function to draw space of program
        private void drawSpace(OpenGL gl, int bk)
        {
            gl.LineWidth(1.0f);
            for (int i = 1; i <= 10 + bk; i++)
            {
                gl.Begin(OpenGL.GL_LINES);
                gl.Color(1.0, 1.0, 1.0, 1.0);
                gl.Vertex(10 + bk, i, 0);
                gl.Vertex(-10 - bk, i, 0);
                gl.End();

                gl.Begin(OpenGL.GL_LINES);
                gl.Color(1.0, 1.0, 1.0, 1.0);
                gl.Vertex(10 + bk, -i, 0);
                gl.Vertex(-10 - bk, -i, 0);
                gl.End();
            }

            for (int i = 1; i <= 10 + bk; i++)
            {
                gl.Begin(OpenGL.GL_LINES);
                gl.Color(1.0, 1.0, 1.0, 0.1);
                gl.Vertex(i, 10 + bk, 0);
                gl.Vertex(i, -10 - bk, 0);
                gl.End();

                gl.Begin(OpenGL.GL_LINES);
                gl.Color(1.0, 1.0, 1.0, 0.1);
                gl.Vertex(-i, 10 + bk, 0);
                gl.Vertex(-i, -10 - bk, 0);
                gl.End();
            }

            //ve 3 truc chinh
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(1.0, 0.0, 0.0, 1.0);
            gl.Vertex(0, 0, 10 + bk);
            gl.Vertex(0, 0, -10 - bk);
            gl.End();

            gl.Begin(OpenGL.GL_LINES);
            gl.Color(0.0, 1.0, 0.0, 1.0);
            gl.Vertex(0, 10 + bk, 0);
            gl.Vertex(0, -10 - bk, 0);
            gl.End();

            gl.Begin(OpenGL.GL_LINES);
            gl.Color(0.0, 0.0, 1.0, 1.0);
            gl.Vertex(10 + bk, 0, 0);
            gl.Vertex(-10 - bk, 0, 0);
            gl.End();
        }

        //list of button on dislay
        private void bt_Cube_Click(object sender, EventArgs e)
        {
            numOfObject += 1;
            lb_NameObject.Items.Add("Cube " + numOfObject);
            ptControl._X = Convert.ToInt16(tb_PositionX.Text);
            ptControl._Y = Convert.ToInt16(tb_PositionY.Text);
            ptControl._Z = Convert.ToInt16(tb_PositionZ.Text);
            BanKinh = Convert.ToInt16(tb_BanKinh.Text);
            shShape = 1;
        }

        private void bt_Pyramid_Click(object sender, EventArgs e)
        {
            numOfObject += 1;
            lb_NameObject.Items.Add("Pyramid " + numOfObject);
            ptControl._X = Convert.ToInt32(tb_PositionX.Text);
            ptControl._Y = Convert.ToInt32(tb_PositionY.Text);
            ptControl._Z = Convert.ToInt32(tb_PositionZ.Text);
            BanKinh = Convert.ToInt16(tb_BanKinh.Text);
            shShape = 2;
        }

        private void bt_Prism_Click(object sender, EventArgs e)
        {
            numOfObject += 1;
            lb_NameObject.Items.Add("Prism " + numOfObject);
            ptControl._X = Convert.ToInt32(tb_PositionX.Text);
            ptControl._Y = Convert.ToInt32(tb_PositionY.Text);
            ptControl._Z = Convert.ToInt32(tb_PositionZ.Text);
            BanKinh = Convert.ToInt16(tb_BanKinh.Text);
            shShape = 3;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            numOfObject = 0;
            idview = -1;
            lb_NameObject.Items.Clear();
        }

        private void bt_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (idview != -1)
                    object3D[idview].setcolor(colorDialog.Color);
            }
        }

        //function control

        private void bt_tranformOk_Click(object sender, EventArgs e)
        {
            if (idview > 0)
            {
                ptControlTranform._X = Convert.ToInt32(tb_tranformPositionX.Text);
                ptControlTranform._Y = Convert.ToInt32(tb_tranformPositionY.Text);
                ptControlTranform._Z = Convert.ToInt32(tb_tranformPositionZ.Text);
                ptControlRotate._X = Convert.ToInt32(tb_tranformRotateX.Text);
                ptControlRotate._Y = Convert.ToInt32(tb_tranformRotateY.Text);
                ptControlRotate._Z = Convert.ToInt32(tb_tranformRotateZ.Text);
                object3D[idview].setInformation(ptControlTranform, ptControlRotate);
            }
        }

        private void openGlControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
                camera.lookNear(1);
            if (e.KeyCode == Keys.X)
                camera.lookFar(1);
            if (e.KeyCode == Keys.A)
                camera.turnLeft(1);
            if (e.KeyCode == Keys.D)
                camera.turnRight(1);
            if (e.KeyCode == Keys.W)
                camera.turnDown(1);
            if (e.KeyCode == Keys.S)
                camera.turnUp(1);
        }

        private void bt_loadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (idview > 0)
                    object3D[idview].changePicture(openFileDialog.FileName);
            }
        }

        private void bt_TexCube_Click(object sender, EventArgs e)
        {
            numOfObject += 1;
            lb_NameObject.Items.Add("CubeTex " + numOfObject);
            ptControl._X = Convert.ToInt32(tb_PositionX.Text);
            ptControl._Y = Convert.ToInt32(tb_PositionY.Text);
            ptControl._Z = Convert.ToInt32(tb_PositionZ.Text);
            shShape = 4;
        }

        private void lb_NameObject_MouseClick(object sender, MouseEventArgs e)
        {
            idview = lb_NameObject.SelectedIndex + 1;
        }
    }
}
