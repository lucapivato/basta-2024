namespace Plot3D
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trackRho = new Wisej.Web.TrackBar();
            this.trackTheta = new Wisej.Web.TrackBar();
            this.trackPhi = new Wisej.Web.TrackBar();
            this.lblInfo = new Wisej.Web.Label();
            this.comboColors = new Wisej.Web.ComboBox();
            this.comboDemo = new Wisej.Web.ComboBox();
            this.labelMouseInfo = new Wisej.Web.Label();
            this.comboRaster = new Wisej.Web.ComboBox();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.btnScreenshot = new Wisej.Web.Button();
            this.btnReset = new Wisej.Web.Button();
            this.label8 = new Wisej.Web.Label();
            this.comboMouse = new Wisej.Web.ComboBox();
            this.statusStrip = new Wisej.Web.StatusBar();
            this.statusLabel = new Wisej.Web.StatusBarPanel();
            this.btnDeselect = new Wisej.Web.Button();
            this.checkPointSelection = new Wisej.Web.CheckBox();
            this.checkMirrorX = new Wisej.Web.CheckBox();
            this.checkMirrorY = new Wisej.Web.CheckBox();
            this.checkIncludeZeroZ = new Wisej.Web.CheckBox();
            this.btnUndo = new Wisej.Web.Button();
            this.btnRedo = new Wisej.Web.Button();
            this.editor3D = new Plot3D.Editor3D();
            ((System.ComponentModel.ISupportInitialize)(this.trackRho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPhi)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackRho
            // 
            this.trackRho.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
                        | Wisej.Web.AnchorStyles.Left)));
            this.trackRho.Location = new System.Drawing.Point(9, 362);
            this.trackRho.Name = "trackRho";
            this.trackRho.Orientation = Wisej.Web.Orientation.Vertical;
            this.trackRho.Size = new System.Drawing.Size(45, 310);
            this.trackRho.TabIndex = 20;
            this.trackRho.TickFrequency = 20;
            this.trackRho.TickStyle = Wisej.Web.TickStyle.None;
            // 
            // trackTheta
            // 
            this.trackTheta.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
                        | Wisej.Web.AnchorStyles.Left)));
            this.trackTheta.Location = new System.Drawing.Point(53, 362);
            this.trackTheta.Name = "trackTheta";
            this.trackTheta.Orientation = Wisej.Web.Orientation.Vertical;
            this.trackTheta.Size = new System.Drawing.Size(45, 310);
            this.trackTheta.TabIndex = 21;
            this.trackTheta.TickFrequency = 20;
            this.trackTheta.TickStyle = Wisej.Web.TickStyle.None;
            // 
            // trackPhi
            // 
            this.trackPhi.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
                        | Wisej.Web.AnchorStyles.Left)));
            this.trackPhi.Location = new System.Drawing.Point(98, 362);
            this.trackPhi.Name = "trackPhi";
            this.trackPhi.Orientation = Wisej.Web.Orientation.Vertical;
            this.trackPhi.Size = new System.Drawing.Size(45, 310);
            this.trackPhi.TabIndex = 22;
            this.trackPhi.TickFrequency = 20;
            this.trackPhi.TickStyle = Wisej.Web.TickStyle.None;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(7, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Info";
            // 
            // comboColors
            // 
            this.comboColors.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Location = new System.Drawing.Point(9, 84);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(121, 21);
            this.comboColors.TabIndex = 3;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged);
            // 
            // comboDemo
            // 
            this.comboDemo.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboDemo.FormattingEnabled = true;
            this.comboDemo.Location = new System.Drawing.Point(9, 26);
            this.comboDemo.Name = "comboDemo";
            this.comboDemo.Size = new System.Drawing.Size(121, 21);
            this.comboDemo.TabIndex = 2;
            this.comboDemo.SelectedIndexChanged += new System.EventHandler(this.comboDemo_SelectedIndexChanged);
            // 
            // labelMouseInfo
            // 
            this.labelMouseInfo.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.labelMouseInfo.AutoSize = true;
            this.labelMouseInfo.ForeColor = System.Drawing.Color.Blue;
            this.labelMouseInfo.Location = new System.Drawing.Point(137, 676);
            this.labelMouseInfo.Name = "labelMouseInfo";
            this.labelMouseInfo.Size = new System.Drawing.Size(60, 13);
            this.labelMouseInfo.TabIndex = 0;
            this.labelMouseInfo.Text = "Mouse Info";
            // 
            // comboRaster
            // 
            this.comboRaster.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboRaster.FormattingEnabled = true;
            this.comboRaster.Location = new System.Drawing.Point(9, 123);
            this.comboRaster.Name = "comboRaster";
            this.comboRaster.Size = new System.Drawing.Size(121, 21);
            this.comboRaster.TabIndex = 4;
            this.comboRaster.SelectedIndexChanged += new System.EventHandler(this.comboRaster_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "3D Demo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color Scheme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Coordinate System:";
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 674);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rho";
            // 
            // label6
            // 
            this.label6.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Theta";
            // 
            // label7
            // 
            this.label7.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phi";
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(9, 255);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(121, 23);
            this.btnScreenshot.TabIndex = 10;
            this.btnScreenshot.Text = "Save Screenshot";
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Position";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mouse Buttons:";
            // 
            // comboMouse
            // 
            this.comboMouse.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboMouse.FormattingEnabled = true;
            this.comboMouse.Items.AddRange(new object[] {
            "Left Theta, Right Phi",
            "Left Theta and Phi",
            "Middle Theta and Phi"});
            this.comboMouse.Location = new System.Drawing.Point(9, 202);
            this.comboMouse.Name = "comboMouse";
            this.comboMouse.Size = new System.Drawing.Size(121, 21);
            this.comboMouse.TabIndex = 8;
            this.comboMouse.SelectedIndexChanged += new System.EventHandler(this.comboMouse_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Panels.AddRange(new Wisej.Web.StatusBarPanel[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 693);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(807, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = Wisej.Web.StatusBarPanelAutoSize.Spring;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "Select a demo";
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(9, 304);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(121, 23);
            this.btnDeselect.TabIndex = 12;
            this.btnDeselect.Text = "Remove Selection";
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // checkPointSelection
            // 
            this.checkPointSelection.AutoSize = true;
            this.checkPointSelection.BackColor = System.Drawing.Color.Transparent;
            this.checkPointSelection.Location = new System.Drawing.Point(10, 283);
            this.checkPointSelection.Name = "checkPointSelection";
            this.checkPointSelection.Size = new System.Drawing.Size(97, 17);
            this.checkPointSelection.TabIndex = 11;
            this.checkPointSelection.Text = "Point Selection";
            this.checkPointSelection.CheckedChanged += new System.EventHandler(this.checkPointSelection_CheckedChanged);
            // 
            // checkMirrorX
            // 
            this.checkMirrorX.AutoSize = true;
            this.checkMirrorX.BackColor = System.Drawing.Color.Transparent;
            this.checkMirrorX.Location = new System.Drawing.Point(9, 167);
            this.checkMirrorX.Name = "checkMirrorX";
            this.checkMirrorX.Size = new System.Drawing.Size(62, 17);
            this.checkMirrorX.TabIndex = 6;
            this.checkMirrorX.Text = "Mirror X";
            this.checkMirrorX.CheckedChanged += new System.EventHandler(this.checkMirrorX_CheckedChanged);
            // 
            // checkMirrorY
            // 
            this.checkMirrorY.AutoSize = true;
            this.checkMirrorY.BackColor = System.Drawing.Color.Transparent;
            this.checkMirrorY.Location = new System.Drawing.Point(71, 167);
            this.checkMirrorY.Name = "checkMirrorY";
            this.checkMirrorY.Size = new System.Drawing.Size(62, 17);
            this.checkMirrorY.TabIndex = 7;
            this.checkMirrorY.Text = "Mirror Y";
            this.checkMirrorY.CheckedChanged += new System.EventHandler(this.checkMirrorY_CheckedChanged);
            // 
            // checkIncludeZeroZ
            // 
            this.checkIncludeZeroZ.AutoSize = true;
            this.checkIncludeZeroZ.BackColor = System.Drawing.Color.Transparent;
            this.checkIncludeZeroZ.Checked = true;
            this.checkIncludeZeroZ.CheckState = Wisej.Web.CheckState.Checked;
            this.checkIncludeZeroZ.Location = new System.Drawing.Point(9, 149);
            this.checkIncludeZeroZ.Name = "checkIncludeZeroZ";
            this.checkIncludeZeroZ.Size = new System.Drawing.Size(96, 17);
            this.checkIncludeZeroZ.TabIndex = 5;
            this.checkIncludeZeroZ.Text = "Include Zero Z";
            this.checkIncludeZeroZ.CheckedChanged += new System.EventHandler(this.checkIncludeZeroZ_CheckedChanged);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(9, 333);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(55, 23);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(75, 333);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(55, 23);
            this.btnRedo.TabIndex = 14;
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // editor3D
            // 
            this.editor3D.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
                        | Wisej.Web.AnchorStyles.Left)
                        | Wisej.Web.AnchorStyles.Right)));
            this.editor3D.BackColor = System.Drawing.Color.White;
            this.editor3D.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editor3D.BorderColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor3D.Cursor = Wisej.Web.Cursors.Default;
            this.editor3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor3D.Location = new System.Drawing.Point(139, 11);
            this.editor3D.Name = "editor3D";
            this.editor3D.Normalize = Plot3D.Editor3D.eNormalize.Separate;
            this.editor3D.Raster = Plot3D.Editor3D.eRaster.Off;
            this.editor3D.Size = new System.Drawing.Size(656, 661);
            this.editor3D.TabIndex = 1;
            this.editor3D.TooltipMode = ((Plot3D.Editor3D.eTooltip)((Plot3D.Editor3D.eTooltip.UserText | Plot3D.Editor3D.eTooltip.Coord)));
            this.editor3D.TopLegendColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 715);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.checkIncludeZeroZ);
            this.Controls.Add(this.checkMirrorY);
            this.Controls.Add(this.checkMirrorX);
            this.Controls.Add(this.checkPointSelection);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboMouse);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRaster);
            this.Controls.Add(this.labelMouseInfo);
            this.Controls.Add(this.comboDemo);
            this.Controls.Add(this.comboColors);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.editor3D);
            this.Controls.Add(this.trackPhi);
            this.Controls.Add(this.trackTheta);
            this.Controls.Add(this.trackRho);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "3D Editor Demo";
            ((System.ComponentModel.ISupportInitialize)(this.trackRho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackPhi)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TrackBar trackRho;
        private Wisej.Web.TrackBar trackTheta;
        private Wisej.Web.TrackBar trackPhi;
        private Plot3D.Editor3D editor3D;
        private Wisej.Web.Label lblInfo;
        private Wisej.Web.ComboBox comboColors;
        private Wisej.Web.ComboBox comboDemo;
        private Wisej.Web.Label labelMouseInfo;
        private Wisej.Web.ComboBox comboRaster;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label6;
        private Wisej.Web.Label label7;
        private Wisej.Web.Button btnScreenshot;
        private Wisej.Web.Button btnReset;
        private Wisej.Web.Label label8;
        private Wisej.Web.ComboBox comboMouse;
        private Wisej.Web.StatusBar statusStrip;
        private Wisej.Web.StatusBarPanel statusLabel;
        private Wisej.Web.Button btnDeselect;
        private Wisej.Web.CheckBox checkPointSelection;
        private Wisej.Web.CheckBox checkMirrorX;
        private Wisej.Web.CheckBox checkMirrorY;
        private Wisej.Web.CheckBox checkIncludeZeroZ;
        private Wisej.Web.Button btnUndo;
        private Wisej.Web.Button btnRedo;

    }
}

