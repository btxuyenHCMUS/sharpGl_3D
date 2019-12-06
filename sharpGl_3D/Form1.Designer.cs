namespace sharpGl_3D
{
    partial class form3D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form3D));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.cb_space = new System.Windows.Forms.CheckBox();
            this.lb_NameObject = new System.Windows.Forms.ListBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.bt_Color = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_rotateX = new System.Windows.Forms.Label();
            this.lb_rotateY = new System.Windows.Forms.Label();
            this.lb_rotateZ = new System.Windows.Forms.Label();
            this.cb_rotateObject = new System.Windows.Forms.CheckBox();
            this.tb_rotateZ = new System.Windows.Forms.TextBox();
            this.tb_rotateY = new System.Windows.Forms.TextBox();
            this.tb_rotateX = new System.Windows.Forms.TextBox();
            this.newPosition = new System.Windows.Forms.GroupBox();
            this.lb_PositionX = new System.Windows.Forms.Label();
            this.lb_newPositionY = new System.Windows.Forms.Label();
            this.lb_newPositionZ = new System.Windows.Forms.Label();
            this.tb_PositionZ = new System.Windows.Forms.TextBox();
            this.tb_PositionY = new System.Windows.Forms.TextBox();
            this.tb_PositionX = new System.Windows.Forms.TextBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.lb_ListOfImage = new System.Windows.Forms.Label();
            this.bt_Prism = new System.Windows.Forms.Button();
            this.by_Pyramid = new System.Windows.Forms.Button();
            this.bt_Cube = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_tranformOk = new System.Windows.Forms.Button();
            this.lb_tranformScale = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tranformScaleX = new System.Windows.Forms.TextBox();
            this.tb_tranformScaleY = new System.Windows.Forms.TextBox();
            this.tb_tranformScaleZ = new System.Windows.Forms.TextBox();
            this.lb_tranformRotate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tranformRotateX = new System.Windows.Forms.TextBox();
            this.tb_tranformRotateY = new System.Windows.Forms.TextBox();
            this.tb_tranformRotateZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tranformPosition = new System.Windows.Forms.Label();
            this.tb_tranformPositionX = new System.Windows.Forms.TextBox();
            this.tb_tranformPositionY = new System.Windows.Forms.TextBox();
            this.tb_tranformPositionZ = new System.Windows.Forms.TextBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_TexCube = new System.Windows.Forms.Button();
            this.bt_loadImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_BanKinh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.newPosition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(462, -34);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1474, 1080);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGlControl_KeyDown);
            // 
            // cb_space
            // 
            this.cb_space.AutoSize = true;
            this.cb_space.Location = new System.Drawing.Point(34, 21);
            this.cb_space.Name = "cb_space";
            this.cb_space.Size = new System.Drawing.Size(75, 21);
            this.cb_space.TabIndex = 4;
            this.cb_space.Text = "Space";
            this.cb_space.UseVisualStyleBackColor = true;
            // 
            // lb_NameObject
            // 
            this.lb_NameObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameObject.FormattingEnabled = true;
            this.lb_NameObject.ItemHeight = 25;
            this.lb_NameObject.Location = new System.Drawing.Point(13, 233);
            this.lb_NameObject.Name = "lb_NameObject";
            this.lb_NameObject.Size = new System.Drawing.Size(440, 179);
            this.lb_NameObject.TabIndex = 7;
            this.lb_NameObject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_NameObject_MouseClick);
            // 
            // bt_Color
            // 
            this.bt_Color.Image = ((System.Drawing.Image)(resources.GetObject("bt_Color.Image")));
            this.bt_Color.Location = new System.Drawing.Point(380, 12);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(73, 56);
            this.bt_Color.TabIndex = 8;
            this.bt_Color.UseVisualStyleBackColor = true;
            this.bt_Color.Click += new System.EventHandler(this.bt_Color_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_rotateX);
            this.groupBox1.Controls.Add(this.lb_rotateY);
            this.groupBox1.Controls.Add(this.lb_rotateZ);
            this.groupBox1.Controls.Add(this.cb_rotateObject);
            this.groupBox1.Controls.Add(this.tb_rotateZ);
            this.groupBox1.Controls.Add(this.tb_rotateY);
            this.groupBox1.Controls.Add(this.tb_rotateX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation";
            // 
            // lb_rotateX
            // 
            this.lb_rotateX.AutoSize = true;
            this.lb_rotateX.Location = new System.Drawing.Point(143, 23);
            this.lb_rotateX.Name = "lb_rotateX";
            this.lb_rotateX.Size = new System.Drawing.Size(18, 17);
            this.lb_rotateX.TabIndex = 12;
            this.lb_rotateX.Text = "X";
            // 
            // lb_rotateY
            // 
            this.lb_rotateY.AutoSize = true;
            this.lb_rotateY.Location = new System.Drawing.Point(245, 24);
            this.lb_rotateY.Name = "lb_rotateY";
            this.lb_rotateY.Size = new System.Drawing.Size(18, 17);
            this.lb_rotateY.TabIndex = 12;
            this.lb_rotateY.Text = "Y";
            // 
            // lb_rotateZ
            // 
            this.lb_rotateZ.AutoSize = true;
            this.lb_rotateZ.Location = new System.Drawing.Point(344, 23);
            this.lb_rotateZ.Name = "lb_rotateZ";
            this.lb_rotateZ.Size = new System.Drawing.Size(18, 17);
            this.lb_rotateZ.TabIndex = 6;
            this.lb_rotateZ.Text = "Z";
            // 
            // cb_rotateObject
            // 
            this.cb_rotateObject.AutoSize = true;
            this.cb_rotateObject.Location = new System.Drawing.Point(34, 21);
            this.cb_rotateObject.Name = "cb_rotateObject";
            this.cb_rotateObject.Size = new System.Drawing.Size(73, 21);
            this.cb_rotateObject.TabIndex = 3;
            this.cb_rotateObject.Text = "rotate";
            this.cb_rotateObject.UseVisualStyleBackColor = true;
            // 
            // tb_rotateZ
            // 
            this.tb_rotateZ.Location = new System.Drawing.Point(365, 21);
            this.tb_rotateZ.Name = "tb_rotateZ";
            this.tb_rotateZ.Size = new System.Drawing.Size(60, 22);
            this.tb_rotateZ.TabIndex = 2;
            this.tb_rotateZ.Text = "0";
            // 
            // tb_rotateY
            // 
            this.tb_rotateY.Location = new System.Drawing.Point(265, 21);
            this.tb_rotateY.Name = "tb_rotateY";
            this.tb_rotateY.Size = new System.Drawing.Size(60, 22);
            this.tb_rotateY.TabIndex = 1;
            this.tb_rotateY.Text = "0";
            // 
            // tb_rotateX
            // 
            this.tb_rotateX.Location = new System.Drawing.Point(164, 21);
            this.tb_rotateX.Name = "tb_rotateX";
            this.tb_rotateX.Size = new System.Drawing.Size(60, 22);
            this.tb_rotateX.TabIndex = 0;
            this.tb_rotateX.Text = "0";
            // 
            // newPosition
            // 
            this.newPosition.Controls.Add(this.lb_PositionX);
            this.newPosition.Controls.Add(this.lb_newPositionY);
            this.newPosition.Controls.Add(this.lb_newPositionZ);
            this.newPosition.Controls.Add(this.tb_PositionZ);
            this.newPosition.Controls.Add(this.tb_PositionY);
            this.newPosition.Controls.Add(this.cb_space);
            this.newPosition.Controls.Add(this.tb_PositionX);
            this.newPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPosition.Location = new System.Drawing.Point(13, 76);
            this.newPosition.Name = "newPosition";
            this.newPosition.Size = new System.Drawing.Size(441, 53);
            this.newPosition.TabIndex = 10;
            this.newPosition.TabStop = false;
            this.newPosition.Text = "newPosition";
            // 
            // lb_PositionX
            // 
            this.lb_PositionX.AutoSize = true;
            this.lb_PositionX.Location = new System.Drawing.Point(142, 20);
            this.lb_PositionX.Name = "lb_PositionX";
            this.lb_PositionX.Size = new System.Drawing.Size(18, 17);
            this.lb_PositionX.TabIndex = 5;
            this.lb_PositionX.Text = "X";
            // 
            // lb_newPositionY
            // 
            this.lb_newPositionY.AutoSize = true;
            this.lb_newPositionY.Location = new System.Drawing.Point(243, 22);
            this.lb_newPositionY.Name = "lb_newPositionY";
            this.lb_newPositionY.Size = new System.Drawing.Size(18, 17);
            this.lb_newPositionY.TabIndex = 4;
            this.lb_newPositionY.Text = "Y";
            // 
            // lb_newPositionZ
            // 
            this.lb_newPositionZ.AutoSize = true;
            this.lb_newPositionZ.Location = new System.Drawing.Point(343, 22);
            this.lb_newPositionZ.Name = "lb_newPositionZ";
            this.lb_newPositionZ.Size = new System.Drawing.Size(18, 17);
            this.lb_newPositionZ.TabIndex = 3;
            this.lb_newPositionZ.Text = "Z";
            // 
            // tb_PositionZ
            // 
            this.tb_PositionZ.Location = new System.Drawing.Point(364, 19);
            this.tb_PositionZ.Name = "tb_PositionZ";
            this.tb_PositionZ.Size = new System.Drawing.Size(60, 22);
            this.tb_PositionZ.TabIndex = 2;
            this.tb_PositionZ.Text = "0";
            // 
            // tb_PositionY
            // 
            this.tb_PositionY.Location = new System.Drawing.Point(264, 20);
            this.tb_PositionY.Name = "tb_PositionY";
            this.tb_PositionY.Size = new System.Drawing.Size(60, 22);
            this.tb_PositionY.TabIndex = 1;
            this.tb_PositionY.Text = "0";
            // 
            // tb_PositionX
            // 
            this.tb_PositionX.Location = new System.Drawing.Point(163, 18);
            this.tb_PositionX.Name = "tb_PositionX";
            this.tb_PositionX.Size = new System.Drawing.Size(60, 22);
            this.tb_PositionX.TabIndex = 0;
            this.tb_PositionX.Text = "0";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Image = ((System.Drawing.Image)(resources.GetObject("bt_Clear.Image")));
            this.bt_Clear.Location = new System.Drawing.Point(302, 12);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(73, 56);
            this.bt_Clear.TabIndex = 11;
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // lb_ListOfImage
            // 
            this.lb_ListOfImage.AutoSize = true;
            this.lb_ListOfImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ListOfImage.Location = new System.Drawing.Point(13, 210);
            this.lb_ListOfImage.Name = "lb_ListOfImage";
            this.lb_ListOfImage.Size = new System.Drawing.Size(125, 20);
            this.lb_ListOfImage.TabIndex = 12;
            this.lb_ListOfImage.Text = "List of image:";
            // 
            // bt_Prism
            // 
            this.bt_Prism.Image = ((System.Drawing.Image)(resources.GetObject("bt_Prism.Image")));
            this.bt_Prism.Location = new System.Drawing.Point(171, 12);
            this.bt_Prism.Name = "bt_Prism";
            this.bt_Prism.Size = new System.Drawing.Size(73, 56);
            this.bt_Prism.TabIndex = 3;
            this.bt_Prism.UseVisualStyleBackColor = true;
            this.bt_Prism.Click += new System.EventHandler(this.bt_Prism_Click);
            // 
            // by_Pyramid
            // 
            this.by_Pyramid.Image = ((System.Drawing.Image)(resources.GetObject("by_Pyramid.Image")));
            this.by_Pyramid.Location = new System.Drawing.Point(92, 12);
            this.by_Pyramid.Name = "by_Pyramid";
            this.by_Pyramid.Size = new System.Drawing.Size(73, 56);
            this.by_Pyramid.TabIndex = 2;
            this.by_Pyramid.UseVisualStyleBackColor = true;
            this.by_Pyramid.Click += new System.EventHandler(this.bt_Pyramid_Click);
            // 
            // bt_Cube
            // 
            this.bt_Cube.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cube.Image")));
            this.bt_Cube.Location = new System.Drawing.Point(13, 13);
            this.bt_Cube.Name = "bt_Cube";
            this.bt_Cube.Size = new System.Drawing.Size(73, 56);
            this.bt_Cube.TabIndex = 1;
            this.bt_Cube.UseVisualStyleBackColor = true;
            this.bt_Cube.Click += new System.EventHandler(this.bt_Cube_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_tranformOk);
            this.groupBox2.Controls.Add(this.lb_tranformScale);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_tranformScaleX);
            this.groupBox2.Controls.Add(this.tb_tranformScaleY);
            this.groupBox2.Controls.Add(this.tb_tranformScaleZ);
            this.groupBox2.Controls.Add(this.lb_tranformRotate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_tranformRotateX);
            this.groupBox2.Controls.Add(this.tb_tranformRotateY);
            this.groupBox2.Controls.Add(this.tb_tranformRotateZ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lb_tranformPosition);
            this.groupBox2.Controls.Add(this.tb_tranformPositionX);
            this.groupBox2.Controls.Add(this.tb_tranformPositionY);
            this.groupBox2.Controls.Add(this.tb_tranformPositionZ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 239);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transform";
            // 
            // bt_tranformOk
            // 
            this.bt_tranformOk.Image = ((System.Drawing.Image)(resources.GetObject("bt_tranformOk.Image")));
            this.bt_tranformOk.Location = new System.Drawing.Point(347, 171);
            this.bt_tranformOk.Name = "bt_tranformOk";
            this.bt_tranformOk.Size = new System.Drawing.Size(73, 56);
            this.bt_tranformOk.TabIndex = 29;
            this.bt_tranformOk.UseVisualStyleBackColor = true;
            this.bt_tranformOk.Click += new System.EventHandler(this.bt_tranformOk_Click);
            // 
            // lb_tranformScale
            // 
            this.lb_tranformScale.AutoSize = true;
            this.lb_tranformScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tranformScale.Location = new System.Drawing.Point(34, 116);
            this.lb_tranformScale.Name = "lb_tranformScale";
            this.lb_tranformScale.Size = new System.Drawing.Size(47, 17);
            this.lb_tranformScale.TabIndex = 28;
            this.lb_tranformScale.Text = "Scale:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Z";
            // 
            // tb_tranformScaleX
            // 
            this.tb_tranformScaleX.Location = new System.Drawing.Point(164, 114);
            this.tb_tranformScaleX.Name = "tb_tranformScaleX";
            this.tb_tranformScaleX.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformScaleX.TabIndex = 24;
            this.tb_tranformScaleX.Text = "01";
            // 
            // tb_tranformScaleY
            // 
            this.tb_tranformScaleY.Location = new System.Drawing.Point(264, 114);
            this.tb_tranformScaleY.Name = "tb_tranformScaleY";
            this.tb_tranformScaleY.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformScaleY.TabIndex = 23;
            this.tb_tranformScaleY.Text = "01";
            // 
            // tb_tranformScaleZ
            // 
            this.tb_tranformScaleZ.Location = new System.Drawing.Point(364, 114);
            this.tb_tranformScaleZ.Name = "tb_tranformScaleZ";
            this.tb_tranformScaleZ.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformScaleZ.TabIndex = 22;
            this.tb_tranformScaleZ.Text = "01";
            // 
            // lb_tranformRotate
            // 
            this.lb_tranformRotate.AutoSize = true;
            this.lb_tranformRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tranformRotate.Location = new System.Drawing.Point(34, 75);
            this.lb_tranformRotate.Name = "lb_tranformRotate";
            this.lb_tranformRotate.Size = new System.Drawing.Size(65, 17);
            this.lb_tranformRotate.TabIndex = 21;
            this.lb_tranformRotate.Text = "Rotation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Z";
            // 
            // tb_tranformRotateX
            // 
            this.tb_tranformRotateX.Location = new System.Drawing.Point(163, 72);
            this.tb_tranformRotateX.Name = "tb_tranformRotateX";
            this.tb_tranformRotateX.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformRotateX.TabIndex = 17;
            this.tb_tranformRotateX.Text = "0";
            // 
            // tb_tranformRotateY
            // 
            this.tb_tranformRotateY.Location = new System.Drawing.Point(264, 72);
            this.tb_tranformRotateY.Name = "tb_tranformRotateY";
            this.tb_tranformRotateY.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformRotateY.TabIndex = 16;
            this.tb_tranformRotateY.Text = "0";
            // 
            // tb_tranformRotateZ
            // 
            this.tb_tranformRotateZ.Location = new System.Drawing.Point(364, 72);
            this.tb_tranformRotateZ.Name = "tb_tranformRotateZ";
            this.tb_tranformRotateZ.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformRotateZ.TabIndex = 15;
            this.tb_tranformRotateZ.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // lb_tranformPosition
            // 
            this.lb_tranformPosition.AutoSize = true;
            this.lb_tranformPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tranformPosition.Location = new System.Drawing.Point(34, 35);
            this.lb_tranformPosition.Name = "lb_tranformPosition";
            this.lb_tranformPosition.Size = new System.Drawing.Size(62, 17);
            this.lb_tranformPosition.TabIndex = 9;
            this.lb_tranformPosition.Text = "Position:";
            // 
            // tb_tranformPositionX
            // 
            this.tb_tranformPositionX.Location = new System.Drawing.Point(163, 31);
            this.tb_tranformPositionX.Name = "tb_tranformPositionX";
            this.tb_tranformPositionX.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformPositionX.TabIndex = 8;
            this.tb_tranformPositionX.Text = "0";
            // 
            // tb_tranformPositionY
            // 
            this.tb_tranformPositionY.Location = new System.Drawing.Point(264, 31);
            this.tb_tranformPositionY.Name = "tb_tranformPositionY";
            this.tb_tranformPositionY.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformPositionY.TabIndex = 7;
            this.tb_tranformPositionY.Text = "0";
            // 
            // tb_tranformPositionZ
            // 
            this.tb_tranformPositionZ.Location = new System.Drawing.Point(365, 31);
            this.tb_tranformPositionZ.Name = "tb_tranformPositionZ";
            this.tb_tranformPositionZ.Size = new System.Drawing.Size(60, 22);
            this.tb_tranformPositionZ.TabIndex = 6;
            this.tb_tranformPositionZ.Text = "0";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.Color.Red;
            this.lb_Time.Location = new System.Drawing.Point(472, 9);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(0, 20);
            this.lb_Time.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_TexCube);
            this.groupBox3.Controls.Add(this.bt_loadImage);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 717);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 106);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Texture3D:";
            // 
            // bt_TexCube
            // 
            this.bt_TexCube.Image = ((System.Drawing.Image)(resources.GetObject("bt_TexCube.Image")));
            this.bt_TexCube.Location = new System.Drawing.Point(13, 29);
            this.bt_TexCube.Name = "bt_TexCube";
            this.bt_TexCube.Size = new System.Drawing.Size(73, 56);
            this.bt_TexCube.TabIndex = 31;
            this.bt_TexCube.UseVisualStyleBackColor = true;
            this.bt_TexCube.Click += new System.EventHandler(this.bt_TexCube_Click);
            // 
            // bt_loadImage
            // 
            this.bt_loadImage.Image = ((System.Drawing.Image)(resources.GetObject("bt_loadImage.Image")));
            this.bt_loadImage.Location = new System.Drawing.Point(347, 29);
            this.bt_loadImage.Name = "bt_loadImage";
            this.bt_loadImage.Size = new System.Drawing.Size(73, 56);
            this.bt_loadImage.TabIndex = 30;
            this.bt_loadImage.UseVisualStyleBackColor = true;
            this.bt_loadImage.Click += new System.EventHandler(this.bt_loadImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileName";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 862);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 161);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Help?";
            // 
            // tb_BanKinh
            // 
            this.tb_BanKinh.Location = new System.Drawing.Point(377, 205);
            this.tb_BanKinh.Name = "tb_BanKinh";
            this.tb_BanKinh.Size = new System.Drawing.Size(60, 22);
            this.tb_BanKinh.TabIndex = 17;
            this.tb_BanKinh.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(357, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "R";
            // 
            // form3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_BanKinh);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_ListOfImage);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.newPosition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Color);
            this.Controls.Add(this.lb_NameObject);
            this.Controls.Add(this.bt_Prism);
            this.Controls.Add(this.by_Pyramid);
            this.Controls.Add(this.bt_Cube);
            this.Controls.Add(this.openGLControl);
            this.Name = "form3D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sharpGl_3D";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.newPosition.ResumeLayout(false);
            this.newPosition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button bt_Cube;
        private System.Windows.Forms.Button by_Pyramid;
        private System.Windows.Forms.Button bt_Prism;
        private System.Windows.Forms.CheckBox cb_space;
        private System.Windows.Forms.ListBox lb_NameObject;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button bt_Color;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_rotateX;
        private System.Windows.Forms.TextBox tb_rotateZ;
        private System.Windows.Forms.TextBox tb_rotateY;
        private System.Windows.Forms.CheckBox cb_rotateObject;
        private System.Windows.Forms.GroupBox newPosition;
        private System.Windows.Forms.TextBox tb_PositionZ;
        private System.Windows.Forms.TextBox tb_PositionY;
        private System.Windows.Forms.TextBox tb_PositionX;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Label lb_newPositionZ;
        private System.Windows.Forms.Label lb_PositionX;
        private System.Windows.Forms.Label lb_newPositionY;
        private System.Windows.Forms.Label lb_rotateY;
        private System.Windows.Forms.Label lb_rotateZ;
        private System.Windows.Forms.Label lb_rotateX;
        private System.Windows.Forms.Label lb_ListOfImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_tranformScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tranformScaleX;
        private System.Windows.Forms.TextBox tb_tranformScaleY;
        private System.Windows.Forms.TextBox tb_tranformScaleZ;
        private System.Windows.Forms.Label lb_tranformRotate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tranformRotateX;
        private System.Windows.Forms.TextBox tb_tranformRotateY;
        private System.Windows.Forms.TextBox tb_tranformRotateZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tranformPosition;
        private System.Windows.Forms.TextBox tb_tranformPositionX;
        private System.Windows.Forms.TextBox tb_tranformPositionY;
        private System.Windows.Forms.TextBox tb_tranformPositionZ;
        private System.Windows.Forms.Button bt_tranformOk;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_loadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button bt_TexCube;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_BanKinh;
        private System.Windows.Forms.Label label10;
    }
}

