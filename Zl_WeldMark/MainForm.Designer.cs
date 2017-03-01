using System.Windows.Forms;

namespace Zl_WeldMark
{
    partial class MainForm : Tekla.Structures.Dialog.PluginFormBase
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
            this.OkApplyModifyGetOnOffCancel = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.SaveLoadSaveAs = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ParametersTabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.ParametersTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkApplyModifyGetOnOffCancel
            // 
            this.structuresExtender.SetAttributeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetAttributeTypeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetBindPropertyName(this.OkApplyModifyGetOnOffCancel, null);
            this.OkApplyModifyGetOnOffCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkApplyModifyGetOnOffCancel.Location = new System.Drawing.Point(0, 244);
            this.OkApplyModifyGetOnOffCancel.Name = "OkApplyModifyGetOnOffCancel";
            this.OkApplyModifyGetOnOffCancel.Size = new System.Drawing.Size(534, 29);
            this.OkApplyModifyGetOnOffCancel.TabIndex = 15;
            this.OkApplyModifyGetOnOffCancel.OkClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OkClicked);
            this.OkApplyModifyGetOnOffCancel.ApplyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ApplyClicked);
            this.OkApplyModifyGetOnOffCancel.ModifyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ModifyClicked);
            this.OkApplyModifyGetOnOffCancel.GetClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_GetClicked);
            this.OkApplyModifyGetOnOffCancel.OnOffClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OnOffClicked);
            this.OkApplyModifyGetOnOffCancel.CancelClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_CancelClicked);
            // 
            // SaveLoadSaveAs
            // 
            this.structuresExtender.SetAttributeName(this.SaveLoadSaveAs, null);
            this.structuresExtender.SetAttributeTypeName(this.SaveLoadSaveAs, null);
            this.SaveLoadSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.SaveLoadSaveAs, null);
            this.SaveLoadSaveAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveLoadSaveAs.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.SaveLoadSaveAs.HelpKeyword = "";
            this.SaveLoadSaveAs.HelpUrl = "";
            this.SaveLoadSaveAs.Location = new System.Drawing.Point(0, 0);
            this.SaveLoadSaveAs.Name = "SaveLoadSaveAs";
            this.SaveLoadSaveAs.SaveAsText = "";
            this.SaveLoadSaveAs.Size = new System.Drawing.Size(534, 43);
            this.SaveLoadSaveAs.TabIndex = 16;
            this.SaveLoadSaveAs.UserDefinedHelpFilePath = null;
            // 
            // tabControl1
            // 
            this.structuresExtender.SetAttributeName(this.tabControl1, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl1, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl1, null);
            this.tabControl1.Controls.Add(this.ParametersTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 201);
            this.tabControl1.TabIndex = 17;
            // 
            // ParametersTabPage
            // 
            this.structuresExtender.SetAttributeName(this.ParametersTabPage, null);
            this.structuresExtender.SetAttributeTypeName(this.ParametersTabPage, null);
            this.structuresExtender.SetBindPropertyName(this.ParametersTabPage, null);
            this.ParametersTabPage.Controls.Add(this.checkBox3);
            this.ParametersTabPage.Controls.Add(this.groupBox2);
            this.ParametersTabPage.Controls.Add(this.textBox3);
            this.ParametersTabPage.Controls.Add(this.textBox2);
            this.ParametersTabPage.Controls.Add(this.checkBox2);
            this.ParametersTabPage.Controls.Add(this.checkBox1);
            this.ParametersTabPage.Controls.Add(this.groupBox1);
            this.ParametersTabPage.Controls.Add(this.textBox1);
            this.ParametersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ParametersTabPage.Name = "ParametersTabPage";
            this.ParametersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParametersTabPage.Size = new System.Drawing.Size(526, 175);
            this.ParametersTabPage.TabIndex = 2;
            this.ParametersTabPage.Text = "albl_Parameters";
            this.ParametersTabPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.structuresExtender.SetAttributeName(this.textBox1, "tw");
            this.structuresExtender.SetAttributeTypeName(this.textBox1, "string");
            this.structuresExtender.SetBindPropertyName(this.textBox1, null);
            this.textBox1.Location = new System.Drawing.Point(196, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(82, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.structuresExtender.SetAttributeName(this.radioButton1, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton1, null);
            this.radioButton1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton1, null);
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "T1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.structuresExtender.SetAttributeName(this.checkBox1, "tw");
            this.structuresExtender.SetAttributeTypeName(this.checkBox1, null);
            this.checkBox1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox1, null);
            this.structuresExtender.SetIsFilter(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(8, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Тип шва";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.structuresExtender.SetAttributeName(this.radioButton2, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton2, null);
            this.radioButton2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton2, null);
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "T3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.structuresExtender.SetAttributeName(this.radioButton3, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton3, null);
            this.radioButton3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton3, null);
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(38, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "T6";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.structuresExtender.SetAttributeName(this.radioButton4, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton4, null);
            this.radioButton4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton4, null);
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(38, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "T7";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.structuresExtender.SetAttributeName(this.radioButton5, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton5, null);
            this.radioButton5.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton5, null);
            this.radioButton5.Location = new System.Drawing.Point(6, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "У4";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.structuresExtender.SetAttributeName(this.radioButton6, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton6, null);
            this.radioButton6.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton6, null);
            this.radioButton6.Location = new System.Drawing.Point(50, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(39, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "У6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.structuresExtender.SetAttributeName(this.radioButton7, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton7, null);
            this.radioButton7.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton7, null);
            this.radioButton7.Location = new System.Drawing.Point(50, 42);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(39, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Text = "У7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.structuresExtender.SetAttributeName(this.radioButton8, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton8, null);
            this.radioButton8.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton8, null);
            this.radioButton8.Location = new System.Drawing.Point(50, 65);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(39, 17);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "Н1";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.structuresExtender.SetAttributeName(this.radioButton9, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton9, null);
            this.radioButton9.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton9, null);
            this.radioButton9.Location = new System.Drawing.Point(50, 88);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(39, 17);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.Text = "Н2";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.structuresExtender.SetAttributeName(this.radioButton10, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton10, null);
            this.radioButton10.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton10, null);
            this.radioButton10.Location = new System.Drawing.Point(51, 111);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(38, 17);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.Text = "С2";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // checkBox2
            // 
            this.structuresExtender.SetAttributeName(this.checkBox2, "height");
            this.structuresExtender.SetAttributeTypeName(this.checkBox2, null);
            this.checkBox2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox2, null);
            this.structuresExtender.SetIsFilter(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(196, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Высота текста\\шва";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.structuresExtender.SetAttributeName(this.textBox2, "height");
            this.structuresExtender.SetAttributeTypeName(this.textBox2, "Double");
            this.structuresExtender.SetBindPropertyName(this.textBox2, null);
            this.textBox2.Location = new System.Drawing.Point(328, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.structuresExtender.SetAttributeName(this.textBox3, "shop");
            this.structuresExtender.SetAttributeTypeName(this.textBox3, "Integer");
            this.structuresExtender.SetBindPropertyName(this.textBox3, null);
            this.textBox3.Location = new System.Drawing.Point(302, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // groupBox2
            // 
            this.structuresExtender.SetAttributeName(this.groupBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox2, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox2, null);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Location = new System.Drawing.Point(286, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 65);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // radioButton11
            // 
            this.structuresExtender.SetAttributeName(this.radioButton11, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton11, null);
            this.radioButton11.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton11, null);
            this.radioButton11.Location = new System.Drawing.Point(6, 42);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(80, 17);
            this.radioButton11.TabIndex = 13;
            this.radioButton11.Text = "Заводской";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.structuresExtender.SetAttributeName(this.radioButton12, null);
            this.structuresExtender.SetAttributeTypeName(this.radioButton12, null);
            this.radioButton12.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.radioButton12, null);
            this.radioButton12.Checked = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 19);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(85, 17);
            this.radioButton12.TabIndex = 12;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Монтажный";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // checkBox3
            // 
            this.structuresExtender.SetAttributeName(this.checkBox3, "shop");
            this.structuresExtender.SetAttributeTypeName(this.checkBox3, null);
            this.checkBox3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox3, null);
            this.structuresExtender.SetIsFilter(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(196, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Положение";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(534, 273);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveLoadSaveAs);
            this.Controls.Add(this.OkApplyModifyGetOnOffCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Drawings Plug-in";
            this.tabControl1.ResumeLayout(false);
            this.ParametersTabPage.ResumeLayout(false);
            this.ParametersTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel OkApplyModifyGetOnOffCancel;
        private Tekla.Structures.Dialog.UIControls.SaveLoad SaveLoadSaveAs;
        private TabControl tabControl1;
        private TabPage ParametersTabPage;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private CheckBox checkBox3;
        private GroupBox groupBox2;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private TextBox textBox3;
        private TextBox textBox2;
        private CheckBox checkBox2;
    }
}
