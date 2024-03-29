﻿
using System;
using System.Runtime.InteropServices;

namespace SCEditor.Prompts
{
    partial class editCharacter
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

        // constants used to hide a checkbox
        public const int TVIF_STATE = 0x8;
        public const int TVIS_STATEIMAGEMASK = 0xF000;
        public const int TV_FIRST = 0x1100;
        public const int TVM_SETITEM = TV_FIRST + 63;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam,
        IntPtr lParam);

        // struct used to set node properties
        public struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public String lpszText;
            public int cchTextMax;
            public int iImage;
            public int iSelectedImage;
            public int cChildren;
            public IntPtr lParam;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editCharacterButtonUp = new System.Windows.Forms.Button();
            this.editCharacterButtonDown = new System.Windows.Forms.Button();
            this.editCharacterButtonLeft = new System.Windows.Forms.Button();
            this.editCharacterButtonRight = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.editCharacterButtonSizeIncrease = new System.Windows.Forms.Button();
            this.editCharacterButtonSizeDecrease = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.scaleFactorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.renderSingleFrameTextBox = new System.Windows.Forms.TextBox();
            this.editMatrixButton = new System.Windows.Forms.Button();
            this.rotateAntiClockWiseButton = new System.Windows.Forms.Button();
            this.rotateClockWiseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.renderSingleFrameCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(242, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 536);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editCharacterButtonUp
            // 
            this.editCharacterButtonUp.Enabled = false;
            this.editCharacterButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCharacterButtonUp.Location = new System.Drawing.Point(84, 329);
            this.editCharacterButtonUp.Name = "editCharacterButtonUp";
            this.editCharacterButtonUp.Size = new System.Drawing.Size(75, 32);
            this.editCharacterButtonUp.TabIndex = 1;
            this.editCharacterButtonUp.Text = "Up";
            this.editCharacterButtonUp.UseVisualStyleBackColor = true;
            this.editCharacterButtonUp.Click += new System.EventHandler(this.editCharacterButtonUp_Click);
            // 
            // editCharacterButtonDown
            // 
            this.editCharacterButtonDown.Enabled = false;
            this.editCharacterButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCharacterButtonDown.Location = new System.Drawing.Point(84, 405);
            this.editCharacterButtonDown.Name = "editCharacterButtonDown";
            this.editCharacterButtonDown.Size = new System.Drawing.Size(75, 30);
            this.editCharacterButtonDown.TabIndex = 1;
            this.editCharacterButtonDown.Text = "Down";
            this.editCharacterButtonDown.UseVisualStyleBackColor = true;
            this.editCharacterButtonDown.Click += new System.EventHandler(this.editCharacterButtonDown_Click);
            // 
            // editCharacterButtonLeft
            // 
            this.editCharacterButtonLeft.Enabled = false;
            this.editCharacterButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCharacterButtonLeft.Location = new System.Drawing.Point(30, 367);
            this.editCharacterButtonLeft.Name = "editCharacterButtonLeft";
            this.editCharacterButtonLeft.Size = new System.Drawing.Size(75, 32);
            this.editCharacterButtonLeft.TabIndex = 1;
            this.editCharacterButtonLeft.Text = "Left";
            this.editCharacterButtonLeft.UseVisualStyleBackColor = true;
            this.editCharacterButtonLeft.Click += new System.EventHandler(this.editCharacterButtonLeft_Click);
            // 
            // editCharacterButtonRight
            // 
            this.editCharacterButtonRight.Enabled = false;
            this.editCharacterButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCharacterButtonRight.Location = new System.Drawing.Point(140, 367);
            this.editCharacterButtonRight.Name = "editCharacterButtonRight";
            this.editCharacterButtonRight.Size = new System.Drawing.Size(75, 32);
            this.editCharacterButtonRight.TabIndex = 1;
            this.editCharacterButtonRight.Text = "Right";
            this.editCharacterButtonRight.UseVisualStyleBackColor = true;
            this.editCharacterButtonRight.Click += new System.EventHandler(this.editCharacterButtonRight_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.treeView1.CheckBoxes = true;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(224, 214);
            this.treeView1.TabIndex = 2;
            this.treeView1.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCheck);
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // editCharacterButtonSizeIncrease
            // 
            this.editCharacterButtonSizeIncrease.Enabled = false;
            this.editCharacterButtonSizeIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCharacterButtonSizeIncrease.Location = new System.Drawing.Point(30, 260);
            this.editCharacterButtonSizeIncrease.Name = "editCharacterButtonSizeIncrease";
            this.editCharacterButtonSizeIncrease.Size = new System.Drawing.Size(75, 31);
            this.editCharacterButtonSizeIncrease.TabIndex = 3;
            this.editCharacterButtonSizeIncrease.Text = "Increase";
            this.editCharacterButtonSizeIncrease.UseVisualStyleBackColor = true;
            this.editCharacterButtonSizeIncrease.Click += new System.EventHandler(this.editCharacterButtonSizeIncrease_Click);
            // 
            // editCharacterButtonSizeDecrease
            // 
            this.editCharacterButtonSizeDecrease.Enabled = false;
            this.editCharacterButtonSizeDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCharacterButtonSizeDecrease.Location = new System.Drawing.Point(140, 260);
            this.editCharacterButtonSizeDecrease.Name = "editCharacterButtonSizeDecrease";
            this.editCharacterButtonSizeDecrease.Size = new System.Drawing.Size(75, 31);
            this.editCharacterButtonSizeDecrease.TabIndex = 4;
            this.editCharacterButtonSizeDecrease.Text = "Decrease";
            this.editCharacterButtonSizeDecrease.UseVisualStyleBackColor = true;
            this.editCharacterButtonSizeDecrease.Click += new System.EventHandler(this.editCharacterButtonSizeDecrease_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Edit Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edit Size";
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.saveButton.Location = new System.Drawing.Point(822, 627);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // revertButton
            // 
            this.revertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revertButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.revertButton.ForeColor = System.Drawing.Color.LightCoral;
            this.revertButton.Location = new System.Drawing.Point(679, 627);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(93, 31);
            this.revertButton.TabIndex = 7;
            this.revertButton.Text = "Revert";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // scaleFactorTextBox
            // 
            this.scaleFactorTextBox.Location = new System.Drawing.Point(246, 635);
            this.scaleFactorTextBox.Name = "scaleFactorTextBox";
            this.scaleFactorTextBox.Size = new System.Drawing.Size(100, 23);
            this.scaleFactorTextBox.TabIndex = 8;
            this.scaleFactorTextBox.Text = "0.25";
            this.scaleFactorTextBox.TextChanged += new System.EventHandler(this.scaleFactorTextBox_TextChanged);
            this.scaleFactorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scaleFactorTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(253, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scale Factor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.renderSingleFrameCheckBox);
            this.panel1.Controls.Add(this.renderSingleFrameTextBox);
            this.panel1.Controls.Add(this.editMatrixButton);
            this.panel1.Location = new System.Drawing.Point(242, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 42);
            this.panel1.TabIndex = 9;
            // 
            // renderSingleFrameTextBox
            // 
            this.renderSingleFrameTextBox.Location = new System.Drawing.Point(539, 16);
            this.renderSingleFrameTextBox.Name = "renderSingleFrameTextBox";
            this.renderSingleFrameTextBox.Size = new System.Drawing.Size(134, 23);
            this.renderSingleFrameTextBox.TabIndex = 1;
            this.renderSingleFrameTextBox.TextChanged += new System.EventHandler(this.renderSingleFrameTextBox_TextChanged);
            // 
            // editMatrixButton
            // 
            this.editMatrixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.editMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMatrixButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editMatrixButton.Location = new System.Drawing.Point(0, 0);
            this.editMatrixButton.Name = "editMatrixButton";
            this.editMatrixButton.Size = new System.Drawing.Size(104, 37);
            this.editMatrixButton.TabIndex = 0;
            this.editMatrixButton.Text = "Edit as Matrix";
            this.editMatrixButton.UseVisualStyleBackColor = false;
            this.editMatrixButton.Click += new System.EventHandler(this.editMatrixButton_Click);
            // 
            // rotateAntiClockWiseButton
            // 
            this.rotateAntiClockWiseButton.Enabled = false;
            this.rotateAntiClockWiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateAntiClockWiseButton.Location = new System.Drawing.Point(30, 485);
            this.rotateAntiClockWiseButton.Name = "rotateAntiClockWiseButton";
            this.rotateAntiClockWiseButton.Size = new System.Drawing.Size(75, 31);
            this.rotateAntiClockWiseButton.TabIndex = 3;
            this.rotateAntiClockWiseButton.Text = "Anti-CW";
            this.rotateAntiClockWiseButton.UseVisualStyleBackColor = true;
            this.rotateAntiClockWiseButton.Click += new System.EventHandler(this.rotateAntiClockWiseButton_Click);
            // 
            // rotateClockWiseButton
            // 
            this.rotateClockWiseButton.Enabled = false;
            this.rotateClockWiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateClockWiseButton.Location = new System.Drawing.Point(140, 485);
            this.rotateClockWiseButton.Name = "rotateClockWiseButton";
            this.rotateClockWiseButton.Size = new System.Drawing.Size(75, 31);
            this.rotateClockWiseButton.TabIndex = 4;
            this.rotateClockWiseButton.Text = "Clockwise";
            this.rotateClockWiseButton.UseVisualStyleBackColor = true;
            this.rotateClockWiseButton.Click += new System.EventHandler(this.rotateClockWiseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rotate";
            // 
            // renderSingleFrameCheckBox
            // 
            this.renderSingleFrameCheckBox.AutoSize = true;
            this.renderSingleFrameCheckBox.Location = new System.Drawing.Point(539, 0);
            this.renderSingleFrameCheckBox.Name = "renderSingleFrameCheckBox";
            this.renderSingleFrameCheckBox.Size = new System.Drawing.Size(134, 19);
            this.renderSingleFrameCheckBox.TabIndex = 4;
            this.renderSingleFrameCheckBox.Text = "Render Single Frame";
            this.renderSingleFrameCheckBox.UseVisualStyleBackColor = true;
            this.renderSingleFrameCheckBox.CheckedChanged += new System.EventHandler(this.renderSingleFrameCheckBox_CheckedChanged);
            // 
            // editCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(927, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scaleFactorTextBox);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rotateClockWiseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotateAntiClockWiseButton);
            this.Controls.Add(this.editCharacterButtonSizeDecrease);
            this.Controls.Add(this.editCharacterButtonSizeIncrease);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.editCharacterButtonRight);
            this.Controls.Add(this.editCharacterButtonLeft);
            this.Controls.Add(this.editCharacterButtonDown);
            this.Controls.Add(this.editCharacterButtonUp);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editCharacter";
            this.Text = "Edit Character";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.editCharacter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button editCharacterButtonUp;
        internal System.Windows.Forms.Button editCharacterButtonDown;
        internal System.Windows.Forms.Button editCharacterButtonLeft;
        internal System.Windows.Forms.Button editCharacterButtonRight;
        internal System.Windows.Forms.TreeView treeView1;
        internal System.Windows.Forms.Button editCharacterButtonSizeIncrease;
        internal System.Windows.Forms.Button editCharacterButtonSizeDecrease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.TextBox scaleFactorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editMatrixButton;
        internal System.Windows.Forms.Button rotateAntiClockWiseButton;
        internal System.Windows.Forms.Button rotateClockWiseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox renderSingleFrameTextBox;
        private System.Windows.Forms.CheckBox renderSingleFrameCheckBox;
    }
}